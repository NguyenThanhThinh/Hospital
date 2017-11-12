namespace Hospital.Models
{
    using Hospital.Utilities;
    public class Doctor : BaseEntity
    {
        private string name;
        private string description;
        private Image image;
        private ExceptionMessage ex;

        public Doctor(string name, string description, Image image) : this()
        {
            this.Name = name;
            this.Description = description;
            this.Image = image;
        }

        public Doctor()
        {
            ex = new ExceptionMessage();
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

        public string Description
        {
            get
            {
                return this.description;
            }

            set
            {
                if (value == null)
                {
                    this.description = "No description";
                }
                else
                {
                    this.description = value;
                }
            }
        }

        public virtual Speciality Specialty { get; set; }

        public Image Image
        {
            get => image;
            set => image = value;
        }

    }
}
