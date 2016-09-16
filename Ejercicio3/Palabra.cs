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

        //------------constructor
        public Palabra(string pPalabra)
        {
            iLetras = pPalabra.ToCharArray();
        }

        //----------propiedades
        public char[] Letras
        {
            get { return this.iLetras; }
        }

        //----------metodos
        public bool BuscarLetra(char pLetra)
        {
            for (byte i = 0; i < this.iLetras.Length; i++)
            {
                if (this.iLetras[i] == pLetra)
                    return true;
            }
            return false;
        }
    }
}
