using PrservMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PrservMvc.Models.EmployeeFo;

namespace PrservMvc.Service
{
    public interface IEmployeeInterface
    {
        List<EmployeeFo> GetEmployees();
        EmployeeFo GetEmployee(int id);

        bool IsEmployeeActive(int id);

        bool CreateEmployee(EmployeeFo employee);

        bool save();

        bool UpdateEmployee(EmployeeFo employee);

        bool DeleteEmployee(EmployeeFo employee);
    }
}
