
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Models
{
    using Hospital.Models.Enums;
    using Hospital.Utilities;
    using System.ComponentModel.DataAnnotations;

    public  class ClinicalTrial:BaseEntity
    {
        private ExceptionMessage ex;

        public ClinicalTrial(string title, decimal price, IsAvailable isavailable) :this()
        {
            this.Title = title;
            this.Price = price;
            this.IsAvailable = isavailable;
        }

        public ClinicalTrial()
        {
            ex = new ExceptionMessage();
        }

        private string title;
        private decimal price;
        private IsAvailable isavailable;
        public string Title
        {
            get=>title;
            set
            {
                this.ex.StringExistenceValidation(value, nameof(ClinicalTrial), nameof(this.Title));
                this.ex.StringMaxLengthValidation(value, NAME_MAX_LENGTH, nameof(this.Title));
                this.title = value;
            }
        }
        [Required]
        public decimal Price
        {
            get
            {
                return this.price;
            }

            set
            {
                this.ex.NummericNonNegativeValidation(value, nameof(this.Price));
                this.price = value;
            }
        }

        public IsAvailable IsAvailable
        {
            get => isavailable;
            set
            {
                this.isavailable = value;
            }
        }

        public virtual Speciality Speciality { get; set; }

    }
}
