using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Libro
    {
        //Campi
        public string titolo;
        public string autore;
        public float prezzo;
        private DateTime creazione;

        //Costruttori
        public Libro(string titolo, string autore, float prezzo) : this(titolo,autore)
        {
            //titolo --> La divina commedia
            //autore --> Dante alighieri
            //prezzo --> 19.99
            //this.titolo = titolo.Trim();
            //this.autore = autore;

            if (prezzo <= 0)
                this.prezzo = 9999;
            else
                this.prezzo = prezzo;
        }

        public Libro(string titolo, string autore) : this(titolo)
        {
            this.autore = autore;
        }

        public Libro(string titolo) : this()
        {
            this.titolo = titolo.Trim();
        }

        public Libro()
        {
            this.creazione = DateTime.Now;
        }
    }
}
