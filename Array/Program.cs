using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] voti = new int[6] { 10, 9, 7, 8, 4,9};

            double media;
            int somma = 0;

            for (int indice = 0; indice < voti.Length; indice++)
            {
                somma += voti[indice];
            }
            Console.WriteLine(somma);

            media = 1.0*(double)somma / voti.Length;
            Console.WriteLine(media);

            Console.ReadLine();
        }
    }
}
