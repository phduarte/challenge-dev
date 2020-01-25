using System;
using System.Collections.Generic;
using System.Linq;
using WappaMobile.ChallengeDev.Models;

namespace WappaMobile.ChallengeDev.Persistence
{
    internal abstract class Repository<T> where T : Entity
    {
        protected readonly List<T> _cache = new List<T>();

        public T Get(Guid id)
        {
            return _cache.FirstOrDefault(x => x.Id.Equals(id));
        }

        public void Remove(Guid id)
        {
            var x = Get(id);
            _cache.Remove(x);
        }

        public IEnumerable<T> GetAll()
        {
            return _cache;
        }

        public void Add(T entidade)
        {
            _cache.Add(entidade);
        }

        public void Save(T entidade)
        {
            Remove(entidade.Id);
            Add(entidade);
        }
    }
}