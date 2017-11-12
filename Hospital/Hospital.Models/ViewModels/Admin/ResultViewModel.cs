using System;
namespace Hospital.Models.ViewModels.Admin
{
    using Hospital.Models.Enums;
    using Hospital.Utilities;
    public class ResultViewModel : BaseViewModel, IMapFrom<ClinicalResult>
    {
        public User Patient { get; set; }

        public DateTime AddedOn { get; set; }

        public StatusResult StatusResult { get; set; }

        public PDF PDF { get; set; }
    }
}
