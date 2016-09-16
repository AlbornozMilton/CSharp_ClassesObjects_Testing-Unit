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
        private int iControlPalabra; //control para saber si la palabra se adivino


        //-------constructor-----------
        public FachadaAhorcado()
        {
            this.iAhorcado = new Ahorcado();
        }

        //------- propiedades  --------
        public Palabra Palabra
        {
             get { return this.iAhorcado.Palabra ;} 
        }

        public Char[] Ocurrencias
        {
            get { return this.iAhorcado.Ocurrencias; }
        }

        public int Control
        {
            get { return this.iControlPalabra; }
        }

        public int Intentos
        {
            get { return this.iAhorcado.Intentos; }
        }
        //----------metodos----------
        public void NuevaPartida(string pNroDocumento, string pNombre)// Intentos por default
        {
            this.iJugador = new Jugador(pNroDocumento, pNombre);
            this.iPartida = new Partida(iJugador,iAhorcado.Palabra);
            this.iControlPalabra = iAhorcado.Palabra.Letras.Length;           
        }

        public void NuevaPartida(string pNroDocumento, string pNombre,int pIntentos)//intentos mediante consola
        {
            this.iJugador = new Jugador(pNroDocumento, pNombre);
            this.iPartida = new Partida(iJugador, iAhorcado.Palabra);
            this.iAhorcado.Intentos = pIntentos;
            this.iControlPalabra = iAhorcado.Palabra.Letras.Length;
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
                if (this.iAhorcado.Palabra.BuscarLetra(pLetra)) // letra se encuentra en palabra
                {
                    this.iControlPalabra--;
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

        
        public void FinPartida(bool pVictoria)
        {
            this.iPartida.FinPartida(pVictoria); //??
            this.iAhorcado.InsertarPartida(this.iPartida);
        }

        private bool void PalabraActual(FachadaAhorcado pFachada)
        {
            for (int i = 0; i < pFachada.Ocurrencias.Length; i++)
            {
                if (pFachada.Palabra.Letras[i] == pFachada.Ocurrencias[i])
                    Console.Write(pFachada.Palabra.Letras[i] + " ");
                else
                    Console.Write(" _ ");
            }
        }
    }
}
