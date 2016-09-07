using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class FacadeFormas //Fachada (Facade)
    {

        public Punto CrearPunto(double pX, double pY)
        {
            return new Punto(pX, pY);
        }

        
        public Circulo CrearCirculo(double pX, double pY, double pRadio)
        {
            Punto iPunto = new Punto(pX, pY);
            return new Circulo(iPunto, pRadio);
        }
        
        public Circulo CrearCirculo(Punto pPunto,double pRadio)
        {
            return new Circulo(pPunto, pRadio);
        }

        public double AreaCirculo(Circulo pCirculo)
        {
            return pCirculo.Area;
        }

        public double PerimetroCirculo(Circulo pCirculo)
        {
            return pCirculo.Perimetro;
        }

        public Triangulo CrearTriangulo(Punto pPunto1, Punto pPunto2, Punto pPunto3)
        {
            return new Triangulo(pPunto1, pPunto2, pPunto3);
        }

        public double AreaTriangulo (Triangulo pTriangulo)
        {
            return pTriangulo.Area;
        }

        public double PerimetroTriangulo(Triangulo pTriangulo)
        {
            return pTriangulo.Perimetro;
        }

    }
}
