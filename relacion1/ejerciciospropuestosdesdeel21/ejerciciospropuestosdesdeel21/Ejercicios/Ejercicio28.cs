using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciospropuestosdesdeel21.Ejercicios
{
    internal class Ejercicio28
    {
        public static void nominas()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine(" Veamos la Calculadora Salarial");
            Console.WriteLine();
            for (int i = 0; i < 10; i++)
            {
                Console.Write("*");
                Thread.Sleep(100);
            }
            Console.Clear();
            // TO DO
            //string mensaje = "Juguemos a un juego. Adivina el numero en el que estoy pensando (1 al 100).";


            Console.WriteLine("Bienvenido a la calculadora salarial");
            Console.WriteLine("Introduce tus horas semanales");
            int horas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce el precio de cada hora");
            int precio = Convert.ToInt32(Console.ReadLine());
            int menu = 2;
            while (menu != 0)
            {
                Console.WriteLine("");
                Console.WriteLine(" ¿Qué deseas ver?");
                Console.WriteLine("0: Salir");
                Console.WriteLine("1: El salario bruto");
                Console.WriteLine("1: Los impuestos que se aplicaran");
                Console.WriteLine("3: El salario neto");
                Console.WriteLine("4: Cambiar horas");
                Console.WriteLine("5: Cambiar pago/hora");
                menu = Convert.ToInt32(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                        salariobruto(horas, precio);
                        break;
                    case 2:
                        impuestos(horas, precio);
                        break;
                    case 3:
                        salarionetoa(horas, precio);
                        break;
                    case 4:
                        Console.WriteLine("");
                        Console.WriteLine("Introduce las nuevas horas semanales.");
                        horas = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 5:
                        Console.WriteLine("");
                        Console.WriteLine("Introducela nueva cantidad.");
                        precio = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }

        }

        public static void salarionetoa(int horas, int precio)
        {
            Console.WriteLine($"Tu salario neto será de {salarioneto(horas, precio)}");
        }

        public static double salarioneto(int horas, int precio)
        {
            double salarioneto = 0.0;
            salarioneto = salariobrutoimp(horas, precio) - impuestocalc(horas, precio);
            return salarioneto;
        }

        public static void impuestos(int horas, int precio)
        {
            Console.WriteLine($"Tus impuestos son de {impuestocalc(horas, precio)}");
        }

        public static double impuestocalc(int horas, int precio)
        {
            var impuestos = 0.0;
            if (salariobrutoimp(horas, precio) <= 1000)
            {
                impuestos = salariobrutoimp(horas, precio) * 0.1;
            }
            else
            {
                impuestos = salariobrutoimp(horas, precio) * 0.15;
            }
            return impuestos;
        }

        public static double salariobrutoimp(int horas, int precio)
        {
            var salariobruto = 0.0;
            if (horas > 45)
            {
                salariobruto = horas * precio;
                salariobruto += (horas - 40) * 1.5 * precio;
                salariobruto += (horas - 5) * 2 * precio;
            }
            else
            {
                if (horas > 40 && horas <= 45)
                {
                    salariobruto = horas * precio;
                    salariobruto += (horas - 40) * 1.5;
                }
                else
                {
                    salariobruto = horas * precio * 4;
                }
            }
            return salariobruto;
        }

        public static void salariobruto(int horas, int precio)
        {
            var salariobruto = 0.0;
            if (horas > 45)
            {
                salariobruto = horas * precio;
                salariobruto += (horas - 40) * 1.5 * precio;
                salariobruto += (horas - 5) * 2 * precio;
            }
            else
            {
                if (horas > 40 && horas <= 45)
                {
                    salariobruto = horas * precio;
                    salariobruto += (horas - 40) * 1.5;
                }
                else
                {
                    salariobruto = horas * precio * 4;
                }
            }

            Console.WriteLine("");
            Console.WriteLine($"Tu salario bruto es de {salariobruto}");
        }
    }
}
