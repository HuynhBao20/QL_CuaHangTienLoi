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

namespace APP.Views
{
	
	public partial class QuanLySanPham : Form
	{
		UI ui = new UI();
		Connection db = new Connection();
		CustomTool cm = new CustomTool();
		public QuanLySanPham()
		{
			InitializeComponent();
			load();
		}
		public void load()
		{
			ui.load_Product_Detail(tabControl1);
			ui.loadCombobox(cboMaLoai, "SELECT * FROM LOAISP","TENLOAI", "TENLOAI");
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
	}
}
