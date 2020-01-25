namespace WappaMobile.ChallengeDev.Models
{
    /// <summary>
    /// I could use the name ICarRepository or ICarsRepository, but that doesn't make sense in this case, 
    /// as it is better to take advantage of the omnipresent language tip and keep names relevant to the 
    /// problem domain and not pollute the domain with technical terms.
    /// </summary>
    public interface ICars : IRepository<Car>
    {
        Car Find(Plate placa);
    }
}
