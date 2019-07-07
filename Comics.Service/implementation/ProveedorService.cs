using System.Collections.Generic;
using Comics.Entity;
using Comics.Repository;

namespace Comics.Service.implementation
{
    public class ProveedorService : IProveedorService
    {
        private IProveedorRepository ProveedorRepository;

        public ProveedorService(IProveedorRepository ProveedorRepository)
        {
            this.ProveedorRepository=ProveedorRepository;
        }

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


