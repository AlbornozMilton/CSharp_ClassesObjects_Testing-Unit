using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Cuenta
    {
        //atributos............................
       
        private double iSaldo;
        private double iAcuerdo; //Acuerdo: obtiene el acuerdo de descubierto de la cuenta. Cantidad minima permitida?? numeros negativos???

        //el descuebiero se lo maneja mediante el Acuerdo  ?

        //contructores
        public Cuenta(double pAcuerdo)
        {
            this.iAcuerdo = pAcuerdo;
            this.iSaldo = 0;

        }
        public Cuenta(double pSaldoInicial, double pAcuerdo)
        {
            this.iSaldo = pSaldoInicial;
            this.iAcuerdo = pAcuerdo;
        }

        //propiedades---------------------------
        public double Saldo
        {
            get { return this.iSaldo; }
        }

        public double Acuerdo
        {
            get { return this.iAcuerdo; }
        }

        //metodos-------------------------------

        public void AcreditarSaldo(double pSaldo)
        {
            if (this.iAcuerdo >= 0)//la cuenta no posee saldo negativo (descubierto)
            {
                this.iSaldo += pSaldo;
            }
            else
            {
                if(pSaldo-iAcuerdo >= 0)//la acreditacion cubre el acuerdo de descubierto
                {
                    iSaldo = pSaldo - iAcuerdo;
                    iAcuerdo = 0;
                }
                else //la acreditacion no alcanza a cubrir el total de acuerdo de descubierto
                {
                    iAcuerdo -= pSaldo;
                }
            }
        }

        public bool DebitarSaldo(double pSaldo)
        {
            if (this.iAcuerdo==0) // no descubierto
            {
              if (this.iSaldo-pSaldo>=0) //no se produce descuebierto
                {
                    this.iSaldo -= pSaldo;
                }
              else //la debitacion supera al saldo disponible
                {
                    this.iAcuerdo = (pSaldo - iSaldo);
                    iSaldo = 0;
                }
                return true; //si realizo la debitacion de todos modos      
            }
            else return false;//descubierto - no se realiza debitacion

        }


    }
}
