using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciospropuestosdesdeel21.Ejercicios
{
    internal class Ejercicio22
    {
        public static void Eratostenes()
        {
            var cont = 0;
            Console.Clear();
            Console.WriteLine("Ahora vamos a visualizar si los numeros del 2 al 1000 son numeros primos o no");

            for (int i = 0; i < 14; i++)
            {
                Console.Write("*");
                Thread.Sleep(100);
            }

            for (int i = 2; i <= 1000; i++)
            {
                cont = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0) cont++;
                }
                if (cont <= 2)
                {
                    Console.WriteLine($"El número {i} es primo");
                }
                else
                {
                    Console.WriteLine($"El número {i} no es primo");
                }
            }
        }
    }
}
