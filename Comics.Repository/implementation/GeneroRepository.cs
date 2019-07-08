using System.Collections.Generic;
using System.Linq;
using Comics.Entity;
using Comics.Repository.dbcontext;
using Microsoft.EntityFrameworkCore;

namespace Comics.Repository.implementation {

    public class GeneroRepository : IGeneroRepository
    {
        private ApplicationDbContext context;
        public GeneroRepository(ApplicationDbContext context){
            this.context=context;
        }
        public bool Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Genero Get(int id)
        {
            var result = new Genero();
            try{
                result = context.Generos.Single(x=>x.Id == id);
            }
            catch(System.Exception){
                throw;
            }
            return result;
        }

        public IEnumerable<Genero> GetAll()
        {
            var result = new List<Genero>();
            try{
                result = context.Generos.ToList();
            }
            catch(System.Exception){
                throw;
            }
            return result;
        }

        public bool Save(Genero entity)
        {
            try{
                context.Add(entity);
                context.SaveChanges();
            }
            catch(System.Exception){
                return false;
            }
            return true;
        }

        public bool Update(Genero entity)
        {
            try{
                var generoOriginal = context.Generos.Single(x=>x.Id == entity.Id);

                generoOriginal.Id = entity.Id;
                generoOriginal.nombre = entity.nombre;
                generoOriginal.subGenero = entity.subGenero;

                context.Update(generoOriginal);
                context.SaveChanges();
            }
            catch(System.Exception){
                return false;
            }
            return true;
        }
    }

}