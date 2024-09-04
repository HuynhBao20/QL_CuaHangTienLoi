using ConnectionDB;
using ConnectionDB.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace APP.Controllers
{
	public class NhapHang
	{
		Connection db;
		Datatable dt;
		public string User { get; set; }
		public string Pass { get; set; }
		public NhapHang(string User, string Pass)
		{
			this.User = User;
			this.Pass = Pass;
			db = new Connection(User, Pass);
			dt = new Datatable(User, Pass);
		}		
		public string fullPath(string Fpath) => Path.GetFullPath(Fpath); //Hàm này lấy ra đường dẫn của file
		public string fpathImage(string ImageName) => File.Exists(fullPath(@"../../Resources/" + ImageName.Trim() + ".jpg")) ? fullPath(@"../../Resources/" + ImageName.Trim() + ".jpg") : fullPath(@"../../Resources/Sp.jpg");
		public void tilte(FlowLayoutPanel flp)
		{
			TableLayoutPanel tbl = new TableLayoutPanel()
			{
				Dock = DockStyle.Fill,
				ColumnCount = 5,
				RowCount = 1,
			};
			Panel pnl = new Panel()
			{
				Width = flp.Width - 40,
				Height = 60,
				BackColor = Color.Chocolate,
				ForeColor = Color.White
			};
			string[] list = { "Mã phiếu nhập", "Ngày lập", "Trạng thái", "Xem", "Duyệt" };
			int i = 0;
			foreach(var item in list)
			{
				Label TrangThai = new Label()
				{
					Dock = DockStyle.Fill,
					Text = item,
					TextAlign = ContentAlignment.MiddleCenter
				};
				tbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20));
				tbl.Controls.Add(TrangThai, i, 0);
				i++;
			}
			pnl.Controls.Add(tbl);
			flp.Controls.Add(pnl);
		}
		public void load_PhieuNhap(FlowLayoutPanel flp, FlowLayoutPanel flp_Ct, string Active, string Date, string condition)
		{
			flp.Controls.Clear();
			tilte(flp);
			flp.AutoScroll = true;
			foreach(DataRow item in dt.da_PhieuNhap(Active, Date, condition).Rows)
			{
				string ID = item["MAPN"].ToString();				
				Color is_PN = db.ExcuteReader($"SELECT TRANGTHAI FROM PHIEUNHAP WHERE MAPN = '{ID}'", "TRANGTHAI") == "Chưa duyệt" ? Color.Red : Color.Green;
				TableLayoutPanel tbl = new TableLayoutPanel()
				{
					Dock = DockStyle.Fill,
					ColumnCount = 5,
					RowCount = 1,
				};
				Label lb = new Label()
				{
					Dock = DockStyle.Fill,
					Text = DateTime.Parse(item["NGAYNHAP"].ToString()).ToString("dd/MM/yyyy HH:mm"),
					TextAlign = ContentAlignment.MiddleCenter
				};
				Label MAPN = new Label()
				{
					Dock = DockStyle.Fill,
					Text = item["MAPN"].ToString(),
					TextAlign = ContentAlignment.MiddleCenter
				};
				Panel pnl = new Panel()
				{
					Width = flp.Width - 30,
					Height = 80,
					BackColor = Color.White
				};
				Label TrangThai = new Label()
				{
					Dock = DockStyle.Fill,
					Text = item["TRANGTHAI"].ToString(),
					ForeColor = is_PN,
					TextAlign = ContentAlignment.MiddleCenter
				};
				Button btn = new Button()
				{
					Dock = DockStyle.Fill,
					Text = "Xem",
					BackColor = Color.Green,
					ForeColor = Color.White
				};
				Button btn_Duyet = new Button()
				{
					Dock = DockStyle.Fill,
					Text = "Duyệt",
					BackColor = Color.Gray,
					ForeColor = Color.White
				};
				tbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20));
				tbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20));
				tbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20));
				tbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20));
				tbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20));
				tbl.Controls.Add(MAPN, 0, 0);
				tbl.Controls.Add(lb, 1, 0);
				tbl.Controls.Add(TrangThai, 2, 0);
				tbl.Controls.Add(btn, 3, 0);
				tbl.Controls.Add(btn_Duyet, 4, 0);
				pnl.Controls.Add(tbl);
				flp.Controls.Add(pnl);
				btn.Click += (sender, e) => Event_Show_PhieuNhap(sender, e, flp_Ct, ID);
				btn_Duyet.Click += (sender, e) => {
					try
					{
						int is_Quanlity = string.IsNullOrEmpty(db.ExcuteReader($"SELECT MAPN, COUNT(*) AS 'SL' FROM CTPHIEUNHAP WHERE MAPN = '{ID}' GROUP BY MAPN", "SL")) ? 0 :
						int.Parse(db.ExcuteReader($"SELECT MAPN, COUNT(*) AS 'SL' FROM CTPHIEUNHAP WHERE MAPN = '{ID}' GROUP BY MAPN", "SL"));
						if (is_Quanlity < 1)
						{
							MessageBox.Show("Phiếu nhập rỗng");
						}
						else
						{
							string Sql = $"UPDATE PHIEUNHAP SET TRANGTHAI = N'Đã duyệt' WHERE MAPN = '{ID}'";
							db.ExcuteQuery(Sql);
							MessageBox.Show("Duyệt thành công");
							load_PhieuNhap(flp, flp_Ct, Active, Date, condition);
						}
					}
					catch (SqlException se)
					{
						MessageBox.Show(se.Message);
					}
				};
			}
		}
		public void load_CTPhieuNhap(FlowLayoutPanel flp, string MAPN)
		{
			flp.AutoScroll = true;
			foreach (DataRow item in dt.da_CTPhieuNhap(MAPN).Rows)
			{
				Panel pnl = new Panel()
				{
					Width = flp.Width - 40,
					Height = 80,
					BackColor = Color.White
				};
				TableLayoutPanel tbl = new TableLayoutPanel()
				{
					Dock = DockStyle.Fill,
					ColumnCount = 4,
					RowCount = 1,
				};
				PictureBox box = new PictureBox()
				{
					Dock = DockStyle.Fill,
					Image = Image.FromFile(fpathImage(item["MASP"].ToString())),
					SizeMode = PictureBoxSizeMode.StretchImage
				};
				Label lb = new Label()
				{
					Dock = DockStyle.Fill,
					Text = DateTime.Parse(item["NGAYNHAP"].ToString()).ToString("dd/MM/yyyy HH:mm"),
					TextAlign = ContentAlignment.MiddleCenter
				};
				Label lb_ProductName = new Label()
				{
					Dock = DockStyle.Fill,
					Text = item["TENSP"].ToString(),
					TextAlign = ContentAlignment.MiddleCenter
				};				
				Button btn = new Button()
				{
					Dock = DockStyle.Fill,
					Text = "Xóa",
					BackColor = Color.Red,
					ForeColor = Color.White
				};
				tbl.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
				tbl.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 180F));
				tbl.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 180F));
				tbl.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
				tbl.Controls.Add(lb, 2, 0);
				tbl.Controls.Add(btn, 3, 0);
				tbl.Controls.Add(lb_ProductName, 1, 0);
				tbl.Controls.Add(box, 0, 0);
				pnl.Controls.Add(tbl);
				flp.Controls.Add(pnl);
				btn.Click += (sender, e) =>
				{
					try
					{
						string MASP = item["MASP"].ToString();
						dt.Del_CTPhieu(MASP, MAPN);
						load_CTPhieuNhap(flp, MAPN);
					}catch(Exception ex)
					{
						MessageBox.Show(ex.Message);
					}
				};

			}
		}
		public void load_SanPham_PhieuNhap(FlowLayoutPanel flp, TextBox MASP, TextBox TENSP, TextBox _MASP, TextBox DonGia, ComboBox box)
		{
			DataTable da = dt.da_SanPham();
			flp.Controls.Clear();
			if (da.Rows.Count > 0)
			{
				foreach (DataRow item in da.Rows)
				{
					TableLayoutPanel tbl = new TableLayoutPanel()
					{
						Dock = DockStyle.Fill,
						RowCount = 2,
						ColumnCount = 2
					};
					Panel pnl = new Panel()
					{
						Width = 150,
						Height = 220,
						BackColor = Color.White
					};
					PictureBox picture = new PictureBox()
					{
						Dock = DockStyle.Fill,
						Image = Image.FromFile(fpathImage(item["MASP"].ToString())),
						SizeMode = PictureBoxSizeMode.StretchImage
					};
					Label lb_ProductName = new Label()
					{
						Dock = DockStyle.Fill,
						Text = item["TENSP"].ToString(),
						TextAlign = ContentAlignment.MiddleCenter
					};
					Button btn = new Button()
					{
						Dock = DockStyle.Fill,
						Text = "Thêm",
						BackColor = Color.Green,
						ForeColor = Color.White
					};

					tbl.Controls.Add(picture, 0, 0);
					tbl.SetColumnSpan(picture, 2);
					tbl.Controls.Add(lb_ProductName, 0, 1);
					tbl.Controls.Add(btn, 1, 1);
					tbl.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 90F));
					tbl.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
					tbl.RowStyles.Add(new ColumnStyle(SizeType.Absolute, 170F));
					tbl.RowStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
					pnl.Controls.Add(tbl);
					flp.Controls.Add(pnl);
					picture.Click += (sender, e) =>
					{
						_MASP.Text = item["MASP"].ToString();
						TENSP.Text = item["TENSP"].ToString();
						DonGia.Text = item["DONGIA"].ToString();
						box.Text = db.ExcuteReader($"SELECT * FROM LOAISP WHERE MALOAI = '{item["MALOAI"].ToString()}'", "TENLOAI");
					};
					btn.Click += (sender, e) => {
						MASP.Text = item["MASP"].ToString();
					};
				}
			}
			else
			{
				MessageBox.Show("Không có sản phẩm");
			}
		}
		public void load_PhieuNhapCT(FlowLayoutPanel flp, string MAPN)
		{
			flp.Controls.Clear();
			flp.AutoScroll = true;
			foreach (DataRow item in dt.da_CTPhieuNhap(MAPN).Rows)
			{
				TableLayoutPanel tbl = new TableLayoutPanel()
				{
					Dock = DockStyle.Fill,
					ColumnCount = 5,
					RowCount = 1,
				};
				PictureBox box = new PictureBox()
				{
					Dock = DockStyle.Fill,
					Image = Image.FromFile(fpathImage(item["MASP"].ToString())),
					SizeMode = PictureBoxSizeMode.StretchImage
				};
				Label lb_ProductID = new Label()
				{
					Dock = DockStyle.Fill,
					Text = item["MASP"].ToString(),
					TextAlign = ContentAlignment.MiddleCenter
				};
				Label lb_ProductName = new Label()
				{
					Dock = DockStyle.Fill,
					Text = item["TENSP"].ToString(),
					TextAlign = ContentAlignment.MiddleCenter
				};
				Panel pnl = new Panel()
				{
					Width = flp.Width - 30,
					Height = 80,
					BackColor = Color.White
				};
				Label sl = new Label()
				{
					Dock = DockStyle.Fill,
					Text = item["SLNHAP"].ToString(),
					TextAlign = ContentAlignment.MiddleCenter

				};
				Button btn = new Button()
				{
					Dock = DockStyle.Fill,
					Text = "Xóa",
					BackColor = Color.Red,
					ForeColor = Color.White
				};

				tbl.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
				tbl.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
				tbl.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
				tbl.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
				tbl.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
				tbl.Controls.Add(lb_ProductID, 0, 0);
				tbl.Controls.Add(box, 1, 0);
				tbl.Controls.Add(lb_ProductName, 2, 0);
				tbl.Controls.Add(sl, 3, 0);
				tbl.Controls.Add(btn, 4, 0);
				pnl.Controls.Add(tbl);
				flp.Controls.Add(pnl);
				btn.Click += (sender, e) => {
					string Sql = $"DELETE FROM CTPHIEUNHAP WHERE MAPN = '{MAPN}' AND MASP = '{item["MASP"].ToString().Trim()}'";
					db.ExcuteQuery(Sql);
					MessageBox.Show($"Xóa sản phẩm: {item["MASP"].ToString().Trim()} trong Phiếu nhập {MAPN}");
					load_PhieuNhapCT(flp, MAPN);
				};
			}
		}
		private void Event_Show_PhieuNhap(object sender, EventArgs e, FlowLayoutPanel flp, string MAPN)
		{
			flp.Controls.Clear();
			load_CTPhieuNhap(flp, MAPN);
		}
	}
}
