using Hospital.Utilities;

namespace Hospital.Models.ViewModels.Admin
{
    using AutoMapper;
    public class PatientViewModel :BaseViewModel, IMapFrom<User>, IHaveCustomMappings
    {    
        public string UserName { get; set; }

        public void CreateMappings(IConfiguration configuration)
        {         
            configuration.CreateMap<User, PatientViewModel>()
                .ForMember(x => x.UserName, opt => opt.MapFrom(x => x.UserName))
                .ForMember(x => x.Id, opt => opt.MapFrom(x => x.Id));
        }
    }
}
