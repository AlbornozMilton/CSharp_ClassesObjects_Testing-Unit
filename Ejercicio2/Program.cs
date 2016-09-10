using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            FachadaCuentas iFachada = new FachadaCuentas();
           //Cuentass iCuentas = new Cuentass(); // no va , no se puede----- >esto puede q si //int iTipoCuenta;
            byte iOpcion;
            int iCuentas; //iTipoCuenta;

            //Menú
            MostrarCuentas(iFachada.);
            Console.WriteLine();
            Console.WriteLine("OPERACIONES ");
            Console.WriteLine("1- Acreditar ");
            Console.WriteLine("2- Debitar");
            Console.WriteLine("3- Transferir"); 

            iOpcion = Convert.ToByte(Console.ReadLine());

            switch (iOpcion)
            {
                case 1://Acreditar
                    {
                        Console.WriteLine("Antes de realizar la operación, eliga la cuenta.");
                        Console.WriteLine("1- Cuenta Corriente ");
                        Console.WriteLine("2- Caja de Ahorro");
                        iOpcion = Convert.ToByte(Console.ReadLine());
                        if (iOpcion == 1)
                        {

                            AcreditarCuenta(iFachada, iCuentas.CuentaCorriente); // fachada--- (iTipoCuenta,iSaldo)
                        }
                        else if (iOpcion == 2)
                        {
                            AcreditarCuenta(iFachada, iCuentas.CajaAhorro); // fachada---

                        }

                        Console.ReadKey();
                        MostrarCuentas(iCuentas);

                        break;
                    }
                case 2: //Debitar
                    {
                        Console.WriteLine("Antes de realizar la operación, eliga la cuenta.");
                        Console.WriteLine("1- Cuenta Corriente ");
                        Console.WriteLine("2- Caja de Ahorro");
                        iOpcion = Convert.ToByte(Console.ReadLine());

                        if (iOpcion == 1) //cuenta corriente
                        {
                            DebitarCuenta(iFachada, iCuentas.CuentaCorriente); // fachada
                        } else if (iOpcion == 2)//Caja de Ahorro
                        {
                            DebitarCuenta(iFachada, iCuentas.CajaAhorro); //fachada
                        }

                        Console.ReadKey();
                        MostrarCuentas(iCuentas);

                        break;
                    }
                case 3: //transferir
                    {
                        Console.WriteLine("¿Desde qué Cuenta transferir?");
                        Console.WriteLine("1- Cuenta Corriente a Caja de Ahorro");
                        Console.WriteLine("2- Caja de Ahorro a Cuenta Corriente");
                        iOpcion = Convert.ToByte(Console.ReadLine());

                        if (iOpcion == 1)
                        {
                            Transferir(iFachada,iCuentas.CuentaCorriente,iCuentas.CajaAhorro); // fachada
                        }
                        else if (iOpcion == 2)
                        {
                            Transferir(iFachada, iCuentas.CajaAhorro,iCuentas.CuentaCorriente); //fachada---
                        }

                        Console.ReadKey();
                        MostrarCuentas(iCuentas);

                        break;
                    }

            } //fin switch

            Console.ReadKey();
            
        } //fin de Main

        private static void MostrarCuentas(int pCuentas)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("ESTADO ACTUAL");
            
            Console.WriteLine("Propietario: " + Cliente.Nombre);

            Console.WriteLine("CAJA DE AHORRO:");
            Console.WriteLine("Saldo: " + pCuentas.CajaAhorro.Saldo);
            Console.WriteLine("Acuerdo: " + pCuentas.CajaAhorro.Acuerdo);

            Console.WriteLine("CUENTA CORRIENTE:");
            Console.WriteLine("Saldo: " + pCuentas.CuentaCorriente.Saldo);
            Console.WriteLine("Acuerdo: " + pCuentas.CuentaCorriente.Acuerdo);
         }

        private static void AcreditarCuenta(FachadaCuentas pF, Cuenta pCuenta)
        {
            Console.WriteLine("Ingrese monto a ACREDITAR:");
            double iSaldo = Convert.ToDouble(Console.ReadLine());
            pF.AcreditarCuenta(pCuenta, iSaldo);              //fachada sacarlo de arriba o dejarlo
            Console.WriteLine("Saldo Acreditado.");
            Console.WriteLine("Su nuevo saldo es de " + pCuenta.Saldo);
        }

        private static void DebitarCuenta(FachadaCuentas pF,Cuenta pCuenta)
        {
            Console.WriteLine("Ingrese monto a DEBITAR:");
            double iSaldo = Convert.ToDouble(Console.ReadLine());
            if (pF.DebitarCuenta(pCuenta, iSaldo))               //fachada---
            {
                Console.WriteLine("Saldo Debitado.");
                Console.WriteLine("Su nuevo saldo es de " + pCuenta.Saldo);
            }
            else { Console.WriteLine("Operación Fallida, cuenta al Descubierto o Monto no válido."); };
        }

        private static void Transferir(FachadaCuentas pF,Cuenta iCuenta1,Cuenta iCuenta2)
        {
            Console.WriteLine("Ingrese monto a Transferir:");
            double iSaldo = Convert.ToDouble(Console.ReadLine());
            if (pF.Transferir(iCuenta1,iCuenta2,iSaldo))    //fachada---


            {
                Console.WriteLine("Éxito en la Transferencia");
            }
            else
                Console.WriteLine("Operación Fallida, cuenta al Descubierto o Monto no válido.");
        }

    }//fin de Program
}


