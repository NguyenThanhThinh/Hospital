using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Models
{
    using Hospital.Utilities;

    public class Speciality : BaseEntity
    {
        private string title;
        private string description;
        private ExceptionMessage ex;

        public Speciality()
        {
            this.ex = new ExceptionMessage();
        }

        public string Title
        {
            get => title;
            set
            {
                this.ex.StringExistenceValidation(value, nameof(Speciality), nameof(this.Title));
                this.ex.StringMaxLengthValidation(value, NAME_MAX_LENGTH, nameof(this.Title));
                this.title = value;
            }
        }

        public string Descriptioname
        {
            get => description;
            set
            {
                this.ex.StringExistenceValidation(value, nameof(Speciality), nameof(this.Descriptioname));
                this.ex.StringMaxLengthValidation(value, NAME_MAX_LENGTH, nameof(this.Descriptioname));
                this.description = value;
            }
        }

        public virtual ICollection<ClinicalTrial> ClinicalTrial { get; set; } = new HashSet<ClinicalTrial>();
        public virtual ICollection<Doctor> Doctor { get; set; } = new HashSet<Doctor>();
    }
}
