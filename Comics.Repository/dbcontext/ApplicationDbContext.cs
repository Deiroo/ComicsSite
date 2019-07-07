using Comics.Entity;
using Microsoft.EntityFrameworkCore;


namespace Comics.Repository.dbcontext {

    public class ApplicationDbContext : DbContext {
        public DbSet<Comic> Comics {get;set;}

        public DbSet<Genero> Generos {get;set;}

        public DbSet<Proveedor> Proveedores {get;set;}

        public DbSet<Usuario> Usuarios {get;set;}

        public DbSet<Carrito> Carritos {get;set;}
        
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) : base (options) {

        }
        
    }
}