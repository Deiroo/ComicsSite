using Comics.Entity;
using Comics.Service;
using Microsoft.AspNetCore.Mvc;

namespace Hospital.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarritoController : ControllerBase
    {

        private ICarritoService CarritoService;

        public CarritoController(ICarritoService CarritoService)
        {
            this.CarritoService = CarritoService;
        }

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(
                CarritoService.GetAll()
            );
        }

        [HttpPost]
        public ActionResult Post([FromBody] Carrito Carrito)
        {
            return Ok(
                CarritoService.Save(Carrito)
            );
        }

        [HttpPut]
        public ActionResult Put([FromBody] Carrito Carrito)
        {
            return Ok(
                CarritoService.Update(Carrito)
            );
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            return Ok(
                CarritoService.Delete(id)
            );
        }

    }
}


