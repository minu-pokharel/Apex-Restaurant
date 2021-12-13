using Microsoft.EntityFrameworkCore;
using ApexRestaurant.Repository.Domain;

namespace ApexRestaurant.Repository
{
    public class NewBaseType
    {
        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }

    public class RestaurantContext : NewBaseType, DbContext
    {

        public RestaurantContext(DbContextOptions<RestaurantContext> options) :
        base(options)
        {
        }
    }
}