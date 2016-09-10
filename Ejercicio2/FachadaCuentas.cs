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
        private Cuentass iCuentas = new Cuentass();


        public Cuenta IngresarACuenta(bool pTipoCuenta)
        {
            if (pTipoCuenta==false)         // caja de ahorro es pTipoCuenta=false
            { return (iCuentas.CajaAhorro); }
            else  //
                { return (iCuentas.CuentaCorriente); }
             
        }


        public Cuentass MostrarCuentas
        {
            get { return this.iCuentas; }
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
