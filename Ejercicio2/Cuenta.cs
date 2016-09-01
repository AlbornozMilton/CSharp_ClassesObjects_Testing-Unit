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
        private double iAcuerdo; 
        //Acuerdo: cantidad limite en el que se produce o no el descubierto

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
            this.iSaldo += pSaldo;
        }

        public bool DebitarSaldo(double pSaldo) //el metodo trabaja con iSaldo negtivo/positivo
        {
            if (this.iSaldo >= 0) //saldo positivo--------------------
            {
                if (pSaldo <= this.iSaldo + this.iAcuerdo) //no se produce descubierto
                {
                    this.iSaldo -= pSaldo;
                    return true;
                }
                else return false; //se produce descubierto
            }


            else //saldo negativo---------------------------------------
            {
                if (this.iSaldo + this.iAcuerdo > 0) //cuenta no descubierta
                {
                    if (pSaldo <= this.iSaldo + this.iAcuerdo) 
                        //no se produce descubierto+++++++++++++
                    {
                        this.iSaldo -= pSaldo;
                        return true;
                    }
                    else //se produce descubierto+++++++++++++
                    {
                        return false;
                    }
                }

                else return false;//cuenta descubierta                     
            }
        }
    }
}
