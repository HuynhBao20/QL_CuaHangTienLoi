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
	public partial class frmQuanLyHoaDon : Form
	{
		UI ui = new UI(new Label());
		public frmQuanLyHoaDon()
		{
			InitializeComponent();
			ui.load_HoaDon_ChuaXuat(flp_LoadHoaDon, "SELECT * FROM HOADON WHERE CAST(NGAYLAP AS DATE) = CAST(GETDATE() AS DATE)", new Label(), new Label(), new FlowLayoutPanel(), new TextBox());
		}

		private void rd_HomNay_CheckedChanged(object sender, EventArgs e)
		{
			dt_NgayChon.Enabled = false;
			ui.load_HoaDon_ChuaXuat(flp_LoadHoaDon, "SELECT * FROM HOADON WHERE CAST(NGAYLAP AS DATE) = CAST(GETDATE() AS DATE)", new Label(), new Label(), new FlowLayoutPanel(), new TextBox());
		}

		private void rd_ChonNgay_CheckedChanged(object sender, EventArgs e)
		{
			dt_NgayChon.Enabled = true;
		}

		private void dt_NgayChon_ValueChanged(object sender, EventArgs e)
		{
			ui.load_HoaDon_ChuaXuat(flp_LoadHoaDon,
						$"SELECT * FROM HOADON WHERE FORMAT(NGAYLAP, 'dd/MM/yyyy') = CAST('{dt_NgayChon.Value.ToString("dd/MM/yyyy")}' AS DATE)",
						new Label(), new Label(), new FlowLayoutPanel(), new TextBox());

		}
	}
}
