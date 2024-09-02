using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectionDB.Models
{
	public class Datatable
	{
		Connection db;
		public string User { get; set; }
		public string Pass { get; set; }
		public Datatable(string User, string Pass)
		{
			this.User = User;
			this.Pass = Pass;
			db = new Connection(User, Pass);
		}

		public DataTable da_NhanVien() => db.loadDB("SELECT * FROM NHANVIEN");
		public DataTable da_KhachHang() => db.loadDB("SELECT * FROM KHACHHANG");
		public DataTable da_HoaDon() => db.loadDB("SELECT * FROM HOADON");
		public DataTable da_SanPham() => db.loadDB("SELECT * FROM SANPHAM");
		public DataTable da_PhieuNhap() => db.loadDB("SELECT * FROM PHIEUNHAP");
		public DataTable da_CTPhieuNhap(string MAPN) => db.loadDB($"EXEC sp_Join_CTPN '{MAPN}'");
		public DataTable da_CTPhieuNhap_MAPN(string MAPN) => db.loadDB($"SELECT * FROM CTPHIEUNHAP WHERE MAPN = '{MAPN}'");
	}
}
