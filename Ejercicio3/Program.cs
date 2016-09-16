using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            FachadaAhorcado iFachada = new FachadaAhorcado();
            byte iOpcion;
            Console.WriteLine("JUEGO AHORACADO");

            Ahorcado A = new Ahorcado();
            A.MostrarDiccionario(); //prueba
            Console.WriteLine("LETRA:");
            
            for (int i = 0; i < iFachada.Palabra.Letras.Length; i++) 
            {
                Console.Write(iFachada.Palabra.Letras[i]);
            }
            Console.ReadKey();
            //menu
            Console.WriteLine("1- Nueva Partida");
            Console.WriteLine("2- Ver Primeros Puestos");
            iOpcion = Convert.ToByte(Console.ReadLine());

            if (iOpcion == 1) //JUGANDO
            {
                Console.WriteLine("Datos de Jugador");
                Console.Write("NroDocumento: ");
                string iNrodocumento = Console.ReadLine();
                Console.WriteLine("Nombre: ");
                string iNombre = Console.ReadLine();
                Console.WriteLine();

                Console.WriteLine("Intentos: ");
                Console.WriteLine("1- Por defecto (10)");
                Console.WriteLine("2- Ingresar intentos");

                iOpcion = Convert.ToByte(Console.ReadLine());
                if (iOpcion == 2)
                {
                    Console.WriteLine("Ingresar intentos: ");
                    int iIntentos = Convert.ToInt16(Console.ReadLine());
                    iFachada.NuevaPartida(iNrodocumento, iNombre, iIntentos);
                }
                else if (iOpcion==1)
                {
                    iFachada.NuevaPartida(iNrodocumento, iNombre);
                }
                Console.WriteLine("Éxito. Presione cualquier tecla para comienzar de Partida");
                Console.ReadKey();
                //------------bien

                while (iFachada.EstadoAhorcado()) //sigue con vida
                {
                    Console.Clear();
                    PalabraActual(iFachada);
                    Console.WriteLine();
                    Console.WriteLine("Letras Usadas: ");
                    MostrarOcurrencias(iFachada);
                    Console.WriteLine("Intentos "+iFachada.Intentos);
                    Console.WriteLine();
                    Console.WriteLine("Ingrese Letra ");
                    char iLetra = Convert.ToChar(Console.ReadLine());
                    iFachada.EvaluarLetra(iLetra);
                    if (iFachada.Control==0) 
                    {
                        iFachada.FinPartida(true); //ganador
                        Console.WriteLine("GANASTE!");
                        PalabraActual(iFachada);
                        Console.ReadKey();
                        break;
                    }
               }//sale con false--> perdedor
                Console.WriteLine("PERDISTE! , la palabra es: ");
                Console.ReadKey();
            }

            else if (iOpcion == 2)
            {
                //ordenar vector de partidas segun duracion
                //mostrar los primeros 5 que solo lo que tienen el campo Victoria = true
            }

        } //FIN DEL MAIN

        private static void PalabraActual(FachadaAhorcado pFachada)
        {
           for (int i = 0; i < pFachada.Ocurrencias.Length; i++)
                {
                    if (pFachada.Palabra.Letras[i] == pFachada.Ocurrencias[i])
                        Console.Write(pFachada.Palabra.Letras[i] + " ");
                    else
                        Console.Write(" _ ");
                }  
        }

        private static void MostrarOcurrencias(FachadaAhorcado pFachada)
        {
            for (int i = 0; i < pFachada.Ocurrencias.Length; i++)
            {
                Console.Write(pFachada.Ocurrencias[i] + " ");
            }
        
    }

    }
}
