using ConnectionDB;
using Reporting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectionMoMo
{
	public partial class QRThanhToanMoMo : Form
	{
		public readonly string MAHD;
		public readonly int TienKD;
		Connection db = new Connection();
		public QRThanhToanMoMo(string MAHD, int TienKD)
		{
			InitializeComponent();
			this.MAHD = MAHD;
			this.TienKD = TienKD;
			LogicMoMo m = new LogicMoMo();
			m.ThanhToan(MAHD, pictureBox1);
		}


		private void btnXacNhan_Click(object sender, EventArgs e)
		{
			try
			{
				string insertTienKD = $"UPDATE HOADON SET TIENKD = {TienKD}, TRANGTHAI = N'Đã xuất hóa đơn' WHERE MAHD = '{MAHD}'";
				db.ExcuteQuery(insertTienKD);
				MessageBox.Show("Xác nhận thành công");
			} catch (SqlException ex)
			{
				MessageBox.Show($"Xác nhận thất bại vì: \n {ex.Message}");
			}

		}

		private void btnXuatHoaDon_Click(object sender, EventArgs e)
		{
			SharedReporting S = new SharedReporting(MAHD);
			S.Show();
		}
	}
}
