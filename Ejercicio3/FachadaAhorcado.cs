using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class FachadaAhorcado
    {
        private Ahorcado iAhorcado;
        private Partida iPartida;
        private Jugador iJugador;

        public void NuevaPartida(string pNroDocumento, string pNombre)
        {
            iJugador = new Jugador(pNroDocumento, pNombre);
            iPartida = new Partida(iJugador);

        }

        
    }
}
