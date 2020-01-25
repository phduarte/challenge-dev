namespace WappaMobile.ChallengeDev.Models
{
    public class Car : Entity
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public Plate Plate { get; set; }
        public bool IsValid => Plate.IsValid && !Model.IsEmpty();

        public override string ToString()
        {
            return $"{Brand} {Model} - {Plate}";
        }
    }
}
