namespace Hospital.Models
{
    public class BaseEntity
    {
        public int Id { get; set; }

        protected const int NAME_MAX_LENGTH = 50;

        protected const int EMAIL_MAX_LENGTH = 100;
      
    }
}
