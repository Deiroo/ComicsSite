using System.Collections.Generic;
using System.Linq;
using Comics.Entity;
using Comics.Repository.dbcontext;
using Microsoft.EntityFrameworkCore;

namespace Comics.Repository.implementation {

    public class CarritoRepository : ICarritoRepository
    {
        private ApplicationDbContext context;

        public CarritoRepository(ApplicationDbContext context)
        {
            this.context = context;
        }        
        
        public bool Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Carrito Get(int id)
        {
            var result = new Carrito();
            try{
                result = context.Carritos.Single(x=>x.Id == id);
            }
            catch(System.Exception){
                throw;
            }
            return result;
        }

        public IEnumerable<Carrito> GetAll()
        {
            var result = new List<Carrito>();
            try{
                result = context.Carritos.ToList();
            }
            catch(System.Exception){
                throw;
            }
            return result;
        }

        public bool Save(Carrito entity)
        {
            Carrito carrito = new Carrito{
                cantidad = entity.cantidad,
                Usuario = entity.Usuario,
                Comic = entity.Comic
            };
            try{
                context.Carritos.Add(carrito);
                context.SaveChanges();
            }
            catch(System.Exception){
                return false;
            }
            return true;
        }

        public bool Update(Carrito entity)
        {
            try{
                var carritoOriginal = context.Carritos.Single(x=>x.Id == entity.Id);

                carritoOriginal.Id = entity.Id;
                carritoOriginal.cantidad = entity.cantidad;
                carritoOriginal.Usuario = entity.Usuario;
                carritoOriginal.Comic = entity.Comic;

                context.Update(carritoOriginal);
                context.SaveChanges();
            }
            catch(System.Exception){
                return false;
            }
            return true;
        }
    }
}