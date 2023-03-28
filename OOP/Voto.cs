using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Voto
    {
		private bool _lode;

		public bool Lode
		{
			get { return _lode; }
			set 
			{
				if (_punteggio < 30) 
					_lode = false;
				else
					_lode = value; 
			}
		}


		private int _punteggio;
		public int Punteggio
		{
			get 
			{ 
				return this._punteggio; 
			}
			set 
			{
				if (value > 30)
					this._punteggio = 30;
				else if (value < 0)
					this._punteggio = 0;
				else
					this._punteggio = value;

				if (_punteggio < 30) _lode = false;
			}
		}
	
		/*public string VotoStringa
		{
			get
			{
				if (_lode==true)
					return $"{_punteggio} con lode";
				else
					return $"{_punteggio}";
			}
		}*/

		public string VotoStringa(string lingua)
		{
			if (_lode == true)
			{
				if(lingua.ToUpper() == "ITA")
                    return $"{_punteggio} con lode";
                else
                    return $"{_punteggio} on laude";
            }
            else
				return $"{_punteggio}";
        }
    }
}
