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
        private Palabra[] iDiccionario = new Palabra[30];
        private Partida[] iPartidas = new Partida[20];
        private char[] iOcurrencias = new char[27];
        private int iContador; //contador de ocurrencias
        private int iIndex; //contador de partidas
        //-----------constructores
        public Ahorcado() 
        {
            iIntentos = 10;
            iDiccionario = IniciarDiccionario(iDiccionario);
            iContador = 0;
            iIndex = 0;
        }

        public Ahorcado(int pIntentos)
        {
            iIntentos = pIntentos;
            iDiccionario = IniciarDiccionario(iDiccionario);
            iContador = 0;
            iIndex = 0;
        }

        //-------------------propiedades
        public int Intentos
        {
            get { return this.iIntentos; }
        }

        public char[] Ocurrencias
        {
            get { return this.iOcurrencias; }
        }
        //-----------------métodos
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

        public Palabra SeleccionPalabra() //seleccion aleatoria
        {
            Random iRandom = new Random();
            int iPos = iRandom.Next(0,29);
            return this.iDiccionario[iPos];
        }

        public void AgregarOcurrencia(char pLetra)
        {
            iOcurrencias[iContador] = pLetra;
            this.iContador++;
        }

        public bool ExisteOcurrencia(char pLetra)
        {
            int i = 0;
            do
            { if (this.iOcurrencias[i] == pLetra)
                    return true;
            i++;
            } while (i <= this.iOcurrencias.Length) ;
            return false;
        }

        public void DecremetarIntento()
        {
            this.iIntentos--;
        }

        public void InsertarPartida(Partida pPartida) //insertar una vez terminada la partida
        {
            this.iPartidas[iIndex] = pPartida;
            this.iIndex++;
        }

        //------------------------------
        public void MostrarDiccionario()
        {
            for (int i = 0;i<=this.iDiccionario.Length-1;i++)
            {
                Console.WriteLine(this.iDiccionario[i].ToString());
            }
            Console.ReadKey();
        }
        //--------------------------
    }
}
