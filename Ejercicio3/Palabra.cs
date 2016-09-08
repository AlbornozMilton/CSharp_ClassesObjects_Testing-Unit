using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Palabra
    {
        private char[] iLetras;

        public Palabra(string pPalabra)
        {
            iLetras = pPalabra.ToCharArray();
        }

        public char[] Letras
        {
            get { return this.iLetras; }
        }

        private bool BuscarLetra(char pLetra)
        {
            return true;
        }
    }
}
