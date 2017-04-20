using Gab.Models;
using Microsoft.EntityFrameworkCore;

namespace Gab.Data
{
    public class AppDataContext : DbContext
    {
        public AppDataContext(DbContextOptions<AppDataContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Cart> Cart { get; set; }
    }
}