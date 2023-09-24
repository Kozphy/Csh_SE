using Microsoft.AspNetCore.Mvc;
using ModelBinderCustom.Models;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using ModelBinderCustom.CustomerModelBinders;

namespace ModelBinderCustom.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [Route("register")]

        public IActionResult Index([FromBody] 
            [ModelBinder(BinderType = 
                typeof(PersonModelBinder))] Person person)
        {
            if (!ModelState.IsValid)
            {
                // get error messages from model state
            }

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