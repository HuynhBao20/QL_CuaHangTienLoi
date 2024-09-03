using APP.Controllers;
using ConnectionDB;
using ConnectionDB.Models;
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
		Datatable dt;
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
			n.load_PhieuNhap(flp_SP, flp_CTPN, "Chưa duyệt");
			ui.loadCombobox(cbo_MaLoai, "SELECT * FROM LOAISP", "TENLOAI", "TENLOAI");
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
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

		}
		private void rdb_Ch_CheckedChanged(object sender, EventArgs e)
		{
			n.load_PhieuNhap(flp_SP, flp_CTPN, "Chưa duyệt");
		}
		private void rdb_D_CheckedChanged(object sender, EventArgs e)
		{
			n.load_PhieuNhap(flp_SP, flp_CTPN, "Đã duyệt");
		}

		private void ptbProduct_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Hello");
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

		}
	}
}
