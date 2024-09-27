using ConnectionDB;
using ConnectionDB.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP.Controllers
{
	public class HoaDon
	{
		public string User { get; set; }
		public string Pass { get; set; }
		public string MAHD { get; set; }

		Connection db;
		Datatable dt;
		process p = new process();

		public HoaDon(string User, string Pass)
		{
			this.User = User;
			this.Pass = Pass;
			db = new Connection(User, Pass);
			dt = new Datatable(User, Pass);
			this.MAHD = db.ExcuteReader(process.get_NewBillID, "MAHD");
		}
		//public void load()
		public void loadInvoid()
		{
			
		}
	}
}
