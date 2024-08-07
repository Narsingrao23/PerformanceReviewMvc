using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PerformanceReviewMvc.Models;
using PrservMvc.Models;
using PrservMvc.Service;

namespace PerformanceReviewMvc.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IEmployeeInterface _employee;
        private readonly IMapper _mapper;

        public EmployeeController(ILogger<HomeController> logger, IEmployeeInterface employee, IMapper mapper)
        {
            _logger = logger;
            _employee = employee;
            _mapper = mapper;
        }

        public IActionResult Employees()
        {
            var obj = new SearchEmployeeViewModel();
            //var kak = _employee.GetEmployees();

            obj.EmployeeList = new List<PrservMvc.Models.EmployeeFo>();
            return View(obj);

        }

        [HttpPost]
        public IActionResult Employees(SearchEmployeeViewModel searchObj)
        {
            var obj = new SearchEmployeeViewModel();
            var kak = _employee.GetEmployees().ToList();


            //var sqlwherestring = searchObj.BfwClause(out var objval);

            var getsqllog = kak.Where(x =>
                                           (searchObj.LastName == null || (searchObj.LastName != null && x.LastName.Contains(searchObj.LastName))) &&
                                           (searchObj.FirstName == null || (searchObj.FirstName != null && x.FirstName.Contains(searchObj.FirstName))) &&
                                           (searchObj.Id == 0 || (searchObj.Id > 0 && x.Id == searchObj.Id))
                                      ).ToList(); // kak.Where(sqlwherestring, objval);




            obj.EmployeeList = getsqllog;
            //obj.EmployeeList = kak;
            return View(obj);

        }

        public IActionResult CreateEdit()
        {
            //var obj = _mapper.Map<EmployeeFo>(createEditMdel);
            // _employee.CreateEmployee(obj);

            return View();
        }
        [HttpPost]
        public IActionResult CreateEdit(CreateEditMdel createEditMdel)
        {
            var obj = _mapper.Map<EmployeeFo>(createEditMdel);
            _employee.CreateEmployee(obj);
            return View();
        }
    }
}
