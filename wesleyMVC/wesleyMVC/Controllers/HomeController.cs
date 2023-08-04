using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using wesleyMVC.Models;

namespace wesleyMVC.Controllers
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
            // string to Session
            HttpContext.Session.SetString("Title_S", "ASP.NET Core MVC");
            HttpContext.Session.SetString("Message_S", "Hello World!");
            HttpContext.Session.SetInt32("Years_S", 2019);
            ViewBag.Message = HttpContext.Session.GetString("Message_S");
            ViewBag.Year = HttpContext.Session.GetInt32("Year_S");
            return View();
        }

        public IActionResult Index2() {
            ViewBag.Message = HttpContext.Session.GetString("Message_S");
            ViewBag.Year = HttpContext.Session.GetInt32("Year_S");
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
    }
}