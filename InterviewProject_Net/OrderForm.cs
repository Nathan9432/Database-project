using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace InterviewProject_Net
{
	public partial class OrderForm : Form
	{
		private readonly string connectionString;

		/// <summary>
		/// Initializes the Order Form
		/// </summary>
		/// <param name="connectionString">Standardized string used to connect to the SQL DB</param>
		/// <param name="specific">Whether or not this form should start off in specified or general form. If true, include identifier</param>
		/// <param name="identifier">What id should be used to filter the table</param>
		public OrderForm(string connectionString, bool specific, int identifier = 0)
        {
            this.connectionString = connectionString;
            InitializeComponent();

            if (specific)
			{
				// Construct the string of Order Ids for the specific view
				using (SqlConnection connection = new SqlConnection(connectionString))
				{
                    // Grabbing Order IDs
                    connection.Open();
                    string query = "SELECT Id FROM dbo.Orders WHERE CustomerId = @Id";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.Add("@Id", SqlDbType.Int).Value = identifier;
                    string orders = "";
                    try
                    {
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                orders += dr.GetInt32(0) + ",";
                            }
                        }
                    }
                    catch (SqlException oError)
                    {
                        MessageBox.Show("There was an SQL error while reading information from the server: " + oError.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (orders.Length == 0) postInitialize("0");
					else postInitialize(orders.Remove(orders.Length-1));
				}
            }
        }

		private void OrderForm_Load(object sender, EventArgs e)
		{
            // TODO: This line of code loads data into the 'interviewProjectDataSet.OrderDetails' table. You can move, or remove it, as needed.
            this.orderDetailsTableAdapter.Fill(this.interviewProjectDataSet.OrderDetails);
            
        }

        // This function updates the three labels every time the selection changes
        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;
            var orderId = (int) dataGridView1.SelectedRows[0].Cells[1].Value; // Grabs orderId
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string orderName;
                int customerId;
                string shipDate;
                // First, we want to call to grab the Order for the Order Name and Ship Date
				connection.Open();
				string query = "SELECT OrderName, CustomerId, ShipDate FROM dbo.Orders WHERE Id = @OrderId";
				SqlCommand cmd = new SqlCommand(query, connection);
				cmd.Parameters.Add("@OrderId", SqlDbType.Int).Value = orderId;
				try
				{
					using (SqlDataReader dr = cmd.ExecuteReader())
					{
						dr.Read();
						orderName = dr[0].ToString();
						customerId = int.Parse(dr[1].ToString());
						shipDate = dr[2].ToString();
					}
				}
				catch (SqlException oError)
				{
					MessageBox.Show("There was an SQL error while reading information from the server: " + oError.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				// Next, we want to grab the Customer from that to get the Customer Name
				string name;
				query = "SELECT FirstName, LastName FROM dbo.Customers WHERE Id = @CustomerId";
				cmd = new SqlCommand(query, connection);
				cmd.Parameters.Add("@CustomerId", SqlDbType.Int).Value = customerId;
				try
				{
					using (SqlDataReader dr = cmd.ExecuteReader())
					{
						dr.Read();
						name = dr[0].ToString() + " " + dr[1].ToString();
					}
				}
				catch (SqlException oError)
				{
					MessageBox.Show("There was an SQL error while reading information from the server: " + oError.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				orderLabel.Text = "Order Name: " + orderName;
				customerLabel.Text = "Customer Name: " + name;
				shipDateLabel.Text = "Ship Date: " + shipDate;
			}
        }
	}
}
