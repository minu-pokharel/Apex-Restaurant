using ApexRestaurant.Repository.Domain;
using Microsoft.EntityFrameworkCore;

namespace ApexRestaurant.Repository
{
    public class CustomerRepository : GenericRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(RestaurantContext dbContext)
        {
            DbContext = dbContext;
        }
    }
}