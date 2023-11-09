using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterviewProject_Net
{
	public partial class MainForm : Form
	{
		private string connectionString;

		public MainForm(string connectionString)
		{
			this.connectionString = connectionString;
			InitializeComponent();
		}

		private void buttonCustomers_Click(object sender, EventArgs e)
		{
			CustomerForm customerForm = new CustomerForm(connectionString);
			customerForm.ShowDialog(this);
		}

		private void buttonOrders_Click(object sender, EventArgs e)
		{
			OrderForm orderForm = new OrderForm(connectionString, false);
			orderForm.ShowDialog(this);
		}
	}
}
