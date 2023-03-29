using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciospropuestosdesdeel21.Ejercicios
{
    internal class Ejercicio27
    {
        public static void numsecreto()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine(" Veamos el Número Secreto");
            Console.WriteLine();
            for (int i = 0; i < 10; i++)
            {
                Console.Write("*");
                Thread.Sleep(100);
            }
            Console.Clear();
            string mensaje = "Juguemos a un juego. Adivina el numero en el que estoy pensando (1 al 100).";


            Console.WriteLine(" ");
            Console.WriteLine("Juguemos a un juego. Adivina el numero en el que estoy pensando (1 al 100).");
            var random = new Random();
            int numeroadi = random.Next(1, 101);
            //Console.WriteLine(numeroadi);
            //int numerointroducido = 0;
            bool sd = true;
            while (sd == true)
            {
                Console.WriteLine("Intentalo.");
                int n = ControladorMensajes.MensajePredeterminado<int>(mensaje);
                if (numeroadi == n)
                {
                    Console.WriteLine("Felicidades, has acertado.");
                    sd = false;
                }
                else
                {
                    if (n > numeroadi)
                    {
                        Console.WriteLine("El número introducido es menor.");
                    }
                    else
                    {
                        Console.WriteLine("El número introducido es mayor.");
                    }
                }
            }
        }
    }
}
