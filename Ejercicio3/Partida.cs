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
        private int iHoraInicio;
        private int iHoraFin;
        private int iDuracion;
        private bool iVictoria;
        private Jugador iJugador;
        private Palabra iPalabra;

        //-------------------constructor-----------------
        public Partida(Jugador pJugador, Palabra pPalabra) // INICIO DE PARTIDA
        {
            this.iFechaInicio = DateTime.Now.Date;
            this.iHoraInicio = DateTime.Now.Second;
            this.iHoraFin = 0;
            this.iDuracion = 0;
            this.iJugador = pJugador;
            this.iPalabra = pPalabra;
        }

        //------------propiedades----------------
        public DateTime FechaInicio
        {
            get { return this.iFechaInicio.Date; }
        }

        public int HoraInicio
        {
            get { return this.iHoraInicio; }
        }
        public int HoraFin
        {
            get { return this.iHoraFin; }
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

        public int Duracion
        {
            get { return this.iDuracion; }
        }
        //-----------Metodos---------------------------------

        public void FinPartida(bool pVictoria)
        {
            this.iHoraFin = DateTime.Now.Second;
            this.iVictoria = pVictoria;
            this.iDuracion = this.iHoraFin - iHoraInicio; 
        }
    }
}
