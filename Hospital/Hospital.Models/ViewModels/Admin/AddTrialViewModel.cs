using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Models.ViewModels.Admin
{
    using Hospital.Models.Enums;
    using Hospital.Utilities;
    using AutoMapper;
    using System.Web.Mvc;

    public class AddTrialViewModel:BaseViewModel, IMapFrom<ClinicalTrial>, IHaveCustomMappings
    {
        public string Title { get; set; }

        public IsAvailable IsAvailable { get; set; }

        public int SpecialityId { get; set; }

        public IEnumerable<SelectListItem> Specialty { get; set; }

        public decimal Price { get; set; }

        public void CreateMappings(IConfiguration configuration)
        {
            configuration.CreateMap<ClinicalTrial, AddTrialViewModel>()
                .ForMember(x => x.SpecialityId, opt => opt.MapFrom(x => x.Speciality.Id))
                .ReverseMap();
        }
    }
}
