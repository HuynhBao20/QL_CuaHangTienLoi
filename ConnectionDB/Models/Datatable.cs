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
		public DataTable da_Kho() => db.loadDB("SELECT MASP, SUM(SLTON) FROM KHO GROUP BY MASP");
		public DataTable da_MaLoai() => db.loadDB("SELECT * FROM LOAISP");
		public DataTable da_MaLoai(string TenSP) => db.loadDB($"SELECT * FROM LOAISP WHERE TENSP = N'{TenSP}'");
		public DataTable da_PhieuNhap(string Active, string Date, string condition) => db.loadDB($"SELECT * FROM PHIEUNHAP WHERE TRANGTHAI = N'{Active}' {condition} CAST(NGAYNHAP AS DATE) = '{Date}'");
		public DataTable da_CTPhieuNhap(string MAPN) => db.loadDB($"EXEC sp_Join_CTPN '{MAPN}'");
		public DataTable da_CTPhieuNhap_MAPN(string MAPN) => db.loadDB($"SELECT * FROM CTPHIEUNHAP WHERE MAPN = '{MAPN}'");
		public void Del_CTPhieu(string MASP, string MAPN) => db.ExcuteQuery($"DELETE FROM CTPHIEUNHAP WHERE MASP = '{MASP}' AND MAPN = '{MAPN}'");
		
	}
}
