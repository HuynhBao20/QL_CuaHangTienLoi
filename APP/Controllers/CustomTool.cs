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
		public void UI_Load(FlowLayoutPanel flp, string Product_Name, string FilePath, string DonGia, string SL, string ThanhTien, int key, EventHandler e)
		{
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
			Label lb_SoLuong = new Label()
			{
				Width = pnl.Width / 6,
				Dock = DockStyle.Left,
				Text = SL,
				TextAlign = ContentAlignment.MiddleCenter
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

			Control control;
			Control control2;
			btn.FlatAppearance.BorderSize = 0;
			if(key == 1)
			{
				control = lb_HinhAnh;
				control2 = pm;
			}else
			{
				control = pictureBox;
				control2 = btn;
			}
			pnl.Controls.Add(control2);
			pnl.Controls.Add(lb_ThanhTien);
			pnl.Controls.Add(lb_SoLuong);
			pnl.Controls.Add(lb_DonGia);
			pnl.Controls.Add(lb_Name);
			pnl.Controls.Add(control);
			flp.Controls.Add(pnl);
			btn.Click += e;
		}
	}
}
