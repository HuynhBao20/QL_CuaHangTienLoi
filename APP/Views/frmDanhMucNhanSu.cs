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
	public partial class frmDanhMucNhanSu : Form
	{
		Connection db = new Connection();
		process p = new process();
		public string UserName { get; set; }
		public string PassWord { get; set; }
		public static string getMaNV = "SELECT TOP 1 MANV FROM NHANVIEN ORDER BY MANV DESC";
		public frmDanhMucNhanSu(string User, string Pass)
		{
			InitializeComponent();
			this.UserName = User;
			this.PassWord = Pass;
			db = new Connection();
			dgv_ListEmployee.DataSource = db.loadDB("SELECT * FROM NHANVIEN");
		}

		private void dgv_ListEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if(dgv_ListEmployee.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
			{
				txtMaNV.Text = dgv_ListEmployee.Rows[e.RowIndex].Cells[0].Value.ToString();
				txtHoTen.Text = dgv_ListEmployee.Rows[e.RowIndex].Cells[1].Value.ToString();
				txtNS.Text = DateTime.Parse(dgv_ListEmployee.Rows[e.RowIndex].Cells[2].Value.ToString()).ToString("dd/MM/yyyy") ?? DateTime.Now.Date.ToString("dd/MM/yyyy");
				txtNVL.Text = DateTime.Parse(dgv_ListEmployee.Rows[e.RowIndex].Cells[3].Value.ToString()).ToString("dd/MM/yyyy") ?? DateTime.Now.Date.ToString("dd/MM/yyyy");
				txtSDT.Text = dgv_ListEmployee.Rows[e.RowIndex].Cells[4].Value.ToString();
				txtCCCD.Text = dgv_ListEmployee.Rows[e.RowIndex].Cells[5].Value.ToString();
				txtDiaChi.Text = dgv_ListEmployee.Rows[e.RowIndex].Cells[6].Value.ToString();
			}
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			string MANV = db.getMAHD(db.ExcuteReader(frmDanhMucNhanSu.getMaNV, "MANV"), "NV");
			string SqlInsert = $"SET DATEFORMAT DMY INSERT INTO NHANVIEN VALUES ('{MANV}', N'" +
				$"{txtHoTen.Text}', '" +
				$"{txtNS.Text}', '" +
				$"{txtNVL.Text}', '" +
				$"{txtSDT.Text}', '" +
				$"{txtCCCD.Text}', N'" +
				$"{txtDiaChi.Text}')";
			db.ExcuteQuery(SqlInsert);
			string SqlCreateAccount = $"CREATE LOGIN {MANV} WITH PASSWORD = '{p.create_Pass(MANV)}' CREATE USER {MANV} FOR LOGIN {MANV} ALTER ROLE NHANVIEN ADD MEMBER {MANV}";
			
			db.ExcuteQuery(SqlCreateAccount);
			dgv_ListEmployee.DataSource = db.loadDB("SELECT * FROM NHANVIEN");
		}
		private void btnXoa_Click(object sender, EventArgs e)
		{
			if(!string.IsNullOrEmpty(txtMaNV.Text))
			{
				string SqlDel = $"DELETE FROM NHANVIEN WHERE MANV = '{txtMaNV.Text.Trim()}' {Environment.NewLine} EXEC drop_User '{txtMaNV.Text.Trim()}'";
				db.ExcuteQuery(SqlDel);
				MessageBox.Show("Xóa thành công");
				dgv_ListEmployee.DataSource = db.loadDB("SELECT * FROM NHANVIEN");
			}
			else
			{
				MessageBox.Show("Không xóa được");
			}
		}
	}
}
