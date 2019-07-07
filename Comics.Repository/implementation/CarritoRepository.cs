using System.Collections.Generic;
using System.Linq;
using Comics.Entity;
using Comics.Repository.dbcontext;
using Microsoft.EntityFrameworkCore;

namespace Comics.Repository.implementation {

    public class CarritoRepository : ICarritoRepository
    {
        public bool Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Carrito Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Carrito> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public bool Save(Carrito entity)
        {
            throw new System.NotImplementedException();
        }

        public bool Update(Carrito entity)
        {
            throw new System.NotImplementedException();
        }
    }
}