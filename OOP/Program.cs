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
            //Libro l1 = new Libro("La divina commedia", "Dante Alighieri", 19.99f);
            /*Libro l1 = new Libro();
            l1.titolo = "La divina commedia";
            l1.autore = "Dante Alighieri";
            l1.prezzo = 19.99f;
            l1.creazione = new DateTime(2000, 01, 01);*/


            Libro l1 = new Libro {
                titolo = "La divina commedia",
                autore = "Dante Alighieri",
                //Prezzo = -19.99f
            };

            l1.Prezzo = -10;

            //l1.Prezzo *= 1.1f;

            Console.WriteLine($"{l1.titolo} di {l1.autore}, prezzo {Math.Round(l1.Prezzo,2)}, creato il {l1.creazione}");



            Libro l2 = new Libro("I promessi sposi", "Alessandro Manzoni");

            Console.ReadLine();
        }
    }
}
