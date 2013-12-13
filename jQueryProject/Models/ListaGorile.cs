using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace jQueryProject.Models
{
    public static class ListaGorile
    {
        public static List<Gorila> listaDeGorile = new List<Gorila>()
        {
            new Gorila("Ana", 23, "o gorila portocalie"),
            new Gorila("Kala", 5, "goriluta mititica"),
            new Gorila("Balu", 12, "gorilo petrecaret")
        };
    }
}