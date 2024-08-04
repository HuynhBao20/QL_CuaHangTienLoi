using CrystalDecisions.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Reporting.Reporting;
using ConnectionDB;
using Reporting.Process;

namespace Reporting
{
	public partial class SharedReporting : Form
	{
		Show s = new Show();
		public SharedReporting(string MAHD)
		{
			InitializeComponent();
			s.showHD($"EXEC sp_XuatHoaDon {int.Parse(MAHD)}", crv);
		}
		private void Form1_Load(object sender, EventArgs e)
		{

		}
	}
}
