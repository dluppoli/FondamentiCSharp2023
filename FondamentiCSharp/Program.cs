using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FondamentiCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Esercizio 1
            //Conversione da Celsius a Fahrenheit
            float tempC = 12;
            float tempF = tempC * 1.8f + 32;
            Console.WriteLine(tempF);



            //Esercizio 2
            //Scambiare il valore di due variabili
            int x = 10;
            int y = 30;

            int temp = x;
            x = y;
            y = temp;
            Console.WriteLine(x);
            Console.WriteLine(y);



            //Esercizio 3
            //Posso votare alle comunali?
            int eta = 19;
            bool cittadinanzaITA = false;
            bool iscrittoRegistro = true;

            bool possoVotare = (eta >= 18) && (cittadinanzaITA || iscrittoRegistro);
            Console.WriteLine(possoVotare);



            //Esercizio 4
            //Posso votare a camera e/o senato?
            //NB: la variabile eta è già state definita nell'esercizio precedente
            if (eta < 18)
                Console.WriteLine("Non puoi votare");
            else if (eta < 25)
                Console.WriteLine("Puoi votare solamente alla Camera");
            else
                Console.WriteLine("Puoi votare sia alla camera che al Senato");



            //Esercizio 5
            //Verificare se un numero è pari o dispari e stamparlo
            int n = 23;
            if (n % 2 == 0)
                Console.WriteLine("PARI");
            else
                Console.WriteLine("DISPARI");




            //Esercizio 6
            //Verificare se un anno è bisestile e stamparlo
            int anno = 2023;
            bool bisestile = (anno % 4 == 0 && anno % 100 != 0) || anno % 400 == 0;
            if (bisestile)
                Console.WriteLine("Bisestile");
            else
                Console.WriteLine("Non bisestile");


            Console.ReadLine();
        }
    }
}
