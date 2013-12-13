using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace jQueryProject.Models
{
    public class Gorila
    {
        public string Nume { get; set; }
        public int Varsta { get; set; }
        public string Descriere { get; set; }

        public Gorila(string nume, int varsta, string descriere) {
            Nume = nume;
            Varsta = varsta;
            Descriere = descriere;
        }

        public Gorila()
        {

        }
    }
}