namespace concert_ticketing_system
{
    public class Visitor : Person
    {
        public override string FileName => "Visitor.txt";

        public string? PhoneNumber { get; set; }

        public Visitor()
        {
            PhoneNumber = string.Empty;
        }

        public Visitor(Guid id, string firstName, string lastName, string email, string phoneNumber)
            : base(id, firstName, lastName, email)
        {
            PhoneNumber = phoneNumber;
        }

        public new bool IsValid()
        {
            return base.IsValid() && !string.IsNullOrEmpty(PhoneNumber);
        }

        public override sealed string Format()
        {
            return $"{base.Format()}[{PhoneNumber}]";
        }

        public new virtual void Parse(string record)
        {
            base.Parse(record);
            var parts = record.Trim('[', ']').Split(new[] { "][" }, StringSplitOptions.None);
            if (parts.Length != 5)
            {
                throw new FormatException("Invalid record format.");
            }

            PhoneNumber = parts[4];
        }
    }
}
