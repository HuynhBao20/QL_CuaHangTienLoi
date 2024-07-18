using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConnectionDB;
namespace APP
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			Connection db = new Connection();
			dataGridView1.DataSource = db.loadDB("SELECT * FROM LOAISP");
			loadSP();
		}
		public void loadSP()
		{
			for(int i = 0; i < 5; i++)
			{
				Panel pnl = new Panel()
				{
					Width = 150,
					Height = 180,
					BackColor = Color.Red
				};
				Button btn = new Button()
				{
					Name = "btn",
					TextAlign = ContentAlignment.BottomCenter,
					Width = 150,
					Height = 150,

				};
				Label lb = new Label();
				
				lb.Text = "Sản phẩm 1";
				pnl.Controls.Add(btn);
				pnl.Controls.Add(lb);
				flowLayoutPanel1.Controls.Add(pnl);
			}
			
		}
	}
}
