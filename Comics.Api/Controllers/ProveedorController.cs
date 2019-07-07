using Comics.Entity;
using Comics.Service;
using Microsoft.AspNetCore.Mvc;

namespace Comics.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProveedorController : ControllerBase
    {

        private IProveedorService ProveedorService;

        public ProveedorController(IProveedorService ProveedorService)
        {
            this.ProveedorService = ProveedorService;
        }

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(
                ProveedorService.GetAll()
            );
        }

        [HttpPost]
        public ActionResult Post([FromBody] Proveedor Proveedor)
        {
            return Ok(
                ProveedorService.Save(Proveedor)
            );
        }

        [HttpPut]
        public ActionResult Put([FromBody] Proveedor Proveedor)
        {
            return Ok(
                ProveedorService.Update(Proveedor)
            );
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            return Ok(
                ProveedorService.Delete(id)
            );
        }

    }
}


