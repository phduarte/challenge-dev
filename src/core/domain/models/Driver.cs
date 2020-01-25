using System.Runtime.Serialization;

namespace WappaMobile.ChallengeDev.Models
{
    [DataContract]
    public class Driver : Entity
    {
        [DataMember]
        public Name Name { get; set; }
        [DataMember]
        public Car Car { get; set; }
        [DataMember]
        public Address Address { get; set; }

        public bool IsValid => Name.IsValid && Car.IsValid && Address.IsValid;

        public override string ToString()
        {
            return Name;
        }
    }
}
