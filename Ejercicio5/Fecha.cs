using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
    public class Fecha
    {
        private const int AÑO_BASE = 1900;
        private static readonly int[] CANTIDAD_DIAS_MES = { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        private static readonly int[] CLAVE_MES = { 0, 3, 3, 6, 1, 4, 6, 2, 5, 0, 3, 5 };
        private static readonly int[] CLAVE_SIGLO = { 0, 6, 4, 2, 0, 6 };
        private static readonly string[] DIA_SEMANA = { "Domingo", "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado" };
        private readonly long iCantidadDias;
        private readonly int iDia;
        private readonly int iMes;
        private readonly int iAño;

        public Fecha(int pDia, int pMes, int pAño)
        {
            if (pMes < 1 || pMes > 12)
            {
                throw new ArgumentException("El mes debe estar comprendido entre 1 y 12");
            }
            if (pDia < 1 || pDia > Fecha.GetCantDiasMes(pMes, pAño))
            {
                throw new ArgumentException("El dia debe estar comprendido entre 1 y la cantidad maxima de dias correspondiente al mes y año");
            }
            this.iDia = pDia;
            this.iMes = pMes;
            this.iAño = pAño;

            long mCantidadDias = pDia;

            for (int bMes = 1; bMes < pMes; bMes++)
            {
                mCantidadDias += Fecha.GetCantDiasMes(bMes, pAño);
            }
            for (int bAño = AÑO_BASE; bAño < pAño; bAño++)
            {
                mCantidadDias += Fecha.GetCantDiasAño(bAño);
            }
            this.iCantidadDias = mCantidadDias;
        }

        public Fecha AgregarDias(int pCant)
        {
            int mDia = this.iDia;
            int mMes = this.iMes;
            int mAño = this.iAño;

            while ((GetCantDiasMes(mMes, mAño) - mDia) < pCant)
            {
                pCant -= (GetCantDiasMes(mMes, mAño) - mDia);
                mDia = 0;
                if (mMes == 12)
                {
                    mMes = 1;
                    mAño++;
                }
                else
                {
                    mMes++;
                }
            }
            mDia += pCant;
            return new Fecha(mDia, mMes, mAño);
        }

        public Fecha AgregarMeses(int pCant)
        {
            int mMes = this.iMes;
            int mAño = this.iAño;
            int mControl = pCant;
            while (mControl != 0)
            {
                if (mMes == 12)
                {
                    mMes = 1;
                    mAño++;
                }
                else
                {
                    mMes++;
                }
                mControl--;
            }
            return new Fecha(this.iDia, mMes, mAño);
        }

        public Fecha AgregarAños(int pCant)
        {
            return new Fecha(this.iDia, this.iMes, this.iAño + pCant);
        }

        private static int GetCantDiasMes(int pMes, int pAño)
        {
            int mCantidadDias = CANTIDAD_DIAS_MES[pMes - 1];
            if (pMes == 2 && !Fecha.EsBisiesto(pAño))
            {
                mCantidadDias -= 1;
            }
            return mCantidadDias;
        }

        private static bool EsBisiesto(int pAño)
        {
            return (pAño % 4 == 0 && pAño % 100 != 0) || pAño % 400 == 0;
        }

        public bool EsBisiesto()
        {
            return Fecha.EsBisiesto(this.iAño);
        }

        public int Dia
        {
            get { return this.iDia; }
        }

        public int Mes
        {
            get { return this.iMes; }
        }

        public int Año
        {
            get { return this.iAño; }
        }

        public String DiaSemana
        {
            get
            {
                int mClaveSiglo = CLAVE_SIGLO[Convert.ToInt32(Convert.ToString(this.iAño).Substring(0, 2)) - 19];
                int mAño = Convert.ToInt32(Convert.ToString(this.iAño).Substring(2, 2));
                int mDiaSemana = ((this.iDia + CLAVE_MES[this.iMes - 1] + mAño + (mAño / 4) + mClaveSiglo) % 7);
                return DIA_SEMANA[mDiaSemana];
            }
        }

        public long CompararFechas(Fecha pFecha)
        {
            if (pFecha == null)
            {
                throw new ArgumentNullException("La fecha proporcionada es nula.");
            }
            return Math.Abs(this.iCantidadDias - pFecha.iCantidadDias);
        }

        private static int GetCantDiasAño(int pAño)
        {
            int mCantidadDias = 365;
            if (Fecha.EsBisiesto(pAño))
            {
                mCantidadDias++;
            }
            return mCantidadDias;
        }
    }
}