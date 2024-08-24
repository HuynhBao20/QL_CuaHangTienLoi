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
	public partial class frmResetPass : Form
	{
		Connection db = new Connection();
		public string MANV { get; set; }
		public frmResetPass(string MANV)
		{
			InitializeComponent();
			this.MANV = MANV;
		}

		private void btnResetPass_Click(object sender, EventArgs e)
		{
			string SqlReset = $"ALTER LOGIN NV001 WITH PASSWORD = '{txtNewPass.Text}' OLD_PASSWORD = '{txtOldPass.Text}'";
			if(txtConfirmPass.Text == txtNewPass.Text)
			{
				db.ExcuteQuery(SqlReset);
				MessageBox.Show("Đổi thành công");
			} else
			{
				MessageBox.Show("Mật khẩu không trùng khớp");
			}
		}
	}
}
