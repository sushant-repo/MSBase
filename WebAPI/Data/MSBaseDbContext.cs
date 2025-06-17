using Microsoft.EntityFrameworkCore;

namespace WebAPI.Data
{
    public class MSBaseDbContext : DbContext
    {

        public MSBaseDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}
