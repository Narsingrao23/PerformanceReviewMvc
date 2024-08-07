using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PerformanceReviewMvc.Models
{
    public class CreateEditMdel
    {
        public int Id { get; set; }
        //[Required(ErrorMessage = "Please enter name"), MaxLength(50)]
        //[DisplayName("Last Name")]
        public string LastName { get; set; }
        //[Required(ErrorMessage = "Please enter name"), MaxLength(50)]
        //[DisplayName("First Name")]
        public string FirstName { get; set; }

        public int Age { get; set; }

        public string Position { get; set; }

        public string Contact { get; set; }
    }
}
