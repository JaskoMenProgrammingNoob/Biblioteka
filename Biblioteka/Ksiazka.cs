using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteka
{
    public class Ksiazka
    {
        public string ISBN { get; set; }
        public string Tytul { get; set; }
        public string Autor { get; set; }
        public string Opis { get; set; }
        public string Gatunek { get; set; }
        public bool Uszkodzona { get; set; }

        public string Ksiega;
        public static int liczbaKsiazek = 0;
       public Ksiazka (string ksiega)
        {
            Ksiega = ksiega;


            liczbaKsiazek++;

        }
        
    }
    
}