using System.Runtime.Serialization;

namespace WappaMobile.ChallengeDev.Models
{
    [DataContract]
    public class Car : Entity
    {
        [DataMember]
        public string Brand { get; set; }
        [DataMember] 
        public string Model { get; set; }
        [DataMember] 
        public Plate Plate { get; set; }
        public bool IsValid => Plate.IsValid && !Model.IsEmpty();

        public override string ToString()
        {
            return $"{Brand} {Model} - {Plate}";
        }
    }
}
