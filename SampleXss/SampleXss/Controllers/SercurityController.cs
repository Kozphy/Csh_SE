using Microsoft.AspNetCore.Mvc;

namespace SampleXss.Controllers
{
    public class SercurityController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult XssAttack(string searchString) {
            HttpContext.Response.Cookies.Append("sercurity", "SecurityValue");
            return View((object)searchString);
        }
    }
}
