using System;
using System.Windows.Forms;

namespace InterviewProject_Net
{
	internal static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
            string connectionString = @"Data Source=localhost;Initial Catalog=InterviewProject;Integrated Security=True";

            // Just checking the connection
            /*using (SqlConnection connection = new SqlConnection(connectionString))
			{
				MessageBox.Show("Connection Opened Successfully!");
			}*/

            Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm(connectionString));
		}
	}
}
