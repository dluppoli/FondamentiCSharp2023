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

            //Inserimento (CREATE)
            Libro l1 = new LibroCartaceo("La divina commedia","Dante Alighieri",12f);
            libreria.Add(l1);

            libreria.Add(new LibroCartaceo("I promessi sposi", "Alessandro Manzoni", 8f));

            libreria.Add(new LibroCartaceo
            {
                titolo = "La concessione del telefono",
                autore = "Andrea Camilleri"
            });

            libreria.Add(new LibroDigitale("Fondamenti di C#", "Bill Gates", 8,120f));

            //Lettura di tutti i libri (READ)
            foreach (Libro libro in libreria)
            {
                if( libro.GetType() == typeof(LibroDigitale) )
                {
                    //Sono sicuro che libro è di classe LibroDigitale
                    Console.WriteLine( ((LibroDigitale)libro).kByte );
                }

                if (libro.GetType() == typeof(LibroCartaceo))
                {
                    //Sono sicuro che libro è di classe LibroCartaceo
                    Console.WriteLine(((LibroCartaceo)libro).pagine);
                }

                Console.WriteLine(libro.getInfo());
            }
            

            Console.ReadLine();
        }
    }
}
