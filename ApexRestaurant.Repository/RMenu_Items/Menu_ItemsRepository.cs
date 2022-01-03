using ApexRestaurant.Repository.Domain;
using Microsoft.EntityFrameworkCore;

namespace ApexRestaurant.Repository
{
    public class Menu_ItemsRepository : GenericRepository<Menu_Items>, IMenu_ItemsRepository
    {
        public Menu_ItemsRepository(RestaurantContext dbContext)
        {
            DbContext = dbContext;
        }
    }
}