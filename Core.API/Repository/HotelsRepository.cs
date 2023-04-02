using Core.API.Contracts;
using Core.API.Data;

namespace Core.API.Repository
{
    public class HotelsRepository : GenericRepository<Hotel>, IHotelsRepository
    {
        public HotelsRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
