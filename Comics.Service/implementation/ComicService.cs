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
            return ComicRepository.GetAll();
        }

        public IEnumerable<Comic> GetComicsByGenero(string Genero)
        {
            return ComicRepository.GetComicsByGenero(Genero);
        }

        public IEnumerable<Comic> GetComicsByIdioma(string Idioma)
        {
            return ComicRepository.GetComicsByIdioma(Idioma);
        }

        public bool Save(Comic entity)
        {
            return ComicRepository.Save(entity);
        }

        public bool Update(Comic entity)
        {
            throw new System.NotImplementedException();
        }
    }
}


