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
using APP.Views;
using ConnectionDB.Models;
namespace APP
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			Dashboard hh = new Dashboard();
			hh.Dock = DockStyle.Fill;
			hh.TopLevel = false;
			hh.FormBorderStyle = FormBorderStyle.None;
			pnl_Load_Main.Controls.Add(hh);
			hh.Show();
		}

		private void tv_DanhMuc_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
		{
			
			switch (e.Node.Text)
			{
				case "Quản lý bán hàng":
					pnl_Load_Main.Controls.Clear();
					QuanLyHangHoa hh = new QuanLyHangHoa();
					hh.Dock = DockStyle.Fill;
					hh.TopLevel = false;
					pnl_Load_Main.Controls.Add(hh);
					hh.Show();
					break;
				case "Quản lý kho":
					pnl_Load_Main.Controls.Clear();
					QuanLySanPham sp = new QuanLySanPham();
					sp.Dock = DockStyle.Fill;
					sp.TopLevel = false;
					pnl_Load_Main.Controls.Add(sp);
					sp.Show();
					break;
				case "Hóa đơn trong ngày":
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
			}	
		}
	}
}
