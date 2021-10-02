using AutoMapper;
using SchoolsAdministrator.Core.Entities;
using SchoolsAdministrator.Web.Models;

namespace SchoolsAdministrator.Web.Mappers
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<School, SchoolModel>();
            CreateMap<Classroom, ClassroomModel>();
            CreateMap<School, SchoolModel>();
            CreateMap<School, SchoolModel>();
            CreateMap<School, SchoolModel>(); 
            CreateMap<School, SchoolModel>(); 
            CreateMap<School, SchoolModel>();
        }
    }
}
