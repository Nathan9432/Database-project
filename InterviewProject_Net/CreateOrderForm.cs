using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace InterviewProject_Net
{
	public partial class CreateOrderForm : Form
    {
        private readonly string connectionString;
        private readonly int id;

        public CreateOrderForm(string connectionString, int id)
        {
            this.connectionString = connectionString;
            this.id = id;
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // First, we check to see that the data the user has entered is acceptable.
            // Check to see if ItemNumber exists
            int count;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM dbo.Items WHERE ItemNumber = @ItemNumber";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.Add("@ItemNumber", SqlDbType.NVarChar).Value = itemNumberTextBox.Text;
                count = (int)cmd.ExecuteScalar();
            }
            if (count == 0)
            {
                MessageBox.Show("Item Number not found. Format: '#000'", "Warning");
            }
            // Check to see if ShipDate is fine
            DateTime shipDate;
            try
            {
                shipDate = DateTime.Parse(shipDateTextBox.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("The ShipDate did not format properly. Try using the format YYYY-MM-DD.", "Warning");
                return;
            }
            // Check to see if quantity, price, and total are all decimals
            decimal quantity;
            decimal price;
            decimal total;
            // Everything checked out, time to create everything
            try
            {
                quantity = decimal.Parse(quantityTextBox.Text);
                price = decimal.Parse(priceTextBox.Text);
                total = decimal.Parse(totalTextBox.Text);
            }
            catch (FormatException)
            {
                // Should never happen, but better to inform the user than to blindly have it backfire on them
                MessageBox.Show("At least one of the three decimal fields- Quantity, Price, and Total- did not format properly. Please check that the corresponding information is formatted properly.", "Warning");
                return;
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Creating the Order
                connection.Open();
                string query = "INSERT INTO dbo.Orders VALUES(@ordername,@customerid,@shipdate)";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.Add("@ordername", SqlDbType.NVarChar).Value = orderNameTextBox.Text;
                cmd.Parameters.Add("@customerid", SqlDbType.NVarChar).Value = id;
                cmd.Parameters.Add("@shipdate", SqlDbType.NVarChar).Value = shipDate;
                cmd.ExecuteNonQuery();

                // Fetching created Order ID
                query = "SELECT MAX(Id) from dbo.Orders WHERE OrderName = @ordername AND CustomerId = @customerid AND ShipDate = @shipdate";
                cmd = new SqlCommand(query, connection);
                cmd.Parameters.Add("@ordername", SqlDbType.NVarChar).Value = orderNameTextBox.Text;
                cmd.Parameters.Add("@customerid", SqlDbType.NVarChar).Value = id;
                cmd.Parameters.Add("@shipdate", SqlDbType.NVarChar).Value = shipDate;
                int orderId = (int)cmd.ExecuteScalar();

                // Creating the Order Details
                query = "INSERT INTO dbo.OrderDetails VALUES(@orderid,@itemnumber,@quantity,@price,@total)";
                cmd = new SqlCommand(query, connection);
                cmd.Parameters.Add("@orderid", SqlDbType.NVarChar).Value = orderId;
                cmd.Parameters.Add("@itemnumber", SqlDbType.NVarChar).Value = itemNumberTextBox.Text;
                cmd.Parameters.Add("@quantity", SqlDbType.NVarChar).Value = quantity;
                cmd.Parameters.Add("@price", SqlDbType.NVarChar).Value = price;
                cmd.Parameters.Add("@total", SqlDbType.NVarChar).Value = total;
                cmd.ExecuteNonQuery();
            }
            this.Close();
        }
	}
}
