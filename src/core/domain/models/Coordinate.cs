using System.Runtime.Serialization;

namespace WappaMobile.ChallengeDev.Models
{
    [DataContract]
    public struct Coordinate
    {
        [DataMember]
        public double Latitude, Longitude;

        public bool IsEmpty => Latitude == 0 && Longitude == 0;

        public Coordinate(double lat, double lng)
        {
            Latitude = lat;
            Longitude = lng;
        }

        public static Coordinate Empty => new Coordinate(0, 0);

        public override string ToString()
        {
            return $"{Latitude}x{Longitude}";
        }
    }
}
