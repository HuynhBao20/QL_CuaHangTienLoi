using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectionMoMo
{
	public partial class frmMainThanhToan : Form
	{
		public readonly string MAHD;
		public frmMainThanhToan(string MAHD)
		{
			InitializeComponent();
			this.MAHD = MAHD;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Form1 form = new Form1(MAHD);
			form.Show();
		}
	}
}
