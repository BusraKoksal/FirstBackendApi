using Microsoft.EntityFrameworkCore;
using FirstBackendApi.Entities;
namespace FirstBackendApi.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
            { }
        public DbSet<Home>Homes
        { get; set; }
    }
}
