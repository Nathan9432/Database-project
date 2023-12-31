﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace InterviewProject_Net
{
	public partial class CustomerForm : Form
	{
		private QueryController qc;
        private DataGridViewCellCollection row;

		public CustomerForm(QueryController qc)
		{
            this.qc = qc; 
			InitializeComponent();			
		}

		private void CustomerForm_Load(object sender, EventArgs e)
		{
            // TODO: This line of code loads data into the 'interviewProjectDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.interviewProjectDataSet.Customers);

        }

		private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
            //Show Order form with relevant data
            var customerId = (int) dataGridView1.Rows[e.RowIndex].Cells[0].Value; // ID is the first collumn, and is hidden.
            OrderForm orderForm = new OrderForm(qc, true, customerId); // Tells the Order Form to only show orders that are related to this customer
            orderForm.ShowDialog(this); // ...And as a modal dialog box, ie, that it must be dismissed before the user can return.
        }

		private void CreateOrdersButton_Click(object sender, EventArgs e)
		{
            // Fetch the customer ID from the form
            var rows = dataGridView1.SelectedRows;
            if (rows.Count == 0)
            {
                // Warn the user about needing to select a row to delete
                MessageBox.Show("It seems like a row has not been selected.\nTo create an order based off of a customer, please create or select one first.", "Alert");
                return;
            }
            if (rows.Count > 1)
            {
                // Warn the user to only delete one row at a time
                MessageBox.Show("It seems like multiple rows have been selected. Please select only one row to delete.", "Alert");
                return;
            }

            int id;
            try
            {
                id = (int)rows[0].Cells[0].Value;
            }
            catch (FormatException)
            {
                // Should never happen, but better to inform the user than to blindly have it backfire on them
                MessageBox.Show("An error has occurred: while trying to find the selected row's ID, it failed to parse to an int.");
                return;
            }

            CreateOrderForm customerForm = new CreateOrderForm(qc, id);
            customerForm.ShowDialog(this);
        }

        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
			int zip;
			try
			{
				zip = int.Parse(zipTextBox.Text);
			} catch (FormatException)
			{
				// Dialog warning: cannot format zip code
				MessageBox.Show("An error has occurred: The zip code could not be converted. Are you sure you only included numbers?", "Warning");
				return;
			}
			string query = "INSERT INTO dbo.Customers VALUES(@firstname,@lastname,@address,@city,@state,@zip)";
            Dictionary<string, (SqlDbType, object)> parameters = new Dictionary<string, (SqlDbType, object)>
            {
                { "@firstname", (SqlDbType.NVarChar, firstNameTextBox.Text) },
				{ "@lastname", (SqlDbType.NVarChar, lastNameTextBox.Text) },
				{ "@address", (SqlDbType.NVarChar, addressTextBox.Text) },
				{ "@city", (SqlDbType.NVarChar, cityTextBox.Text) },
				{ "@state", (SqlDbType.NVarChar, stateTextBox.Text) },
				{ "@zip", (SqlDbType.Int, zip) }
			};
            qc.ExecuteQuery(query, parameters);
            
            RefreshData();
        }

		private void UpdateCustomerButton_Click(object sender, EventArgs e)
		{
            // This one will be tricky. First, we need to make sure that the datagridview has a row selected.
            // If so, then we can update the selected row with data from the above boxes.
            var rows = dataGridView1.SelectedRows;
            if (rows.Count == 0)
            {
                // Warn the user about needing to select a row to delete
                MessageBox.Show("It seems like a row has not been selected. Please select a customer to update.", "Alert");
                return;
            }
            if (rows.Count > 1)
            {
                // Warn the user to only delete one row at a time
                MessageBox.Show("It seems like multiple rows have been selected. Please select only one row to delete.", "Alert");
                return;
            }

            int id;
            try
            {
                id = (int)rows[0].Cells[0].Value;
            }
            catch (FormatException)
            {
                // Should never happen, but better to inform the user than to blindly have it backfire on them
                MessageBox.Show("An error has occurred: while trying to find the selected row's ID, it failed to parse to an int.");
                return;
            }
			int zip;
			try
			{
				zip = int.Parse(zipTextBox.Text);
			} catch (FormatException)
			{
				// Dialog warning: cannot format zip code
				MessageBox.Show("An error has occurred: The zip code could not be converted. Are you sure you only included numbers?", "Warning");
				return;
			}
			string query = "UPDATE dbo.Customers SET FirstName = @firstname, LastName = @lastname, Address = @address, City = @city, State = @state, ZipCode = @zip WHERE Id = @Id";
			Dictionary<string, (SqlDbType, object)> parameters = new Dictionary<string, (SqlDbType, object)>
			{
				{ "@firstname", (SqlDbType.NVarChar, firstNameTextBox.Text) },
				{ "@lastname", (SqlDbType.NVarChar, lastNameTextBox.Text) },
				{ "@address", (SqlDbType.NVarChar, addressTextBox.Text) },
				{ "@city", (SqlDbType.NVarChar, cityTextBox.Text) },
				{ "@state", (SqlDbType.NVarChar, stateTextBox.Text) },
				{ "@zip", (SqlDbType.Int, zip) },
				{ "@Id", (SqlDbType.Int, id) }
			};
			qc.ExecuteQuery(query, parameters);
            RefreshData();
        }

		private void DeleteCustomerButton_Click(object sender, EventArgs e)
		{
			// This will require a similar check for the datagridview to have something selected.
			var rows = dataGridView1.SelectedRows;
            if (rows.Count == 0)
            {
                // Warn the user about needing to select a row to delete
                MessageBox.Show("It seems like a row has not been selected. Please select a customer to delete.", "Alert");
                return;
            }
            if (rows.Count > 1)
			{
                // Warn the user to only delete one row at a time
                MessageBox.Show("It seems like multiple rows have been selected. Please select only one row to delete.", "Alert");
                return;
			}

			// Now we're sure that we only selected one row.
			int id;
			try
			{
                id = (int)rows[0].Cells[0].Value;
            }
			catch (FormatException)
			{
				// Should never happen, but better to inform the user than to blindly have it backfire on them
				MessageBox.Show("An error has occurred: while trying to find the selected row's ID, it failed to parse to an int.");
				return;
			}

			// Now, deleting a customer could leave orders and order details hanging out in the air. Let's make sure that doesn't happen.
			// First, let's detect if there is anything that should also be deleted, and inform the user, letting them back out of a cascading deletion.
			// Checking DB
			string query = "SELECT COUNT(*) FROM dbo.Orders WHERE CustomerId = @Id"; 
            Dictionary<string, (SqlDbType, object)> parameters = new Dictionary<string, (SqlDbType, object)>
			{
				{ "@Id", (SqlDbType.Int, id) }
			};
			int count = qc.ExecuteQuery_ReturnScalar(query, parameters);
            if (count > 0)
			{
				DialogResult res = MessageBox.Show("Continuing with this deletion will delete the orders and details pertaining to this customer. Do you wish to continue?", "Confirmation",MessageBoxButtons.YesNo);
				if (res == DialogResult.Yes)
				{
					query = "SELECT Id FROM dbo.Orders WHERE CustomerId = @Id";
					parameters = new Dictionary<string, (SqlDbType, object)>
			        {
				        { "@Id", (SqlDbType.Int, id) }
			        };
                    List<int> values = qc.ExecuteQuery_ReturnList(query, parameters);

					query = "DELETE FROM dbo.OrderDetails WHERE OrderId = @Id";
					foreach (var value in values)
					{
						parameters = new Dictionary<string, (SqlDbType, object)>
					    {
						    { "@Id", (SqlDbType.Int, value) }
					    };
						qc.ExecuteQuery(query, parameters);
					}
					query = "DELETE FROM dbo.Orders WHERE CustomerId = @Id";
					parameters = new Dictionary<string, (SqlDbType, object)>
					{
						{ "@Id", (SqlDbType.Int, id) }
					};
					qc.ExecuteQuery(query, parameters);
                }
				else { return; } // User backed out, do not delete anything
			}

            // Everything has been cleared out; now the customer can be safely deleted
            query = "DELETE FROM dbo.Customers WHERE Id = @Id";
			parameters = new Dictionary<string, (SqlDbType, object)>
			{
				{ "@Id", (SqlDbType.Int, id) }
			};
            qc.ExecuteQuery(query, parameters);
            RefreshData();
        }

        private void RefreshData()
        {
            //var dt = new DataTable();
            //SqlDataAdapter adapter = qc.GetAdapter("SELECT * FROM dbo.Customers");
            //adapter.Fill(dt);
			var dt = qc.GetDataTable("SELECT * FROM dbo.Customers");
			dataGridView1.DataSource = dt;
        }

		private void DataGridView1_SelectionChanged(object sender, EventArgs e)
		{
            if (dataGridView1.SelectedRows.Count == 0) return;
            row = dataGridView1.SelectedRows[0].Cells;
            SelectionHelper(firstNameTextBox, 1);
            SelectionHelper(lastNameTextBox, 2);
            SelectionHelper(addressTextBox, 3);
            SelectionHelper(cityTextBox, 4);
            SelectionHelper(stateTextBox, 5);
            SelectionHelper(zipTextBox, 6);
        }

        private void SelectionHelper(TextBox tb, int i)
        {
            tb.Text = row[i].Value.ToString();
            tb.BackColor = Color.Khaki;
        }

		private void FirstNameTextBox_Enter(object sender, EventArgs e)
		{
            firstNameTextBox.BackColor = SystemColors.Window;
		}

		private void LastNameTextBox_Enter(object sender, EventArgs e)
		{
            lastNameTextBox.BackColor = SystemColors.Window;
        }

		private void AddressTextBox_Enter(object sender, EventArgs e)
		{
            addressTextBox.BackColor = SystemColors.Window;
        }

		private void CityTextBox_Enter(object sender, EventArgs e)
		{
            cityTextBox.BackColor = SystemColors.Window;
        }

		private void StateTextBox_Enter(object sender, EventArgs e)
		{
            stateTextBox.BackColor = SystemColors.Window;
        }

		private void ZipTextBox_Enter(object sender, EventArgs e)
		{
            zipTextBox.BackColor = SystemColors.Window;
        }
	}
}
