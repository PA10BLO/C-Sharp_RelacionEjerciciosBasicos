using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciospropuestosdesdeel21.Ejercicios
{
    internal class Ejercicio29
    {
        public static void poligonos()
        {

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine(" Veamos el Cálculo de Polígonos");
            Console.WriteLine();
            for (int i = 0; i < 10; i++)
            {
                Console.Write("*");
                Thread.Sleep(100);
            }
            Console.Clear();


            var menu = 0;
            Console.WriteLine("");
            Console.WriteLine("Bienvenidos al cálculo de polígonos");
            Console.WriteLine("¿Qué desea realizar");
            Console.WriteLine("1: El área");
            Console.WriteLine("2: El perímetro");
            menu = Convert.ToInt32(Console.ReadLine());
            switch (menu)
            {
                case 1:
                    area();
                    break;
                case 2:
                    perimetro();
                    break;
            }
        }

        public static void perimetro()
        {
            Console.WriteLine(" Para poder calcular el área necesito unos datos, por favor introducelos: ");
            Console.WriteLine(" El número de lados");
            int nlados = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Longitud del lado");
            int longitud = Convert.ToInt32(Console.ReadLine());
            int perimetro = nlados * longitud;
            Console.WriteLine($"El perímetro del {typepoly(nlados)} es de {perimetro}");
        }

        public static String typepoly(int nlados)
        {
            String[] poligonos = new String[] { "Triángulo", "Tetrágono", "Pentágono", "Hexágono", "Heptágono", "Octógono", "Eneágono", "Decágono", "Endecágono", "Dodécagono", "Tridecágono", "Tetradecágono", "Pentadecágono", "Hexadecágono", "Heptadecágono", "Octodecágono", "Eneadecágono", "Isodecágono" };
            return poligonos[nlados - 3];
        }

        public static void area()
        {
            Console.WriteLine(" Para poder calcular el área necesito unos datos, por favor introducelos: ");
            Console.WriteLine(" El número de lados");
            int nlados = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Longitud del lado");
            int longitud = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" El apotema");
            int apotema = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("...");
            int area = nlados * longitud * apotema / 2;
            Console.WriteLine($"El área es de {area}");
        }
    }
}
