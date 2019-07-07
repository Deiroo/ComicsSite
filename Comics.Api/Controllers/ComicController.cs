using Comics.Entity;
using Comics.Service;
using Microsoft.AspNetCore.Mvc;

namespace Comics.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComicController : ControllerBase
    {

        private IComicService ComicService;

        public ComicController(IComicService ComicService)
        {
            this.ComicService = ComicService;
        }

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(
                ComicService.GetAll()
            );
        }

        [HttpGet("Genero/{genero}")]
        public ActionResult GetByGenero([FromRoute] string Genero)
        {
            return Ok(
                ComicService.GetComicsByGenero(Genero)
            );
        }

        [HttpGet("Idioma/{idioma}")]
        public ActionResult GetByIdioma([FromRoute] string Idioma)
        {
            return Ok(
                ComicService.GetComicsByIdioma(Idioma)
            );
        }


        [HttpPost]
        public ActionResult Post([FromBody] Comic Comic)
        {
            return Ok(
                ComicService.Save(Comic)
            );
        }

        [HttpPut]
        public ActionResult Put([FromBody] Comic Comic)
        {
            return Ok(
                ComicService.Update(Comic)
            );
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            return Ok(
                ComicService.Delete(id)
            );
        }

    }
}


