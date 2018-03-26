using Microsoft.EntityFrameworkCore;
 
namespace Ecommerce.Models
{
    public class StoreContext : DbContext
    {
        // base() calls the parent class' constructor passing the "options" parameter along
        public StoreContext(DbContextOptions<StoreContext> options) : base(options) { }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}