using System.Collections.Generic;
using Comics.Entity;
using Comics.Repository;

namespace Comics.Service.implementation
{
    public class ComicService : IComicService
    {
        private IComicRepository ComicRepository;

        public ComicService(IComicRepository ComicRepository)
        {
            this.ComicRepository=ComicRepository;
        }

        public bool Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Comic Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Comic> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Comic> GetComicsByGenero(string Genero)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Comic> GetComicsByIdioma(string Idioma)
        {
            throw new System.NotImplementedException();
        }

        public bool Save(Comic entity)
        {
            throw new System.NotImplementedException();
        }

        public bool Update(Comic entity)
        {
            throw new System.NotImplementedException();
        }
    }
}


