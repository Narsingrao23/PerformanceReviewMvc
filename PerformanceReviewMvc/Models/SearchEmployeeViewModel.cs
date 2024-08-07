using PrservMvc.Models;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;

namespace PerformanceReviewMvc.Models
{
    public class SearchEmployeeViewModel
    {
        public int Id { get; set; }
        
        public string LastName { get; set; }
       
        public string FirstName { get; set; }

        public int Age { get; set; }

        public string Position { get; set; }

        public string Contact { get; set; }
        public List<EmployeeFo> EmployeeList { get; set; }

        public string BfwClause(out object[] varray)
        {
            var lap = new List<string>();
            var lap2 = new List<object>();
            int counter = -1;

            if(!string.IsNullOrEmpty(LastName))
            {
                counter++;
                lap.Add($"LastName=@{counter}");
                lap2.Add(LastName);

            }
            if(!string.IsNullOrEmpty(FirstName))
            {
                counter++;
                lap.Add($"FirstName=@{counter}");
                lap2.Add(FirstName);
            }

            varray = lap2.ToArray();
            if(lap.Count > 0)
            {
                return String.Join("and", lap);
            }
            return "1=1";
        }
    }
}
