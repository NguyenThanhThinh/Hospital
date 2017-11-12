using System;

namespace Hospital.Models
{
    using Hospital.Models.Enums;
    public class ClinicalResult : BaseEntity
    {
        public ClinicalResult()
        {
            this.AddedOn = DateTime.Now;
        }
        public DateTime AddedOn { get; set; }

        public StatusResult StatusResult { get; set; }

        public virtual User Patient { get; set; }

        public virtual PDF File { get; set; }
    }
}
