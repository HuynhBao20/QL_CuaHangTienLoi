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
		public string UserName { get; set; }
		public string PassWord { get; set; }
		public MainForm(string User, string Pass)
		{
			InitializeComponent();
			this.UserName = User;
			this.PassWord = Pass;
			conn = new Connection(UserName, PassWord);
			_UserName.Text = conn.ExcuteReader($"SELECT HOTEN FROM NHANVIEN WHERE MANV = '{User}'", "HOTEN");
			load();
		}
		public void load()
		{
			UI ui = new UI();
			HomePage h = new HomePage();
			h.Dock = DockStyle.Fill;
			h.TopLevel = false;
			h.FormBorderStyle = FormBorderStyle.None;
			pnl_Load_Main.Controls.Add(h);
			h.Show();
			tv_DanhMuc.Nodes.Clear();
			foreach (DataRow item in conn.loadDB($"SELECT * FROM PQMANHINH p, DANHSACHMANHINH ds WHERE p.ID = ds.ID AND p.MANV = '{UserName}'").Rows)
			{
				 tv_DanhMuc.Nodes.Add(item["TENMH"].ToString());
			}

		}
		private void tv_DanhMuc_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
		{
			
			switch (e.Node.Text)
			{
				case "Trang chủ":
					Dashboard h = new Dashboard(UserName, PassWord);
					h.Dock = DockStyle.Fill;
					h.TopLevel = false;
					h.FormBorderStyle = FormBorderStyle.None;
					pnl_Load_Main.Controls.Add(h);
					h.Show();

					break;
				case "Quản lý bán hàng":
					pnl_Load_Main.Controls.Clear();
					QuanLyHangHoa hh = new QuanLyHangHoa();
					hh.Dock = DockStyle.Fill;
					hh.TopLevel = false;
					pnl_Load_Main.Controls.Add(hh);
					hh.Show();
					break;
				case "Quản lý nhập hàng":
					pnl_Load_Main.Controls.Clear();
					QuanLySanPham sp = new QuanLySanPham(UserName, PassWord);
					sp.Dock = DockStyle.Fill;
					sp.TopLevel = false;
					pnl_Load_Main.Controls.Add(sp);
					sp.Show();
					break;
				case "Quản lý hóa đơn":
					pnl_Load_Main.Controls.Clear();
					QuanLyHoaDon hd = new QuanLyHoaDon();
					hd.Dock = DockStyle.Fill;
					hd.TopLevel = false;
					pnl_Load_Main.Controls.Add(hd);
					hd.Show();
					break;
				case "Quản lý khách hàng":
					pnl_Load_Main.Controls.Clear();
					frmKhachHang kh = new frmKhachHang();
					kh.FormBorderStyle = FormBorderStyle.None;
					kh.Dock = DockStyle.Fill;
					kh.TopLevel = false;
					pnl_Load_Main.Controls.Add(kh);
					kh.Show();
					break;
				case "Quản lý nhân sự":
					pnl_Load_Main.Controls.Clear();
					DanhMucNhanSu ns = new DanhMucNhanSu(UserName, PassWord);
					ns.FormBorderStyle = FormBorderStyle.None;
					ns.Dock = DockStyle.Fill;
					ns.TopLevel = false;
					pnl_Load_Main.Controls.Add(ns);
					ns.Show();
					break;
				case "Quản lý doanh thu":
					pnl_Load_Main.Controls.Clear();
					frmQuanLyDoanhThu dt = new frmQuanLyDoanhThu();
					dt.FormBorderStyle = FormBorderStyle.None;
					dt.Dock = DockStyle.Fill;
					dt.TopLevel = false;
					pnl_Load_Main.Controls.Add(dt);
					dt.Show();
					break;
			}
		}

		private void resetPass_Click(object sender, EventArgs e)
		{
			frmResetPass reset = new frmResetPass(UserName);
			reset.Show();
		}

		private void _Logout_Click(object sender, EventArgs e)
		{
			FrmLogin lg = new FrmLogin();
			this.Hide();
			lg.Show();
		}
	}
}
