using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal abstract class Libro
    {
        //Campi
        public string titolo;
        public string autore;

        //Obiettivo > 0 (se si tenta di settare un valore <= 0 impostarlo a 9999)
        private float prezzo;
        public float Prezzo
        {
            get
            {
                return prezzo;    
            }
            set
            {
                if (value <= 0)
                    prezzo = 9999;
                else
                    prezzo = value;
            }
        }

        //Obiettivo in sola lettura
        public DateTime creazione { get; }


        //Costruttori
        public Libro(string titolo, string autore, float prezzo) : this(titolo,autore)
        {
            //titolo --> La divina commedia
            //autore --> Dante alighieri
            //prezzo --> 19.99
            //this.titolo = titolo.Trim();
            //this.autore = autore;

            /*if (prezzo <= 0)
                this.prezzo = 9999;
            else
                this.prezzo = prezzo;*/
            Prezzo = prezzo;
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
    
        //Metodi
        public virtual string getInfo()
        {
            return $"{titolo} - {autore} - Prezzo: {prezzo} - creato il {creazione}";
        }

        public void aumentaPrezzo(float percentuale)
        {
            prezzo = prezzo * (1 + percentuale / 100);
        }
    }
}
