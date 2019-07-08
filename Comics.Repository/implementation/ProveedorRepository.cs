using System.Collections.Generic;
using System.Linq;
using Comics.Entity;
using Comics.Repository.dbcontext;
using Microsoft.EntityFrameworkCore;

namespace Comics.Repository.implementation {

    public class ProveedorRepository : IProveedorRepository
    {
         private ApplicationDbContext context;

        public ProveedorRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public bool Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Proveedor Get(int id)
        {
            var result = new Proveedor();
            try{
                result = context.Proveedores.Single(x=>x.Id == id);
            }
            catch(System.Exception){
                throw;
            }
            return result;
        }

        public IEnumerable<Proveedor> GetAll()
        {
            var result = new List<Proveedor>();
            try{
                result = context.Proveedores.ToList();
            }
            catch(System.Exception){
                throw;
            }
            return result;
        }

        public bool Save(Proveedor entity)
        {
            try{
                context.Add(entity);
                context.SaveChanges();
            }
            catch(System.Exception){
                throw;
            }
            return true;
        }

        public bool Update(Proveedor entity)
        {
            try{
                var proveedorOriginal = context.Proveedores.Single(x=>x.Id == entity.Id);
                
                proveedorOriginal.Id = entity.Id;
                proveedorOriginal.nombre = entity.nombre;
                proveedorOriginal.direccion = entity.direccion;

                context.Update(proveedorOriginal);
                context.SaveChanges();
            }    
            catch(System.Exception){
                return false;
            }
            return true;
        }
    }
}