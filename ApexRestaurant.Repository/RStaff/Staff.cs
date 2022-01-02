using ApexRestaurant.Repository.Domain;
using Microsoft.EntityFrameworkCore;

namespace ApexRestaurant.Repository
{
    public class MealsRepository : GenericRepository<Meals>, IMealsRepository
    {
        public MealsRepository(RestaurantContext dbContext)
        {
            DbContext = dbContext;
        }
    }
}