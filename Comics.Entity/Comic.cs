using System;

namespace Comics.Entity
{
    public class Comic
    {
        public int Id{get;set;}

        public string nombre{get;set;}

        public DateTime fechaPublicacion{get;set;}

        public DateTime fechaRegistro{get;set;}

        public string idioma{get;set;}

        public int GeneroId{get;set;}

        public int ProveedorId{get;set;}

        public Genero Genero {get;set;}
        public Proveedor Proveedor {get;set;}
    }
}
