using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Partida
    {
        private DateTime iFechaInicio;
        private DateTime iHoraInicio;
        private DateTime iHoraFin;
        private int iDuracion;
        private bool iVictoria;
        private Jugador iJugador;
        private Palabra iPalabra;

        //-------------------constructor-----------------
        public Partida (Jugador pJugador,Palabra pPalabra) // INICIO DE PARTIDA
        {
        iFechaInicio = new DateTime();
        iHoraInicio = new DateTime();
        iJugador = pJugador;
        iPalabra = pPalabra;
        }

        //------------propiedades----------------
        public DateTime FechaInicio
        {
            get { return this.iFechaInicio; }
        }

        public DateTime HoraInicio
        {
            get { return this.iHoraInicio; }
        }
        public DateTime HoraFIn
        {
            get { return this.iHoraFin; }
        }
        public int Duracion
        {
            get { return this.iDuracion; }
        }
        public bool Victoria
        {
            get { return this.iVictoria; }
        }
        public Jugador Jugador
        {
            get { return this.iJugador; }
        }

        public Palabra Palabra
        {
            get { return this.iPalabra; }
        }
        //-----------Metodos---------------------------------
        public void FinPartida(pHoraFin, pDuracion,bool pVictoria)
        {
            this.iHoraFin = 0;
            this.iDuracion = 0;
            this.iVictoria = pVictoria;
        }
    }
}
