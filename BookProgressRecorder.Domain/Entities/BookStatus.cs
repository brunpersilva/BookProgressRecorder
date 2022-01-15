namespace BookProgressRecorder.Domain.Entities
{
    public class BookStatus : BaseEntity
    {
        public Guid UserId { get; set; }
        public Guid BookId { get; set; }
        public int CurrentPage { get; set; }
        public bool Completed { get; set; }
    }
}
