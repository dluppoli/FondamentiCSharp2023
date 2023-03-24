using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = a;
            a = 20;
            Console.WriteLine(a); //20
            Console.WriteLine(b); //10


            int[] c = new int[] { 10, 20 };
            int[] d = c;
            c[0] = 30;
            Console.WriteLine(c[0]); //30
            Console.WriteLine(d[0]); //30


            string s1 = "Hello";
            string s2 = s1;
            s1 = "Ciao";
            Console.WriteLine(s1); //Ciao
            Console.WriteLine(s2); //Hello

            Console.ReadLine();
        }
    }
}
