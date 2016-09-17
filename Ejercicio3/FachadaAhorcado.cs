using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class FachadaAhorcado
    {
        private Ahorcado iAhorcado = new Ahorcado();
        private Partida iPartida;
        private Jugador iJugador;
        private char[] iPalabraJugador;
       
        
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
            
        public Partida[] PartidasPorDuracion
        {
            get { return this.iAhorcado.Partidas; }
        }
    
        //----------metodos----------

        public void NuevaPartida(string pNroDocumento, string pNombre)// Intentos por default
        {
            this.iAhorcado.SeleccionPalabra();
            this.iPalabraJugador = new char[this.iAhorcado.Palabra.Letras.Length];
            this.iJugador = new Jugador(pNroDocumento, pNombre);
            this.iPartida = new Partida(iJugador, iAhorcado.Palabra);
            this.iAhorcado.Intentos = 10;
        }

        public void NuevaPartida(string pNroDocumento, string pNombre, int pIntentos)//intentos mediante consola
        {
            this.iAhorcado.Intentos = (pIntentos);
            this.iAhorcado.SeleccionPalabra();
            this.iPalabraJugador = new char[this.iAhorcado.Palabra.Letras.Length];
            this.iJugador = new Jugador(pNroDocumento, pNombre);
            this.iPartida = new Partida(iJugador, iAhorcado.Palabra);
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

        private void OrdenAscendente()//orden burbuja
        {
            for (int i = 0; i < (this.iAhorcado.Partidas.Length); i++)
            {
                for (int j = 0; j < (this.iAhorcado.Partidas.Length) - i; j++)
                {
                    if (this.iAhorcado.Partidas[j].Duracion > this.iAhorcado.Partidas[j + 1].Duracion)
                    {
                        //intercambio de posiciones
                        Partida iAux = this.iAhorcado.Partidas[j];
                        this.iAhorcado.Partidas[j] = this.iAhorcado.Partidas[j + 1];
                        this.iAhorcado.Partidas[j + 1] = iAux;
                    }
                }
            }
        }
    }
}
