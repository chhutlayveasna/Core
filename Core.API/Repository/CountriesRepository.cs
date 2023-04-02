using Core.API.Contracts;
using Core.API.Data;
using Microsoft.EntityFrameworkCore;

namespace Core.API.Repository
{
    public class CountriesRepository : GenericRepository<Country>, ICountriesRepository
    {
        private readonly ApplicationDbContext _context;

        public CountriesRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Country> GetDetail(int id)
        {
            return await _context.Countries.Include(q => q.Hotels)
                .FirstOrDefaultAsync(q => q.Id == id);
        }
    }
}
