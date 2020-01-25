using System;
using System.Linq;

namespace WappaMobile.ChallengeDev.Models
{
    /// <summary>
    /// This struct is a design pattern's implementation of Primite Obsession
    /// </summary>
    public struct Name
    {
        public string FirstName, LastName;
        public string FullName => $"{FirstName} {LastName}";

        public bool IsValid => !FullName.IsEmpty();

        public Name(string first, string last)
        {
            if (string.IsNullOrEmpty(first) || !Check.IsLetter(first))
                throw new ArgumentException(nameof(first));

            if (string.IsNullOrEmpty(last) || !Check.IsLetter(last))
                throw new ArgumentException(nameof(last));

            FirstName = first;
            LastName = last;
        }

        public Name(string fullname)
        {
            if (string.IsNullOrEmpty(fullname) || !Check.IsLetter(fullname))
                throw new ArgumentException(nameof(fullname));

            var pieces = fullname.Split(' ');

            LastName = string.Empty;

            if (pieces.Length == 1)
            {
                FirstName = pieces[0];
            }
            else if (pieces.Length == 2)
            {
                FirstName = pieces[0];
                LastName = pieces[1];
            }
            else if (pieces.Length == 4)
            {
                FirstName = $"{pieces[0]} {pieces[1]}";
                LastName = $"{pieces[2]} {pieces[3]}";
            }
            else
            {
                FirstName = pieces[0];
                LastName = string.Join(" ", pieces.Skip(1));
            }
        }

        public override bool Equals(object obj)
        {
            return ToString().Equals(obj.ToString());
        }

        public override int GetHashCode()
        {
            return FullName.GetHashCode();
        }

        public override string ToString()
        {
            return FullName;
        }

        public static implicit operator string(Name name)
        {
            return name.FullName;
        }

        public static implicit operator Name(string name)
        {
            return new Name(name);
        }
    }
}
