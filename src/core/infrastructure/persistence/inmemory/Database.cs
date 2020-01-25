using WappaMobile.ChallengeDev.Models;

namespace WappaMobile.ChallengeDev.Persistence
{
    public static class Database
    {
        public static IDrivers Drivers = new Drivers();
        public static ICars Cars = new Cars();
    }
}
