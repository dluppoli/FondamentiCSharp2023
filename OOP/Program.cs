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
            List<IElementoLibreria> libreria = new List<IElementoLibreria>();
            /*
            libreria.Add(new LibroCartaceo("La divina commedia","Dante Alighieri",10,500));
            libreria.Add(new LibroDigitale("I promessi sposi","Manzoni",5,1024));

            Libro l = new LibroCartaceo("La concessione del telefono", "Camilleri", 10, 100);
            libreria.Add(l);

            foreach (Libro libro in libreria)
            {
                libro.getInfo();

                if( libro.GetType() == typeof(LibroCartaceo) )
            }*/

            while (true)
            {
                //Console.Clear();
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
                    foreach (IElementoLibreria l in libreria) Console.WriteLine(l.getInfo());
                }

                if(scelta=="3")
                {
                    Console.WriteLine($"La tua libreria contiene {libreria.Count} libri");
                }

                if(scelta == "4")
                {
                    //Leggo la ricerca da tastiera
                    Console.Write("Inserisci il termine da cercare: ");
                    string ricerca = Console.ReadLine().ToLower();
                    bool trovato = false;

                    //Scorro tutti i libri
                    foreach (IElementoLibreria l in libreria)
                    {
                        //Verifico che il titolo o l'autore contengano la ricerca
                        if( l.Contains(ricerca) )
                        {
                            //Se la contengono stampo il libro
                            Console.WriteLine(l.getInfo());
                            trovato = true;
                        }
                    }

                    if(trovato==false)
                    {
                        Console.WriteLine("Nessun libro trovato");
                    }
                }

                if (scelta == "9") break;
            }
            Console.WriteLine("Terminato!");
            Console.ReadLine();
        }
    }
}
