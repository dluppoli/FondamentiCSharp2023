using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] voti = new int[6] { 10, 9, 7, 8, 4, 9 };
            List<int> voti = new List<int>() { 10, 9, 7, 8, 4 , 9};
            voti.Add(7);

            double media;
            int somma = 0;

            /*for (int indice = 0; indice < voti.Count; indice++)
            {
                somma += voti[indice];
            }*/

            foreach(int voto in voti)
            {
                somma += voto;
                //somma = somma + voto;
            }

            Console.WriteLine(somma);

            media = 1.0 * (double)somma / voti.Count;
            Console.WriteLine(media);

            Console.ReadLine();
        }
    }
}
