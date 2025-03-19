using System.Text;

namespace concert_ticketing_system
{
    public class Concert : Entity
    {
        public override string FileName => "Concert.txt";

        public string? Name { get; set; }
        public TimeSpan? Duration { get; set; }
        public DateTime? StartDateTime { get; set; }
        public List<Performer>? Performers { get; set; }
        public List<Visitor>? Visitors { get; set; }

        public Concert()
        {
            Name = string.Empty;
            Duration = null;
            StartDateTime = new DateTime();
            Performers = new List<Performer>();
            Visitors = new List<Visitor>();
        }

        public Concert(Guid id, string name, TimeSpan? duration, DateTime? strartDateTime, List<Performer> performers, List<Visitor> visitors)
            : base(id)
        {
            Name = name;
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

            return $"{base.Format()}[{Name}][{Duration}][{StartDateTime.Value.ToUniversalTime()}][{performersIdStr}][{visitorsIdStr}]";
        }

        public virtual void Parse(string record)
        {
            if (string.IsNullOrWhiteSpace(record))
            {
                throw new ArgumentException("Record cannot be null or empty.", nameof(record));
            }

            var parts = record.Trim().Split(new[] { "][" }, StringSplitOptions.None);
            if (parts.Length != 6)
            {
                throw new FormatException("Invalid record format.");
            }

            parts[0] = parts[0].TrimStart('[');
            parts[5] = parts[5].TrimEnd(']');

            if (!Guid.TryParse(parts[0], out Guid id))
            {
                throw new FormatException("Invalid ID format.");
            }

            string name = parts[1];

            if (!TimeSpan.TryParse(parts[2], out TimeSpan duration))
            {
                throw new FormatException("Invalid duration format.");
            }

            if (!DateTime.TryParse(parts[3], out DateTime startDateTime))
            {
                throw new FormatException("Invalid start date/time format.");
            }

            var performers = new List<Performer>();
            if (!string.IsNullOrEmpty(parts[4]))
            {
                var performerIds = parts[4].Split(',', StringSplitOptions.RemoveEmptyEntries);
                foreach (var performerId in performerIds)
                {
                    if (Guid.TryParse(performerId, out Guid performerGuid))
                    {
                        performers.Add(new Performer { Id = performerGuid });
                    }
                }
            }

            var visitors = new List<Visitor>();
            if (!string.IsNullOrEmpty(parts[5]))
            {
                var visitorIds = parts[5].Split(',', StringSplitOptions.RemoveEmptyEntries);
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
    }
}
