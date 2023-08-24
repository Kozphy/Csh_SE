using Microsoft.AspNetCore.Mvc;
using ModelValidation.Models;


namespace ModelValidation.Controllers
{
    public class HomeController : Controller
    {
        [Route("register")]
        public IActionResult Index(Person person)
        {
            if (!ModelState.IsValid)
            {
                string errors = string.Join("\n", ModelState.Values.SelectMany(
                    value => value.Errors).Select(err => err.ErrorMessage));
                return BadRequest(errors);
            }
            return Content($"{person}");
        }

        [Route("ModelStateTest")]
        public IActionResult State(Person person)
        {
            if (!ModelState.IsValid)
            {
                List<string> errorsList = new List<string>(){ };
                foreach (var value in ModelState.Values)
                {
                    // print each validation error
                    foreach (var err in value.Errors)
                    {
                        errorsList.Add(err.ErrorMessage);
                    }
                    //Console.WriteLine(value);
                }

                string errors = string.Join('\n', errorsList);
                return BadRequest(errors);
            }
            return Content($"{person}");
        }
    }
}
