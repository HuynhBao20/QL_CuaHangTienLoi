using ConnectionDB;
using ConnectionDB.Models;
using System;
using System.Collections.Generic;
using System.Data;
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
		public string fullPath(string Fpath) => Path.GetFullPath(Fpath); //Hàm này lấy ra đường dẫn của file
		public string User { get; set; }
		public string Pass { get; set; }
		public NhapHang(string User, string Pass)
		{
			this.User = User;
			this.Pass = Pass;
			db = new Connection(User, Pass);
			dt = new Datatable(User, Pass);
		}
		public void load_ChiTiet(FlowLayoutPanel flp)
		{
			flp.AutoScroll = true;
			foreach(DataRow item in dt.da_PhieuNhap().Rows)
			{
				TableLayoutPanel tbl = new TableLayoutPanel()
				{
					Dock = DockStyle.Fill,
					ColumnCount = 3,
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
				Button btn = new Button()
				{
					Dock = DockStyle.Fill,
					Text = "Xem"
				};
				tbl.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 250F));
				tbl.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 250F));
				tbl.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 12));
				tbl.Controls.Add(lb, 1, 0);
				tbl.Controls.Add(MAPN, 0, 0);
				tbl.Controls.Add(btn, 3, 0);
				pnl.Controls.Add(tbl);
				flp.Controls.Add(pnl);

			}
		}
	}
}
