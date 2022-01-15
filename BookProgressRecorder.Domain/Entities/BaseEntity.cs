namespace BookProgressRecorder.Domain.Entities
{
    public class BaseEntity
    {
        public Guid Id { get; set; }

        public BaseEntity()
        {
            Id = new Guid();
        }
    }
}
