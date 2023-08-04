using Microsoft.AspNetCore.Mvc;
using mvc_pagenation.Models;
using System.Diagnostics;
using System.Text;

namespace mvc_pagenation.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AdventureWorksDW2022Context _context;
        private int totalRow {get;set;}
        private int pageSize = 5;

        public HomeController(ILogger<HomeController> logger, AdventureWorksDW2022Context context)
        {
            _logger = logger;
            _context = context; 
        }

        public int GetDbTableTotalPage() { 
            totalRow = _context.DimProducts.Count();
            int totalPage = (totalRow % pageSize) > 0 ? totalRow / pageSize + 1 : totalRow / pageSize;
            return totalPage;
        }

        public IActionResult Index(int pageNum)
        {
            int currentPage = 1;
            int currentIndex = pageSize * (currentPage - 1);
            List<DimProduct> Products = _context.DimProducts.Skip(currentIndex).Take(pageSize).ToList();
            return View(Products);
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