using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrservMvc.Models
{
    public class EmployeeFo
    {
        
        
            public int Id { get; set; }

            public string LastName { get; set; }
        
            public string FirstName { get; set; }

            public int Age { get; set; }

            public string Position { get; set; } 

            public string Contact { get; set; } 
       


    }
}
