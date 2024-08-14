using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using APP.Controllers;
using ConnectionDB;
using ConnectionDB.Enum;
using ConnectionDB.Logic;
using Reporting;
using System.Data.SqlClient;
using APP.Views.manhinhphu;

namespace APP.Views
{
	public partial class QuanLyHangHoa : Form
	{
		UI ui = new UI();
		Connection db = new Connection();
		Process p = new Process();
		public static string getBillID = "SELECT TOP 1 MAHD FROM HOADON ORDER BY MAHD DESC";
		public static string query_Bill = "SELECT COUNT(*) as 'SL' FROM HOADON WHERE TRANGTHAI = N'Chưa xuất' AND CAST(NGAYLAP AS DATE) = CAST(GETDATE() AS DATE)";
		public string MAHD { get; set; }
		public int SOHD { get; set; }
		public QuanLyHangHoa()
		{
			InitializeComponent();
			UI_Design();
		}
		public void UI_Design()
		{
			lb_MaHD.Text = "";
			lb_NgayLap.Text = "";
			ui.UI_LoadProduct(flp_Product, flp_BillDetail, txtTongTien);
			ui.UI_BillDetail(flp_BillDetail, "");
			tv_LoaiSP.Controls.Clear();
			ui.loadTreeView(tv_LoaiSP);
			ui.load_HoaDon_ChuaXuat(flp_HDChuaXuat, "EXEC sp_HD_ChuaXuat", lb_MaHD, lb_NgayLap, flp_BillDetail);
			int SOHD = int.Parse(db.ExcuteReader(QuanLyHangHoa.query_Bill, "SL"));
			gp_HoaDonChuaXuat.Text = $"Số hóa đơn chưa xuất: {SOHD}";
		}
		private void btnThemHoaDon_Click(object sender, EventArgs e)
		{
			try
			{
				string getMAHD = db.ExcuteReader(QuanLyHangHoa.getBillID, "MAHD").Trim();
				string MAHD = p.getMAHD(getMAHD);
				this.MAHD = MAHD;
				string Sql = $"INSERT INTO HOADON(MAHD, MAKH, MANV) VALUES ('{MAHD}', 'KH001', 'NV001')";
				db.ExcuteQuery(Sql);
				lb_MaHD.Text = MAHD;
				lb_NgayLap.Text = DateTime.Now.ToString("dd/MM/yyyy");
				int HDDT = int.Parse(db.ExcuteReader(QuanLyHangHoa.query_Bill, "SL"));
				if (HDDT != this.SOHD)
				{
					gp_HoaDonChuaXuat.Text = $"Số hóa đơn chưa xuất: {HDDT}";
					ui.load_HoaDon_ChuaXuat(flp_HDChuaXuat, "EXEC sp_HD_ChuaXuat", lb_MaHD, lb_NgayLap, flp_BillDetail);
				}
				txtThanhTien.Text = db.ExcuteReader($"EXEC Tong_ThanhTien '{MAHD}'", "Thành tiền");
			} catch (Exception ex)
			{
				MessageBox.Show($"Thêm hóa đơn thất bại \n{ex.Message}");
			}
		}
		private void btnHuyHoaDon_Click(object sender, EventArgs e)
		{
			try
			{
				string Sql = $"";
				db.ExcuteQuery(Sql);
			} catch(Exception ex)
			{
				MessageBox.Show($"Hủy hóa đơn thất bại \n{ex.Message}");
			}
		}
		private void btnSearch_Click(object sender, EventArgs e)
		{
			flp_Product.Controls.Clear();
			ui.Ui_Filter_Product(flp_Product, $"SELECT * FROM SANPHAM sp WHERE TENSP LIKE N'{txtSearch.Text}%' OR TENSP LIKE N'%{txtSearch.Text}%' OR TENSP LIKE N'%{txtSearch.Text}'", flp_BillDetail, txtThanhTien);
		}
		private void tv_LoaiSP_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
		{
			flp_Product.Controls.Clear();
			ui.Ui_Filter_Product(flp_Product, $"SELECT * FROM SANPHAM sp, LOAISP l WHERE sp.MALOAI = l.MALOAI AND TENLOAI = N'{e.Node.Text}'", flp_BillDetail, txtThanhTien);
		}
		private void txtKD_TextChanged(object sender, EventArgs e)
		{

		}
		private void button3_Click(object sender, EventArgs e)
		{
			try
			{
				MAHD = lb_MaHD.Text;
				string insertTienKD = $"UPDATE HOADON SET TIENKD = {int.Parse(txtKD.Text)}, TRANGTHAI = N'Đã xuất hóa đơn' WHERE MAHD = '{MAHD}'";
				db.ExcuteQuery(insertTienKD);
				MessageBox.Show("Xác nhận thành công");
			}
			catch (SqlException ex)
			{
				MessageBox.Show($"Xác nhận thất bại vì: \n {ex.Message}");
			}

		}
		private void btnMua_Click(object sender, EventArgs e)
		{
			try
			{
				string query = $"SELECT Count(*) as SL FROM SANPHAM WHERE MASP = '{txtMaSP.Text}'";
				int kt_TonTai = int.Parse(db.ExcuteReader(query, "SL").ToString());
				if(kt_TonTai < 1)
				{
					MessageBox.Show("Không có sản phẩm");
				}
				else
				{

					string Sql = $"INSERT INTO CT_HOADON(MAHD, MASP, SOLUONG) VALUES ('{MAHD}', '{txtMaSP.Text}', 1)";
					db.ExcuteQuery(Sql);
					//ui.Add_ProductToBill(txtMaSP.Text, txtThanhTien);
					ui.UI_BillDetail(flp_BillDetail, MAHD);
				}
			}
			catch (SqlException ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		private void txtMaSP_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
			{
				e.Handled = true;
			} 
		}
		private void btnLamMoi_Click(object sender, EventArgs e)
		{
			flp_BillDetail.Controls.Clear();
			UI_Design();
		}
		private void btnThemKhach_Click(object sender, EventArgs e)
		{
			frmKhachHang kh = new frmKhachHang();
			kh.Show();
		}
		private void btnTotalMoMo_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(this.MAHD) && !string.IsNullOrEmpty(txtKD.Text))
			{
				QRThanhToanMoMo momo = new QRThanhToanMoMo(MAHD, int.Parse(txtKD.Text));
				momo.Show();
			} else
			{
				MessageBox.Show("Bạn chưa có hóa đơn");
			}
		}
		private void btnTimKH_Click(object sender, EventArgs e)
		{
			if(!string.IsNullOrEmpty(txtSDT.Text))
			{
				string Sql = $"SELECT Count(*) AS 'SL' FROM KHACHHANG WHERE SDT = '{txtSDT.Text}'";
				string is_Customer = int.Parse(db.ExcuteReader(Sql, "SL")) > 0 ? "đã có" : "chưa đăng ký";
				MessageBox.Show($"Khách hàng {is_Customer} tài khoản");
			} else
			{
				MessageBox.Show("Số điện thoại không được để trống");
			}
		}
		private void btnMacDinh_Click(object sender, EventArgs e)
		{
			txtKD.Text = db.ExcuteReader($"EXEC Tong_ThanhTien '{lb_MaHD.Text}'", "Thành tiền");
		}
		private void lb_MaHD_TextChanged(object sender, EventArgs e)
		{
			if(!string.IsNullOrEmpty(lb_MaHD.Text))
			{
				btnHuyHoaDon.Enabled = true;
				btnMacDinh.Enabled = true;
				btnTienMat.Enabled = true;
				btnTotalMoMo.Enabled = true;
			} else
			{
				btnHuyHoaDon.Enabled = false;
				btnMacDinh.Enabled = false;
				btnTienMat.Enabled = false;
				btnTotalMoMo.Enabled = false;
			}
		}
	}
}
