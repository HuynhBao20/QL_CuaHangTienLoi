using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using APP.Controllers;
using APP.Views;
using APP.Views.manhinhphu;
using ConnectionDB;
using ConnectionDB.Models;
namespace APP
{
	public partial class MainForm : Form
	{
		public Connection conn;
		Connection db = new Connection();
		process p = new process();
		public string UserName { get; set; }
		public string PassWord { get; set; }
		public MainForm(string User, string Pass)
		{
			InitializeComponent();
			this.UserName = User;
			this.PassWord = Pass;
			conn = new Connection(UserName, PassWord);
			_UserName.Text = db.ExcuteReader($"SELECT HOTEN FROM NHANVIEN WHERE MANV = '{User}'", "HOTEN");
			load();
		}
		public void load()
		{
			frmHomePage h = new frmHomePage();
			p.load_Interface(h, pnl_Load_Main);
		}
		private void resetPass_Click(object sender, EventArgs e)
		{
			frmResetPass reset = new frmResetPass(UserName);
			reset.Show();
		}

		private void _Logout_Click(object sender, EventArgs e)
		{
			frmLogin lg = new frmLogin();
			this.Hide();
			lg.Show();
		}

		private void btnHome_Click(object sender, EventArgs e)
		{
			frmDashboard h = new frmDashboard(UserName, PassWord);
			p.load_Interface(h, pnl_Load_Main);
		}

		private void btnBanHang_Click(object sender, EventArgs e)
		{
			//frmQuanLyHangHoa hh = new frmQuanLyHangHoa();
			//p.load_Interface(hh, pnl_Load_Main);
		}

		private void btnKhachHang_Click(object sender, EventArgs e)
		{
			frmKhachHang kh = new frmKhachHang(UserName, PassWord);
			p.load_Interface(kh, pnl_Load_Main);
		}

		private void btnNhanSu_Click(object sender, EventArgs e)
		{
			frmDanhMucNhanSu ns = new frmDanhMucNhanSu(UserName, PassWord);
			p.load_Interface(ns, pnl_Load_Main);
		}
		private void btnDoanhThu_Click(object sender, EventArgs e)
		{
			frmQuanLyDoanhThu dt = new frmQuanLyDoanhThu();
			p.load_Interface(dt, pnl_Load_Main);
		}
		private void MainForm_Load(object sender, EventArgs e)
		{

		}
		private void tt_Kho_Click(object sender, EventArgs e)
		{
			frmQuanLyKho kho = new frmQuanLyKho(UserName, PassWord);
			p.load_Interface(kho, pnl_Load_Main);

		}

		private void btnNhap_Click(object sender, EventArgs e)
		{
			frmNhapHang sp = new frmNhapHang(UserName, PassWord);
			p.load_Interface(sp, pnl_Load_Main);

		}
	}
}
