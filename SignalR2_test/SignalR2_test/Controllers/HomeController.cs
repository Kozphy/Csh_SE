using Microsoft.AspNetCore.Mvc;

namespace SignalR2_test.Controllers
{
    public class HomeController : Controller 
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
