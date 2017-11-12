using System;

namespace Hospital.Models.ViewModels.Patient
{
    using Hospital.Models.Enums;
    using Hospital.Utilities;
    public class PatientResultViewModel :BaseViewModel, IMapFrom<ClinicalResult>
    {
        public DateTime AddedOn { get; set; }

        public StatusResult StatusResult { get; set; }

        public BaseFile PDF { get; set; }
    }
}
