using S7Backend.Database.Models;
using Microsoft.EntityFrameworkCore;

namespace S7Backend.Database.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<User> users { get; set; }
    }
}
