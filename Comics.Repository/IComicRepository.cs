using Comics.Entity;
using System.Collections.Generic;

namespace Comics.Repository
{
    public interface IComicRepository: IRepository<Comic>
    {
        IEnumerable<Comic> GetComicsByGenero (string Genero);

        IEnumerable<Comic> GetComicsByIdioma (string Idioma);

    }
}