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
using ConnectionDB.Logic;
using Reporting;
using System.Data.SqlClient;
using APP.Views.manhinhphu;

namespace APP.Views
{
	public partial class frmQuanLyHangHoa : Form
	{
		UI ui;
		Connection db;
		process p = new process();
		public static string getBillID = "SELECT TOP 1 MAHD FROM HOADON ORDER BY MAHD DESC";
		public static string query_Bill = "SELECT COUNT(*) as 'SL' FROM HOADON WHERE TRANGTHAI = N'Chưa xuất' AND CAST(NGAYLAP AS DATE) = CAST(GETDATE() AS DATE)";
		public string MAHD { get; set; }
		public int SOHD { get; set; }
		public string UserName { get; set; }
		public string PassWord { get; set; }

		public frmQuanLyHangHoa()
		{
			InitializeComponent();
			db = new Connection();
			ui = new UI(lb_MaHD);
			UI_Design();
		}
		public frmQuanLyHangHoa(string UserName, string PassWord)
		{
			this.UserName = UserName;
			this.PassWord = PassWord;
			db = new Connection(UserName, PassWord);
			ui = new UI(lb_MaHD);
			UI_Design();

		}
		public void UI_Design()
		{
			lb_MaHD.Text = "";
			lb_NgayLap.Text = "";
			ui.UI_LoadProduct(flp_Product, flp_BillDetail, txtTongTien, txtSDT.Text);
			ui.UI_BillDetail(flp_BillDetail, "", txtTongTien);
			tv_LoaiSP.Controls.Clear();
			ui.loadTreeView(tv_LoaiSP);
			btnTotalMoMo.Enabled = false;
			ui.load_HoaDon_ChuaXuat(flp_HDChuaXuat, "EXEC sp_HD_ChuaXuat", lb_MaHD, lb_NgayLap, flp_BillDetail, txtTongTien);
			int SOHD = int.Parse(db.ExcuteReader(frmQuanLyHangHoa.query_Bill, "SL"));
			gp_HoaDonChuaXuat.Text = $"Số hóa đơn chưa xuất: {SOHD}";
			lb_DT.Text = db.ExcuteReader(Connection.Query_DoanhThu, "Tổng giá trị hóa đơn") == "" ? "0" : db.ExcuteReader(Connection.Query_DoanhThu, "Tổng giá trị hóa đơn");
		}
		private void btnThemHoaDon_Click(object sender, EventArgs e)
		{
			try
			{
				string getMAHD = db.ExcuteReader(frmQuanLyHangHoa.getBillID, "MAHD").Trim();
				string MAHD = db.getMAHD(getMAHD, "HD");
				this.MAHD = MAHD;
				string Sql = $"INSERT INTO HOADON(MAHD, MAKH, MANV) VALUES ('{MAHD}', 'KH001', 'NV001')";
				db.ExcuteQuery(Sql);
				lb_MaHD.Text = MAHD;
				lb_NgayLap.Text = DateTime.Now.ToString("dd/MM/yyyy");
				int HDDT = int.Parse(db.ExcuteReader(frmQuanLyHangHoa.query_Bill, "SL"));
				if (HDDT != this.SOHD)
				{
					gp_HoaDonChuaXuat.Text = $"Số hóa đơn chưa xuất: {HDDT}";
					ui.load_HoaDon_ChuaXuat(flp_HDChuaXuat, "EXEC sp_HD_ChuaXuat", lb_MaHD, lb_NgayLap, flp_BillDetail, txtTongTien);
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
                // Kiểm tra giá trị MAHD
                if (string.IsNullOrEmpty(this.MAHD))
                {
                    MessageBox.Show("Không có mã hóa đơn để hủy.");
                    return;
                }

                MessageBox.Show($"Đang hủy hóa đơn: {this.MAHD}"); // Kiểm tra mã hóa đơn

                // Cập nhật trạng thái của hóa đơn thành "Đã hủy"
                string updateInvoiceSql = $"UPDATE HOADON SET TRANGTHAI = N'Đã hủy' WHERE MAHD = '{this.MAHD}'";
                db.ExcuteQuery(updateInvoiceSql);

                // Kiểm tra trạng thái đã được cập nhật chưa
                string checkStatusSql = $"SELECT TRANGTHAI FROM HOADON WHERE MAHD = '{this.MAHD}'";
                string currentStatus = db.ExcuteReader(checkStatusSql, "TRANGTHAI");

                if (currentStatus == "Đã hủy")
                {
                    MessageBox.Show($"Hóa đơn {this.MAHD} đã được hủy thành công!");

                    // Xóa mã sản phẩm
                    txtMaSP.Clear();

                    // Xóa mã hóa đơn
                    lb_MaHD.Text = "";

                    // Xóa ngày lập
                    lb_NgayLap.Text = "";
                }

                else
                {
                    MessageBox.Show($"Cập nhật trạng thái thất bại. Trạng thái hiện tại của hóa đơn {this.MAHD}: {currentStatus}");
                }

                // Làm mới giao diện
                ui.load_HoaDon_ChuaXuat(flp_HDChuaXuat, "EXEC sp_HD_ChuaXuat", lb_MaHD, lb_NgayLap, flp_BillDetail, txtTongTien);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hủy hóa đơn thất bại: {ex.Message}");
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
		{
			flp_Product.Controls.Clear();
			ui.Ui_Filter_Product(flp_Product, $"SELECT * FROM SANPHAM sp WHERE TENSP LIKE N'{txtSearch.Text}%' OR TENSP LIKE N'%{txtSearch.Text}%' OR TENSP LIKE N'%{txtSearch.Text}'", flp_BillDetail, txtThanhTien, txtSDT.Text);
		}
		private void tv_LoaiSP_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
		{
			flp_Product.Controls.Clear();
			ui.Ui_Filter_Product(flp_Product, $"SELECT * FROM SANPHAM sp, LOAISP l WHERE sp.MALOAI = l.MALOAI AND TENLOAI = N'{e.Node.Text}'", flp_BillDetail, txtThanhTien, txtSDT.Text);
		}
		private void button3_Click(object sender, EventArgs e)
		{
			try
			{

				this.MAHD = lb_MaHD.Text;
				string KD = txtKD.Text == "" ? db.ExcuteReader($"EXEC Tong_ThanhTien '{lb_MaHD.Text}'", "Thành tiền") : txtKD.Text;
				string insertTienKD = $"UPDATE HOADON SET TIENKD = {KD}, TRANGTHAI = N'Đã xuất hóa đơn' WHERE MAHD = '{this.MAHD}'";
				db.ExcuteQuery(insertTienKD);
				MessageBox.Show("Xác nhận thành công");
				btnTotalMoMo.Enabled = true;

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
					MessageBox.Show("Sản phẩm không tồn tại");
				}
				else
				{
					if(this.MAHD == null)
					{
						//string Sql = $"INSERT INTO HOADON VALUES ('{}')";
					} else
					{
						p.ThemHoaDon(flp_BillDetail, this.MAHD, txtMaSP, txtTongTien);
					}
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
			string sql = $"SELECT TRANGTHAI FROM HOADON WHERE MAHD = '{MAHD}'";
			//string is_ShowBill = db.ExcuteReader(sql, "TRANGTHAI");
				SharedReporting S = new SharedReporting(MAHD);
				S.Show();
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
		private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
		{
			if(txtSDT.TextLength == 10 || (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)))
			{
				e.Handled = true;
			}
		}

        private void flp_BillDetail_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
