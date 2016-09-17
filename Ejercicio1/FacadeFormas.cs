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



        public Punto UnPunto
        {
            get { return this.iPunto; }

        }


        public Circulo UnCirculo
        {
            get
            {
                return this.iCirculo;
            }
        }

        public Triangulo UnTriangulo
        {
            get { return this.iTriangulo; }

        }

        public void CrearPunto(double pX, double pY)
        {
            this.iPunto = new Punto(pX, pY);
        }

        public double CrearCirculo(double pPunto, double pRadio)
        {
            return CrearCirculo(pPunto, pRadio);

        }

        public Circulo CrearCirculo(double pX, double pY, double pRadio)
        {
            Punto iPunto = new Punto(pX, pY);
            //this.iCirculo = new Circulo(pX, pY, pRadio);
            return iCirculo = new Circulo(iPunto, pRadio);


        }

        public Circulo CrearCirculo(Punto pPunto, double pRadio)
        {
            return iCirculo = new Circulo(pPunto, pRadio);

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

            return iTriangulo = new Triangulo(pPunto1, pPunto2, pPunto3);
        }

        public double AreaTriangulo(Triangulo pTriangulo)
        {
            return pTriangulo.Area;
        }

        public double PerimetroTriangulo(Triangulo pTriangulo)
        {
            return pTriangulo.Perimetro;
        }

    }
}
