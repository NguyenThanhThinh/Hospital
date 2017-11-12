namespace Hospital.Models
{
    public abstract class BaseFile : BaseEntity
    {
        public byte[] Content { get; set; }

        public string FileName { get; set; }

        public string FileExtension { get; set; }

        public string Path { get; set; }
    }
}
