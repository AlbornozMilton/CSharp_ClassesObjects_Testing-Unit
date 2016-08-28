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
            Console.WriteLine("Titulo");
            Console.WriteLine("Eliga una opcion:");
            Console.WriteLine("1- ");
            Console.WriteLine("2- ");
            Console.WriteLine("3- ");
            //FacadeFormas iFFormas = new FacadeFormas(); //fachada

            byte iOpcion = Convert.ToByte(Console.ReadLine());

            switch (iOpcion)
            {
                case 1:
                    {
                       
                        Console.WriteLine("");
                        //metodod fachada
                        Console.ReadKey();

                        break;
                    }
                case 2: //Circulo---------------------------------------
                    {
                        Console.WriteLine("");
                        //metodod fachada
                        Console.ReadKey();

                        break;
                    }
                case 3://Triangulo---------------------------------------
                    {

                        Console.WriteLine("");
                        //metodod fachada
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


