using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Cuentass
    {
        //atributos-------------
        private Cliente iCliente;
        private Cuenta iCuentaCorriente;
        private Cuenta iCajaAhorro;

        //constructor
        public Cuentass()
        {
            this.iCuentaCorriente = new Cuenta(6000, 2000);
            this.iCajaAhorro = new Cuenta(1000);
            this.iCliente = new Cliente(TipoDocumento.DNI, "37115628", "Chamorro Mauricio");
        }

        public Cliente Cliente
        {
            get
            {
                return this.iCliente;
            }
        }

        public Cuenta CuentaCorriente
        {
            get
            {
                return (this.iCuentaCorriente);
            }
        }

        public Cuenta CajaAhorro
        {
            get
            {
                return (this.iCajaAhorro);
            }
        }

    }
}
