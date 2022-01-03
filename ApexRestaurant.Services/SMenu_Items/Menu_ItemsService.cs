using ApexRestaurant.Repository.Domain;
using ApexRestaurant.Repository;

namespace ApexRestaurant.Services.SMenu_Items
{
    public class Menu_ItemsService : GenericService<Menu_Items>, IMenu_ItemsService
    {
        public Menu_ItemsService(IMenu_ItemsRepository menu_ItemsRepository) :
        base(menu_ItemsRepository)
        {

        }
    }
}