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
using Reporting;
namespace APP.Views
{
	public partial class QuanLyHangHoa : Form
	{
		UI ui = new UI();
		Connection db = new Connection();
		public static string getBillID = "SELECT TOP 1 MAHD FROM HOADON ORDER BY MAHD DESC";
		public QuanLyHangHoa()
		{
			InitializeComponent();
			UI_Design();
		}
		public void UI_Design()
		{
			ui.UI_LoadProduct(flp_Product, flp_BillDetail, "", txtTongTien);
			ui.loadCombobox(cbo_MaKH, "SELECT MAKH FROM KHACHHANG", "MAKH", "MAKH");
			ui.UI_BillDetail(flp_BillDetail, 0);
			ui.loadTreeView(tv_LoaiSP);
		}
		private void btnThemHoaDon_Click(object sender, EventArgs e)
		{
			try
			{
				string Sql = "INSERT INTO HOADON(MAKH, MANV) VALUES (1, 1)";
				db.ExcuteQuery(Sql);
				lb_MaHD.Text = db.ExcuteReader(QuanLyHangHoa.getBillID, "MAHD");
				lb_NgayLap.Text = DateTime.Now.ToString("dd/MM/yyyy");
				txtThanhTien.Text = db.ExcuteReader("EXEC Tong_ThanhTien " + int.Parse(db.ExcuteReader(QuanLyHangHoa.getBillID, "MAHD")), "Thành tiền");
			} catch (Exception ex)
			{
				MessageBox.Show($"Thêm hóa đơn thất bại \n{ex.Message}");
			}
		}
		private void btnHuyHoaDon_Click(object sender, EventArgs e)
		{
			try
			{
				string Sql = $"DELETE FROM HOADON WHERE MAHD = {int.Parse(db.ExcuteReader(UI.getBillID, "MAHD"))}";
				db.ExcuteQuery(Sql);
			} catch(Exception ex)
			{
				MessageBox.Show($"Hủy hóa đơn thất bại \n{ex.Message}");
			}
		}
		private void btnSearch_Click(object sender, EventArgs e)
		{
			flp_Product.Controls.Clear();
			ui.UI_LoadProduct(flp_Product, flp_BillDetail, txtSearch.Text, txtTongTien);
		}
		private void tv_LoaiSP_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
		{
			flp_Product.Controls.Clear();
			ui.Ui_Filter_Product(flp_Product, $"SELECT * FROM SANPHAM sp, LOAISP l WHERE sp.MALOAI = l.MALOAI AND TENLOAI = N'{e.Node.Text}'", flp_BillDetail, txtThanhTien);
		}
		private void btnXuatHoaDon_Click(object sender, EventArgs e)
		{
			SharedReporting S = new SharedReporting(db.ExcuteReader(QuanLyHangHoa.getBillID, "MAHD"));
			S.Show();
		}
		private void txtKD_TextChanged(object sender, EventArgs e)
		{
			int thanhtien = int.Parse(txtTongTien.Text);
			int tienKD = int.Parse(txtKD.Text);
			txtThanhTien.Text = (tienKD - thanhtien).ToString();
		}
		private void button3_Click(object sender, EventArgs e)
		{
			int MAHD = ui.getHoaDon();
			string insertTienKD = $"UPDATE HOADON SET TIENKD = {int.Parse(txtKD.Text)}, TRANGTHAI = N'Đã xuất hóa đơn' WHERE MAHD = {MAHD}";
			db.ExcuteQuery(insertTienKD);
		}
	}
}
