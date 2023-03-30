using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciospropuestosdesdeel21.Ejercicios
{
    internal class Ejercicio33
    {
        public static void ContadorDias()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine(" Veamos al Contador de Días");
            Console.WriteLine();
            for (int i = 0; i < 10; i++)
            {
                Console.Write("*");
                Thread.Sleep(100);
            }
            Console.Clear();


            TimeSpan resultado;

            Console.WriteLine("");
            Console.WriteLine("Introduce el día actual del año y te diré cuantos días han pasado desde el inicio y cuantos dias faltan para el fin del año.");
            String mensaje = "Introduce el día actual del año y te diré cuantos días han pasado desde el inicio y cuantos dias faltan para el fin del año.";

            DateTime inicanyo = new DateTime(2023, 1, 1);
            DateTime finalanyo = new DateTime(2023, 12, 31);
            //checkDateFormat(fecnac);
            Console.WriteLine("La fecha (formato: dd/mm/yyyy) y deber ser del año actual): ");
            DateTime fechaintr = ControladorMensajes.MensajePredeterminado<DateTime>(mensaje);


            DateTime[] tresfechas = new DateTime[] { inicanyo, fechaintr, finalanyo };

            contdiascheckdate(tresfechas);
            resultado = tresfechas[1] - tresfechas[0];

            Console.WriteLine($" ");
            Console.WriteLine($"Han pasado {(int)resultado.TotalDays} días desde que comenzó el año.");

            resultado = tresfechas[2] - tresfechas[1];

            Console.WriteLine($" ");
            Console.WriteLine($"Faltan {(int)resultado.TotalDays + 1} para que acabe el año.");

        }

        public static bool contdiascheckdate(DateTime[] fechas)
        {
            string mensaje = "";

            while (fechas[1].Year != fechas[0].Year || (fechas[2] < fechas[1]))
            {
                Console.WriteLine(" ");
                Console.WriteLine("El año debe ser el actual(2023)");
                Console.WriteLine("");
                Console.WriteLine("Vuelve a introducir la fecha (formato: dd/mm/yyyy): ");
                fechas[1] = ControladorMensajes.MensajePredeterminado<DateTime>(mensaje);

            }

            return true;
        }
    }
}
