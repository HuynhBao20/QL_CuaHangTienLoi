using Domain.API.Process;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.API.Controllers
{
	[ApiController]
	[Route("api/tichdiem")]
	public class TichDiemController : Controller
	{
		loadData da = new loadData();
		[HttpGet("/showlist")]
		public IActionResult Index()
		{

			return Ok(da.DataKH());
		}
	}
}
