namespace concert_ticketing_system
{
    public interface IEntity
    {
        public Guid Id { get; set; }
        public bool Search(string searchString);
    }
}
