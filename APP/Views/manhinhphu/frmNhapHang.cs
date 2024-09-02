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

namespace APP.Views.manhinhphu
{
	public partial class frmNhapHang : Form
	{
		UI ui = new UI();
		process p = new process();
		NhapHang n;
		Connection db;
		public static string getBillID = "SELECT TOP 1 MAPN FROM PHIEUNHAP ORDER BY MAPN DESC";
		public string UserName { get; set; }
		public string PassWord { get; set; }
		public string MAPN { get; set; }

		public frmNhapHang(string User, string Pass)
		{
			InitializeComponent();
			this.UserName = User;
			this.PassWord = Pass;
			db = new Connection(UserName, PassWord);
			n = new NhapHang(UserName, PassWord);
			load();
		}
		public frmNhapHang()
		{
			InitializeComponent();
			db = new Connection();
		}
		public void load()
		{
			n.load_SanPham_PhieuNhap(flp, txtMaSP);
			n.load_PhieuNhap(flp_SP, flp_CTPN);
		}
		private void btnTaoPhieu_Click(object sender, EventArgs e)
		{
			flpDs.Controls.Clear();
			string getMAPN = db.ExcuteReader(frmNhapHang.getBillID, "MAPN");
			string PhieuNhapNew = db.getMAHD(getMAPN, "N0");
			string InsertSql = $"INSERT INTO PHIEUNHAP(MAPN, MANV) VALUES ('{PhieuNhapNew}', '{UserName}')";
			db.ExcuteQuery(InsertSql);
			lb_MAPN.Text = PhieuNhapNew;
			this.MAPN = PhieuNhapNew;
			n.load_PhieuNhapCT(flpDs, PhieuNhapNew);
			//da = db.loadDB($"SELECT * FROM CTPHIEUNHAP WHERE MAPN = '{PhieuNhapNew}'");
			//dgvLoad.DataSource = da;
		}

		private void dataGridView1_ParentChanged(object sender, EventArgs e)
		{
			
		}

		private void btnAddSP_Click(object sender, EventArgs e)
		{
			groupBox3.Enabled = true;
		}

		private void btnNhapHang_Click(object sender, EventArgs e)
		{
			try
			{
				string Sql = $"SET DATEFORMAT DMY INSERT INTO CTPHIEUNHAP VALUES ('{MAPN}', '" +
					$"{txtMaSP.Text}', '" +
					$"{txtSL.Text}', '" +
					$"{txtGN.Text}'," +
					$"'{txtNgaySX.Text}', '" +
					$"{txtNgayHH.Text}', N'" +
					$"{txtDVT.Text}')";
				db.ExcuteQuery(Sql);
				MessageBox.Show($"Thêm thành công Sản phẩm: {txtMaSP.Text.Trim()} vào phiếu {MAPN}");
				n.load_PhieuNhapCT(flpDs, this.MAPN);

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

		}
	}
}
