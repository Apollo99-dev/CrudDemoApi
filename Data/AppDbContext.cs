using Microsoft.EntityFrameworkCore;
using CrudDemoApi.Models;

namespace CrudDemoApi.Data
{
    public class AppDbContext : DbContext   // ✅ MUST inherit
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}