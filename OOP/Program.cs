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
            List<LibroCartaceo> libreria = new List<LibroCartaceo>();
            List<LibroDigitale> kindle = new List<LibroDigitale>();

            //Inserimento (CREATE)
            LibroCartaceo l1 = new LibroCartaceo("La divina commedia","Dante Alighieri",12f);
            libreria.Add(l1);

            libreria.Add(new LibroCartaceo("I promessi sposi", "Alessandro Manzoni", 8f));

            libreria.Add(new LibroCartaceo
            {
                titolo = "La concessione del telefono",
                autore = "Andrea Camilleri"
            });

            //Lettura di tutti i libri (READ)
            foreach (LibroCartaceo libro in libreria) Console.WriteLine(libro.getInfo());
            

            Console.ReadLine();
        }
    }
}
