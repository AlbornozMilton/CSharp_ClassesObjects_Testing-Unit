using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Cliente
    {
        //atributos-------------------
        private string iNroDocumento;
        private string iNombre;
        private TipoDocumento iTipoDocumento;

        //contructores----------------
        public Cliente(TipoDocumento pTipoDocumento, string pNroDocumento, string pNombre)
        {
            this.iTipoDocumento = pTipoDocumento;
            this.iNroDocumento = pNroDocumento;
            this.iNombre = pNombre;
        }

        //propiedades-----------------
        public string NroDocumento
        {
            get { return this.iNroDocumento; }
        }

        public string Nombre
        {
            get { return this.iNombre; }
        }

        public TipoDocumento TipoDocumento
        {
            get { return this.iTipoDocumento; }
        }
    }
}
