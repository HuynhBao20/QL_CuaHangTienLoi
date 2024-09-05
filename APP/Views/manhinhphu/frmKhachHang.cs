using APP.Controllers;
using ConnectionDB;
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

namespace APP.Views
{
	public partial class frmKhachHang : Form
	{
		Connection db = new Connection();
		UI ui = new UI();
		public string active { get; set; }
		public frmKhachHang(string UserName, string PassWord)
		{
			InitializeComponent();
			db = new Connection(UserName, PassWord);
			ui = new UI(UserName, PassWord);
			dgvKhachHang.DataSource = db.loadDB("SELECT * FROM KHACHHANG");
		}
		private void btnThem_Click(object sender, EventArgs e)
		{
			btnSua.Enabled = false;
			btnXoa.Enabled = false;
			txtMaKH.Text = db.getMAHD(db.ExcuteReader(Connection.Query_GetMAKH, "MAKH"), "KH");
			active = btnThem.Text;
		}
		private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			txtMaKH.Text = dgvKhachHang.Rows[e.RowIndex].Cells[0].Value.ToString();
			txtHoTen.Text = dgvKhachHang.Rows[e.RowIndex].Cells[1].Value.ToString();
			txtDiaChi.Text = dgvKhachHang.Rows[e.RowIndex].Cells[3].Value.ToString();
			txtSDT.Text = dgvKhachHang.Rows[e.RowIndex].Cells[2].Value.ToString();
			cboLoaiKH.Text = dgvKhachHang.Rows[e.RowIndex].Cells[4].Value.ToString();
		}
		private void btnClear_Click(object sender, EventArgs e)
		{
			txtMaKH.Clear();
			txtHoTen.Clear();
			txtDiaChi.Clear();
			txtSDT.Clear();
		}
		private void btnLuu_Click(object sender, EventArgs e)
		{
			try
			{
				string Insert = $"INSERT INTO KHACHHANG VALUES ('{db.getMAHD(db.ExcuteReader(Connection.Query_GetMAKH, "MAKH"), "KH")}', N'" +
					$"{txtHoTen.Text}', '" +
					$"{txtSDT.Text}', N'" +
					$"{txtDiaChi.Text}', N'" +
					$"{cboLoaiKH.Text}')";
				string Update = $"UPDATE KHACHHANG SET HOTEN = N'{txtHoTen.Text}', SDT = '{txtSDT.Text}', DIACHI = N'{txtDiaChi.Text}', LOAIKH = N'{cboLoaiKH.Text}' WHERE MAKH = '{txtMaKH.Text}'";
				string Del = $"DELETE FROM KHACHHANG WHERE MAKH = '{txtMaKH.Text}'";
				string SqlInsert = this.active == "Thêm" ? Insert : this.active == "Sửa" ? Update : Del;
				db.ExcuteQuery(SqlInsert);
				MessageBox.Show($"{active} thành công");
				btnThem.Enabled = true;
				btnXoa.Enabled = true;
				btnSua.Enabled = true;
				dgvKhachHang.DataSource = db.loadDB("SELECT * FROM KHACHHANG");
			}
			catch (SqlException ex)
			{
				MessageBox.Show(ex.Message);
			}

		}
		private void btnSua_Click(object sender, EventArgs e)
		{
			btnThem.Enabled = false;
			btnXoa.Enabled = false;
			active = btnSua.Text;

		}
		private void btnXoa_Click(object sender, EventArgs e)
		{
			btnThem.Enabled = false;
			btnSua.Enabled = false;
			active = btnXoa.Text;
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
