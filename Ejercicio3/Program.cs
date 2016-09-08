using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            FachadaAhorcado iFachada = new FachadaAhorcado();
            byte iOpcion;
            Console.WriteLine("JUEGO AHORACADO");
            Console.WriteLine("1- Nueva Partida");
            Console.WriteLine("2- Ver Primeros Puestos");
            iOpcion = Convert.ToByte(Console.ReadLine());

            if (iOpcion == 1)
            {
                Console.WriteLine("Datos de Jugador");
                Console.Write("NroDocumento: ");
                string iNrodocumento = Console.ReadLine();
                Console.WriteLine("2- Ver Primeros Puestos");
                string iNombre = Console.ReadLine();
                iFachada.NuevaPartida(iNrodocumento, iNombre);
                


            }
            else if (iOpcion == 2)
            {

            }
        }
    }
}
