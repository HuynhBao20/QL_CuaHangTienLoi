using ConnectionDB;
using ConnectionDB.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP.Controllers
{
	public class HoaDon
	{
		Connection db;
		Datatable dt;
		public string User { get; set; }
		public string Pass { get; set; }
		public string MAHD { get; set; }
		
		public HoaDon(string User, string Pass)
		{
			this.User = User;
			this.Pass = Pass;
			db = new Connection(User, Pass);
			dt = new Datatable(User, Pass);
			this.MAHD = db.ExcuteReader(process.get_NewBillID, "MAHD");
		}

	}
}
