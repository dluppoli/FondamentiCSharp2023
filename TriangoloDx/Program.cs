﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangoloDx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 7;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
