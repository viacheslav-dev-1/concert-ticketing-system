namespace concert_ticketing_system
{
    public class DataManager
    {
        public IEnumerable<IEntity> Entities { get; private set; } = new List<IEntity>();

        public IEntity? this[Guid id]
        {
            get
            {
                IEntity? entity = null;
                foreach (var item in Entities)
                {
                    if (item.Id == id)
                        return item;
                }

                return entity;
            }
        }

        public void Add(IEntity entity)
        {
            Entities = Entities.Append(entity);
        }

        public IEnumerable<IEntity> Search(string searchString)
        {
            foreach (var entity in Entities)
            {
                if (entity.Search(searchString))
                {
                    yield return entity;
                }
            }
        }

        public IEnumerable<IEntity> Filter(FilterDelegate filter)
        {
            foreach (var entity in Entities)
            {
                if (filter.Invoke(entity))
                {
                    yield return entity;
                }
            }
        }
    }
}
