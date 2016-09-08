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
            get { return this.iFechaInicio.Date; }
        }

        public int HoraInicio
        {
            get { return this.iHoraInicio.Hour; }
        }
        public int HoraFin
        {
            get { return this.iHoraFin.Hour; }
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

        public void FinPartida(bool pVictoria)
        {
            this.iHoraFin = new DateTime();
            this.iVictoria = pVictoria;
        }

        public int Duracion()
        {
          return (this.iHoraFin.Second - this.iHoraInicio.Second);
        }
    }
}
