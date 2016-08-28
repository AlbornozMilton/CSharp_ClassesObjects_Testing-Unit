using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Punto
    {
        //atributos------------------------
        private double iX, iY;

        //constructores
        public Punto() : this(0, 0) { }

        public Punto(double pX, double pY)
        {
            this.iX = pX;
            this.iY = pY;
        }

        //propiedades----------------------
        public double X
        {
            get { return this.iX; }

        }

        public double Y
        {
            get { return this.iY; }
        }

        //métodos-------------------------
        public double CalcularDistanciaDesde(Punto pPunto)
        {
            return Math.Sqrt( Math.Pow(pPunto.X - this.iX, 2) + Math.Pow(pPunto.Y - this.iY, 2)  );
        }
        
    }
}
