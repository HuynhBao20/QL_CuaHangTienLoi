using ConnectionDB;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP.Controllers
{
	public class CustomTool
	{
		Connection db = new Connection();
		public Button button(int Width,
						  int Height,
						  Color color,
						  DockStyle dock,
						  Image image,
						  ImageLayout layout, 
						  FlatStyle flat, 
						  int border)
		{
			Button btn = new Button()
			{
				Width = Width,
				Height = Height,
				BackColor = color,
				Dock = dock,
				BackgroundImage = image,
				BackgroundImageLayout = layout,
				FlatStyle = flat
			};
			btn.FlatAppearance.BorderSize = border;
			return btn;
		}
		public void UI_Load(string ImagePathBg, string ImageFromFile, FlowLayoutPanel flp, string lable, int Width, EventHandler e)
		{
			Panel pnl = new Panel()
			{
				Width = Width,
				Height = 200,
				
			};
			if(ImagePathBg != "") {
				pnl.BackgroundImage = Image.FromFile(ImagePathBg);
				pnl.BackgroundImageLayout = ImageLayout.Stretch;
			} else
			{
				pnl.BackColor = Color.Azure;
			}
			Button btn = button(pnl.Width - 10, pnl.Height, Color.Transparent, DockStyle.Fill, Image.FromFile(ImageFromFile), ImageLayout.Stretch, FlatStyle.Flat, 0);
			Label ProductName = new Label()
			{
				Height = 50,
				Text = lable,
				Dock = DockStyle.Bottom,
				BackColor = Color.Transparent
			};

			btn.Click += e;
			pnl.Controls.Add(btn);
			pnl.Controls.Add(ProductName);
			flp.Controls.Add(pnl);
		}
		public void UI_Load(FlowLayoutPanel flp, string MAHD, string Product_Name, string FilePath, string DonGia, string SL, string ThanhTien, int key, EventHandler e)
		{
			Control control;
			Control control2;
			Control ctrlSoLuong;
			Panel pnl = new Panel()
			{
				Width = 500,
				Height = 80,
				Dock = DockStyle.Top,
				BackColor = key == 1 ? Color.Azure : Color.White
			};
			Label lb_Name = new Label()
			{
				Width = pnl.Width / 6,
				Dock = DockStyle.Left,
				Text = Product_Name,
				TextAlign = ContentAlignment.MiddleCenter
			};
			PictureBox pictureBox = new PictureBox()
			{
				Width = pnl.Width / 6,
				Image = Image.FromFile(FilePath),
				SizeMode = PictureBoxSizeMode.StretchImage,
				Dock = DockStyle.Left
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
				Text = DonGia,
				TextAlign = ContentAlignment.MiddleCenter
			};
			Panel lb_SoLuong = new Panel()
			{
				Margin = new Padding(0, 30, 0, 0),
				Width = pnl.Width / 6,
				Dock = DockStyle.Left,
			};
			Label SoLuong = new Label()
			{
				Width = pnl.Width / 6,
				Dock = DockStyle.Left,
				Text = SL,
				TextAlign = ContentAlignment.MiddleCenter
			};
			Button btnDesc = new Button()
			{
				Width = 25,
				Text = "-",
				Height = 25,
				BackColor = Color.Red,
				TextAlign = ContentAlignment.MiddleCenter,
				Location = new Point(0, 25)
			};
			TextBox txtSL = new TextBox()
			{
				Text = SL,
				Width = 25,
				Height = 20,
				BorderStyle = BorderStyle.FixedSingle,
				Location = new Point(btnDesc.Width, 25)
			};
			Button btnASC = new Button()
			{
				Width = 25,
				Text = "+",
				Height = 25,
				BackColor = Color.Green,
				TextAlign = ContentAlignment.MiddleCenter,
				Location = new Point(txtSL.Width + txtSL.Width, 25)
			};
			Label lb_ThanhTien = new Label()
			{
				Width = pnl.Width / 6,
				Dock = DockStyle.Left,
				Text = ThanhTien,
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
			Label pm = new Label()
			{
				Width = pnl.Width / 6,
				Dock = DockStyle.Right,
				Text = "Xóa",
				TextAlign = ContentAlignment.MiddleCenter
			};
			btn.FlatAppearance.BorderSize = 0;
			
			if(key == 1)
			{
				control = lb_HinhAnh;
				control2 = pm;
				ctrlSoLuong = SoLuong;
			}else
			{
				control = pictureBox;
				control2 = btn;
				ctrlSoLuong = lb_SoLuong;
				lb_ThanhTien.Text = (int.Parse(txtSL.Text) * int.Parse(DonGia)).ToString();
			}
			#region thêm vào panel
			pnl.Controls.Add(control2);
			pnl.Controls.Add(lb_ThanhTien);
			
			lb_SoLuong.Controls.Add(btnDesc);
			lb_SoLuong.Controls.Add(txtSL);
			lb_SoLuong.Controls.Add(btnASC);

			pnl.Controls.Add(ctrlSoLuong);
			pnl.Controls.Add(lb_DonGia);
			pnl.Controls.Add(lb_Name);
			pnl.Controls.Add(control);
			flp.Controls.Add(pnl);
			#endregion
			btn.Click += e;
			btnDesc.Click += (sender, ex) => Event_Product_Sort_Click(sender, ex, MAHD, db.ExcuteReader($"SELECT MASP FROM SANPHAM WHERE TENSP = '{Product_Name}'", "MASP").ToString(), "desc", txtSL, lb_ThanhTien, int.Parse(DonGia));
			btnASC.Click += (sender, ex) => Event_Product_Sort_Click(sender, ex, MAHD, db.ExcuteReader($"SELECT MASP FROM SANPHAM WHERE TENSP = '{Product_Name}'", "MASP").ToString(), "asc", txtSL, lb_ThanhTien, int.Parse(DonGia));
		}
		public void Event_Product_Sort_Click(object sender, EventArgs e, string MAHD, string MASP, string sort, TextBox txt, Label thanhtien, int dongia)
		{
			int SL = int.Parse(db.ExcuteReader($"SELECT SOLUONG FROM CT_HOADON WHERE MAHD = '{MAHD}' AND MASP = '{MASP}'", "SOLUONG"));
			SL++;
			string Sql = $"UPDATE CT_HOADON SET SOLUONG = {SL} WHERE MAHD = '{MAHD}' AND MASP = '{MASP}'";
			db.ExcuteQuery(Sql);
			txt.Text = SL.ToString();
			thanhtien.Text = (int.Parse(txt.Text) * dongia).ToString();
		}
	}
}
