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
            //MENU : DO-WHILE
            byte iOpcionMenu;

            do
            {
                Console.Clear();
                Console.WriteLine("JUEGO AHORACADO");
                Console.WriteLine("1- Nueva Partida");
                Console.WriteLine("2- Ver Primeros Puestos");
                Console.WriteLine("3- Salir");
                iOpcionMenu = Convert.ToByte(Console.ReadLine());

                switch (iOpcionMenu)
                {
                    case 1:  //nueva partida

                        Console.WriteLine("Datos de Jugador");
                        Console.Write("NroDocumento: ");
                        string iNrodocumento = Console.ReadLine();
                        Console.WriteLine("Nombre: ");
                        string iNombre = Console.ReadLine();
                        Console.WriteLine();

                        Console.WriteLine("Intentos: ");
                        Console.WriteLine("1- Por defecto (10)");
                        Console.WriteLine("2- Ingresar intentos");

                        byte iOpcion = Convert.ToByte(Console.ReadLine());
                        if (iOpcion == 2)
                        {
                            Console.WriteLine("Ingresar intentos: ");
                            int iIntentos = Convert.ToInt16(Console.ReadLine());
                            iFachada.NuevaPartida(iNrodocumento, iNombre, iIntentos);
                        }
                        else if (iOpcion == 1)
                        {
                            iFachada.NuevaPartida(iNrodocumento, iNombre);
                        }

                        Console.WriteLine("Éxito. Presione cualquier tecla para comienzar de Partida");
                        Console.ReadKey();
                        //------------bien

                        do //Jugando - sigue con vida
                        {
                            Console.Clear();
                            Console.WriteLine("JUEGO AHORCADO");
                            PalabraActual(iFachada); //metodo de Program para mostrar PalabraActual
                            Console.WriteLine();
                            Console.WriteLine("Intentos " + iFachada.Intentos);
                            Console.WriteLine();
                            Console.WriteLine("Ingrese Letra... ");
                            char iLetra = Convert.ToChar(Console.ReadLine());

                            iFachada.EvaluarLetra(iLetra); //verdadero si exite letra y actualiza
                            if (iFachada.ComparacionPalabras()) //palabra compmpleta
                            {
                                iFachada.FinPartida(true); //ganador
                                Console.WriteLine("GANASTE!, la palabra es: " + new string(iFachada.Palabra.Letras));
                                // PalabraActual(iFachada);
                                Console.ReadKey();
                                break; //ganador,corta el ciclo Do
                            }
                            else if (iFachada.Intentos == 0)
                            {
                                iFachada.FinPartida(false); //ganador
                                Console.WriteLine("PERDISTE! , la palabra es: "+ new string (iFachada.Palabra.Letras));
                                Console.ReadKey();
                            }
                            //Actualizar Palabra decrementa los intentos en la fachada
                        } while (iFachada.Intentos != 0);//sale con falso--> perdedor


                        break;
                    case 2:
                        Console.WriteLine("GANADORES CON MENOR DURACION");
                        iFachada.OrdenarPartidasPorDuracion(); 
                        for (int i = 0; i < 5; i++)
                        {
                            if (iFachada.PartidasPorDuracion[i] != null && iFachada.PartidasPorDuracion[i].Victoria == true)
                                {
                                    Console.Write("\tNombre: " + iFachada.PartidasPorDuracion[i].Jugador.Nombre);
                                    Console.Write("\tDuración: " + iFachada.PartidasPorDuracion[i].Duracion);
                                    Console.Write("\tVictoria: " + iFachada.PartidasPorDuracion[i].Victoria);
                                }                       
                        }
                                               
                        Console.ReadKey();

                        break;
                } //fin de switch

            } while (iOpcionMenu != 3); //fin menu do-while
        } //FIN DEL MAIN

        private static void PalabraActual(FachadaAhorcado pFachada)
        {
            Console.WriteLine("Palabra Actual");

            for (int i = 0; i < pFachada.PalabraJugador.Length; i++)
            {
                if (pFachada.PalabraJugador[i] == '\0')
                    Console.Write(" _ ");
                else
                    Console.Write(pFachada.PalabraJugador[i] + " ");
            }
        }
    }
}
