namespace BookProgressRecorder.Domain.Entities
{
    public class Book
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Author Author { get; set; }
        public DateTime PublishDate { get; set; }
        public int TotalPages { get; set; }
        public int CurrentPage { get; set; }
    }
}