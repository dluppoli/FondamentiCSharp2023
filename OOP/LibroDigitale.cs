using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class LibroDigitale : Libro
    {
        public float kByte { get; set; }

        public LibroDigitale(string titolo, string autore, float prezzo, float kByte) : this(titolo, autore, prezzo)
        {
            this.kByte = kByte;
        }

        public LibroDigitale(string titolo, string autore, float prezzo) : base(titolo, autore, prezzo)
        {
        }

        public LibroDigitale(string titolo, string autore) : base(titolo, autore)
        {
        }

        public LibroDigitale(string titolo) : base(titolo)
        {
        }

        public LibroDigitale() : base()
        {
        }

        public override string getInfo()
        {
            return base.getInfo() + $" {kByte} Kb";
        }
    }
}
