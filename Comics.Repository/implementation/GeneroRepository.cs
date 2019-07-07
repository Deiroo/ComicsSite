using System.Collections.Generic;
using System.Linq;
using Comics.Entity;
using Comics.Repository.dbcontext;
using Microsoft.EntityFrameworkCore;

namespace Comics.Repository.implementation {

    public class GeneroRepository : IGeneroRepository
    {
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