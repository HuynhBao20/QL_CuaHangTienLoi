using APP.Controllers;
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

namespace APP.Views
{
	public partial class frmQuanLyHoaDon : Form
	{
		UI ui;
		Connection db;
		public frmQuanLyHoaDon(string User, string Pass)
		{
			InitializeComponent();
			db = new Connection(User, Pass);
			ui = new UI(User, Pass);
			ui.load_HoaDon_ChuaXuat(flp_LoadHoaDon, "SELECT * FROM HOADON WHERE CAST(NGAYLAP AS DATE) = CAST(GETDATE() AS DATE)", new Label(), new FlowLayoutPanel(), new TextBox());
		}

		private void rd_HomNay_CheckedChanged(object sender, EventArgs e)
		{
			dt_NgayChon.Enabled = false;
			ui.load_HoaDon_ChuaXuat(flp_LoadHoaDon, "SELECT * FROM HOADON WHERE CAST(NGAYLAP AS DATE) = CAST(GETDATE() AS DATE)", new Label(), new FlowLayoutPanel(), new TextBox());
		}

		private void rd_ChonNgay_CheckedChanged(object sender, EventArgs e)
		{
			dt_NgayChon.Enabled = true;
		}

		private void dt_NgayChon_ValueChanged(object sender, EventArgs e)
		{
			ui.load_HoaDon_ChuaXuat(flp_LoadHoaDon,
						$"SELECT * FROM HOADON WHERE FORMAT(NGAYLAP, 'dd/MM/yyyy') = '{dt_NgayChon.Value.ToString("dd/MM/yyyy")}'",
						new Label(), new FlowLayoutPanel(), new TextBox());
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				db.ExcuteQuery("EXEC sp_LocHD");
				MessageBox.Show("Lọc thành công");
			}catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}
