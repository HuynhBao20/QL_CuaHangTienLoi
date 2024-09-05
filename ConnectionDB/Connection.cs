using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using ConnectionDB.Models;
namespace ConnectionDB
{
	public class Connection
	{
		public static string _conStr;
		SqlConnection _cnn;
		public static string Query_GetMAKH = "SELECT TOP 1 MAKH FROM KHACHHANG WHERE MAKH LIKE 'KH%' ORDER BY MAKH DESC";
		public static string Query_DoanhThu = "EXEC sp_ThongKeTheoNgay";
		public static string Query_List_LoaiSP = "SELECT * FROM LOAISP";
		public Connection() {
			Connection._conStr = @"Data Source=LAPTOP-V4M3UK0D\THEBAO;Initial Catalog=QL_CHTienLoi;Integrated Security=True";
			_cnn = new SqlConnection(_conStr);
		}
		public Connection(string UserName, string PassWord)
		{
			Connection._conStr = @"Data Source=LAPTOP-V4M3UK0D\THEBAO;Initial Catalog=QL_CHTienLoi;User ID=" + UserName +"; Password=" +PassWord;
			_cnn = new SqlConnection(_conStr);
		}
		public bool is_Connection()
		{
			try
			{
				_cnn.Open();
				return true;
			}catch
			{
				return false;
			}
		}
		public DataTable loadDB(string Sql)
		{
			try
			{
				DataTable da = new DataTable();
				SqlDataAdapter sda = new SqlDataAdapter(Sql, _cnn);
				sda.Fill(da);
				return da;
			}catch(Exception e)
			{
				throw new Exception(e.Message);
			}
		}
		
		public void ExcuteQuery(string Sql)
		{
			try
			{
				_cnn.Open();
				SqlCommand cmd = new SqlCommand(Sql, _cnn);
				cmd.ExecuteNonQuery();
				_cnn.Close();
			}catch
			{
				_cnn.Close();
			}
		}
		public string ExcuteReader(string Sql, string tableName)
		{
			try
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
			catch 
			{
				_cnn.Close();
				return "";
			}
		}
		public void close()
		{
			try
			{
				if (_cnn.State == ConnectionState.Open)
				{
					_cnn.Close();
				}
			}
			catch 
			{
				_cnn.Close();
			}
		}
		public string getMAHD(string MAHD, string KTD)
		{
			int a = int.Parse(MAHD.Trim().Substring(2, MAHD.Trim().Length - 2));
			a++;
			return a < 10 ? $"{KTD}00{a}" : (a >= 10 && a < 100) ? $"{KTD}0{a}" : $"{KTD}{a}";
		}
	}
}
