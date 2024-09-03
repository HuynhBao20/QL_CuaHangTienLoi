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
			a.Analyst_Month(chart1);
			a.Analyst_Product_Buy(chart2);
			int currentMonth = DateTime.Now.Month;
			label7.Text = int.Parse(db.ExcuteReader($"EXEC sp_ThongKeTheoThang {currentMonth}", "Tổng giá trị hóa đơn")).ToString("0,00") + " VNĐ";
			label6.Text = float.Parse(db.ExcuteReader($"SELECT AVG(SOLUONG * DONGIA) AS 'DT' FROM HOADON, SANPHAM, CT_HOADON WHERE HOADON.MAHD = CT_HOADON.MAHD AND SANPHAM.MASP = CT_HOADON.MASP", "DT")).ToString("0,00") + " VNĐ";
			label8.Text = int.Parse(db.ExcuteReader($"SELECT COUNT(*) AS 'SL' FROM HOADON", "SL")).ToString();
			//label5.Text = int.Parse(db.ExcuteReader($"SELECT SUM(*) AS 'SL' FROM HOADON", "SL")).ToString("0.00") + " VNĐ";
		}
	}
}
