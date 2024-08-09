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
		public QuanLySanPham()
		{
			InitializeComponent();
			load();
		}
		public void load()
		{
			//ui.loadPhieuKho(flp_PhieuNhap, @"../../Resources/quan-ly-ton-kho-la-gi.png", "select * from PHIEUNHAP", "NGAYNHAP");
			//ui.load_Product_Vertical(flp_PhieuNhap);
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
					string Sql = $"INSERT INTO SANPHAM VALUES ({int.Parse(item["MASP"].ToString())}, N'{item["TENSP"].ToString()}',{int.Parse(item["MALOAI"].ToString())}, '{item["NGAYSX"].ToString()}', '{item["NGAYHH"].ToString()}', {int.Parse(item["DONGIA"].ToString())})";
					db.ExcuteQuery(Sql);
				}
				MessageBox.Show("Thành công");
			}
		}
	}
}
