using ApexRestaurant.Repository.Domain;
using ApexRestaurant.Repository;

namespace ApexRestaurant.Services.SMeal_Dishes
{
    public class Meal_DishesService : GenericService<Meal_Dishes>, IMeal_DishesService
    {
        public Meal_DishesService(IMeal_DishesRepository meal_DishesRepository) :
        base(meal_DishesRepository)
        {

        }
    }
}