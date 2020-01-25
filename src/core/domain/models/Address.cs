namespace WappaMobile.ChallengeDev.Models
{
    public class Address
    {
        public string Suffix { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public Coordinate Coordinate { get; set; } = Coordinate.Empty;

        public bool IsValid => !Number.IsEmpty() && !Street.IsEmpty();

        public override string ToString()
        {
            return $"{Suffix} {Street},{Number} - {District}, {City}, {State} {ZipCode}";
        }
    }
}
