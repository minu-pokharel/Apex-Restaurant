using ApexRestaurant.Repository.Domain;
using ApexRestaurant.Services.SMenu_Items;
using Microsoft.AspNetCore.Mvc;

namespace ApexRestaurant.Api.Controller
{
    [Route("api/menu_Items")]
    public class Menu_ItemsController : ControllerBase
    {

        private readonly IMenu_ItemsService _menu_ItemsService;

        public Menu_ItemsController(IMenu_ItemsService menu_ItemsService)
        {
            _menu_ItemsService = menu_ItemsService;
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult Get([FromRoute] int id)
        {
            var menu_Items = _menu_ItemsService.GetById(id);

            if (menu_Items == null)
            return NotFound();

            return Ok(menu_Items);
        }

        [HttpGet]
        [Route("")]
        public IActionResult GetAll()
        {
            var menu_Items = _menu_ItemsService.GetAll();
            return Ok(menu_Items);
        }

        [HttpPost]
        [Route("")]
        public IActionResult Post([FromBody] Menu_Items model)
        {
            _menu_ItemsService.Insert(model);

            return Ok();
        }

        [HttpPut]
        [Route("")]
        public IActionResult Put([FromBody] Menu_Items model)
        {
            _menu_ItemsService.Update(model);
            return Ok();
        }

        [HttpDelete]
        [Route("")]
        public IActionResult Delete([FromBody] Menu_Items model)
        {
            _menu_ItemsService.Delete(model);
            return Ok();
        }
    }
}