using Domain.API.Process;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Domain.API.Models;
using Microsoft.AspNetCore.Cors;

namespace Domain.API.Controllers
{
	[ApiController]
	[Route("Home")]
	[EnableCors("AllowAllOrigins")]
	public class HomeController : Controller
	{
		Connection db = new Connection();
		[HttpGet]
		public async Task<IActionResult> Index()
		{
			DataTable da = db.loadDB("SELECT MAHD, TRANGTHAI, NGAYLAP FROM HOADON");
			var item = da.AsEnumerable().Select(t => new HoaDon()
			{
				MaHD = t.Field<string>("MAHD"),
				TrangThai = t.Field<string>("TRANGTHAI"),
				NgayLap = t.Field<DateTime>("NGAYLAP"),
			}).ToList();
			return Ok(item);
		}
	}
}
