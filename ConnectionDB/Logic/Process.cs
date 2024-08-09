using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectionDB.Logic
{
	public class Process
	{
		public string getMAHD(string MAHD)
		{
			int a = int.Parse(MAHD.Trim().Substring(2, MAHD.Length - 2));
			a++;
			return a < 10 ? $"HD00{a}" : (a >= 10 && a < 100) ? $"HD0{a}" : $"HD{a}";
		}
	}
}
