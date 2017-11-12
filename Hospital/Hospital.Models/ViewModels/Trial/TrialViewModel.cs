
namespace Hospital.Models.ViewModels.Trial
{
    using AutoMapper;
    using Hospital.Models.Enums;
    using Hospital.Utilities;
    public class TrialViewModel :BaseViewModel, IMapFrom<ClinicalTrial>, IHaveCustomMappings
    {
    
        public string Title { get; set; }

        public IsAvailable IsAvailable { get; set; }

        public string SpecialityTitle { get; set; }

        public Speciality Speciality { get; set; }

        public decimal Price { get; set; }

        public void CreateMappings(IConfiguration configuration)
        {
            configuration.CreateMap<ClinicalTrial, TrialViewModel>()
                .ForMember(x => x.SpecialityTitle, opt => opt.MapFrom(x => x.Speciality.Title));
        }
    }
}
