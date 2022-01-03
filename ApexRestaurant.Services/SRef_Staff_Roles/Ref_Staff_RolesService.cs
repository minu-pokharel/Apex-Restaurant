using ApexRestaurant.Repository.Domain;
using ApexRestaurant.Repository;

namespace ApexRestaurant.Services.SRef_Staff_Roles
{
    public class Ref_Staff_RolesService : GenericService<Ref_Staff_Roles>, IRef_Staff_RolesService
    {
        public Ref_Staff_RolesService(IRef_Staff_RolesRepository ref_Staff_RolesRepository) :
        base(ref_Staff_RolesRepository)
        {

        }
    }
}