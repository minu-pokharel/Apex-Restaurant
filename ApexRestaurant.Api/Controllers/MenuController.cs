using ApexRestaurant.Repository.Domain;
using ApexRestaurant.Services.SMenu;
using Microsoft.AspNetCore.Mvc;

namespace ApexRestaurant.Api.Controller
{
    [Route("api/menu")]
    public class MenuController : ControllerBase
    {

        private readonly IMenuService _menuService;

        public MenuController(IMenuService menuService)
        {
            _menuService = menuService;
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult Get([FromRoute] int id)
        {
            var menu = _menuService.GetById(id);

            if (menu == null)
            return NotFound();

            return Ok(menu);
        }

        [HttpGet]
        [Route("")]
        public IActionResult GetAll()
        {
            var menu = _menuService.GetAll();
            return Ok(menu);
        }

        [HttpPost]
        [Route("")]
        public IActionResult Post([FromBody] Menu model)
        {
            _menuService.Insert(model);

            return Ok();
        }

        [HttpPut]
        [Route("")]
        public IActionResult Put([FromBody] Menu model)
        {
            _menuService.Update(model);
            return Ok();
        }

        [HttpDelete]
        [Route("")]
        public IActionResult Delete([FromBody] Menu model)
        {
            _menuService.Delete(model);
            return Ok();
        }
    }
}