using System.Collections.Generic;
using Comics.Entity;

namespace Comics.Service
{

    public interface IComicService : IService<Comic>
    {

        IEnumerable<Comic> GetComicsByGenero (string Genero);

        IEnumerable<Comic> GetComicsByIdioma (string Idioma);
    }
}