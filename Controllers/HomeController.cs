using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using zadanie8.Models;

namespace zadanie8.Controllers
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
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Stepen2(string n)
        {
            double number = double.Parse(n);
            number = Math.Pow(2, number);
            return View(number);
        }

		public IActionResult Chess(string Cord1, string Cord2)
		{
            string[] Cords1 = Cord1.Split(' ');
            string[] Cords2 = Cord2.Split(' ');
            bool hit;
            if (Cords1[0] == Cords2[0] || Cords1[1] == Cords2[1]) hit = true;
            else hit = false;
			return View(hit);
		}
	}
}