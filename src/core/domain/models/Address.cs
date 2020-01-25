using System.Runtime.Serialization;

namespace WappaMobile.ChallengeDev.Models
{
    [DataContract]
    public class Address
    {
        [DataMember]
        public string Suffix { get; set; }
        [DataMember]
        public string Street { get; set; }
        [DataMember]
        public string Number { get; set; }
        [DataMember]
        public string District { get; set; }
        [DataMember]
        public string City { get; set; }
        [DataMember]
        public string State { get; set; }
        [DataMember(Name = "zipcode")]
        public string ZipCode { get; set; }
        [DataMember]
        public Coordinate Coordinate { get; set; } = Coordinate.Empty;
        public bool IsValid => !Number.IsEmpty() && !Street.IsEmpty();

        public override string ToString()
        {
            return $"{Suffix} {Street},{Number} - {District}, {City}, {State} {ZipCode}";
        }
    }
}
