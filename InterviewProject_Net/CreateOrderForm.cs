using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace InterviewProject_Net
{
	public partial class CreateOrderForm : Form
    {
        private QueryController qc;
        private readonly int id;

        public CreateOrderForm(QueryController qc, int id)
        {
            this.qc = qc;
            this.id = id;
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // First, we check to see that the data the user has entered is acceptable.
            // Check to see if ItemNumber exists
            string query = "SELECT COUNT(*) FROM dbo.Items WHERE ItemNumber = @ItemNumber";
			Dictionary<string, (SqlDbType, object)> parameters = new Dictionary<string, (SqlDbType, object)>
			{
				{ "@ItemNumber", (SqlDbType.NVarChar, itemNumberTextBox.Text) }
			};
			int count = qc.ExecuteQuery_ReturnScalar(query, parameters);
			if (count == 0)
            {
                MessageBox.Show("Item Number not found. Format: '#000'", "Warning");
                return;
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
            query = "INSERT INTO dbo.Orders VALUES(@ordername,@customerid,@shipdate)";
			parameters = new Dictionary<string, (SqlDbType, object)>
			{
				{ "@ordername", (SqlDbType.NVarChar, orderNameTextBox.Text) },
				{ "@customerid", (SqlDbType.NVarChar, id) },
				{ "@shipdate", (SqlDbType.NVarChar, shipDate) }
			};
			qc.ExecuteQuery(query, parameters);

			query = "SELECT MAX(Id) from dbo.Orders WHERE OrderName = @ordername AND CustomerId = @customerid AND ShipDate = @shipdate";
			int orderId = qc.ExecuteQuery_ReturnScalar(query, parameters);

			query = "INSERT INTO dbo.OrderDetails VALUES(@orderid,@itemnumber,@quantity,@price,@total)";
			parameters = new Dictionary<string, (SqlDbType, object)>
			{
				{ "@orderid", (SqlDbType.NVarChar, orderId) },
				{ "@itemnumber", (SqlDbType.NVarChar, itemNumberTextBox.Text) },
				{ "@quantity", (SqlDbType.NVarChar, quantity) },
				{ "@price", (SqlDbType.NVarChar, price) },
				{ "@total", (SqlDbType.NVarChar, total) }
			};

			Close();
        }
	}
}
