using Argos.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Web.Resource;

namespace ArgosWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoutesController : Controller
    {
        ITravelRoutesService _service;
        public RoutesController(ITravelRoutesService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("GetAllTravelRoutes")]
        public IActionResult GetRoutes()
        {
            var data = _service.GetAll();
            return Ok(data);
        }
    }
}
