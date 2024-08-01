using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConnectionDB;
using ConnectionDB.Enum;

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
			ui.UI_LoadProduct(flowLayoutPanel1, flp_BillDetail, "", int.Parse(db.ExcuteReader(QuanLyHangHoa.getBillID, "MAHD")));
			ui.loadCombobox(cbo_MaKH, "SELECT MAKH FROM KHACHHANG", "MAKH", "MAKH");
			ui.UI_BillDetail(flp_BillDetail, 0);
			ui.loadTreeView(treeView1);
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
				string getBillID = "SELECT TOP 1 MAHD FROM HOADON ORDER BY MAHD DESC";
				string Sql = $"DELETE FROM HOADON WHERE MAHD = {int.Parse(db.ExcuteReader(getBillID, "MAHD"))}";
				db.ExcuteQuery(Sql);
			} catch(Exception ex)
			{
				MessageBox.Show($"Hủy hóa đơn thất bại \n{ex.Message}");
			}
		}
		private void btnSearch_Click(object sender, EventArgs e)
		{
			flowLayoutPanel1.Controls.Clear();
			ui.UI_LoadProduct(flowLayoutPanel1, flp_BillDetail, txtSearch.Text, int.Parse(db.ExcuteReader(QuanLyHangHoa.getBillID, "MAHD")));
		}
		private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
		{

		}
		private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
		{
			
		}
	}
}
