using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clessidra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 7;

            int spazi = 0;
            int asterischi = n;

            for (int i = 0; i < n; i++)
            {
                //Stampo gli spazi
                for (int j = 0; j < spazi; j++) Console.Write(" ");

                //Stampo gli asterischi
                for (int j = 0; j < asterischi; j++) Console.Write("*");

                Console.WriteLine();

                if ( i< n/2)
                {
                    spazi++;
                    asterischi -= 2;
                }
                else
                {
                    spazi--;
                    asterischi += 2;
                }
            }

            Console.ReadLine();
        }
    }
}
