using System;
using System.Collections.Generic;

namespace WappaMobile.ChallengeDev.Models
{
    /// <summary>
    /// SOLID principle of Segregation of Interfaces
    /// </summary>
    /// <typeparam name="T">A DomainModel entity</typeparam>
    public interface IReadOnlyRepository<T> where T : Entity
    {
        IEnumerable<T> GetAll();
        T Get(Guid id);
    }
}
