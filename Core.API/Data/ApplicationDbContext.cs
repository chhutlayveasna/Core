using Microsoft.EntityFrameworkCore;

namespace Core.API.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions options): base(options)
        {
        }
    }
}
