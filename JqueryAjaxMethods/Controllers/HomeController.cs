using JqueryAjaxMethods.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace JqueryAjaxMethods.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreateStudent()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateStudent(StudentModel student)
        {
            if (!ModelState.IsValid) 
            
            return BadRequest("Enter required fields");
            //Write your Insert code here;
            return Ok( "Form Data received!");
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
