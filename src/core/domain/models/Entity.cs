using System;

namespace WappaMobile.ChallengeDev.Models
{
    public class Entity
    {
        public Guid Id { get; set; }

        public Entity()
        {
            Id = Guid.NewGuid();
        }

        public override bool Equals(object obj)
        {
            if(obj is Entity e)
                return e.Id.Equals(Id);

            return false;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        public override string ToString()
        {
            return Id.ToString();
        }
    }
}
