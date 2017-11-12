namespace Hospital.Models.ViewModels.Doctor
{
    using Hospital.Models;
    using AutoMapper;
    using Hospital.Utilities;
    public class DoctorViewModel :BaseViewModel, IMapFrom<Doctor>, IHaveCustomMappings
    {
        public string Name { get; set; }

        public string SpecialityTitle { get; set; }

        public Image Image { get; set; }

        public string Description { get; set; }

        public void CreateMappings(IConfiguration configuration)
        {
            configuration.CreateMap<Doctor, DoctorViewModel>()
                .ForMember(x => x.SpecialityTitle, opt => opt.MapFrom(x => x.Specialty.Title));
        }
    }
}
