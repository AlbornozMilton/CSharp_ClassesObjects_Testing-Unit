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
        private int iCliente;
        private Cuenta iCuentaCorriente;
        private Cuenta iCajaAhorro;
        
        //constructor
        public Cuentass()
        {
            this.iCuentaCorriente = new Cuenta(0,0);
            this.iCajaAhorro = new Cuenta(0,0);
        }

        public Cuenta CuentaCorriente
        {
            get
            {
                return (this.iCuentaCorriente.)
            }
        }


    }
}
