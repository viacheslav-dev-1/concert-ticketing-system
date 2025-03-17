namespace concert_ticketing_system
{
    public sealed class Performer : Person
    {
        public override string FileName => "Performer.txt";

        public string? Qualification { get; set; }

        public Performer()
        {
            Qualification = string.Empty;
        }

        public Performer(Guid id, string firstName, string lastName, string email, string qualification)
            : base(id, firstName, lastName, email)
        {
            Qualification = qualification;
        }

        public override string Format()
        {
            return $"{base.Format()}[{Qualification}]";
        }

        public new void Parse(string record)
        {
            base.Parse(record);
            var parts = record.Trim('[', ']').Split(new[] { "][" }, StringSplitOptions.None);
            if (parts.Length != 5)
            {
                throw new FormatException("Invalid record format.");
            }

            Qualification = parts[4];
        }
    }
}
