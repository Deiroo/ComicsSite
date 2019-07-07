using System;

namespace Comics.Entity
{
    public class Genero
    {
        public int Id{get;set;}

        public string nombre{get;set;}

        public Genero subGenero{get;set;}
    }
}
