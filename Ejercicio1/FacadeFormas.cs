using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class FacadeFormas //Fachada (Facade)
    {

        private Punto iPunto;
        private Circulo iCirculo;
        private Triangulo iTriangulo;

        public Punto CrearPunto()
        {
            Console.WriteLine("Ingrese valor X");
            double iX = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese valor Y");
            double iY = Convert.ToDouble(Console.ReadLine());
            iPunto = new Punto(iX, iY);
            return iPunto;
        }

        public void AreaYPerimetroCirculo()
        {
            Console.WriteLine("1-Ingresar Centro y Radio");
            Console.WriteLine("2-Ingresar X e Y, más el Radio");
            byte iOpcion = Convert.ToByte(Console.ReadLine());

            if (iOpcion == 1)
            {
                Console.WriteLine("Definiendo centro como Punto...");
                Punto iPunto = this.CrearPunto();
                Console.WriteLine("Ingresar valor de Radio");
                double iRadio = Convert.ToDouble(Console.ReadLine());

                iCirculo = new Circulo(iPunto, iRadio);
                Console.WriteLine("El valor del AREA es: " + Math.Truncate(iCirculo.Area));
                Console.WriteLine("El valor del PERIMETRO es: " + Math.Truncate(iCirculo.Perimetro));
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

                iCirculo = new Circulo(iX, iY, iRadio);

                Console.WriteLine("El valor del AREA es: " + iCirculo.Area);
                Console.WriteLine("El valor del PERIMETRO es: " + iCirculo.Perimetro);
            }
        }

        public void AreaYPerimetroTriangulo()
        {
            Console.WriteLine("1-Deberá ingresar tres puntos");

            Console.WriteLine("Punto 1");
            Punto iPunto1 = this.CrearPunto();
            Console.WriteLine("Punto 2");
            Punto iPunto2 = this.CrearPunto();
            Console.WriteLine("Punto 3");
            Punto iPunto3 = this.CrearPunto();

            iTriangulo = new Triangulo(iPunto1, iPunto2, iPunto3);
            Console.WriteLine("El valor del AREA es: " + iTriangulo.Area);
            Console.WriteLine("El valor del PERIMETRO es: " + iTriangulo.Perimetro);

        }
    }
}
