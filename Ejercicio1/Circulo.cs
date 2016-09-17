using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Circulo
    {
        //atributos------------------------
        private double iRadio, iX, iY, iArea, iPerimetro;
        private Punto iCentro;

        //constructores
        public Circulo(Punto pCentro, double pRadio)
        {
            this.iCentro = pCentro;
            this.iRadio = pRadio;
        }

        public Circulo(double pX, double pY, double pRadio)
        {
            this.iCentro = new Punto(pX, pY);//creación de objeto punto
            this.iRadio = pRadio;
        }

        //propiedades----------------------
        public Punto Centro
        {
            get { return this.iCentro; }
        }

        public double Radio
        {
            get { return this.iRadio; }
        }

        public double Area
        {
            get { return this.iArea = Math.PI * iRadio * iRadio; }
        }

        public double Perimetro
        {
            get { return this.iPerimetro = 2 * Math.PI * iRadio; }
        }

        //métodos-------------------------

    }
}
