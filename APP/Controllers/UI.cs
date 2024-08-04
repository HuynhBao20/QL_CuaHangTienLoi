using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConnectionDB;
namespace APP.Controllers
{
	//Summary:
	// Class này dùng để thực hiện UI trên giao diện người dùng
	public class UI
	{
		Connection db = new Connection();
		public string fullPath(string Fpath) => Path.GetFullPath(Fpath); //Hàm này lấy ra đường dẫn của file
		public void UI_loadSP(FlowLayoutPanel flp)
		{
			for (int i = 0; i < 5; i++)
			{
				Panel pnl = new Panel()
				{
					Width = 170,
					Height = 180,
					BackgroundImageLayout = ImageLayout.Stretch,
					BackgroundImage = Image.FromFile(fullPath(@"../../Resources/pngtree-purple-gradient-geometric-circle-background-image_50104.jpg"))
				};
				Button btn = new Button()
				{
					Name = "btn",
					TextAlign = ContentAlignment.BottomCenter,
					Width = 150,
					Height = 150,
					Dock = DockStyle.Top,
					Margin = new Padding(200),
					FlatStyle = FlatStyle.Flat,
					BackColor = Color.AliceBlue,
					BackgroundImage = Image.FromFile(fullPath(@"..\..\Resources\pngtree-graduation-bachelor-hat-illustration-png-image_6580811.png")),
					BackgroundImageLayout = ImageLayout.Stretch
				};
				btn.FlatAppearance.BorderSize = 0;
				 
				Label lb = new Label();
				lb.Text = "Sản phẩm 1";
				lb.Dock = DockStyle.Bottom;
				lb.BackColor = Color.Transparent;
				pnl.Controls.Add(btn);
				pnl.Controls.Add(lb);
				flp.Controls.Add(pnl);
			}

		}
		public void UI_LoadProduct(FlowLayoutPanel flp, FlowLayoutPanel billDetail, string ProName, int MAHD = 1)
		{
			//string Query = ProName == "" ? "" : $"WHERE TENSP = N'{ProName}'";
			DataTable da = db.loadDB("SELECT * FROM SANPHAM"); //Đưa dữ liệu vào bảng
			var dat = da.AsEnumerable()
				.Where(t => t.Field<string>("TENSP")
				.Contains(ProName));
			DataTable data = new DataTable();
			if(dat.Any())
			{
				 data = dat.CopyToDataTable();
			}
			if (data.Rows.Count > 0)
			{
				foreach (DataRow item in data.Rows)
				{
					Panel pnl = new Panel()
					{
						Width = (flp.Width - 10) / 4,
						Height = 200,
						BackgroundImage = Image.FromFile(fullPath(@"../../Resources/pngtree-purple-gradient-geometric-circle-background-image_50104.jpg")),
						BackgroundImageLayout = ImageLayout.Stretch
					};
					Button btn = new Button()
					{
						Width = pnl.Width - 10,
						Dock = DockStyle.Fill,
						BackColor = Color.Transparent,
						BackgroundImage = Image.FromFile(fullPath(@"../../Resources/" + item["MASP"] + ".jpg")),
						BackgroundImageLayout = ImageLayout.Stretch
					};
					btn.FlatAppearance.BorderSize = 0;
					Label ProductName = new Label()
					{
						Text = item["TENSP"].ToString(),
						Dock = DockStyle.Bottom,
						BackColor = Color.Transparent
					};

					btn.Click += (sender, e) => Event_Product_Click(sender, e, int.Parse(item["MASP"].ToString()), billDetail, MAHD);
					pnl.Controls.Add(btn);
					pnl.Controls.Add(ProductName);
					flp.Controls.Add(pnl);
				}
			} 
			else
			{
				MessageBox.Show("Không tìm thấy");
				
			}
		}
		public void UI_BillDetail(FlowLayoutPanel flp, int MAHD)
		{
			DataTable da = db.loadDB($"exec Select_CTHoaDon {MAHD}");
			Tilte(flp);
			foreach(DataRow item in da.Rows)
			{
				Panel pnl = new Panel()
				{
					Width = flp.Width - 20,
					Height = 70,
					BackColor = Color.White,
					Dock = DockStyle.Top
				};
				Label lb_Name = new Label()
				{
					Width = pnl.Width / 6,
					Dock = DockStyle.Left,
					Text = item["Tên sản phẩm"].ToString(),
					TextAlign = ContentAlignment.MiddleCenter
				};
				
				PictureBox pictureBox = new PictureBox()
				{
					Width = pnl.Width / 6,
					Image = Image.FromFile(fullPath(@"../../Resources/" + item["Mã sản phẩm"] + ".jpg")),
					SizeMode = PictureBoxSizeMode.StretchImage,
					Dock = DockStyle.Left
				};
				Label lb_DonGia = new Label()
				{
					Width = pnl.Width / 6,
					Dock = DockStyle.Left,
					Text = item["Đơn giá"].ToString(),
					TextAlign = ContentAlignment.MiddleCenter
				};
				Label lb_SoLuong = new Label()
				{
					Width = pnl.Width / 6,
					Dock = DockStyle.Left,
					Text = item["Số lượng"].ToString(),
					TextAlign = ContentAlignment.MiddleCenter
				};
				Label lb_ThanhTien = new Label()
				{
					Width = pnl.Width / 6,
					Dock = DockStyle.Left,
					Text = item["Thành Tiền"].ToString(),
					TextAlign = ContentAlignment.MiddleCenter
				};
				Button btn = new Button()
				{
					Width = pnl.Width / 6,
					Text = "Xóa",
					Dock = DockStyle.Right,
					FlatStyle = FlatStyle.Flat,
					BackColor = Color.Red
				};
				btn.FlatAppearance.BorderSize = 0;
				pnl.Controls.Add(btn);
				pnl.Controls.Add(lb_ThanhTien);
				pnl.Controls.Add(lb_SoLuong);
				pnl.Controls.Add(lb_DonGia);
				pnl.Controls.Add(lb_Name);
				pnl.Controls.Add(pictureBox);
				flp.Controls.Add(pnl);
				btn.Click += (Sender, e) => Event_Del_Product_BillDetail(Sender, e, int.Parse(item["Mã sản phẩm"].ToString()), flp, MAHD);
			}
		}
		public void Tilte(FlowLayoutPanel flp)
		{
			Panel pnl = new Panel()
			{
				Width = flp.Width - 20,
				Height = 70,
				BackColor = Color.White,
				Dock = DockStyle.Top
			};
			Label lb_Name = new Label()
			{
				Width = pnl.Width / 6,
				Dock = DockStyle.Left,
				Text = "Tên sản phẩm",
				TextAlign = ContentAlignment.MiddleCenter
			};
			Label lb_HinhAnh = new Label()
			{
				Width = pnl.Width / 6,
				Dock = DockStyle.Left,
				Text = "Hình ảnh",
				TextAlign = ContentAlignment.MiddleCenter
			};
			Label lb_DonGia = new Label()
			{
				Width = pnl.Width / 6,
				Dock = DockStyle.Left,
				Text = "Đơn giá",
				TextAlign = ContentAlignment.MiddleCenter
			};
			Label lb_SoLuong = new Label()
			{
				Width = pnl.Width / 6,
				Dock = DockStyle.Left,
				Text = "Số lượng",
				TextAlign = ContentAlignment.MiddleCenter
			};
			Label lb_ThanhTien = new Label()
			{
				Width = pnl.Width / 6,
				Dock = DockStyle.Left,
				Text = "Thành Tiền",
				TextAlign = ContentAlignment.MiddleCenter
			};
			
			pnl.Controls.Add(lb_ThanhTien);
			pnl.Controls.Add(lb_SoLuong);
			pnl.Controls.Add(lb_DonGia);
			pnl.Controls.Add(lb_Name);
			pnl.Controls.Add(lb_HinhAnh);
			flp.Controls.Add(pnl);
		}
		public void Event_Product_Click(object sender, EventArgs e, int MASP, FlowLayoutPanel flp, int MAHD)
		{
			try
			{
				string getBillID = "SELECT TOP 1 MAHD FROM HOADON ORDER BY MAHD DESC";
				MAHD = int.Parse(db.ExcuteReader(getBillID, "MAHD"));
				string Sql = $"INSERT INTO CT_HOADON(MAHD, MASP, SOLUONG) VALUES ({int.Parse(db.ExcuteReader(getBillID, "MAHD"))}, {MASP}, 3)";
				db.ExcuteQuery(Sql);
				flp.Controls.Clear();
				UI_BillDetail(flp, MAHD);
			} catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		public void show_SumTotal(TextBox txt)
		{
			string getBillID = "SELECT TOP 1 MAHD FROM HOADON ORDER BY MAHD DESC";
			txt.Text = db.ExcuteReader("EXEC Tong_ThanhTien " + int.Parse(db.ExcuteReader(getBillID, "MAHD")), "Thành tiền");
		}
		public void Event_Del_Product_BillDetail(object sender, EventArgs e, int MASP, FlowLayoutPanel flp, int MAHD)
		{
			string Sql = $"DELETE FROM CT_HOADON WHERE MASP = {MASP}";
			db.ExcuteQuery(Sql);
			flp.Controls.Clear();
			UI_BillDetail(flp, MAHD);
		}
		public void loadCombobox(ComboBox combo, string Sql, string display, string Value)
		{
			combo.DataSource = db.loadDB(Sql);
			combo.DisplayMember = display;
			combo.ValueMember = Value;
		}
		public void loadTreeView(TreeView tv)
		{
			DataTable da = db.loadDB("SELECT TENLOAI FROM LOAISP");
			foreach(DataRow item in da.Rows)
			{
				tv.Nodes.Add(item["TENLOAI"].ToString());
			}
		}
		public void Ui_Filter_Product(FlowLayoutPanel flp, string SQL, FlowLayoutPanel billDetail, int MAHD = 1)
		{
			DataTable da = db.loadDB(SQL);
			foreach (DataRow item in da.Rows)
			{
				Panel pnl = new Panel()
				{
					Width = (flp.Width - 10) / 4,
					Height = 200,
					BackgroundImage = Image.FromFile(fullPath(@"../../Resources/pngtree-purple-gradient-geometric-circle-background-image_50104.jpg")),
					BackgroundImageLayout = ImageLayout.Stretch
				};
				Button btn = new Button()
				{
					Width = pnl.Width - 10,
					Dock = DockStyle.Fill,
					BackColor = Color.Transparent,
					BackgroundImage = Image.FromFile(fullPath(@"../../Resources/" + item["MASP"] + ".jpg")),
					BackgroundImageLayout = ImageLayout.Stretch
				};
				btn.FlatAppearance.BorderSize = 0;
				Label ProductName = new Label()
				{
					Text = item["TENSP"].ToString(),
					Dock = DockStyle.Bottom,
					BackColor = Color.Transparent
				};

				btn.Click += (sender, e) => Event_Product_Click(sender, e, int.Parse(item["MASP"].ToString()), billDetail, MAHD);
				pnl.Controls.Add(btn);
				pnl.Controls.Add(ProductName);
				flp.Controls.Add(pnl);
			}
		}
	}
}
