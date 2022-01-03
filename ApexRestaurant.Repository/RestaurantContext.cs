using Microsoft.EntityFrameworkCore;
using ApexRestaurant.Repository.Domain;

namespace ApexRestaurant.Repository
{
    public class RestaurantContext : DbContext
    {

        public RestaurantContext(DbContextOptions<RestaurantContext> options) : base(options)
        {
        }

        public DbSet<Customer> Customers {get; set;}
        public DbSet<Customer> Menu {get; set;}
        public DbSet<Customer> Menu_Items {get; set;}
        public DbSet<Customer> Meals {get; set;}
        public DbSet<Customer> Meal_Dishes {get; set;}
        public DbSet<Customer> Staff {get; set;}
        public DbSet<Customer> Ref_Staff_Roles {get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}