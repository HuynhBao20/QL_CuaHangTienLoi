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
			Load();
		}
		private void Load()
		{
			ui.load_SanPham_PhieuNhap(flp, lb_MAPN.Text);
		}

		private void btnTaoPhieu_Click(object sender, EventArgs e)
		{
			string getMAPN = db.ExcuteReader(frmNhapHang.getBillID, "MAPN");
			string PhieuNhapNew = db.getMAHD(getMAPN, "N0");
			lb_MAPN.Text = PhieuNhapNew;
			this.MAPN = MAPN;
			string InsertSql = $"INSERT INTO PHIEUNHAP(MAPN, MANV) VALUES ('{PhieuNhapNew}', '{UserName}')";
			db.ExcuteQuery(InsertSql);
			dataGridView1.DataSource = db.loadDB($"SELECT * FROM CTPHIEUNHAP WHERE MAPN = '{PhieuNhapNew}'");
		}
	}
}
