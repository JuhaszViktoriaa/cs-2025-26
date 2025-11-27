using Microsoft.EntityFrameworkCore;
using MyApp.Backend.Models;

namespace MyApp.Backend.Context
{
    public class AppContext : DbContext
    {
        /// <summary>
        /// Termékek
        /// </summary>
        public DbSet<Product> Products { get; set; }

        public AppContext(DbContextOptions options) : base(options)
        {
        }
    }
}
