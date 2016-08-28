using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Triangulo
    {
        //atributos------------------------
        private Punto iPunto1, iPunto2, iPunto3;
        private double iArea, iPerimetro;

        //constructor----------------------
        public Triangulo(Punto pPunto1, Punto pPunto2, Punto pPunto3) //constructor de instancia
        {
            this.iPunto1 = pPunto1;
            this.iPunto2 = pPunto2;
            this.iPunto3 = pPunto3;
        }

        //propiedades----------------------
        public Punto Punto1
        {
            get { return this.iPunto1; }

        }

        public Punto Punto2
        {
            get { return this.iPunto2; }

        }
        public Punto Punto3
        {
            get { return this.iPunto3; }

        }

        public double Area
        {        
            get {
                return this.iArea =
                  Math.Sqrt(   0.5 * (this.Perimetro) * //semiperimetro
                              (0.5 * this.Perimetro - this.iPunto1.CalcularDistanciaDesde(this.iPunto2)) *
                              (0.5 * this.Perimetro - this.iPunto2.CalcularDistanciaDesde(this.iPunto3)) *
                              (0.5 * this.Perimetro - this.iPunto3.CalcularDistanciaDesde(this.iPunto1))
                            );
                }
            /*     0.5 *
                   this.iPunto1.CalcularDistanciaDesde(this.iPunto2) 
                   this.iPunto3.CalcularDistanciaDesde(this.iPunto2); 
                   */
        }

        public double Perimetro
        {
            //suma de los lados
            get {
                return this.iPerimetro =
                  this.iPunto1.CalcularDistanciaDesde(this.iPunto2) +
                  this.iPunto2.CalcularDistanciaDesde(this.iPunto3) +
                  this.iPunto3.CalcularDistanciaDesde(this.iPunto1);
                }
        }
        
        //métodos-------------------------
        
    }
}
