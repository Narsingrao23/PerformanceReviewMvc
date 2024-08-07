using AutoMapper;
using PerformanceReviewMvc.Models;
using PrservMvc.Models;

namespace PerformanceReviewMvc.Mapper
{

    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<EmployeeFo, CreateEditMdel>();
            CreateMap<CreateEditMdel, EmployeeFo>();
        }
    }
}
