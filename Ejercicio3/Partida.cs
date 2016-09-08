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
        private DateTime iHoraHinicio;
        private DateTime iHoraFin;
        private int iDuracion;
        private bool iVictoria;
        private Jugador iJugador;

        public Partida (Jugador pJugador) // INICIO DE PARTIDA
        {
        iFechaInicio = new DateTime();
        iHoraHinicio = new DateTime();
        iJugador = pJugador;
        }

        public Partida FinPartida(pHoraFin,pDuracion,pVictoria) 
        {
            this.iHoraFin = 0;
            this.iDuracion = 0;
            this.iVictoria = 0;
        }
    }
}
