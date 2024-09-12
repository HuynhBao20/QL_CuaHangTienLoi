using ConnectionDB;
using ConnectionDB.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using APP.Views.LoadControl;
namespace APP.Controllers
{
	public class SanPham
	{
		Connection db;
		Datatable dt;
		process p = new process();
		public SanPham(string User, string Pass)
		{
			db = new Connection(User, Pass);
			dt = new Datatable(User, Pass);
		}
		public SanPham()
		{
			db = new Connection();
		}
		public void load_Product(FlowLayoutPanel flow, Panel pnl)
		{
			flow.Controls.Clear();
			pnl.Controls.Clear();
			foreach(DataRow item in dt.da_SanPham().Rows)
			{
				Product product = new Product(p.fpathImage(item["MASP"].ToString()), item["TENSP"].ToString(), item["DONGIA"].ToString(), item["MASP"].ToString(), pnl);
				flow.Controls.Add(product);
				product.Show();
			}
		}
	}
}
