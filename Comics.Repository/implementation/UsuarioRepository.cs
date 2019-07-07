using System.Collections.Generic;
using System.Linq;
using Comics.Entity;
using Comics.Repository.dbcontext;

namespace Comics.Repository.implementation {

    public class UsuarioRepository : IUsuarioRepository
    {
        private ApplicationDbContext context;

        public UsuarioRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public bool Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Usuario Get(int id)
        {
            var result = new Usuario();
            try
            {
                result = context.Usuarios.Single(x => x.Id == id);
            }

            catch (System.Exception)
            {

                throw;
            }
            return result;
        }

        public IEnumerable<Usuario> GetAll()
        {
            var result = new List<Usuario>();
            try
            {
                result = context.Usuarios.ToList();
            }

            catch (System.Exception)
            {

                throw;
            }
            return result;
        }

        public bool Save(Usuario entity)
        {
           try
            {
                context.Add(entity);
                context.SaveChanges();
            }
            catch (System.Exception)
            {

                return false;
            }
            return true;
        }

        public bool Update(Usuario entity)
        {
            try
            {
                 var usuarioOriginal = context.Usuarios.Single(
                     x => x.Id == entity.Id
                 );

                 usuarioOriginal.Id=entity.Id;
                 usuarioOriginal.nombres=entity.nombres;
                 usuarioOriginal.apellidos=entity.apellidos;
                 usuarioOriginal.email=entity.email;
                 usuarioOriginal.contraseña=entity.contraseña;

                 context.Update(usuarioOriginal);
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