using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using UI.Models;
using Model;
namespace UI.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index()
		{
			List<Employee> employee = new List<Employee>
			{
				new Employee {Id = 1, Name = "Huỳnh Thế Bảo", Age = 22, Date = DateTime.Parse("2002-10-20")},
				new Employee {Id = 2, Name = "Trương Lê Bảo Trân", Age = 21, Date = DateTime.Parse("2002-01-22")},
				new Employee {Id = 3, Name = "Hồng Thắm", Age = 15, Date = DateTime.Parse("2002-10-20")},
				new Employee {Id = 4, Name = "Nguyễn Thanh Long", Age = 19, Date = DateTime.Parse("2002-10-20")},
				new Employee {Id = 5, Name = "Cao Quốc Phú", Age = 4, Date = DateTime.Parse("2002-05-01")},
			};
			return View(employee);
		}

		
	}
}
