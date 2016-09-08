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
        private Palabra iPalabra;


        public void NuevaPartida(string pNroDocumento, string pNombre)
        {
            iJugador = new Jugador(pNroDocumento, pNombre);
            iPalabra = iAhorcado.SeleccionPalabra(); 
            iPartida = new Partida(iJugador,iPalabra);
            
        }
        public void PalabraActual()
        {
            for (int i = 0; i <= this.iPalabra.Letras.Length; i++)
            {
                for (int j = 0; j <= this.iAhorcado.Ocurrencias.Length; j++)
                {
                    if (iPalabra.Letras[i] == this.iAhorcado.Ocurrencias[j])
                        Console.Write(iPalabra.Letras[i]+ " ");
                    else
                        Console.Write(" _ ");
                }
            }
        }
        
        public bool EvaluarLetra(char pLetra)
        {
            if (this.iAhorcado.ExisteOcurrencia(pLetra))// si ya se uso la letra
            {
                this.iAhorcado.DecremetarIntento();
                return false;
            }
            else
            {
                iAhorcado.AgregarOcurrencia(pLetra);
                if (this.iPalabra.BuscarLetra(pLetra)) // letra se encuentra en palabra
                {
                    return true;
                }
                else //letra no se encuentra en la palabra
                {
                    //decrementar los intentos
                    this.iAhorcado.DecremetarIntento();
                    return false;
                }
            }
        }

        public bool EstadoAhorcado() //ganó o perdió?
        {
            if (iAhorcado.Intentos != 0)
                return true;//sigue jugando
            else
            {//se guardan los datos en el objeto
                this.iPartida.FinPartida();
                this.iAhorcado.InsertarPartida(iPartida);
                return false;
            }
        }

        public void MostrarOcurrencias() 
        {
            for (int i = 0; i <= this.iPalabra.Letras.Length; i++)
            {
              Console.Write(iPalabra.Letras[i] + " ");
            }
        }
    }
}
