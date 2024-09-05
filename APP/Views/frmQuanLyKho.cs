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
	public partial class frmQuanLyKho : Form
	{
		process p = new process();
		NhapHang n;
		Connection db;
		public static string getBillID = "SELECT TOP 1 MAPN FROM PHIEUNHAP ORDER BY MAPN DESC";
		public string UserName { get; set; }
		public string PassWord { get; set; }

		public frmQuanLyKho(string User, string Pass)
		{
			InitializeComponent();
			this.UserName = User;
			this.PassWord = Pass;
			db = new Connection(UserName, PassWord);
			n = new NhapHang(UserName, PassWord);
			load();
		}
		private void load()
		{
			dgv.DataSource = db.loadDB("SELECT KHO.MASP, TENSP, NGAYSX, NGAYHH, SLTON FROM KHO, SANPHAM where KHO.MASP = SANPHAM.MASP");
			lb_TongSL.Text = $"Tổng số lượng: {db.ExcuteReader("SELECT SUM(SLTON) AS 'TONG' FROM KHO", "TONG")} sản phẩm";
			lb_TongTien.Text = $"Tổng tiền: {int.Parse(db.ExcuteReader("SELECT SUM((SLTON * DONGIA)) AS 'TONG' FROM KHO, SANPHAM where KHO.MASP = SANPHAM.MASP", "TONG")).ToString("0,00")} VNĐ";
		}
		private void radioButton1_CheckedChanged(object sender, EventArgs e)
		{
			dgv.DataSource = db.loadDB("SELECT KHO.MASP, TENSP, SUM(SLTON) FROM KHO, SANPHAM where KHO.MASP = SANPHAM.MASP GROUP BY KHO.MASP, TENSP");
		}
		private void btnSearch_Click(object sender, EventArgs e)
		{
			dgv.DataSource = db.loadDB($"SELECT KHO.MASP, TENSP, NGAYSX, NGAYHH, SLTON FROM KHO, SANPHAM where KHO.MASP = SANPHAM.MASP and KHO.MASP = '{txtMaSP.Text}'");
		}
		private void button1_Click(object sender, EventArgs e)
		{

		}
	}
}
