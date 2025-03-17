namespace concert_ticketing_system
{
    public sealed class Manager : Person
    {
        public override string FileName => "Manager.txt";

        public string? Password { get; set; }

        public Manager()
        {
            Password = string.Empty;
        }

        public Manager(Guid id, string firstName, string lastName, string email, string password)
            : base(id, firstName, lastName, email)
        {
            Password = password;
        }

        public new bool IsValid()
        {
            return base.IsValid() && !string.IsNullOrEmpty(Password);
        }

        public override string Format()
        {
            return $"{base.Format()}[{Password}]";
        }

        public new void Parse(string record)
        {
            base.Parse(record);
        }
    }
}
