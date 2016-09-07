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
            Punto iPunto;
            Circulo iCirculo;
            Triangulo iTriangulo;

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
                        
                        Console.WriteLine("1-Ingresar Centro y Radio");
                        Console.WriteLine("2-Ingresar X e Y, más el Radio");
                        iOpcion = Convert.ToByte(Console.ReadLine());

                        if (iOpcion == 1)
                        {
                            Console.WriteLine("Definiendo centro como Punto...");
                            iPunto = CrearPunto(iFFormas);
                            Console.WriteLine("Ingresar valor de Radio");
                            double iRadio = Convert.ToDouble(Console.ReadLine());
                            iCirculo = iFFormas.CrearCirculo(iPunto,iRadio);
                            Console.WriteLine("El valor del AREA es: " + iFFormas.AreaCirculo(iCirculo));
                            Console.WriteLine("El valor del PERIMETRO es: " + iFFormas.PerimetroCirculo(iCirculo));
                        }
                        else
                        {//opcion 2
                            Console.WriteLine("Definiendo centro directamente...");
                            Console.WriteLine("Ingresar valor X");
                            double iX = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Ingresar valor Y");
                            double iY = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Ingresar valor de Radio");
                            double iRadio = Convert.ToDouble(Console.ReadLine());

                            iCirculo = iFFormas.CrearCirculo(iX, iY, iRadio);

                            Console.WriteLine("El valor del AREA es: " + iFFormas.AreaCirculo(iCirculo));
                            Console.WriteLine("El valor del PERIMETRO es: " + iFFormas.PerimetroCirculo(iCirculo));
                        }
                        Console.ReadKey();

                        break;
                    }
                case 2://Triangulo---------------------------------------
                    {
                        Console.WriteLine("Eligió Triangulo...");
                        Console.WriteLine("1-Deberá ingresar tres puntos");
                        Console.WriteLine("Punto 1");
                        Punto iPunto1 = CrearPunto(iFFormas);
                        Console.WriteLine("Punto 2");
                        Punto iPunto2 = CrearPunto(iFFormas);
                        Console.WriteLine("Punto 3");
                        Punto iPunto3 = CrearPunto(iFFormas);

                        iTriangulo = iFFormas.CrearTriangulo(iPunto1, iPunto2, iPunto3);
                        Console.WriteLine("El valor del AREA es: " + iFFormas.AreaTriangulo(iTriangulo));
                        Console.WriteLine("El valor del PERIMETRO es: " + iFFormas.PerimetroTriangulo(iTriangulo));
                        Console.ReadKey();

                        break;
                    }
            }
       } //Fin de Main

        private static Punto CrearPunto(FacadeFormas iFach) //retorna un punto
        {
            Console.WriteLine("Ingrese valor X");
            double iX = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese valor Y");
            double iY = Convert.ToDouble(Console.ReadLine());
            return iFach.CrearPunto(iX, iY);
        }
    }
}


