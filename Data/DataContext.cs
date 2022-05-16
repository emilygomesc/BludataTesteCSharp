using BludataAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace BludataAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
        : base(options)

        {
        }

        public DbSet<Company> Companies { get; set; }
        public DbSet<Provider> Providers { get; set; }
        public DbSet<Phone> Phones { get; set; }
    }
}
