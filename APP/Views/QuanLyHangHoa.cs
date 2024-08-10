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
using ConnectionMoMo;
using System.Data.SqlClient;

namespace APP.Views
{
	public partial class QuanLyHangHoa : Form
	{
		UI ui = new UI();
		Connection db = new Connection();
		Process p = new Process();
		public static string getBillID = "SELECT TOP 1 MAHD FROM HOADON ORDER BY MAHD DESC";
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
			ui.loadTreeView(tv_LoaiSP);
			ui.load_HoaDon_ChuaXuat(flp_HDChuaXuat, "EXEC sp_HD_ChuaXuat", lb_MaHD, lb_NgayLap, flp_BillDetail);
			btnHuyHoaDon.Enabled = false;
		}
		private void btnThemHoaDon_Click(object sender, EventArgs e)
		{
			try
			{
				btnHuyHoaDon.Enabled = true;
				string getMAHD = db.ExcuteReader("SELECT TOP 1 MAHD FROM HOADON ORDER BY MAHD DESC", "MAHD").Trim();
				string MAHD = p.getMAHD(getMAHD);
				string Sql = $"INSERT INTO HOADON(MAHD, MAKH, MANV) VALUES ('{MAHD}', 'VL000', 'NV001')";
				db.ExcuteQuery(Sql);
				lb_MaHD.Text = MAHD;
				lb_NgayLap.Text = DateTime.Now.ToString("dd/MM/yyyy");
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
			ui.Ui_Filter_Product(flp_Product, $"SELECT * FROM SANPHAM sp WHERE TENSP LIKE N'{txtSearch.Text}%' OR TENSP LIKE N'%{txtSearch.Text}%' OR TENSP LIKE N'%{txtSearch.Text}'", flp_BillDetail, txtThanhTien);
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
			
			int tongtien = int.Parse(txtKD.Text != "" ? txtKD.Text : "0") - int.Parse(txtTongTien.Text);
			if(tongtien < 0)
			{
				txtThanhTien.Text = "0";
			}else
			{
				txtThanhTien.Text = (tongtien).ToString();

			}
		}
		private void button3_Click(object sender, EventArgs e)
		{
			txtThanhTien.Text = string.IsNullOrEmpty(txtThanhTien.Text) ? "0" : txtThanhTien.Text;
			txtKD.Text = string.IsNullOrEmpty(txtKD.Text) ? "0" : txtKD.Text;
			if (int.Parse(txtThanhTien.Text) >= int.Parse(txtKD.Text))
			{
				MessageBox.Show("Tiền khách đưa phải >= tổng thành tiền");
			}else
			{
				string MAHD = ui.getHoaDon();
				frmMainThanhToan main = new frmMainThanhToan(MAHD, int.Parse(txtKD.Text));
				main.Show();
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
					string Sql = $"INSERT INTO CT_HOADON(MAHD, MASP, SOLUONG) VALUES ('{db.ExcuteReader(UI.getBillID, "MAHD")}', '{txtMaSP.Text}', 1)";
					db.ExcuteQuery(Sql);
					ui.UI_BillDetail(flp_BillDetail, db.ExcuteReader(UI.getBillID, "MAHD"));
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
	}
}
