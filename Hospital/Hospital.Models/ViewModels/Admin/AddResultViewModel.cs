using Hospital.Models.Enums;
using Hospital.Utilities;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace Hospital.Models.ViewModels.Admin
{
    public class AddResultViewModel : IMapFrom<ClinicalResult>
    {
        [Display(Name = "Status Result")]
        public StatusResult StatusResult { get; set; }

        public User Patient { get; set; }

        public HttpPostedFileBase UploadedFile { get; set; }

        public string PatientId { get; set; }
    }
}
