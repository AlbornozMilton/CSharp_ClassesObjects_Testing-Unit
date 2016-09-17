using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Ahorcado
    {
        private int iIntentos;
        private string[] iDiccionario = new string[30];
        private Palabra iPalabra;
        private Partida[] iPartidas;
        private int iCantPartidas; //contador de partidas
        
        //-----------constructor
        public Ahorcado()
        {
            this.IniciarDiccionario();
            this.iCantPartidas = 0;
            this.iPartidas = new Partida[20];
        }
        

        //-------------------propiedades---------
        public int Intentos
        {
            get { return this.iIntentos; }
            set { this.iIntentos = value; }
        }
         
        public Partida[] Partidas
        {
            get { return this.iPartidas; }
        }
        
        public Palabra Palabra
        {
            get { return this.iPalabra; }
        }

        //-----------------métodos
         
        public void IniciarDiccionario()
        {
            this.iDiccionario[0] = "mantecol";
            this.iDiccionario[1] = "bicicleta";
            this.iDiccionario[2] = "mesa";
            this.iDiccionario[3] = "caracol";
            this.iDiccionario[4] = "calefon";
            this.iDiccionario[5] = "heladera";
            this.iDiccionario[6] = "cortina";
            this.iDiccionario[7] = "microondas";
            this.iDiccionario[8] = "conexion";
            this.iDiccionario[9] = "computadora";
            this.iDiccionario[10] = "teclado";
            this.iDiccionario[11] = "rueda";
            this.iDiccionario[12] = "cable";
            this.iDiccionario[13] = "amarillo";
            this.iDiccionario[14] = "celeste";
            this.iDiccionario[15] = "carrera";
            this.iDiccionario[16] = "musica";
            this.iDiccionario[17] = "puzzle";
            this.iDiccionario[18] = "emocion";
            this.iDiccionario[19] = "magia";
            this.iDiccionario[20] = "congelar";
            this.iDiccionario[21] = "suscripcion";
            this.iDiccionario[22] = "cartas";
            this.iDiccionario[23] = "tutorial";
            this.iDiccionario[24] = "ingenieria";
            this.iDiccionario[25] = "videos";
            this.iDiccionario[26] = "historial";
            this.iDiccionario[27] = "corazon";
            this.iDiccionario[28] = "amistad";
            this.iDiccionario[29] = "ecuacion";
        }


        public void SeleccionPalabra() //seleccion aleatoria
        {
            Random iRandom = new Random();
            this.iPalabra = new Palabra(this.iDiccionario[iRandom.Next(0, 29)]); //rango del arreglo de 0 a 29
        }

        public void InsertarPartida(Partida pPartida) //insertar una vez terminada la partida
        {
            this.iPartidas[iCantPartidas] = pPartida;
            this.iCantPartidas++;
        }

        public void OrdenAscendente()//orden burbuja
        {
            for (int i = 0; i < (this.iPartidas.Length); i++)
            {
                for (int j = 0; j < (this.iPartidas.Length) - i; j++)
                {
                    if (this.Partidas[j + 1] == null) break;
                    if (this.Partidas[j].Duracion > this.Partidas[j + 1].Duracion)
                    {
                        //intercambio de posiciones
                        Partida iAux = this.Partidas[j];
                        this.Partidas[j] = this.Partidas[j + 1];
                        this.Partidas[j + 1] = iAux;
                    }
                }
            }
        }//fin de burbuja


    }
}
