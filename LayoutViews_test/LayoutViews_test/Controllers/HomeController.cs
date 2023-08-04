using LayoutViews_test.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LayoutViews_test.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [Route("/", Name ="Home")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("about-company", Name ="about-company")]
        public IActionResult About() {
            return View();
        }

        [Route("contact-support", Name ="contact-support")]
        public IActionResult Contact() {
            return View();
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}