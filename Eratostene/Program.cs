using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eratostene
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 50;

            bool[] numeri = new bool[n+1];

            numeri[0] = false;
            for (int i = 1; i < numeri.Length; i++)
            {
                numeri[i] = true;
            }

            for(int i = 2; i<n; i++)
            {
                if (numeri[i] == true)
                {
                    for (int j = i + 1; j < n + 1; j++)
                    {
                        if (numeri[j]==true && j % i == 0) numeri[j] = false;
                    }
                }
            }

            List<int> numeriPrimi = new List<int>();
            for(int i = 0; i<=n; i++)
            {
                if (numeri[i]==true) numeriPrimi.Add(i);    
            }

            foreach (int numero in numeriPrimi) Console.WriteLine(numero);

            Console.ReadLine();
        }
    }
}
