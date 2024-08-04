using ConnectionDB;
using CrystalDecisions.Windows.Forms;
using Reporting.Reporting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Reporting.Process
{
	public class Show
	{
		public readonly string Sql;
		//CrystalReportViewer crv = new CrystalReportViewer();
		public Show()
		{
		}
		public void showHD(string Sql, CrystalReportViewer crv)
		{
			HoaDon hd = new HoaDon();
			Connection db = new Connection();
			hd.SetDataSource(db.loadDB(Sql));
			crv.ReportSource = hd;
		}
	}
}
