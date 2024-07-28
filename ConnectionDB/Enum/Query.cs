using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectionDB.Enum
{
	public class Query
	{
		public static string Select_NhanVien = "SELECT * FROM NHANVIEN";
		public static string Select_KhachHang = "SELECT * FROM KHACHHANG";
		public static string Select_HoaDon = "SELECT * FROM HOADON";
		public static string Select_PhieuNhap = "SELECT * FROM NHANVIEN";
		public static string Select_TongThanhTien = "EXEC Tong_ThanhTien ";
	}
}
