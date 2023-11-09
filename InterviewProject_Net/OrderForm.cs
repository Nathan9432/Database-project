using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace InterviewProject_Net
{
	public partial class OrderForm : Form
	{
		private QueryController qc;

		/// <summary>
		/// Initializes the Order Form
		/// </summary>
		/// <param name="connectionString">Standardized string used to connect to the SQL DB</param>
		/// <param name="specific">Whether or not this form should start off in specified or general form. If true, include identifier</param>
		/// <param name="identifier">What id should be used to filter the table</param>
		public OrderForm(QueryController qc, bool specific, int identifier = 0)
        {
            this.qc = qc;
            InitializeComponent();

            if (specific)
			{
				// Construct the string of Order Ids for the specific view
				string query = "SELECT Id FROM dbo.Orders WHERE CustomerId = @Id";
				Dictionary<string, (SqlDbType, object)> parameters = new Dictionary<string, (SqlDbType, object)>
				{
					{ "@Id", (SqlDbType.Int, identifier) }
				};
				List<int> values = qc.ExecuteQuery_ReturnList(query, parameters);
				string orders = "";
				foreach (var value in values)
					orders += value + ",";
				if (orders.Length == 0) postInitialize("0");
				else postInitialize(orders.Remove(orders.Length - 1));
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
            string query = "SELECT OrderName, CustomerId, ShipDate FROM dbo.Orders WHERE Id = @OrderId";
			Dictionary<string, (SqlDbType, object)> parameters = new Dictionary<string, (SqlDbType, object)>
			{
				{ "@OrderId", (SqlDbType.Int, orderId) }
			};
			var values = qc.ExecuteQuery_ReturnColumns(query, parameters, 3);
			string orderName = values[0].ToString();
			int customerId = int.Parse(values[1].ToString());
			string shipDate = values[2].ToString();

			query = "SELECT FirstName, LastName FROM dbo.Customers WHERE Id = @CustomerId";
			parameters = new Dictionary<string, (SqlDbType, object)>
			{
				{ "@CustomerId", (SqlDbType.Int, customerId) }
			};
			values = qc.ExecuteQuery_ReturnColumns(query, parameters, 2);
			string name = values[0].ToString() + " " + values[1].ToString();

			orderLabel.Text = "Order Name: " + orderName;
			customerLabel.Text = "Customer Name: " + name;
			shipDateLabel.Text = "Ship Date: " + shipDate;
        }
	}
}
