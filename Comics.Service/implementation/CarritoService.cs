using System.Collections.Generic;
using Comics.Entity;
using Comics.Repository;

namespace Comics.Service.implementation
{
    public class CarritoService : ICarritoService
    {
        private ICarritoRepository carritoRepository;

        public CarritoService(ICarritoRepository carritoRepository)
        {
            this.carritoRepository=carritoRepository;
        }
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
