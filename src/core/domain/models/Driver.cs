using System;

namespace WappaMobile.ChallengeDev.Models
{
    public class Driver : Entity
    {
        public Name Name { get; set; }
        public Car Car { get; set; }
        public Address Address { get; set; }

        public bool IsValid => Name.IsValid && Car.IsValid && Address.IsValid;

        public override string ToString()
        {
            return Name;
        }
    }
}
