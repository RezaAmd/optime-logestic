namespace Domain.Commons
{
    public class BaseEntity
    {
        public Guid Id { get; private set; }
        public DateTime CreatedOn { get; private set; } = DateTime.Now;
    }
}