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
namespace APP
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

		public void UI_LoadProduct(FlowLayoutPanel flp, string ProName)
		{
			string Query = ProName == "" ? "" : $"WHERE TENSP = N'{ProName}'";
			DataTable da = db.loadDB("SELECT * FROM SANPHAM " + Query); //Đưa dữ liệu vào bảng
			foreach(DataRow item in da.Rows)
			{
				Panel pnl = new Panel()
				{
					Width = flp.Width / 6,
					Height = 150,
					BackgroundImage = Image.FromFile(fullPath(@"../../Resources/pngtree-purple-gradient-geometric-circle-background-image_50104.jpg")),
					BackgroundImageLayout = ImageLayout.Stretch
				};
				Button btn = new Button()
				{
					Width = pnl.Width - 10,
					Dock = DockStyle.Fill,
					BackColor = Color.Transparent
				};
				btn.FlatAppearance.BorderSize = 0;
				Label ProductName = new Label()
				{
					Text = item["TENSP"].ToString(),
					Dock = DockStyle.Bottom,
					BackColor = Color.Transparent
				};
				Label ProductPrice = new Label()
				{
					Text = item["DONGIA"].ToString(),
					Dock = DockStyle.Right,
					BackColor = Color.Transparent
				};
				pnl.Controls.Add(btn);
				pnl.Controls.Add(ProductName);
				flp.Controls.Add(pnl);
			}
		}
	}
}
