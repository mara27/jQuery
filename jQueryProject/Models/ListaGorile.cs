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

        //public static List<Gorila> getAll()
        //{
        //    if (listaDeGorile == null)
        //    {
        //        listaDeGorile = new List<Gorila>()
        //        {
        //            new Gorila("Ana", 23, "o gorila portocalie"),
        //            new Gorila("Kala", 5, "goriluta mititica"),
        //            new Gorila("Balu", 12, "gorilo petrecaret")
        //        };
        //        return listaDeGorile;
        //    }
        //    else
        //    {
        //        return listaDeGorile;
        //    }
        //}

        public static List<Gorila> getAll()
        {
            if (listaDeGorile == null)
            {
                listaDeGorile = new List<Gorila>();
                Gorila g1 = new Gorila("Ana", 23, "o gorila portocalie");
                Gorila g2 = new Gorila("Kala", 5, "goriluta mititica");
                Gorila g3 = new Gorila("Balu", 12, "gorilo petrecaret");

                listaDeGorile.Add(g1);
                listaDeGorile.Add(g2);
                listaDeGorile.Add(g3);

                return listaDeGorile;
            }
            else
            {
                return listaDeGorile;
            }
        }
    }
}