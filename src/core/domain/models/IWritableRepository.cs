using System;

namespace WappaMobile.ChallengeDev.Models
{
    /// <summary>
    /// SOLID principle of Segregation of Interfaces
    /// </summary>
    /// <typeparam name="T">A DomainModel entity</typeparam>
    public interface IWritableRepository<T> where T : Entity
    {
        void Add(T entity);
        void Save(T entity);
        void Remove(Guid id);
    }
}
