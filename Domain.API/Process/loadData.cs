using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Domain.API.Models;
namespace Domain.API.Process
{
	public class loadData
	{
		Connection db = new Connection();
		public const string Query_KhachHang = "SELECT * FROM KHACHHANG";
		public List<KhachHang> DataKH()
		{
			DataTable dakh = db.loadDB(Query_KhachHang);
			return dakh.AsEnumerable().Select(t => new KhachHang { 
				MaKH = t.Field<string>("MAKH"),
				HoTen = t.Field<string>("HOTEN"),
				DiaChi = t.Field<string>("DIACHI"),
				SDT = t.Field<string>("SDT"),
				LoaiKH = t.Field<string>("LOAIKH"),
			}).ToList();
		}
	}
}
