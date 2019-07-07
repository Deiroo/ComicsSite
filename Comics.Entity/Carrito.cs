using System;

namespace Comics.Entity
{
    public class Carrito
    {
        public int Id {get;set;}
        public int cantidad {get;set;}

        public Usuario Usuario{get;set;}

        public Comic Comic{get;set;}
    }
}
