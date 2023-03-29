using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciospropuestosdesdeel21.Ejercicios
{
    internal class Ejercicio36
    {
        public partial class Grav
        {
            public static void atracgrav()
            {
                int i = 0;
                int h = 0;
                string mensaje = "Introduce X kilometro y te diré como varía la gravedad a esa altitud hasta tu kilometro introducido.";
                Console.Clear();
                Console.WriteLine("");
                Console.WriteLine(" Introduce X kilometro y te diré como varía la gravedad a esa altitud hasta tu kilometro introducido.");
                h = ControladorMensajes.MensajePredeterminado<int>(mensaje);

                Console.WriteLine("    Altitud (km)                   Gravedad (m/s2)");
                Console.WriteLine("   --------------                 ------------------");
                const double gravedad = 9.8;
                const int radio = 6370000;
                var g = 0.1;
                while (i < h)
                {
                    if (i < 100)
                    {
                        Console.Write($"               {i}");
                        g = gravedad * Math.Pow(radio, 2) / (Math.Pow(radio + h + i, 2));
                        g = Math.Round(g, 2);
                        Console.WriteLine($"                     {g}");
                        i += 100;
                    }
                    else
                    {
                        if (i < 1000)
                        {
                            Console.Write($"             {i}");
                            g = gravedad * Math.Pow(radio, 2) / (Math.Pow(radio + h + i * 1000, 2));
                            g = Math.Round(g, 2);
                            Console.WriteLine($"                     {g}");
                            i += 100;
                        }
                        else
                        {
                            if (i < 10000)
                            {
                                Console.Write($"            {i}");
                                g = gravedad * Math.Pow(radio, 2) / (Math.Pow(radio + h + i * 1000, 2));
                                g = Math.Round(g, 2);
                                Console.WriteLine($"                     {g}");
                                i += 100;
                            }
                            else
                            {
                                if (i < 100000)
                                {
                                    Console.Write($"           {i}");
                                    g = gravedad * Math.Pow(radio, 2) / (Math.Pow(radio + h + i * 1000, 2));
                                    g = Math.Round(g, 2);
                                    Console.WriteLine($"                     {g}");
                                    i += 100;
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
