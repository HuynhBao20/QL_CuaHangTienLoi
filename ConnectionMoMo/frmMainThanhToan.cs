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
		public readonly int TienKD;
		public frmMainThanhToan(string MAHD, int TienKD)
		{
			InitializeComponent();
			this.MAHD = MAHD;
			this.TienKD = TienKD;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			QRThanhToanMoMo form = new QRThanhToanMoMo(MAHD, TienKD);
			form.Show();
		}
	}
}
