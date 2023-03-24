using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*DateTime oggi = new DateTime(2023, 03, 23);

            Console.WriteLine(oggi.ToString("ddd dd-MMMM-yyyy") );
            Console.WriteLine($"Oggi è il {oggi.DayOfYear}° giorno dell'anno");
            Console.WriteLine(DateTime.IsLeapYear(oggi.Year));*/

            Console.WriteLine("Premi invio per iniziare");
            Console.ReadLine();
            DateTime start = DateTime.Now;
          
            Console.WriteLine("Premi stop per fermare");
            Console.ReadLine();
            DateTime stop = DateTime.Now;

            //Calcolare quanti secondi sono passati
            TimeSpan intervallo = stop - start;
            Console.WriteLine($"Sono passati {Math.Round(intervallo.TotalSeconds,0)} secondi");
            Console.ReadLine();
        }
    }
}
