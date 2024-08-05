using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConnectionDB.Models;
namespace ConnectionDB.Logic
{
	public class DBContext
	{
		DataEntities db = new DataEntities();
		public List<KHUYENMAI> lstKhuyenMai() => db.KHUYENMAIs.ToList();
	}
}
