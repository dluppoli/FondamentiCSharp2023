using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cicli
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Inizializzazione
            const int daStampare = 20;
            int n = 74;
            int i = 0;

            //Condizione
            while (i < daStampare)
            {
                //Corpo
                n = n + 1;
                Console.WriteLine(n);

                //Incremento
                i++;
            }

            for (int j = 0; j < daStampare; j++)
            {
                n++;
                Console.WriteLine(n);
            }

            //Inizializzazione
            //daStampare = 20;
            int anno = 2023;
            i = 0;
            //bool bisestile;

            //Condizione
            while (i < daStampare)
            {
                //Verifico se anno è bisestile
                //Se è bisestile
                //Lo stampo
                //Incremento i

                //Incremento anno

                bool bisestile = (anno % 4 == 0 && anno % 100 != 0) || (anno % 400 == 0);
                if (bisestile)
                {
                    Console.WriteLine(anno);
                    i++;
                }
                anno++;
            }
            Console.ReadLine();
        }
    }
}
