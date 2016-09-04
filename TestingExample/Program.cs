using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DIVISICIÓN");
            Console.WriteLine("Ingrese Dividendo");
            int iDividendo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese Divisor");
            int iDivisor = Convert.ToInt32(Console.ReadLine());

            // MatematicaClass iMatematica = new MatematicaClass; --> NO DEJA INSTANCIAR LA CLASE

            Console.WriteLine("Resultado: " + MatematicaClass.Dividir(iDividendo, iDivisor));
            Console.ReadKey();
        }
    }
}
