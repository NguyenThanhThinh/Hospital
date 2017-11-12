namespace Hospital.Models
{
    using Hospital.Utilities;
    public class Doctor : BaseEntity
    {
        private string name;
        private string description;
        private ExceptionMessage ex;

        private Doctor()
        {
            this.ex = new ExceptionMessage();
        }

        public string Name
        {
            get => name;
            set
            {
                this.ex.StringExistenceValidation(value, nameof(Doctor), nameof(this.Name));
                this.ex.StringMaxLengthValidation(value, NAME_MAX_LENGTH, nameof(this.Name));
                this.name = value;
            }
        }

        public string Descriptioname
        {
            get => description;
            set
            {
                this.ex.StringExistenceValidation(value, nameof(Doctor), nameof(this.Descriptioname));
                this.ex.StringMaxLengthValidation(value, NAME_MAX_LENGTH, nameof(this.Descriptioname));
                this.name = value;
            }
        }

        public virtual Speciality Specialty { get; set; }

        public Image Image { get; set; }

    }
}
