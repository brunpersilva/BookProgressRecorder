namespace BookProgressRecorder.Domain.Entities
{
    public class Book : BaseEntity
    {
        public string Name { get; set; }
        public Author Author { get; set; }
        public DateTime PublishDate { get; set; }
        public int TotalPages { get; set; }
    }
}