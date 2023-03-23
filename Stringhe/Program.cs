using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stringhe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //data una stringa verificare se contiene la parola italia
            //se la contiene estrarla (con substring)

            string s = "Nazioni ITALIA e Germania.";

            int i = s.ToLower().IndexOf("Italia".ToLower());

            if(i>=0)
            {
                string s1 = s.Substring(i,6);
                Console.WriteLine(s1);
            }


            //string temps = "19,18,23";
            //temps.Split(new char[1] { ',' });

            Console.ReadLine();
        }
    }
}
