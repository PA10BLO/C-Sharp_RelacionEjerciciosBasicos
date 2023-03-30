using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciospropuestosdesdeel21.Ejercicios
{
    internal class Ejercicio26
    {
        public static void calculadora()
        {

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine(" Veamos la Calculadora");
            Console.WriteLine();
            for (int i = 0; i < 10; i++)
            {
                Console.Write("*");
                Thread.Sleep(100);
            }
            Console.Clear();

            char ope = '2';
            while (ope != '0')
            {
                Console.WriteLine("Bienvenido a la calculadora. Introduce dos numeros para posteriormente decidir que hacer");
                string mensaje = "Bienvenido a la calculadora. Introduce dos numeros para posteriormente decidir que hacer";
                int a = ControladorMensajes.MensajePredeterminado<int>(mensaje);
                int b = ControladorMensajes.MensajePredeterminado<int>(mensaje);
                Console.WriteLine("¿Qué desea realizar?");
                Console.WriteLine(" * para multiplicar");
                Console.WriteLine(" - para restar");
                Console.WriteLine(" + para sumar");
                Console.WriteLine(" / para dividir");
                Console.WriteLine(" 0 para salir");
                ope = Convert.ToChar(Console.ReadLine());
                switch (ope)
                {
                    case '*': Console.WriteLine(a * b); break;
                    case '-': Console.WriteLine(a - b); break;
                    case '+': Console.WriteLine(a + b); break;
                    case '/': Console.WriteLine(a / b); break;
                    case var s when !ope.Equals('*') && !ope.Equals('-') && !ope.Equals('/') && !ope.Equals('+'):
                        Console.WriteLine("Vuelve a introducir el operador correctamente");
                        ope = Convert.ToChar(Console.ReadLine());
                        break;
                }
                Console.WriteLine("¿ Qué desea realizar?");
                Console.WriteLine("0: Salir, Cualquier tecla repetir");
                ope = Convert.ToChar(Console.ReadLine());
            }

        }
    }
}
