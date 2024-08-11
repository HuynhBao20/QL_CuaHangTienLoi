using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.API.Process
{
	public class Connection
	{
		public static string _conStr = @"Data Source=LAPTOP-V4M3UK0D\THEBAO;Initial Catalog=QL_CHTienLoi;Integrated Security=True";
		SqlConnection _cnn = new SqlConnection(_conStr);
		public DataTable loadDB(string Sql)
		{
			DataTable da = new DataTable();
			SqlDataAdapter sda = new SqlDataAdapter(Sql, _cnn);
			sda.Fill(da);
			return da;
		}

		public void ExcuteQuery(string Sql)
		{
			_cnn.Open();
			SqlCommand cmd = new SqlCommand(Sql, _cnn);
			cmd.ExecuteNonQuery();
			_cnn.Close();
		}

		public string ExcuteReader(string Sql, string tableName)
		{
			_cnn.Open();
			SqlCommand cmd = new SqlCommand(Sql, _cnn);
			SqlDataReader Sdr = cmd.ExecuteReader();
			string name = "";
			while (Sdr.Read())
			{
				name = Sdr[tableName].ToString();
			}
			_cnn.Close();
			return name;
		}
		public void close()
		{
			if (_cnn.State == ConnectionState.Open)
			{
				_cnn.Close();
			}
		}

	}
}
