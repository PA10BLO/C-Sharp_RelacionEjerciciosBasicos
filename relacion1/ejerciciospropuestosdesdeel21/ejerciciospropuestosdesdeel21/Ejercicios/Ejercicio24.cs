using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciospropuestosdesdeel21.Ejercicios
{
    internal class Ejercicio24
    {
        public static void primitiva()
        {

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine(" Veamos la primitiva");
            Console.WriteLine();
            for (int i = 0; i < 14; i++)
            {
                Console.Write("*");
                Thread.Sleep(100);
            }

            int[] ar = new int[6];

            var ran = new Random();
            for (int i = 0; i < 6; i++)
            {
                int a = ran.Next(1, 49);
                ar[i] = a;
            }

            Console.WriteLine();

            Console.WriteLine($"El número de la primitiva es {ar[0]}{ar[1]}{ar[2]}{ar[3]}{ar[4]}{ar[5]}");
        }
    }
}
