using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using mvc_api.Models;

namespace mvc_api.Controllers
{
    public class ActionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


    }
}
