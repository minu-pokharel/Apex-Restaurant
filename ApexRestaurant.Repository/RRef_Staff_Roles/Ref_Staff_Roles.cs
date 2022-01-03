using ApexRestaurant.Repository.Domain;
using Microsoft.EntityFrameworkCore;

namespace ApexRestaurant.Repository
{
    public class Ref_Staff_RolesRepository : GenericRepository<Ref_Staff_Roles>, IRef_Staff_RolesRepository
    {
        public Ref_Staff_RolesRepository(RestaurantContext dbContext)
        {
            DbContext = dbContext;
        }
    }
}