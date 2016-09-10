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
        //private int iTipoCuenta;
        private Cuentass iCuentas;

        public void IngresarACuenta (int pTipoCuenta)
            {

            iCuentas.CuentaCorriente  = pTipoCuenta; //iCuentas.CuentaCorriente
        }

        public void AcreditarCuenta(Cuenta pCuenta, double pSaldo)
        {
            pCuenta.AcreditarSaldo(pSaldo);
        }

       
        //AcreditarCuenta(pCuenta, iSaldo);

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
