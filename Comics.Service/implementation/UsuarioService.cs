using System.Collections.Generic;
using Comics.Entity;
using Comics.Repository;

namespace Comics.Service.implementation
{
    public class UsuarioService : IUsuarioService
    {
        private IUsuarioRepository UsuarioRepository;

        public UsuarioService(IUsuarioRepository UsuarioRepository)
        {
            this.UsuarioRepository=UsuarioRepository;
        }

        public bool Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Usuario Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Usuario> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public bool Save(Usuario entity)
        {
            throw new System.NotImplementedException();
        }

        public bool Update(Usuario entity)
        {
            throw new System.NotImplementedException();
        }
    }
}


