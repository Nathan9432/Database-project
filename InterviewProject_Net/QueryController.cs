using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Markup;

namespace InterviewProject_Net
{
	public class QueryController
	{
		private readonly string connectionString;

		public QueryController(string connectionString){
			this.connectionString = connectionString;
		}

		/// <summary>
		/// Given a query and parameters, executes the query without expecting a response.
		/// </summary>
		public void ExecuteQuery(string query, Dictionary<string, (SqlDbType, object)> parameters)
		{
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();
				SqlCommand cmd = new SqlCommand(query, connection);
				foreach (var param in parameters.ToList())
				{
					cmd.Parameters.Add(param.Key, param.Value.Item1).Value = param.Value.Item2;
				}
				cmd.ExecuteNonQuery();
			}
		}

		public int ExecuteQuery_ReturnScalar(string query, Dictionary<string, (SqlDbType, object)> parameters)
		{
			int ret;
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();
				SqlCommand cmd = new SqlCommand(query, connection);
				foreach (var param in parameters.ToList())
				{
					cmd.Parameters.Add(param.Key, param.Value.Item1).Value = param.Value.Item2;
				}
				ret = (int)cmd.ExecuteScalar();
			}
			return ret;
		}

		public List<int> ExecuteQuery_ReturnList(string query, Dictionary<string, (SqlDbType, object)> parameters)
		{
			List<int> ret = new List<int>();
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				// Grabbing Order IDs
				connection.Open();
				SqlCommand cmd = new SqlCommand(query, connection);
				foreach (var param in parameters.ToList())
				{
					cmd.Parameters.Add(param.Key, param.Value.Item1).Value = param.Value.Item2;
				}
				List<int> values = new List<int>();
				try
				{
					SqlDataReader dr = cmd.ExecuteReader();
					while (dr.Read())
					{
						values.Add(dr.GetInt32(0));
					}
					dr.Close();
					ret = values.ToList();
				} catch (SqlException oError)
				{
					MessageBox.Show("There was an SQL error while deleting the extra information: " + oError.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			return ret;
		}

		public object[] ExecuteQuery_ReturnColumns(string query, Dictionary<string, (SqlDbType, object)> parameters, int cols)
		{
			object[] ret = new object[cols];
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				// Grabbing Order IDs
				connection.Open();
				SqlCommand cmd = new SqlCommand(query, connection);
				foreach (var param in parameters.ToList())
				{
					cmd.Parameters.Add(param.Key, param.Value.Item1).Value = param.Value.Item2;
				}
				List<int> values = new List<int>();
				try
				{
					SqlDataReader dr = cmd.ExecuteReader();
					dr.Read();
					for (int i = 0; i < cols; i++)
					{
						ret[i] = dr[i];
					}
					dr.Close();
				} catch (SqlException oError)
				{
					MessageBox.Show("There was an SQL error while deleting the extra information: " + oError.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			return ret;
		}

		public SqlDataAdapter GetAdapter(string query)
		{
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();
				SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
				return adapter;
			}
		}

		public DataTable GetDataTable(string query)
		{
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();
				var dt = new DataTable();
				SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
				adapter.Fill(dt);
				return dt;
			}
		}
	}
}
