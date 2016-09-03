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
            Cuentass iCuentas = new Cuentass();
            byte iOpcion;

            //Menú
            MostrarCuentas(iCuentas);
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
                            Console.WriteLine("Ingrese monto a ACREDITAR:");
                            double iSaldo = Convert.ToDouble(Console.ReadLine());
                            iFachada.AcreditarCuenta(iCuentas.CuentaCorriente, iSaldo);
                            Console.WriteLine("Saldo Acreditado.");
                            Console.WriteLine("Su nuevo saldo es de " + iCuentas.CuentaCorriente.Saldo);
                        }
                        else if (iOpcion == 2)
                        {
                            Console.WriteLine("Ingrese monto a ACREDITAR:");
                            double iSaldo = Convert.ToDouble(Console.ReadLine());
                            iFachada.AcreditarCuenta(iCuentas.CajaAhorro, iSaldo);
                            Console.WriteLine("Saldo Acreditado.");
                            Console.WriteLine("Su nuevo saldo es de " + iCuentas.CajaAhorro.Saldo);
                        }
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
                            Console.WriteLine("Ingrese monto a DEBITAR:");
                            double iSaldo = Convert.ToDouble(Console.ReadLine());
                            if (iFachada.DebitarCuenta(iCuentas.CuentaCorriente, iSaldo))
                            {
                                Console.WriteLine("Saldo Debitado.");
                                Console.WriteLine("Su nuevo saldo es de " + iCuentas.CuentaCorriente.Saldo);
                            }
                            else { Console.WriteLine("Operación Fallida, cuenta al Descubierto o Monto no válido."); };

                        } else if (iOpcion == 2)//Caja de Ahorro
                        {
                            Console.WriteLine("Ingrese monto a DEBITAR:");
                            double iSaldo = Convert.ToDouble(Console.ReadLine());
                            if (iFachada.DebitarCuenta(iCuentas.CajaAhorro, iSaldo))
                            {
                                Console.WriteLine("Saldo Debitado.");
                                Console.WriteLine("Su nuevo saldo es de " + iCuentas.CajaAhorro.Saldo);
                            }
                            else { Console.WriteLine("Operación Fallida, cuenta al Descubierto o Monto no válido."); };
                        }

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
                            Console.WriteLine("Ingrese monto a Transferir:");
                            double iSaldo = Convert.ToDouble(Console.ReadLine());
                            if (iFachada.Transferir(iCuentas.CuentaCorriente, iCuentas.CajaAhorro, iSaldo))
                            {
                                Console.WriteLine("Éxito en la Transferencia");
                            } else
                                Console.WriteLine("Operación Fallida, cuenta al Descubierto o Monto no válido.");
                        }
                        else if (iOpcion == 2)
                        {
                            Console.WriteLine("Ingrese monto a Transferir:");
                            double iSaldo = Convert.ToDouble(Console.ReadLine());
                            if (iFachada.Transferir(iCuentas.CajaAhorro, iCuentas.CuentaCorriente, iSaldo))
                            {
                                Console.WriteLine("Éxito en la Transferencia");
                            }
                            else
                                Console.WriteLine("Operación Fallida, cuenta al Descubierto o Monto no válido.");
                        }
                        Console.WriteLine("");

                        MostrarCuentas(iCuentas);

                        break;
                    }

            } //fin switch

            Console.ReadKey();
        } //fin de Main

        static void MostrarCuentas(Cuentass pCuentas)
        {
            Console.WriteLine("ESTADO ACTUAL");
            Console.WriteLine("Propietario: " + pCuentas.Cliente.Nombre);

            Console.WriteLine("CAJA DE AHORRO:");
            Console.WriteLine("Saldo: " + pCuentas.CajaAhorro.Saldo);
            Console.WriteLine("Acuerdo: " + pCuentas.CajaAhorro.Acuerdo);

            Console.WriteLine("CUENTA CORRIENTE:");
            Console.WriteLine("Saldo: " + pCuentas.CuentaCorriente.Saldo);
            Console.WriteLine("Acuerdo: " + pCuentas.CuentaCorriente.Acuerdo);
         }
    }//fin de Program
}


