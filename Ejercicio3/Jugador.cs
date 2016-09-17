using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Jugador
    {
        private string iNroDocumento;
        private string iNombre;

        public Jugador(string pNroDocumento, string pNombre)
        {
            iNroDocumento = pNroDocumento;
            iNombre = pNombre;
        }

        public string NroDocumento
        {
            get { return this.iNroDocumento.ToString(); }
        }

        public string Nombre
        {
            get { return this.iNombre; }
        }
    }
}
