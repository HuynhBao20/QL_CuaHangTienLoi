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
	public partial class Dashboard : Form
	{
		Analyst a = new Analyst();
		Connection db;
		public Dashboard(string UserName, string Pass)
		{
			InitializeComponent();
			db = new Connection(UserName, Pass);
			a.Analyst_Month(chart1);
			a.Analyst_Product_Buy(chart2);
			lb_MaNV.Text = db.ExcuteReader($"SELECT MANV FROM NHANVIEN WHERE MANV = '{UserName}'", "MANV");
			lb_HoTen.Text = db.ExcuteReader($"SELECT HOTEN FROM NHANVIEN WHERE MANV = '{UserName}'", "HOTEN");
			lb_NgaySinh.Text = DateTime.Parse(db.ExcuteReader($"SELECT NGAYSINH FROM NHANVIEN WHERE MANV = '{UserName}'", "NGAYSINH")).ToString("dd/MM/yyyy");

		}
	}
}
