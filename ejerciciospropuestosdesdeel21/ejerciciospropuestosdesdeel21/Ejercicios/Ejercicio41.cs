using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    //prueba = Convert.ToInt32(point.Y);
                    //Console.Write(prueba);
                }
                if (tecla.Key == ConsoleKey.DownArrow && point.Y < 7 /*&& point.Y < 8)*/ )
                {
                    Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop + 1);
                    point.Y = Console.CursorTop;
                }
                //prueba = Convert.ToInt32(point.Y);
                prueba = Convert.ToInt32(point.Y);
                //Console.Write(prueba);
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

            //var nSerie = new int[] { 1, 2, 3 };

            for (int i = 1; i < 11; i++)
            {
                SiguienteSerie(i, nSerie);
                Console.ReadLine();
            }
        }

        private static void SiguienteSerie(int i, List<int> nSerie)
        {
            Random rand = new Random();

            //Array.Clear(nSerie, 0, nSerie.Length);
            nSerie.Clear();

            for (int j = 0; j < i; j++)
            {
                //nSerie[j] = rand.Next(1, 3);
                nSerie.Add(rand.Next(1, 3));
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

            //foreach (int j in nSerie)
            //{
            //    Console.Write(j + ", ");
            //}
            //for (int j = 0; i < nSerie.Count; i++)
            //{
            //    if (nSerie[j] == nSerie.Count-1)
            //    {
            //        Console.Write(nSerie[j]);
            //    }
            //    else
            //    {
            //        Console.Write(nSerie[j] + ", ");
            //    }
            //}

        }
    }
}
