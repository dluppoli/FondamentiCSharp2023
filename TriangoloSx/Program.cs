using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangoloSx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 7;
            string s = "*";

            for (int i = 0; i < n; i++)
            {
                //SOLUZIONE 1 - Con solo 1 ciclo
                //Console.WriteLine(s);
                //s = s + "*";

                //SOLUZIONE 2 - Con 2 cicli
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write(s);
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
