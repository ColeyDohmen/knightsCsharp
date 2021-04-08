using System.Collections.Generic;
using knights.Models;
using knights.Services;
using Microsoft.AspNetCore.Mvc;

namespace knights.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CastlesController : ControllerBase
    {


        private readonly CastlesService _service;

        public CastlesController(CastlesService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Castle>> Get()
        {
            try
            {
                return Ok(_service.Get());
            }
            catch (System.Exception err)
            {

                return BadRequest(err.Message);
            }
        }
        [HttpPost]
        public ActionResult<Castle> Create([FromBody] Castle newCastle)
        {
            try
            {
                return Ok(_service.Create(newCastle));
            }
            catch (System.Exception err)
            {

                return BadRequest(err.Message);
            }
        }
    }
}
