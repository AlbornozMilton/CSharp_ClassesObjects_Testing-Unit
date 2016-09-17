using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    public class Complejo
    {
        private readonly double iReal, iImaginario;
        //CONSTRUCTORESS
        public Complejo(double pReal, double pImaginario)
        {
            this.iReal = pReal;
            this.iImaginario = pImaginario;
        }

        //PROPIEDADES
        public double Real
        {
            get { return this.iReal; }
        }
        public double Imaginario
        {
            get { return this.iImaginario; }
        }
        public double Magnitud
        {
            get { return Math.Sqrt((Math.Pow(this.iReal, 2)) + Math.Pow(this.iImaginario, 2)); }
        }
        public Complejo Conjugado
        {
            get { return new Complejo(this.iReal, (this.iImaginario * -1)); }
        }
        public double ArgumentoEnRadianes
        {
            get
            {
                if (this.iReal > 0)
                {
                    return Math.Atan(this.iImaginario / this.iReal);
                }
                else
                {
                    if (this.iReal < 0)
                    {
                        if (this.iImaginario >= 0)
                        {
                            return (Math.Atan(this.iImaginario / this.iReal)) + Math.PI;
                        }
                        else
                        {
                            return (Math.Atan(this.iImaginario / this.iReal)) - Math.PI;
                        }
                    }
                    else
                    {
                        if (this.iImaginario > 0)
                        {
                            return Math.PI / 2;
                        }
                        else
                        {
                            return -(Math.PI / 2);
                        }
                    }
                }
            }
        }

        public double ArgumentoEnGrados
        {
            get { return (180 * this.ArgumentoEnRadianes) / Math.PI; }
        }

        //METODOS
        public Boolean EsReal()
        {
            if (this.iImaginario == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Boolean EsImaginario()
        {
            if (this.iReal == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public Boolean EsIgual(Complejo pOtroComplejo)
        {
            if ((this.iReal == pOtroComplejo.iReal) && (this.iImaginario == pOtroComplejo.iImaginario))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Boolean EsIgual(double pReal, double pImaginario)
        {
            if (this.iReal == pReal && this.iImaginario == pImaginario)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Complejo Sumar(Complejo pOtroComplejo)
        {
            double iRe = this.iReal + pOtroComplejo.iReal;
            double iIma = this.iImaginario + pOtroComplejo.iImaginario;
            return new Complejo(iRe, iIma);
        }
        public Complejo Restar(Complejo pOtroComplejo)
        {
            double iRe = this.iReal - pOtroComplejo.iReal;
            double iIma = this.iImaginario - pOtroComplejo.iImaginario;
            return new Complejo(iRe, iIma);
        }
        public Complejo MultiplicarPor(Complejo pOtroComplejo)
        {
            double iRe = ((this.iReal * pOtroComplejo.Real) - ((this.iImaginario * pOtroComplejo.Imaginario)));
            double iIma = ((this.iReal * pOtroComplejo.Imaginario) + (this.iImaginario * pOtroComplejo.Real));
            return new Complejo(iRe, iIma);
        }

        public Complejo DividirPor(Complejo pOtroComplejo)
        {
            double iRe = ((this.iReal * pOtroComplejo.Real + this.iImaginario * pOtroComplejo.Imaginario) / (Math.Pow(pOtroComplejo.Real, 2) + Math.Pow(pOtroComplejo.Imaginario, 2)));
            double iIma = ((this.iImaginario * pOtroComplejo.Real - this.iReal * pOtroComplejo.Imaginario) / (Math.Pow(pOtroComplejo.Real, 2) + Math.Pow(pOtroComplejo.Imaginario, 2)));
            return new Complejo(iRe, iIma);
        }
    }
}
