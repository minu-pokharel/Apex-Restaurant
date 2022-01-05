using ApexRestaurant.Repository.Domain;
using ApexRestaurant.Services.SRef_Staff_Roles;
using Microsoft.AspNetCore.Mvc;

namespace ApexRestaurant.Api.Controller
{
    [Route("api/Ref_Staff_Roles")]
    public class Ref_Staff_RolesController : ControllerBase
    {

        private readonly IRef_Staff_RolesService _ref_Staff_RolesService;

        public Ref_Staff_RolesController(IRef_Staff_RolesService ref_Staff_RolesService)
        {
            _ref_Staff_RolesService = ref_Staff_RolesService;
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult Get([FromRoute] int id)
        {
            var ref_Staff_Roles = _ref_Staff_RolesService.GetById(id);

            if (ref_Staff_Roles == null)
            return NotFound();

            return Ok(ref_Staff_Roles);
        }

        [HttpGet]
        [Route("")]
        public IActionResult GetAll()
        {
            var ref_staff_Roles = _ref_Staff_RolesService.GetAll();
            return Ok(ref_staff_Roles);
        }

        [HttpPost]
        [Route("")]
        public IActionResult Post([FromBody] Ref_Staff_Roles model)
        {
            _ref_Staff_RolesService.Insert(model);

            return Ok();
        }

        [HttpPut]
        [Route("")]
        public IActionResult Put([FromBody] Ref_Staff_Roles model)
        {
            _ref_Staff_RolesService.Update(model);
            return Ok();
        }

        [HttpDelete]
        [Route("")]
        public IActionResult Delete([FromBody] Ref_Staff_Roles model)
        {
            _ref_Staff_RolesService.Delete(model);
            return Ok();
        }
    }
}