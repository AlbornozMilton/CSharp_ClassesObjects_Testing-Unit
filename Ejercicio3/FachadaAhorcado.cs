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
        private int iControl; //control para saber si la palabra se adivino
       
        public void NuevaPartida(string pNroDocumento, string pNombre)// Intentos por default
        {
            iJugador = new Jugador(pNroDocumento, pNombre);
            iPalabra = iAhorcado.SeleccionPalabra(); 
            iPartida = new Partida(iJugador,iPalabra);
            iAhorcado = new Ahorcado();
            iControl = iPalabra.Letras.Length;           
        }

        public void NuevaPartida(string pNroDocumento, string pNombre,int pIntentos)//intentos mediante consola
        {
            iJugador = new Jugador(pNroDocumento, pNombre);
            iPalabra = iAhorcado.SeleccionPalabra();
            iPartida = new Partida(iJugador, iPalabra);
            iAhorcado = new Ahorcado(pIntentos);
            iControl = iPalabra.Letras.Length;
        }

        public void PalabraActual()
        {
            for (int i = 0; i <= this.iPalabra.Letras.Length; i++)
            {
                for (int j = 0; j <= this.iAhorcado.Ocurrencias.Length; j++)
                {
                    if (this.iPalabra.Letras[i] == this.iAhorcado.Ocurrencias[j])
                        Console.Write(this.iPalabra.Letras[i]+ " ");
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
                this.iAhorcado.AgregarOcurrencia(pLetra);
                if (this.iPalabra.BuscarLetra(pLetra)) // letra se encuentra en palabra
                {
                    this.iControl--;
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
            //determinar cuando ganar
            if (this.iAhorcado.Intentos != 0)
                return true;//sigue jugando
            else
            {
                //se guardan los datos en el objeto
                this.FinPartida(false);
                return false;
            }
        }

        public int Control
        {
            get { return this.iControl; }
        }

        public void FinPartida(bool pVictoria)
        {
            this.iPartida.FinPartida(pVictoria); //??
            this.iAhorcado.InsertarPartida(this.iPartida);
        }

        public void MostrarOcurrencias() 
        {
            for (int i = 0; i <= this.iPalabra.Letras.Length; i++)
            {
              Console.Write(this.iPalabra.Letras[i] + " ");
            }
        }
        public int Intentos()
        {
            return this.iAhorcado.Intentos;
        }

        public string Palabra()
        {
           return this.iPalabra.ToString();
        }
    }
}
