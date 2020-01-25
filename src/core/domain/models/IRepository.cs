namespace WappaMobile.ChallengeDev.Models
{
    public interface IRepository<T> : IReadOnlyRepository<T>, IWritableRepository<T> where T : Entity
    {
    }
}
