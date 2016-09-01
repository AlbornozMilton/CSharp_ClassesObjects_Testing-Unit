using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class FachadaCuentas
    {
        private Cliente iCliente;
        private Cuentass iCuentas;
        
        public void Inicializar()
        {
            iCliente = new Cliente(TipoDocumento.DNI, "37115628", "Chamorro Mauricio");
            iCuentas = new Cuentass(iCliente);
            Console.WriteLine("Éxito, Cuentas cread para el cliente "+iCliente.NroDocumento);
            MostarDatosCuentas(iCuentas);

            Console.WriteLine("Operaciones de Acréditar y Debitar");
            Console.WriteLine("Antes de realizar una operación, eliga la cuenta.");
            Console.WriteLine("1- Cuenta Corriente");
            Console.WriteLine("2- Caja de Ahorro");

            byte iOpcion = Convert.ToByte(Console.ReadLine());

            Operaciones(iOpcion,iCuentas);
            Console.ReadKey();
        }

        public void MostarDatosCuentas(Cuentass pCuentas)
        {
            Console.WriteLine("Propietario "+ pCuentas.Cliente.Nombre);

            Console.WriteLine("CAJA DE AHORRO:");
            Console.WriteLine("Saldo: "+ pCuentas.CajaAhorro.Saldo);
            Console.WriteLine("Acuerdo: " + pCuentas.CajaAhorro.Acuerdo);

            Console.WriteLine("CUENTA CORRIENTE:");
            Console.WriteLine("Saldo: " + pCuentas.CuentaCorriente.Saldo);
            Console.WriteLine("Acuerdo: " + pCuentas.CuentaCorriente.Acuerdo);
            Console.WriteLine();

        }

        public void Operaciones(byte o, Cuentass pCuentas)
        {
            if (o == 1)
            { RealizarOperacion(pCuentas.CuentaCorriente);
            }
            else if (o == 2) RealizarOperacion(pCuentas.CajaAhorro);
        }

        public void RealizarOperacion(Cuenta pCuenta)
        {
            Console.WriteLine("Elija operación:");
            Console.WriteLine("1- Acreditar");
            Console.WriteLine("2- Debitar");

            byte iOpcion = Convert.ToByte(Console.ReadLine());

            switch (iOpcion)
            {
                case 1://Acreditar
                    {
                        Console.WriteLine("Ingrese monto a ACREDITAR:");
                        double iSaldo = Convert.ToDouble(Console.ReadLine());
                        pCuenta.AcreditarSaldo(iSaldo);
                        Console.WriteLine("Saldo Acreditado.");
                        Console.WriteLine("Su nuevo saldo es de " + pCuenta.Saldo);
                       break;
                    }
                case 2: //Debitar
                    {
                        Console.WriteLine("Ingrese monto a DEBITAR:");
                        double iSaldo = Convert.ToDouble(Console.ReadLine());

                        if (pCuenta.DebitarSaldo(iSaldo))
                        {
                            Console.WriteLine("Saldo Debitado.");
                            Console.WriteLine("Su nuevo saldo es de " + pCuenta.Saldo);
                        }
                        else { Console.WriteLine("Operación Fallida, cuenta al Descubierto o Monto no válido."); };
                        break;
                    }
            }
        }
    }
}
