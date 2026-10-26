using Biblioteka;
using System.Security.Cryptography.X509Certificates;

class Program
{




    static void Main(string[] args)
    {

        Ksiazka ksiazka = new Ksiazka("Księga główna")
        {
            ISBN = "0000000000001",
            Tytul = "Hobbit: Tam i z powrotem",
            Autor = "John Tolkien",
            Opis = "Opowieść o hobbitach",
            Gatunek = "Fantasy",

            Uszkodzona = false
        };
        Ksiazka ksiazka1 = new Ksiazka("Księga główna")
        {
            ISBN = "0000000000002",
            Tytul = "Hobbit: Pustkowie Smauga",
            Autor = "John Tolkien",
            Opis = "Opowieść o smokach",
            Gatunek = "Fantasy",

            Uszkodzona = false
        };

        
        
        
        

        
        Biblio biblio = new Biblio();

        biblio.Zbior.Add((ksiazka));
        biblio.Zbior.Add((ksiazka1)); 

        
        foreach (Ksiazka ksiazki in biblio.Zbior)
        { 
            Console.WriteLine($"ISBN: {ksiazki.ISBN}");
            Console.WriteLine($"Tytuł: {ksiazki.Tytul}");
            Console.WriteLine($"Autor: {ksiazki.Autor}");
            Console.WriteLine($"Opis: {ksiazki.Opis}");
            Console.WriteLine($"Gatunek: {ksiazki.Gatunek}");
            Console.WriteLine($"Uszkodzona: {ksiazki.Uszkodzona}");
            
            Console.WriteLine();

        }
        Console.WriteLine($"Liczba książek w zbiorze: {Ksiazka.liczbaKsiazek}");
    }
}
