using INDATAProject.Models;
using Microsoft.EntityFrameworkCore;

namespace INDATAProject.Repository
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }


        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
