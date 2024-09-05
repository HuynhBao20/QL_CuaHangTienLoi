using APP.Controllers;
using ConnectionDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP.Views
{
	public partial class frmQuanLyDoanhThu : Form
	{
		Analyst a = new Analyst();
		Connection db = new Connection();
		public frmQuanLyDoanhThu()
		{
			InitializeComponent();
			a.Analyst_Month(chart1, "EXEC sp_ThongKeTheoNgay", "Ngày lập");
			a.Analyst_Month(chart2, "EXEC sp_ThongKeTheoThang", "Thang");

			int currentMonth = DateTime.Now.Month;
			//label7.Text = int.Parse(db.ExcuteReader($"EXEC sp_ThongKeTheoThang {currentMonth}", "Tổng giá trị hóa đơn")).ToString("0,00") + " VNĐ";
			//label6.Text = float.Parse(db.ExcuteReader($"SELECT AVG(SOLUONG * DONGIA) AS 'DT' FROM HOADON, SANPHAM, CT_HOADON WHERE HOADON.MAHD = CT_HOADON.MAHD AND SANPHAM.MASP = CT_HOADON.MASP", "DT")).ToString("0,00") + " VNĐ";
			//label8.Text = int.Parse(db.ExcuteReader($"SELECT COUNT(*) AS 'SL' FROM HOADON", "SL")).ToString();
			dgv.DataSource = db.loadDB($"EXEC sp_DoanhThu");
			lb_TongTien.Text = "Tổng doanh thu: " + int.Parse(db.ExcuteReader("SELECT SUM([Thành tiền]) AS 'TT' FROM Tong_DoanhThu", "TT")).ToString("0,00") + "VNĐ";
		}

		private void dtp_ValueChanged(object sender, EventArgs e)
		{
			try
			{
				dgv.DataSource = db.loadDB($"EXEC sp_HoaDon_DoanhThu '{dtp.Value}'");
				lb_TongTien.Text = $"Tổng doanh thu ngày {dtp.Value.ToString("dd/MM/yyyy")}: " + int.Parse(db.ExcuteReader($"EXEC sp_ThanhTienTheoNgay '{dtp.Value}'", "TT")).ToString("0,00") + "VNĐ";
			} catch
			{
				MessageBox.Show($"Không có hóa đơn trong ngày {dtp.Value.ToString("dd/MM/yyyy")}");
			}
			
		}

		private void dtp_toDate_ValueChanged(object sender, EventArgs e)
		{
			try
			{
				dgv.DataSource = db.loadDB($"SELECT * FROM Tong_DoanhThu WHERE CAST([Ngày lập] AS DATE) >= '{dtp.Value.ToString("yyyy-MM-dd")}' AND CAST([Ngày lập] AS DATE) <= '{dtp_toDate.Value.ToString("yyyy-MM-dd")}'");
				lb_TongTien.Text = $"Tổng doanh thu từ ngày {dtp.Value.ToString("dd/MM/yyyy")} đến : {dtp_toDate.Value.ToString("dd/MM/yyyy")}" + int.Parse(db.ExcuteReader($"EXEC sp_ThanhTienTheoNgay '{dtp.Value}'", "TT")).ToString("0,00") + "VNĐ";
			}
			catch
			{
				MessageBox.Show($"Không có hóa đơn trong ngày {dtp.Value.ToString("dd/MM/yyyy")}");
			}
		}
		private void btnMaKH_Click(object sender, EventArgs e)
		{
			try
			{
				dgv.DataSource = db.loadDB($"SELECT * FROM Tong_DoanhThu WHERE [Mã khách hàng] = '{txtMaKH.Text}'");
				//lb_TongTien.Text = $"Tổng doanh thu của khách hàng: {txtMaKH.Text}" + int.Parse(db.ExcuteReader($"EXEC sp_ThanhTienTheoNgay '{dtp.Value}'", "TT")).ToString("0,00") + "VNĐ";
			}
			catch
			{
				MessageBox.Show($"Không có hóa đơn trong ngày {dtp.Value.ToString("dd/MM/yyyy")}");
			}

		}
	}
}
