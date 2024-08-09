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
	public partial class Form1 : Form
	{
		public readonly string MAHD;
		public Form1(string MAHD)
		{
			InitializeComponent();
			this.MAHD = MAHD;
			LogicMoMo m = new LogicMoMo();
			m.ThanhToan(MAHD, pictureBox1);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			
		}
	}
}
