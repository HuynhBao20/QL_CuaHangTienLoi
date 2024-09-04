using APP.Controllers;
using ConnectionDB;
using ConnectionDB.Logic;
using ConnectionDB.Models;
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

namespace APP.Views.manhinhphu
{
	public partial class frmNhapHang : Form
	{
		UI ui = new UI();
		process p = new process();
		NhapHang n;
		Connection db;
		Datatable dt;
		public static string getBillID = "SELECT TOP 1 MAPN FROM PHIEUNHAP ORDER BY MAPN DESC";
		public string UserName { get; set; }
		public string PassWord { get; set; }
		public string MAPN { get; set; }
		public string Active { get; set; }

		public frmNhapHang(string User, string Pass)
		{
			InitializeComponent();
			this.UserName = User;
			this.PassWord = Pass;
			db = new Connection(UserName, PassWord);
			n = new NhapHang(UserName, PassWord);
			dt = new Datatable(UserName, PassWord);
			load();
		}
		public frmNhapHang()
		{
			InitializeComponent();
			db = new Connection();
		}
		public void load()
		{
			n.load_SanPham_PhieuNhap(flp, txtMaSP, txtTenSP, txMasp, txtDonGia, cbo_MaLoai);
			n.load_PhieuNhap(flp_SP, flp_CTPN, "Chưa duyệt", DateTime.Now.Date.ToString("yyyy-MM-dd"), "AND");
			ui.loadCombobox(cbo_MaLoai, "SELECT * FROM LOAISP", "TENLOAI", "TENLOAI");
			string[] cboText = { "6 tháng", "1 năm", "2 năm", "Vô hạn" };
			foreach(var item in cboText)
			{
				cbo.Items.Add(item);
			}
			this.Active = "Chưa duyệt";
			dtime.Value.ToString("dd/MM/yyyy");
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
				n.load_PhieuNhap(flp_SP, flp_CTPN, "Chưa duyệt", DateTime.Now.Date.ToString("yyyy-MM-dd"), "AND");
				n.load_CTPhieuNhap(flpDs, MAPN);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

		}
		private void rdb_Ch_CheckedChanged(object sender, EventArgs e)
		{
			n.load_PhieuNhap(flp_SP, flp_CTPN, "Chưa duyệt", DateTime.Now.Date.ToString("yyyy-MM-dd"), "AND");
			Active = "Chưa duyệt";
		}
		private void rdb_D_CheckedChanged(object sender, EventArgs e)
		{
			n.load_PhieuNhap(flp_SP, flp_CTPN, "Đã duyệt", DateTime.Now.Date.ToString("yyyy-MM-dd"), "AND");
			Active = "Đã duyệt";

		}
		private void ptbProduct_Click(object sender, EventArgs e)
		{
			
		}
		private void btnThem_Click(object sender, EventArgs e)
		{
			try
			{
				int MaLoai = int.Parse(db.ExcuteReader($"SELECT * FROM LOAISP WHERE TENLOAI = N'{cbo_MaLoai.Text}'", "MALOAI"));
				string Sql = $"INSERT INTO SANPHAM VALUES ('{txtMaSP.Text.Trim()}', N'" +
					$"{txtTenSP.Text.Trim()}', " +
					$"{MaLoai}," +
					$"{int.Parse(txtDonGia.Text.Trim())})";
				db.ExcuteQuery(Sql);
				MessageBox.Show("Thêm thành công");
				n.load_SanPham_PhieuNhap(flp, txtMaSP, txtTenSP, txMasp, txtDonGia, cbo_MaLoai);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);

			}
		}
		private void btnSua_Click(object sender, EventArgs e)
		{
			try
			{
				int MaLoai = int.Parse(db.ExcuteReader($"SELECT * FROM LOAISP WHERE TENLOAI = N'{cbo_MaLoai.Text}'", "MALOAI"));
				string Sql = $"UPDATE SANPHAM SET MASP = '{txMasp.Text}', TENSP = N'{txtTenSP}', MALOAI = {MaLoai}, DONGIA = {int.Parse(txtDonGia.Text)} WHERE MASP = '{txtMaSP.Text}'";
				db.ExcuteQuery(Sql);
				MessageBox.Show("Sửa thành công");
				n.load_SanPham_PhieuNhap(flp, txtMaSP, txtTenSP, txMasp, txtDonGia, cbo_MaLoai);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		private void btnXoa_Click(object sender, EventArgs e)
		{
			try
			{
				string Sql = $"DELETE FROM SANPHAM WHERE MASP = '{txtMaSP.Text}'";
				db.ExcuteQuery(Sql);
				MessageBox.Show("Xóa thành công");
				n.load_SanPham_PhieuNhap(flp, txtMaSP, txtTenSP, txMasp, txtDonGia, cbo_MaLoai);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

		}
		private void button2_Click(object sender, EventArgs e)
		{
			OpenFileDialog open = new OpenFileDialog();
			open.Filter = "Excel Files|*.xls;*.xlsx";
			if (open.ShowDialog() == DialogResult.OK)
			{
				string excelFilePath = open.FileName; // Đường dẫn tệp Excel đã chọn
				ImportExcel import = new ImportExcel();
				foreach (DataRow item in import.load(excelFilePath).Rows)
				{
					string Sql = $"INSERT INTO SANPHAM VALUES (" +
						$"{item["MASP"].ToString()}, N'" +
						$"{item["TENSP"].ToString()}'," +
						$"{int.Parse(item["MALOAI"].ToString())}," +
						$"{int.Parse(item["DONGIA"].ToString())})";
					db.ExcuteQuery(Sql);
				}
				MessageBox.Show("Thành công");
			}

		}
		private void btnTim_Click(object sender, EventArgs e)
		{

		}
		private void btnKho_Click(object sender, EventArgs e)
		{
			frmQuanLyKho k = new frmQuanLyKho(UserName, PassWord);
			k.Show();
		}
		private void btnLamSach_Click(object sender, EventArgs e)
		{
			try
			{
				db.ExcuteQuery("EXEC sp_LamSachPhieu");
				MessageBox.Show("Làm sạch thành công");
			}catch(SqlException se)
			{
				MessageBox.Show(se.Message);
			}
		}
		private void dtime_ValueChanged(object sender, EventArgs e)
		{
			n.load_PhieuNhap(flp_SP, flp_CTPN, Active, DateTime.Parse(dtime.Text).ToString("yyyy-MM-dd"), "AND");
		}
	}
}
