using System.Collections.Generic;
using System.Linq;
using Comics.Entity;
using Comics.Repository.dbcontext;
using Microsoft.EntityFrameworkCore;

namespace Comics.Repository.implementation {

    public class ProveedorRepository : IProveedorRepository
    {
        public bool Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Proveedor Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Proveedor> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public bool Save(Proveedor entity)
        {
            throw new System.NotImplementedException();
        }

        public bool Update(Proveedor entity)
        {
            throw new System.NotImplementedException();
        }
    }
}