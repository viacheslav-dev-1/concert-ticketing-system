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

        public static List<T> Read<T>(string path) where T : Entity, new()
        {
            if (string.IsNullOrEmpty(path))
            {
                throw new ArgumentNullException();
            }

            if (!File.Exists(path))
            {
                throw new Exception("File does not exist");
            }

            var lines = File.ReadAllLines(path);
            var results = new List<T>();

            foreach (var line in lines)
            {
                var entity = new T();
                entity.Parse(line);
                results.Add(entity);
            }

            return results;
        }
    }
}
