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

namespace APP.Views.manhinhphu
{
	public partial class frmNhapCTPhieu : Form
	{
		Connection db;
		public string UserName { get; set; }
		public string PassWord { get; set; }
		public string MAPN { get; set; }
		public string MASP { get; set; }

		public frmNhapCTPhieu(string User, string Pass, string MASP, string MAPN)
		{
			InitializeComponent();
			db = new Connection("NV001", "123");
			this.UserName = User;
			this.PassWord = Pass;
			this.MAPN = MAPN;
			this.MASP = MASP;
			lb_MAPN.Text = this.MAPN;
			txtMASP.Text = MASP;
			
		}

		private void btnNhapHang_Click(object sender, EventArgs e)
		{
			string Sql = $"SET DATEFORMAT DMY INSERT INTO CTPHIEUNHAP VALUES ('{MAPN}', '" +
				$"{MASP}', '" +
				$"{txtSL.Text}', '" +
				$"{txtGN.Text}'," +
				$"'{txtNgaySX.Text}', '" +
				$"{txtNgayHH.Text}', N'" +
				$"{txtDVT.Text}')";
			db.ExcuteQuery(Sql);
		}
	}
}
