namespace concert_ticketing_system
{
    public static class FileManager
    {
        public static void Add(Entity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException();
            }

            if (!entity.IsValid())
            {
                throw new Exception("Entity is invalid");
            }

            var record = entity.Format();

            using (var writer = new StreamWriter(entity.FileName, append: true))
            {
                writer.WriteLine(record);
            }
        }
    }
}
