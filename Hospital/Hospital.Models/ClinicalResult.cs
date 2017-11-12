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

        public virtual User Patient { get; set; }

        public DateTime AddedOn { get; set; }

        public StatusResult StatusResult { get; set; }

        public virtual PDF File { get; set; }
    }
}
