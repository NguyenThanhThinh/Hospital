using Hospital.Utilities;
using System.Collections.Generic;

namespace Hospital.Models.ViewModels.Specialities
{
    public class SpecialitiesIndexViewModel : BaseViewModel, IMapFrom<Speciality>
    {
        public string Title { get; set; }

        public ICollection<ClinicalTrial> ClinicalTrials { get; set; }
    }
}
