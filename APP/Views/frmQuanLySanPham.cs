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
using ConnectionDB.Logic;
using ConnectionDB;
using APP.Views.manhinhphu;

namespace APP.Views
{
	
	public partial class frmQuanLySanPham : Form
	{
		UI ui;
		Connection db;
		CustomTool cm = new CustomTool();
		public string UserName { get; set; }
		public string PassWord { get; set; }


		public frmQuanLySanPham(string User, string Pass)
		{
			InitializeComponent();
			this.UserName = User;
			this.PassWord = Pass;
			ui = new UI(UserName, PassWord);
			db = new Connection(UserName, PassWord);
			load();
		}
		public void load()
		{
			ui.load_Product_Detail(tabControl1);
			ui.loadCombobox(cboMaLoai, "SELECT * FROM LOAISP","TENLOAI", "TENLOAI");
			ui.load_PhieuNhap(flpPhieuNhap);
		}
		private void btn_ImportExcel_Click(object sender, EventArgs e)
		{
			OpenFileDialog open = new OpenFileDialog();
			open.Filter = "Excel Files|*.xls;*.xlsx";
			if (open.ShowDialog() == DialogResult.OK)
			{
				string excelFilePath = open.FileName; // Đường dẫn tệp Excel đã chọn
				ImportExcel import = new ImportExcel();
				//dataGridView1.DataSource = import.load(excelFilePath);
				foreach(DataRow item in import.load(excelFilePath).Rows)
				{
					string Sql = $"INSERT INTO SANPHAM VALUES ({int.Parse(item["MASP"].ToString())}, N'" +
						$"{item["TENSP"].ToString()}'," +
						$"{int.Parse(item["MALOAI"].ToString())}, '{item["NGAYSX"].ToString()}', '" +
						$"{item["NGAYHH"].ToString()}', " +
						$"{int.Parse(item["DONGIA"].ToString())})";
					db.ExcuteQuery(Sql);
				}
				MessageBox.Show("Thành công");
			}
		}
		private void ptbProduct_Click(object sender, EventArgs e)
		{
			OpenFileDialog open = new OpenFileDialog();
			open.Filter = "Excel Files|*.xls;*.xlsx";
			if (open.ShowDialog() == DialogResult.OK)
			{
				string excelFilePath = open.FileName; // Đường dẫn tệp Excel đã chọn
				
				MessageBox.Show("Thành công");
			}

		}

		private void btnNH_Click(object sender, EventArgs e)
		{
			frmNhapHang nh = new frmNhapHang(UserName, PassWord);
			nh.StartPosition = FormStartPosition.CenterScreen;
			nh.Show();
		}
	}
}
