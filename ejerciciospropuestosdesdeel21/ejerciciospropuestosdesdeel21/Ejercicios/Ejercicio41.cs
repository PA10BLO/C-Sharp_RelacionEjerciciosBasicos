using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace ejerciciospropuestosdesdeel21.Ejercicios
{
    internal class Ejercicio41
    {
        public static void JuegodeMemoria()
        {

            var prueba = 0;

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine(MenuEjercicios.Centrar("Bienvenido al juego de la memoria.", 95));

            Console.WriteLine();
            Console.WriteLine(MenuEjercicios.Centrar("Elige la dificultad: ", 95));
            Console.WriteLine(MenuEjercicios.Centrar("\t 1: Fácil", 95));
            Console.WriteLine(MenuEjercicios.Centrar("\t 2: Mediano ", 95));
            Console.WriteLine(MenuEjercicios.Centrar("\t 3: Díficl", 95));
            Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop);
            ConsoleKeyInfo tecla = new ConsoleKeyInfo('z', ConsoleKey.Z, false, false, false);


            Console.SetCursorPosition(Console.CursorLeft + 49, Console.CursorTop -1);
            Point point = new Point(Console.CursorLeft, Console.CursorTop);

            while (tecla.Key != ConsoleKey.Enter)
            {
               tecla = Console.ReadKey();
                if (tecla.Key == ConsoleKey.UpArrow && point.Y > 5)
                {
                    Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop - 1);
                    point.Y = Console.CursorTop;
                }
                if (tecla.Key == ConsoleKey.DownArrow && point.Y < 7)
                {
                    Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop + 1);
                    point.Y = Console.CursorTop;
                }
                prueba = Convert.ToInt32(point.Y);
            }


            switch (prueba)
            {
                case 5: JuguemosMemoria("Fácil"); break;
                case 6: JuguemosMemoria("Media"); break;
                case 7: JuguemosMemoria("Díficil"); break;
            }


        }

        private static void JuguemosMemoria(string v)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Bievenido al Juego de la Memoria... Dificultad " + v);


            List<int> nSerie = new List<int>();

            int wow;

            if (v.Equals("Fácil"))
            {
                wow = 10;
                EscribirSerie(wow, nSerie);
            }else if (v.Equals("Media"))
            {
                wow = 5;
                EscribirSerie(wow, nSerie);
            }else if (v.Equals("Díficil"))
            {
                wow = 2;
                EscribirSerie(wow, nSerie);
            }
                
        }

        private static void EscribirSerie(int wow, List<int> nSerie)
        {
            string mensaje = "";


            for (int i = 1; i < 11; i++)
            {
                nSerie = SiguienteSerie(i, nSerie);
                Console.WriteLine();

                for (int j = 0; j < wow; j++)
                {
                    Console.Write("*");
                    Thread.Sleep(1000);
                }
                Console.Clear();

                int nadivinar;

                Console.WriteLine("Ahora escribe los números mostrados en pantalla anteriormente: ");
                for (int j = 0; j < nSerie.Count; j++)
                {
                    nadivinar = ControladorMensajes.MensajePredeterminado<int>(mensaje);
                    if (nSerie[j] == nadivinar)
                    {

                    }
                    else
                    {
                        Console.WriteLine("Te has equivocado... Se acabó el juego");
                        return;
                    }
                }
            }
    }

        private static List<int> SiguienteSerie(int i, List<int> nSerie)
        {
            Random rand = new Random();

            Console.Clear();
            Console.WriteLine("Atento a los números");
            nSerie.Clear();

            for (int j = 0; j < i; j++)
            {
                nSerie.Add(rand.Next(1, 4));
            }

            bool primerElemento = true;

            foreach (int j in nSerie)
            {
                if (primerElemento)
                {
                    Console.Write(j);
                    primerElemento = false;
                }
                else
                {
                    Console.Write(", " + j);
                }
            }
            return nSerie;
        }
    }
}
