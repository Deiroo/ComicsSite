using Comics.Entity;
using Comics.Service;
using Microsoft.AspNetCore.Mvc;

namespace Hospital.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GeneroController : ControllerBase
    {

        private IGeneroService GeneroService;

        public GeneroController(IGeneroService GeneroService)
        {
            this.GeneroService = GeneroService;
        }

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(
                GeneroService.GetAll()
            );
        }

        [HttpPost]
        public ActionResult Post([FromBody] Genero Genero)
        {
            return Ok(
                GeneroService.Save(Genero)
            );
        }

        [HttpPut]
        public ActionResult Put([FromBody] Genero Genero)
        {
            return Ok(
                GeneroService.Update(Genero)
            );
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            return Ok(
                GeneroService.Delete(id)
            );
        }

    }
}

