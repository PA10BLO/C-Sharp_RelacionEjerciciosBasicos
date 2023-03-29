using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciospropuestosdesdeel21.Ejercicios
{
    internal class Ejercicio32
    {
        public static void calcedad()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine(" Veamos al Cálculo de Edad");
            Console.WriteLine();
            for (int i = 0; i < 10; i++)
            {
                Console.Write("*");
                Thread.Sleep(100);
            }
            Console.Clear();

            Console.WriteLine("");
            Console.WriteLine("Introduce tu fecha de nacimiento y la fecha actual y te diré tu edad.");
            Console.WriteLine("Fecha de nacimiento (formato: dd/mm/yyyy): ");
            String mensaje = "Introduce tu fecha de nacimiento y la fecha actual y te diré tu edad.";
            DateTime fecnac = ControladorMensajes.MensajePredeterminado<DateTime>(mensaje);
            //checkDateFormat(fecnac);
            Console.WriteLine("Fecha actual (formato: dd/mm/yyyy): ");
            DateTime fecnac2 = ControladorMensajes.MensajePredeterminado<DateTime>(mensaje);

            DateTime[] dosfechas = new DateTime[] { fecnac, fecnac2 };


            checkDateFormat(dosfechas);

            Console.WriteLine($" ");
            Console.WriteLine($"Tienes {Edad(dosfechas)} años.");

        }

        public static int Edad(DateTime[] dosfechas)
        {
            TimeSpan resultado;
            resultado = dosfechas[1] - dosfechas[0];
            int anyos = (int)resultado.TotalDays / 365;
            return anyos;                       
        }

        public static bool checkDateFormat(DateTime[] fechas)
        {
            string mensaje = "";

            DateTime check = DateTime.Now;

            while (fechas[0].Year > fechas[1].Year || (fechas[1].Year >= check.Year && fechas[1].Month > check.Month))
            {
                Console.WriteLine(" ");
                Console.WriteLine("La primera fecha introducida no puede ser superior a la última introducida ni la segunda fecha superior a la actual ");
                Console.WriteLine("");
                Console.WriteLine("Vuelve a introducir la primera fecha");
                fechas[0] = ControladorMensajes.MensajePredeterminado<DateTime>(mensaje);
                Console.WriteLine(" ");
                Console.WriteLine("Vuelve a introducir la segunda fecha");
                fechas[1] = ControladorMensajes.MensajePredeterminado<DateTime>(mensaje);
            }

            return true;
        }

    }
}
