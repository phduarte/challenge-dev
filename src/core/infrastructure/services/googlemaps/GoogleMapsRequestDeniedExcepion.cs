using System;
using System.Runtime.Serialization;

namespace WappaMobile.ChallengeDev.GoogleMaps
{
    [Serializable]
    internal class GoogleMapsRequestDeniedExcepion : Exception
    {
        public GoogleMapsRequestDeniedExcepion()
        {
        }

        public GoogleMapsRequestDeniedExcepion(string message) : base(message)
        {
        }

        public GoogleMapsRequestDeniedExcepion(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected GoogleMapsRequestDeniedExcepion(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}