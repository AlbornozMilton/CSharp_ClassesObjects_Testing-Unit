using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class FachadaCuentas
    {
        /*
        private Cliente iCliente;
        private Cuentass iCuentas;
        */
        public Cuentass iCuentas;

        public Cuenta CuentaCorriente
        {
            get { return this.iCuentas.CuentaCorriente; }
        }

        public Cuenta CajaAhorro
        {
            get { return this.iCuentas.CajaAhorro; }
        }

        public void AcreditarCuenta(Cuenta pCuenta, double pSaldo)
        {
            pCuenta.AcreditarSaldo(pSaldo);
        }

        public Boolean DebitarCuenta (Cuenta pCuenta, double pSaldo)
        {
            if (pCuenta.DebitarSaldo(pSaldo))
                return true;
            else
                return false; 
        }

        
        public Boolean Transferir(Cuenta pCuenta1, Cuenta pCuenta2, double pSaldo)
        {
            if (DebitarCuenta(pCuenta1, pSaldo))
            {
                pCuenta2.AcreditarSaldo(pSaldo);
                return true;
            }
            else return false;
        }      
    }
}
