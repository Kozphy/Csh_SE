using Microsoft.AspNetCore.Mvc;

namespace LayoutViews_test.Controllers
{
    public class ProductController : Controller
    {
        [Route("products", Name ="products")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("search-products", Name ="search-products")]
        public IActionResult Search()
        {
            return View();
        }

        [Route("order-product",Name ="order-product")]
        public IActionResult Order()
        {
            return View();
        }
    }
}
