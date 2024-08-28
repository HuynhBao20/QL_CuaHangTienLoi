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
		DataTable da = new DataTable();
		DataTable sl = new DataTable();
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
		}
		public frmNhapHang()
		{
			InitializeComponent();
			db = new Connection();
		}

		private void btnTaoPhieu_Click(object sender, EventArgs e)
		{
			string getMAPN = db.ExcuteReader(frmNhapHang.getBillID, "MAPN");
			string PhieuNhapNew = db.getMAHD(getMAPN, "N0");
			string InsertSql = $"INSERT INTO PHIEUNHAP(MAPN, MANV) VALUES ('{PhieuNhapNew}', '{UserName}')";
			db.ExcuteQuery(InsertSql);
			lb_MAPN.Text = PhieuNhapNew;
			ui.load_SanPham_PhieuNhap(flp, PhieuNhapNew);
			da = db.loadDB($"SELECT * FROM CTPHIEUNHAP WHERE MAPN = '{PhieuNhapNew}'");
			dgvLoad.DataSource = da;
		}

		private void dataGridView1_ParentChanged(object sender, EventArgs e)
		{
			
		}

		private void btnAddSP_Click(object sender, EventArgs e)
		{
			groupBox3.Enabled = true;
		}
	}
}
