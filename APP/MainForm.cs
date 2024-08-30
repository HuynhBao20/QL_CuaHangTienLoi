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
			UI ui = new UI();
			frmHomePage h = new frmHomePage();
			h.Dock = DockStyle.Fill;
			h.TopLevel = false;
			h.FormBorderStyle = FormBorderStyle.None;
			pnl_Load_Main.Controls.Add(h);
			h.Show();

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
			h.Dock = DockStyle.Fill;
			h.TopLevel = false;
			h.FormBorderStyle = FormBorderStyle.None;
			pnl_Load_Main.Controls.Add(h);
			h.Show();
		}

		private void btnBanHang_Click(object sender, EventArgs e)
		{
			pnl_Load_Main.Controls.Clear();
			frmQuanLyHangHoa hh = new frmQuanLyHangHoa();
			hh.Dock = DockStyle.Fill;
			hh.TopLevel = false;
			pnl_Load_Main.Controls.Add(hh);
			hh.Show();
		}

		private void btnKhachHang_Click(object sender, EventArgs e)
		{
			pnl_Load_Main.Controls.Clear();
			frmKhachHang kh = new frmKhachHang();
			kh.FormBorderStyle = FormBorderStyle.None;
			kh.Dock = DockStyle.Fill;
			kh.TopLevel = false;
			pnl_Load_Main.Controls.Add(kh);
			kh.Show();
		}

		private void btnNhanSu_Click(object sender, EventArgs e)
		{
			pnl_Load_Main.Controls.Clear();
			frmDanhMucNhanSu ns = new frmDanhMucNhanSu(UserName, PassWord);
			ns.FormBorderStyle = FormBorderStyle.None;
			ns.Dock = DockStyle.Fill;
			ns.TopLevel = false;
			pnl_Load_Main.Controls.Add(ns);
			ns.Show();

		}

		private void button6_Click(object sender, EventArgs e)
		{
			pnl_Load_Main.Controls.Clear();
			frmQuanLyHoaDon hd = new frmQuanLyHoaDon();
			hd.Dock = DockStyle.Fill;
			hd.TopLevel = false;
			pnl_Load_Main.Controls.Add(hd);
			hd.Show();

		}

		private void btnDoanhThu_Click(object sender, EventArgs e)
		{
			pnl_Load_Main.Controls.Clear();
			frmQuanLyDoanhThu dt = new frmQuanLyDoanhThu();
			dt.FormBorderStyle = FormBorderStyle.None;
			dt.Dock = DockStyle.Fill;
			dt.TopLevel = false;
			pnl_Load_Main.Controls.Add(dt);
			dt.Show();

		}

		private void btnHangHoa_Click(object sender, EventArgs e)
		{
			pnl_Load_Main.Controls.Clear();
			frmNhapHang sp = new frmNhapHang(UserName, PassWord);
			sp.Dock = DockStyle.Fill;
			sp.TopLevel = false;
			sp.FormBorderStyle = FormBorderStyle.None;
			pnl_Load_Main.Controls.Add(sp);
			sp.Show();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{

		}
	}
}
