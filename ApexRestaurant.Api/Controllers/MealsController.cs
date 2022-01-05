using ApexRestaurant.Repository.Domain;
using ApexRestaurant.Services.SMeals;
using Microsoft.AspNetCore.Mvc;

namespace ApexRestaurant.Api.Controller
{
    [Route("api/meals")]
    public class MealsController : ControllerBase
    {

        private readonly IMealsService _mealsService;

        public MealsController(IMealsService mealsService)
        {
            _mealsService = mealsService;
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult Get([FromRoute] int id)
        {
            var meals = _mealsService.GetById(id);

            if (meals == null)
            return NotFound();

            return Ok(meals);
        }

        [HttpGet]
        [Route("")]
        public IActionResult GetAll()
        {
            var meals = _mealsService.GetAll();
            return Ok(meals);
        }

        [HttpPost]
        [Route("")]
        public IActionResult Post([FromBody] Meals model)
        {
            _mealsService.Insert(model);

            return Ok();
        }

        [HttpPut]
        [Route("")]
        public IActionResult Put([FromBody] Meals model)
        {
            _mealsService.Update(model);
            return Ok();
        }

        [HttpDelete]
        [Route("")]
        public IActionResult Delete([FromBody] Meals model)
        {
            _mealsService.Delete(model);
            return Ok();
        }
    }
}