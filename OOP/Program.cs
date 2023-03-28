using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CRUD --> Create, Read, Update, Delete

            //Strutte per contenere i dati
            List<Libro> libreria = new List<Libro>();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("1- Inserimento nuovo libro");
                Console.WriteLine("2- Stampa elenco libro");
                Console.WriteLine("3- Stampa numero di libri");
                Console.WriteLine("4- Ricerca libro");
                Console.WriteLine("5- Stampa libri in ordine alfabetico di autore");
                Console.WriteLine("\n9- Esci");

                string scelta = Console.ReadLine();

                if (scelta == "1")
                {
                    Console.Write("Inserire il titolo: ");
                    string titolo = Console.ReadLine();

                    Console.Write("Inserire l'autore: ");
                    string autore = Console.ReadLine();

                    float prezzoFloat;
                    string prezzo;

                    do
                    {
                        Console.Write("Inserire il prezzo: ");
                        prezzo = Console.ReadLine();

                    } while (!float.TryParse(prezzo, out prezzoFloat));

                    libreria.Add(new LibroCartaceo(titolo, autore, prezzoFloat));
                }

                if (scelta == "2")
                {
                    foreach (Libro l in libreria) Console.WriteLine(l.getInfo());
                }

                if (scelta == "9") break;
            }
            Console.WriteLine("Terminato!");
            Console.ReadLine();
        }
    }
}
