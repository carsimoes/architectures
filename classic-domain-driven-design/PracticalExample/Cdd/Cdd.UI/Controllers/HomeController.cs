using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Cdd.Application.Services;
using Cdd.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Cdd.UI.Controllers
{
	public class HomeController : Controller
	{
		private IClienteAppService _clienteAppService;

		public HomeController(IClienteAppService clienteAppService)
		{
			_clienteAppService = clienteAppService;
		}

		public IActionResult Index()
		{
			var hi = _clienteAppService.GetData();
			return View();
		}

		public IActionResult About()
		{
			ViewData["Message"] = "Your application description page.";

			return View();
		}

		public IActionResult Contact()
		{
			ViewData["Message"] = "Your contact page.";

			return View();
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			//return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
			return View();
		}
	}
}
