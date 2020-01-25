using System.Linq;
using WappaMobile.ChallengeDev.Models;

namespace WappaMobile.ChallengeDev.Persistence
{
    internal class Cars : Repository<Car>, ICars
    {
        public Car Find(Plate plate)
        {
            return _cache.First(x => x.Plate.Equals(plate));
        }
    }
}