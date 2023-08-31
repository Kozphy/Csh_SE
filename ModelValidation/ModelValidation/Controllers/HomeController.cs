using Microsoft.AspNetCore.Mvc;
using ModelValidation.Models;

namespace ModelValidation.Controllers
{
    public class HomeController : Controller
    {
        [Route("register")]
        public IActionResult Index([Bind(nameof(Person.PersonName), 
            nameof(Person.Email), nameof(Person.Phone), nameof(Person.Password), 
            nameof(Person.ConfirmPassword), nameof(Person.DateOfBirth), 
            nameof(Person.FromDate), nameof(Person.ToDate))] Person person)
        {
            if (!ModelState.IsValid)
            {
                Console.WriteLine(ModelState);
                string errors = string.Join("\n", ModelState.Values.SelectMany(
                    value => value.Errors)
                    .Select(err => err.ErrorMessage));
                return BadRequest(errors);
            }

            return Content($"{person.ToString()}");
        }

        [Route("register2")]
        public IActionResult Index2(Person2 person)
        {
            if (!ModelState.IsValid)
            {
                string errors = string.Join("\n", ModelState.Values
                    .SelectMany(v => v.Errors)
                    .Select(err => err.ErrorMessage));
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
                }

                string errors = string.Join('\n', errorsList);
                return BadRequest(errors);
            }
            return Content($"{person.ToString()}");
        }
    }
}
