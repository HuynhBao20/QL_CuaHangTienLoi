using APP.Controllers;
using ConnectionDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP.Views.LoadControl
{
	public partial class Product : UserControl
	{
		process p = new process();
		Panel Panel = new Panel();
		Connection db = new Connection();
		public string MASP { get; set; }
		public Product(string imgPath, string Name, string Price, string MASP, Panel pnl)
		{
			InitializeComponent();
			this.Panel = pnl;
			pictureBox1.Image = Image.FromFile(imgPath);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			label1.Text = Name;
			label2.Text = int.Parse(Price).ToString("0,00đ");
			this.MASP = MASP;
		}
		private void btn_Click(object sender, EventArgs e)
		{
			
		}
	}
}