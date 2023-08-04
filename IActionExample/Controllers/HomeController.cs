using Microsoft.AspNetCore.Mvc;
using IActionResultExample.Models;

namespace IActionResultExample.Controllers
{
    public class HomeController : Controller
    {
        [Route("bookstore")]
        // Url: /bookstore?bookid=5&isloggedin=true&Author=John
        // Model Binding 
        public IActionResult Index([FromQuery]int? bookid, [FromQuery]bool? isloggedin, Book book)
        {
            if (bookid.HasValue == false)
            {
                //Response.StatusCode = 400;
                //return Content("Bood id is not supplied.");
                return BadRequest("Book id is not supplied.");
            }
            // bookid value can't be 0 
            else if (bookid <= 0)
            {
                return Content("bookid can't be 0");
                // Book id should be between 1 to 1000
            }
            //int bookid = Convert.ToInt32(Request.Query["bookid"]);

            if (bookid < 0 || bookid > 1000) {
                return NotFound("Book id should be between 1 to 1000");
            }

            //isloggedin should be true
            if (isloggedin == false || isloggedin.HasValue == false) {
                //Response.StatusCode = 401;
                //return Content("User must be authenticated");
                return Unauthorized("User must be authenticated");
            }

            return Content($"Book id: {bookid}, Book: {book}", "text/plain");
        }
    }
}
