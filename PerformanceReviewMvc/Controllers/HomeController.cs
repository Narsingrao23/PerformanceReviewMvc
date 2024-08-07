
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using PerformanceReviewMvc.Models;
using PrservMvc.Service;
using System.Diagnostics;
using System.Linq;

namespace PerformanceReviewMvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IEmployeeInterface _employee;

        public HomeController(ILogger<HomeController> logger,IEmployeeInterface employee)
        {
            _logger = logger;
            _employee = employee;
        }

        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult Projects()
        {
            return View();
        }

        public IActionResult Performances()
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
