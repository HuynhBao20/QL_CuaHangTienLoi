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
	public partial class frmChiTietHoaDon : Form
	{
		UI ui = new UI(new Label());
		public frmChiTietHoaDon(string MAHD)
		{
			InitializeComponent();
			ui.loadCT_HoaDon(flowLayoutPanel1, MAHD);
		}
	}
}
