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
            iFachada.Inicializar();
                    
            Console.ReadKey();
           
        }
    }
}


