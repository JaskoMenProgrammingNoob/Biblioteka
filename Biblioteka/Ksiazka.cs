using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteka
{
    public class Ksiazka
    {
        public required string ISBN { get; set; }
        public required string Tytul { get; set; }
        public required string Autor { get; set; }
        public required string Opis { get; set; }
        public required string Gatunek { get; set; }
        public required bool Uszkodzona { get; set; }

        public string Ksiega;
        public static int liczbaKsiazek = 0;
       public Ksiazka (string ksiega)
        {
            Ksiega = ksiega;


            liczbaKsiazek++;

        }
        
    }
    
}