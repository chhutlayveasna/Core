using Core.API.Data;

namespace Core.API.Contracts
{
    public interface ICountriesRepository : IGenericRepository<Country>
    {
        Task<Country> GetDetail(int id);
    }
}
