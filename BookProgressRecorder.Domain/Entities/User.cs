namespace BookProgressRecorder.Domain.Entities
{
    public class User : BaseEntity
    {
        public string Login { get; set; }
        public string Senha { get; set; }
        public ICollection<BookStatus> Books { get; set; }
    }
}
