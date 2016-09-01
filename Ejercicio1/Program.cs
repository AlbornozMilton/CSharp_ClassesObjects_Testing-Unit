using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("AREAS Y PERIMETROS");
            Console.WriteLine("Eliga figura geométrica:");
            Console.WriteLine("1- Círculo");
            Console.WriteLine("2- Triángulo");
            FacadeFormas iFFormas = new FacadeFormas(); //fachada

            byte iOpcion = Convert.ToByte(Console.ReadLine());
            
            switch (iOpcion)
            {
                case 1: //Circulo---------------------------------------
                    {
                        Console.WriteLine("Eligió Círculo...");
                        iFFormas.AreaYPerimetroCirculo();
                        Console.ReadKey();

                        break;
                    }
                case 2://Triangulo---------------------------------------
                    {
                        Console.WriteLine("Eligió Triangulo...");
                        iFFormas.AreaYPerimetroTriangulo();
                        Console.ReadKey();

                        break;
                    }

                default:
                    {
                        Console.WriteLine("Eliga una opcion correcta");
                        Console.ReadKey();
                        break;
                    }
            }
       }
    }     
}


