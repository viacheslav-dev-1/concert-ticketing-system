namespace concert_ticketing_system
{
    public class Concert : Entity, IEntity
    {
        public override string FileName => "Concert.txt";

        public string? Name { get; set; }
        public string? Description { get; set; }
        public TimeSpan? Duration { get; set; }
        public DateTime? StartDateTime { get; set; }
        public List<Performer>? Performers { get; set; }
        public List<Visitor>? Visitors { get; set; }

        public Concert()
        {
            Name = " ";
            Description = " ";
            Duration = null;
            StartDateTime = new DateTime();
            Performers = new List<Performer>();
            Visitors = new List<Visitor>();
        }

        public Concert(Guid id, string name, string description, TimeSpan? duration, DateTime? strartDateTime, List<Performer> performers, List<Visitor> visitors)
            : base(id)
        {
            Name = name;
            Description = description;
            Duration = duration;
            StartDateTime = strartDateTime ?? new DateTime();
            Performers = performers;
            Visitors = visitors;
        }

        public new bool IsValid()
        {
            return base.IsValid() &&
                    !string.IsNullOrEmpty(Name) &&
                    Duration != null &&
                    StartDateTime != null &&
                    Performers?.Count > 0;
        }

        public override string Format()
        {
            var performersId = new List<string>();
            foreach (var performer in Performers)
            {
                performersId.Add(performer.Id.ToString());
            }

            var visitorsId = new List<string>();
            foreach (var visitor in Visitors)
            {
                visitorsId.Add(visitor.Id.ToString());
            }

            var performersIdStr = Performers.Count > 0 ? string.Join(",", performersId) : "empty";
            var visitorsIdStr = Visitors.Count > 0 ? string.Join(",", visitorsId) : "empty";

            return $"{base.Format()}[{Name}][{Description}][{Duration}][{StartDateTime.Value.ToUniversalTime()}][{performersIdStr}][{visitorsIdStr}]";
        }

        public virtual void Parse(string record)
        {
            if (string.IsNullOrWhiteSpace(record))
            {
                throw new ArgumentException("Record cannot be null or empty.", nameof(record));
            }

            var parts = record.Trim().Split(new[] { "][" }, StringSplitOptions.None);
            if (parts.Length != 7)
            {
                throw new FormatException("Invalid record format.");
            }

            parts[0] = parts[0].TrimStart('[');
            parts[6] = parts[6].TrimEnd(']');

            if (!Guid.TryParse(parts[0], out Guid id))
            {
                throw new FormatException("Invalid ID format.");
            }

            string name = parts[1];

            if (!TimeSpan.TryParse(parts[3], out TimeSpan duration))
            {
                throw new FormatException("Invalid duration format.");
            }

            if (!DateTime.TryParse(parts[4], out DateTime startDateTime))
            {
                throw new FormatException("Invalid start date/time format.");
            }

            var performers = new List<Performer>();
            if (!string.IsNullOrEmpty(parts[5]))
            {
                var performerIds = parts[5].Split(',', StringSplitOptions.RemoveEmptyEntries);
                foreach (var performerId in performerIds)
                {
                    if (Guid.TryParse(performerId, out Guid performerGuid))
                    {
                        performers.Add(new Performer { Id = performerGuid });
                    }
                }
            }

            var visitors = new List<Visitor>();
            if (!string.IsNullOrEmpty(parts[6]))
            {
                var visitorIds = parts[6].Split(',', StringSplitOptions.RemoveEmptyEntries);
                foreach (var visitorId in visitorIds)
                {
                    if (Guid.TryParse(visitorId, out Guid visitorGuid))
                    {
                        visitors.Add(new Visitor { Id = visitorGuid });
                    }
                }
            }

            Id = id;
            Name = name;
            Duration = duration;
            StartDateTime = startDateTime;
            Performers = performers;
            Visitors = visitors;
        }

        public bool Search(string searchString)
        {
            return Name!.Contains(searchString, StringComparison.OrdinalIgnoreCase) ||
                   Description!.Contains(searchString, StringComparison.OrdinalIgnoreCase);
        }
    }
}
