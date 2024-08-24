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

namespace APP.Views
{
	public partial class frmQuanLyDoanhThu : Form
	{
		Analyst a = new Analyst();

		public frmQuanLyDoanhThu()
		{
			InitializeComponent();
			a.Analyst_Month(chart1);
			a.Analyst_Product_Buy(chart2);

		}
	}
}
