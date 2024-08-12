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

namespace APP.Views
{
	public partial class frmKhachHang : Form
	{
		Connection db = new Connection();
		UI ui = new UI();
		public frmKhachHang()
		{
			InitializeComponent();
			dataGridView1.DataSource = db.loadDB("SELECT * FROM KHACHHANG");
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
