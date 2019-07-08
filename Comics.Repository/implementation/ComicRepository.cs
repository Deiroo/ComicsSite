using System.Collections.Generic;
using System.Linq;
using Comics.Entity;
using Comics.Repository.dbcontext;
using Microsoft.EntityFrameworkCore;

namespace Comics.Repository.implementation {

    public class ComicRepository : IComicRepository
    {

        private ApplicationDbContext context;
        public ComicRepository (ApplicationDbContext context) {
            this.context = context;
        }
        public bool Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Comic Get(int id)
        {
            var result = new Comic();
            try
            {
                result = context.Comics.Single(x => x.Id == id);
            }

            catch (System.Exception)
            {

                throw;
            }
            return result;
        }

        public IEnumerable<Comic> GetAll()
        {
            var result = new List<Comic>();
            try
            {
                result = context.Comics.ToList();
            }

            catch (System.Exception)
            {

                throw;
            }
            return result;
        }

        public IEnumerable<Comic> GetComicsByGenero(string GeneroA)
        {
            var result = new List<Comic>();
            try{
                result = context.Comics
                .Include(c => c.Genero)
                .OrderByDescending(c=>c.Id)
                .Take(10)
                .Where(c => c.Genero.nombre == GeneroA)
                .ToList();
            } catch (System.Exception){
                throw;
            }
            return result;

        }

        public IEnumerable<Comic> GetComicsByIdioma(string Idioma)
        {
            var result = new List<Comic>();
            try{
                result = context.Comics
                .OrderByDescending(c=>c.Id)
                .Take(10)
                .Where(c => c.idioma == Idioma)
                .ToList();
            } catch (System.Exception){
                throw;
            }
            return result;
        }

        public bool Save(Comic entity)
        {
            Comic comic = new Comic{
                nombre = entity.nombre,
                fechaPublicacion = entity.fechaPublicacion,
                fechaRegistro = entity.fechaRegistro,
                idioma = entity.idioma,
                GeneroId =entity.GeneroId,
                ProveedorId = entity.ProveedorId
            };
            try
            {
                context.Comics.Add(comic);
                context.SaveChanges();
            }
            catch (System.Exception)
            {

                return false;
            }
            return true;
        }

        public bool Update(Comic entity)
        {
            try
            {
                 var comicOriginal = context.Comics.Single(
                     x => x.Id == entity.Id
                 );

                 comicOriginal.Id=entity.Id;
                 comicOriginal.nombre=entity.nombre;
                 comicOriginal.fechaPublicacion=entity.fechaPublicacion;
                 comicOriginal.fechaRegistro=entity.fechaRegistro;
                 comicOriginal.ProveedorId=entity.ProveedorId;
                 comicOriginal.idioma=entity.idioma;
                 comicOriginal.GeneroId=entity.GeneroId;

                 context.Update(comicOriginal);
                 context.SaveChanges();
            }
            catch (System.Exception)
            {
                
                return false;
            }
            return true;
        }
    }

}