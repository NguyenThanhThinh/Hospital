using System.Collections.Generic;
namespace Hospital.Models.ViewModels.Specialities
{
    using Hospital.Utilities;
    using Hospital.Models;
    public class SpecialitiesViewModel : BaseViewModel, IMapFrom<Speciality>
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public ICollection<ClinicalTrial> ClinicalTrial { get; set; }

        public ICollection<Doctor> Doctor { get; set; }
    }
}
