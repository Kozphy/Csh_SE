using arch_seperate.Models;
using arch_seperate.Repository;
using Microsoft.AspNetCore.Mvc;

namespace arch_seperate.Controllers
{
    public class ExamResultController : Controller
    {
        private readonly IExamResultRepository _examResult;

        public ExamResultController(IExamResultRepository examResult) { 
            _examResult = examResult;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _examResult.GetAllAsync());
        }

        public async Task<IActionResult> GetSomeAsync([FromQuery] string studentName) {
            return View("~/Views/ExamResult/Index.cshtml",await _examResult.GetSomeAsync(studentName));
        }

        [ActionName("GetOneStudent")]
        //[Route("Exam/GetOneStudent")]
        public async Task<IActionResult> GetOneAsync([FromQuery] string studentName, [FromQuery] string subject, [FromQuery] int marks)
        {
            //Dictionary<string, object> dictVal = new Dictionary<string, object>() {
            //    { "StudentName", studentName},
            //    { "Subject", subject},
            //    { "Marks", marks}
            //};
            return View("~/Views/ExamResult/Index.cshtml",await _examResult.GetOneAsync(studentName, subject, marks));
        }

        public async Task<IActionResult> Edit(ExamResult examResult)
        {

            _examResult.UpdateAsync(examResult);
            return RedirectToAction(nameof(Index));
        }
    }
}
