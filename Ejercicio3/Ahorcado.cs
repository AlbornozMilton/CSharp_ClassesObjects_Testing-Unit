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
        private Partida[] iPartidas = new Partida[20];
        private int iCantPartias; //contador de partidas
        
        //-----------constructores
        public Ahorcado()
        {
            this.iIntentos = 10;
            this.IniciarDiccionario();
            this.SeleccionPalabra();
            this.iCantPartias = 0;
        }

        public Ahorcado(int pIntentos) //se ingresa la cantidad de intentos
        {
            this.iIntentos = pIntentos;
            this.IniciarDiccionario();
            this.SeleccionPalabra();
            this.iCantPartias = 0;
        }

        //-------------------propiedades---------
        public int Intentos
        {
            get { return this.iIntentos; }
            set { this.iIntentos = value; }
        }
         /*
        public char[] Ocurrencias
        {
            get { return this.iOcurrencias; }
        }
        */
        public Palabra Palabra
        {
            get { return this.iPalabra; }
        }

        //-----------------métodos
        /*
        private Palabra[] IniciarDiccionario(Palabra[] pDiccionario) //la seleccion de la palabra es aleatoria
        {
            pDiccionario[0] = new Palabra("mantecol");
            pDiccionario[1] = new Palabra("bicicleta");
            pDiccionario[2] = new Palabra("mesa");
            pDiccionario[3] = new Palabra("caracol");
            pDiccionario[4] = new Palabra("calefon");
            pDiccionario[5] = new Palabra("heladera");
            pDiccionario[6] = new Palabra("cortina");
            pDiccionario[7] = new Palabra("microondas");
            pDiccionario[8] = new Palabra("conexion");
            pDiccionario[9] = new Palabra("computadora");
            pDiccionario[10] = new Palabra("teclado");
            pDiccionario[11] = new Palabra("rueda");
            pDiccionario[12] = new Palabra("cable");
            pDiccionario[13] = new Palabra("amarillo");
            pDiccionario[14] = new Palabra("celeste");
            pDiccionario[15] = new Palabra("carrera");
            pDiccionario[16] = new Palabra("musica");
            pDiccionario[17] = new Palabra("puzzle");
            pDiccionario[18] = new Palabra("emocion");
            pDiccionario[19] = new Palabra("magia");
            pDiccionario[20] = new Palabra("congelar");
            pDiccionario[21] = new Palabra("suscripcion");
            pDiccionario[22] = new Palabra("cartas");
            pDiccionario[23] = new Palabra("tutorial");
            pDiccionario[24] = new Palabra("ingenieria");
            pDiccionario[25] = new Palabra("videos");
            pDiccionario[26] = new Palabra("historial");
            pDiccionario[27] = new Palabra("corazon");
            pDiccionario[28] = new Palabra("amistad");
            pDiccionario[29] = new Palabra("ecuacion");

            return pDiccionario;
        }
        */
        public void IniciarDiccionario() //la seleccion de la palabra es aleatoria
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
            int iPos = iRandom.Next(0, 29); //rango del arreglo
            this.iPalabra = new Palabra(this.iDiccionario[iPos]);
        }

        /*
        public void AgregarOcurrencia(char pLetra)
        {
            this.iOcurrencias[iContador] = pLetra;
            this.iContador++;
        }

        public bool ExisteOcurrencia(char pLetra)
        {
            int i = 0;
            do
            {
                if (this.iOcurrencias[i] == pLetra) //error
                    return true;
                i++;
            } while (i <= this.iOcurrencias.Length);
            return false;
        }
        */
        public void DecremetarIntento()
        {
            this.iIntentos--;
        }

        public void InsertarPartida(Partida pPartida) //insertar una vez terminada la partida
        {
            this.iPartidas[iCantPartias] = pPartida;
            this.iCantPartias++;
        }

        //------------------------------pruebas
        public void MostrarDiccionario()
        {
            for (int i = 0; i <= this.iDiccionario.Length - 1; i++)
            {
                Console.WriteLine(this.iDiccionario[i]);
            }
            Console.WriteLine("Fin diccionario");
        }
        //--------------------------
    }
}
