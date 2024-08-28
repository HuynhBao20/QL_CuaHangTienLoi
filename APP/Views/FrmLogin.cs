using APP.Controllers;
using APP.Views.manhinhphu;
using ConnectionDB;
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

namespace APP.Views
{
	public partial class frmLogin : Form
	{
		process p = new process();
		public frmLogin()
		{
			InitializeComponent();
			Connection conn = new Connection();
			Debug.WriteLine(p.create_Pass("NV002"));
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			
			try
			{	
				Connection conn = new Connection(txtUserName.Text, txtPass.Text);
					string dialog = conn.is_Connection() ? "Đăng nhập thành công" : "Đăng nhập thất bại";
					if(dialog == "Đăng nhập thành công")
					{
							this.Hide();
							MainForm main = new MainForm(txtUserName.Text, txtPass.Text);
							main.Show();
					} else
					{
						MessageBox.Show(dialog);
					}
			} catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)Keys.Enter)
			{
				btnLogin_Click(sender, e);			
				txtPass.Clear();

			}
		}
	}
}
