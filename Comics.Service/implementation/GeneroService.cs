using System.Collections.Generic;
using Comics.Entity;
using Comics.Repository;

namespace Comics.Service.implementation
{
    public class GeneroService : IGeneroService
    {
        private IGeneroRepository generoRepository;

        public GeneroService(IGeneroRepository generoRepository)
        {
            this.generoRepository=generoRepository;
        }

        public bool Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Genero Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Genero> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public bool Save(Genero entity)
        {
            throw new System.NotImplementedException();
        }

        public bool Update(Genero entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
