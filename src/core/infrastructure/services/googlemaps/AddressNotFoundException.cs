using System;
using System.Runtime.Serialization;
using WappaMobile.ChallengeDev.Models;

namespace WappaMobile.ChallengeDev.GoogleMaps
{
    [Serializable]
    public class AddressNotFoundException : Exception
    {
        public Address Address { get; }

        public AddressNotFoundException(Address address) : base("Check the address.")
        {
            Address = address;
        }

        public AddressNotFoundException(string message) : base(message)
        {
        }

        public AddressNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected AddressNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}