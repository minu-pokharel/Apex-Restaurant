using ApexRestaurant.Repository.Domain;
using ApexRestaurant.Services.SMeal_Dishes;
using Microsoft.AspNetCore.Mvc;

namespace ApexRestaurant.Api.Controller
{
    [Route("api/meal_Dishes")]
    public class Meal_DishesController : ControllerBase
    {

        private readonly IMeal_DishesService _meal_DishesService;

        public Meal_DishesController(IMeal_DishesService meal_DishesService)
        {
            _meal_DishesService = meal_DishesService;
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult Get([FromRoute] int id)
        {
            var meal_Dishes = _meal_DishesService.GetById(id);

            if (meal_Dishes == null)
            return NotFound();

            return Ok(meal_Dishes);
        }

        [HttpGet]
        [Route("")]
        public IActionResult GetAll()
        {
            var meal_Dishes = _meal_DishesService.GetAll();
            return Ok(meal_Dishes);
        }

        [HttpPost]
        [Route("")]
        public IActionResult Post([FromBody] Meal_Dishes model)
        {
            _meal_DishesService.Insert(model);

            return Ok();
        }

        [HttpPut]
        [Route("")]
        public IActionResult Put([FromBody] Meal_Dishes model)
        {
            _meal_DishesService.Update(model);
            return Ok();
        }

        [HttpDelete]
        [Route("")]
        public IActionResult Delete([FromBody] Meal_Dishes model)
        {
            _meal_DishesService.Delete(model);
            return Ok();
        }
    }
}