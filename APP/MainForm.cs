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
        }

		private void tv_DanhMuc_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
		{
			switch(e.Node.Text)
			{
				case "Quản lý bán hàng":

					QuanLyHangHoa hh = new QuanLyHangHoa();
					hh.Dock = DockStyle.Fill;
					hh.TopLevel = false;
					pnl_Load_Main.Controls.Add(hh);
					hh.Show();
				break;
			}	
		}
	}
}
