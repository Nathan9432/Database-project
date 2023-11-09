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
		private QueryController qc;

		public MainForm(QueryController qc)
		{
			this.qc = qc;
			InitializeComponent();
		}

		private void buttonCustomers_Click(object sender, EventArgs e)
		{
			CustomerForm customerForm = new CustomerForm(qc);
			customerForm.ShowDialog(this);
		}

		private void buttonOrders_Click(object sender, EventArgs e)
		{
			OrderForm orderForm = new OrderForm(qc, false);
			orderForm.ShowDialog(this);
		}
	}
}
