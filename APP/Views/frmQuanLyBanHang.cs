using APP.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using APP.Views.LoadControl;
namespace APP.Views
{
	public partial class frmQuanLyBanHang : Form
	{
		SanPham sp = new SanPham("NV001", "123");
		public frmQuanLyBanHang()
		{
			InitializeComponent();
		}

		private void frmQuanLyBanHang_Load(object sender, EventArgs e)
		{
			sp.load_Product(flp_SanPham, pnl);
			load_Infor_Product l = new load_Infor_Product();
			l.Dock = DockStyle.Fill;
			pnl.Controls.Add(l);
			l.Show();
		}
	}
}
