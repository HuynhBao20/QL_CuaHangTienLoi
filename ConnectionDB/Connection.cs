using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ConnectionDB
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
	}
}
