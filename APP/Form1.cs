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
		Connection db = new Connection();
		UI ui = new UI();
		public Form1()
		{
			InitializeComponent();
			dataGridView1.DataSource = db.loadDB("SELECT * FROM NHANVIEN");
			ui.UI_loadSP(flowLayoutPanel1);
		}
		
	}
}
