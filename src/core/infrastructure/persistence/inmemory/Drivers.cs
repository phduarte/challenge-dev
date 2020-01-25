using System.Linq;
using WappaMobile.ChallengeDev.Models;

namespace WappaMobile.ChallengeDev.Persistence
{
    internal class Drivers : Repository<Driver>, IDrivers
    {
        public Driver Find(Name name)
        {
            return _cache.First(x => x.Name.Equals(name));
        }
    }
}