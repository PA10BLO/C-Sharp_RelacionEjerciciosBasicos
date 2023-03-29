using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciospropuestosdesdeel21.Ejercicios
{
    internal class Ejercicio25
    {
        public static void quinela()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine(" Veamos la Quinela");
            Console.WriteLine();
            for (int i = 0; i < 14; i++)
            {
                Console.Write("*");
                Thread.Sleep(100);
            }

            Console.Clear();

            const string chars = "X12";
            var ran = new Random();
            Console.WriteLine(new string(Enumerable.Repeat(chars, 14).Select(s => s[ran.Next(s.Length)]).ToArray()));
        }
    }
}
