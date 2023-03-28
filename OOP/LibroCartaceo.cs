using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class LibroCartaceo : Libro
    {
        public uint pagine { get; set; }

        public LibroCartaceo(string titolo, string autore, float prezzo, uint pagine) : this(titolo,autore,prezzo)
        {
            this.pagine = pagine;
        }

        public LibroCartaceo(string titolo, string autore, float prezzo) : base(titolo,autore,prezzo)
        {
        }

        public LibroCartaceo(string titolo, string autore) : base(titolo,autore)
        {
        }

        public LibroCartaceo(string titolo) : base(titolo)
        {
        }

        public LibroCartaceo() : base()
        {
        }

    }
}
