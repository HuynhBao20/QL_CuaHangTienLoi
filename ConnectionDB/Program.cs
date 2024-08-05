using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConnectionDB.Logic;
namespace ConnectionDB
{
	class Program
	{
		static void Main(string[] argv)
		{
			DBContext db = new DBContext();
            foreach(var item in db.lstKhuyenMai())
			{
				Console.WriteLine(item.MASP);
			}
            Console.ReadKey();
		}
	}
}
