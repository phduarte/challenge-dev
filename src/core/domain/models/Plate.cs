using System.Linq;

namespace WappaMobile.ChallengeDev.Models
{
    public struct Plate
    {
        string _letters;

        public string Letters { get { return _letters; } set { _letters = value.ToUpper(); } }
        public string Numbers { get; set; }

        public Plate(string placa)
        {
            _letters = placa.Substring(0, 3);
            Numbers = placa.Substring(placa.Length - 4);
        }

        public Plate(string letras, string numeros)
        {
            _letters = letras;
            Numbers = numeros;
        }

        public bool IsValid
        {
            get
            {
                return Numbers.All(x => "0123456789".Contains(x));
            }
        }

        public override string ToString()
        {
            return $"{Letters}-{Numbers}";
        }

        public static implicit operator Plate(string plate)
        {
            return new Plate(plate);
        }
    }
}