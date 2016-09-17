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

            //  Punto iPunto;
            // Circulo iCirculo;
            //FacadeFormas iFach = new FacadeFormas();
            //Triangulo iTriangulo;
            //double iPunto;



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

                            CrearPuntoM(iFFormas);   //CrearPuntoM es el metodo que lee los datos ingresados
                            Console.WriteLine("Ingresar valor de Radio");
                            double iRadio = Convert.ToDouble(Console.ReadLine());
                            iFFormas.CrearCirculo(iFFormas.UnPunto, iRadio);
                            Console.WriteLine("El valor del AREA es: " + iFFormas.AreaCirculo(iFFormas.UnCirculo));
                            Console.WriteLine("El valor del PERIMETRO es: " + iFFormas.PerimetroCirculo(iFFormas.UnCirculo));
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

                            iFFormas.CrearCirculo(iX, iY, iRadio);  //asignar a iCirculo
                            //iCirculo = iFFormas.CrearCirculo(iX, iY, iRadio);
                            Console.WriteLine("El valor del AREA es: " + iFFormas.AreaCirculo(iFFormas.UnCirculo));
                            Console.WriteLine("El valor del PERIMETRO es: " + iFFormas.PerimetroCirculo(iFFormas.UnCirculo));
                        }
                        Console.ReadKey();

                        break;
                    }
                case 2://Triangulo---------------------------------------
                    {
                        Console.WriteLine("Eligió Triangulo...");
                        Console.WriteLine("1-Deberá ingresar tres puntos");
                        Console.WriteLine("Punto 1");
                        CrearPuntoM(iFFormas);
                        Console.WriteLine("Punto 2");
                        CrearPuntoM(iFFormas);
                        Console.WriteLine("Punto 3");
                        CrearPuntoM(iFFormas);

                        iFFormas.CrearTriangulo(iFFormas.UnPunto, iFFormas.UnPunto, iFFormas.UnPunto); //iFFormas.UnPunto antes era iPunto2,1,3

                        //iTriangulo = iFFormas.CrearTriangulo(iPunto1, iPunto2o, iPunto3);
                        //iTriangulo es una objeto de tipo clase Triangulo 

                        Console.WriteLine("El valor del AREA es: " + iFFormas.AreaTriangulo(iFFormas.UnTriangulo));
                        Console.WriteLine("El valor del PERIMETRO es: " + iFFormas.PerimetroTriangulo(iFFormas.UnTriangulo));
                        Console.ReadKey();

                        break;
                    }
            }
        } //Fin de Main

        private static void CrearPuntoM(FacadeFormas iFach) //retorna un punto
        {
            Console.WriteLine("Ingrese valor X");
            double iX = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese valor Y");
            double iY = Convert.ToDouble(Console.ReadLine());
            iFach.CrearPunto(iX, iY);
        }
    }
}


