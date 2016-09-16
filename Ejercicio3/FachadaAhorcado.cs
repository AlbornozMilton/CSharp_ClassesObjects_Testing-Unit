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
        private char[] iPalabraJugador;
       
        //-------constructor-----------
        public FachadaAhorcado()
        {
            this.iAhorcado = new Ahorcado();
            this.iPalabraJugador = new char[this.iAhorcado.Palabra.Letras.Length];

        }

        //------- propiedades  --------
        public Palabra Palabra
        {
            get { return this.iAhorcado.Palabra; }
        }

        
        public char[] PalabraJugador
        {
            get { return this.iPalabraJugador; }
        }
        
        public int Intentos
        {
            get { return this.iAhorcado.Intentos; }
        }
        //----------metodos----------

        public void NuevaPartida(string pNroDocumento, string pNombre)// Intentos por default
        {
            this.iJugador = new Jugador(pNroDocumento, pNombre);
            this.iPartida = new Partida(iJugador, iAhorcado.Palabra);
            
        }

        public void NuevaPartida(string pNroDocumento, string pNombre, int pIntentos)//intentos mediante consola
        {
            this.iJugador = new Jugador(pNroDocumento, pNombre);
            this.iPartida = new Partida(iJugador, iAhorcado.Palabra);
            this.iAhorcado.Intentos = pIntentos;
            
        }

        public bool EvaluarLetra(char pLetra)
        {
            if (this.iAhorcado.Palabra.BuscarLetra(pLetra)) //Evalua la existencia de la letra antes
            {
                this.ActualizarPalabra(pLetra);
                return true;
            }
            else
            {
                this.iAhorcado.Intentos--;
                return false;
            }
         }

        private void ActualizarPalabra (char pLetra) //recorre toda la Palabra y actualiza PalabraJugador
        {
            for (int i = 0; i < this.iAhorcado.Palabra.Letras.Length; i++)
            {
                if (this.iAhorcado.Palabra.Letras[i]==pLetra) 
                {
                    this.iPalabraJugador[i] = pLetra;
                }
            }
        }

        public bool ComparacionPalabras() //compara Palabra con PalabaJugador para saber si se adivino la palabra
        {
            for (int i = 0; i < this.iAhorcado.Palabra.Letras.Length; i++)
            {
                if (this.iAhorcado.Palabra.Letras[i] != this.iPalabraJugador[i])
                //comara elemento a elemento, en caso de ser distintos elementos retorna falso
                {
                    return false;
                }
            }
            return true; //si todos los elementos son iguales, retorna verdadero
        }        
             
        public void FinPartida(bool pVictoria)
        {
            this.iPartida.FinPartida(pVictoria); 
            this.iAhorcado.InsertarPartida(this.iPartida);
        }
    }
}
