using Hospital.Utilities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper.Configuration;

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
