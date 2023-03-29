using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciospropuestosdesdeel21.Ejercicios
{
    internal class Ejercicio31
    {
        public static void predmeteo()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine(" Veamos la Predicción del Tiempo");
            Console.WriteLine();
            for (int i = 0; i < 10; i++)
            {
                Console.Write("*");
                Thread.Sleep(100);
            }
            Console.Clear();



            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Bienvenido a tu fiable predicción del tiempo");
            Console.WriteLine("¿Para calcularla necesito la presio atmosferica. ¿ Es alta, media o baja?");
            String presionat = Console.ReadLine();
            while (!checkstring(presionat))
            {
                Console.WriteLine("La presion introducida no concuerda, vuelve a escribirla. ¿ Es alta, media o baja?");
                presionat = Console.ReadLine();
                checkstring(presionat);
            }

            Console.WriteLine("¿Para calcularla necesito la humedad relativa. ¿ Es alta, media o baja?");
            String humrel = Console.ReadLine();
            while (!checkstring(humrel))
            {
                Console.WriteLine("La humedad introducida no concuerda, vuelve a escribirla. ¿ Es alta, media o baja?");
                humrel = Console.ReadLine();
                checkstring(humrel);
            }

            var menu = 2;
            while (menu != 0)
            {
                Console.WriteLine("");
                Console.WriteLine(" ¿ Qué desea ver ?");
                Console.WriteLine(" 0: Salir al Menú");
                Console.WriteLine(" 1: La probabilidad de lluvia");
                Console.WriteLine(" 2: La probabilidad de sol");
                Console.WriteLine(" 3: La probabilidad de frio");
                menu = Convert.ToInt32(Console.ReadLine());
                switch (menu)
                {
                    case 1: problluvia(presionat, humrel, menu); break;
                    case 2: probsol(presionat, humrel, menu); break;
                    case 3: probfrio(presionat, humrel, menu); break;
                }
            }


        }

        private static void probfrio(string? presionat, string? humrel, int aux)
        {
            String[] probs = new String[] { "Baja", "Alta", "Alta", "Muy alta" };
            String[] probs2 = new String[] { "Baja", "Media", "Alta" };

            String press = presionat.ToLower();
            String hum = humrel.ToLower();

            for (int i = 0; i < 3; i++)
            {
                if (press.Equals(probs2[i].ToLower()))
                {
                    switch (i)
                    {
                        case 0: calcwithlowpress(hum, probs2, probs, aux); break;
                        case 1: calcmidcold(hum); break;
                        case 2: Console.WriteLine(); Console.WriteLine("La probabilidad de frío es baja"); break;
                    }


                }
            }
        }

        private static void calcmidcold(String hum)
        {
            String[] porbs = new String[] { "Baja", "Media", "Alta" };
            for (int i = 0; i < 3; i++)
            {
                if (hum.Equals(porbs[i].ToLower()))
                {
                    Console.WriteLine(); Console.WriteLine($"La probabilidad de frío es {porbs[i]}");
                }
            }

        }

        private static void probsol(string? presionat, string? humrel, int aux)
        {
            String[] probs = new String[] { "Media", "Media", "Baja", "Muy alta" };
            String[] probs2 = new String[] { "Baja", "Media", "Alta" };

            String press = presionat.ToLower();
            String hum = humrel.ToLower();

            for (int i = 0; i < 3; i++)
            {
                if (press.Equals(probs2[i].ToLower()))
                {
                    switch (i)
                    {
                        case 0: calcwithlowpress(hum, probs2, probs, aux); break;
                        case 1:
                            if (hum.Equals("media")) { Console.WriteLine(); Console.WriteLine("La probabilidad de sol es media"); }
                            else { Console.WriteLine(); Console.WriteLine("La probabilidad de sol es baja"); }; break;
                        case 2: Console.WriteLine(); Console.WriteLine("La probabilidad de sol es Alta"); break;
                    }


                }
            }
        }

        private static void problluvia(String presion, String humerel, int aux)
        {
            String[] probs = new String[] { "Baja", "Alta", "Muy Alta", "Muy alta" };
            String[] probs2 = new String[] { "Baja", "Media", "Alta" };

            String press = presion.ToLower();
            String hum = humerel.ToLower();

            for (int i = 0; i < 3; i++)
            {
                if (press.Equals(probs2[i].ToLower()))
                {
                    switch (i)
                    {
                        case 0: calcwithlowpress(hum, probs2, probs, aux); break;
                        case 1:
                            if (hum.Equals("media")) { Console.WriteLine(); Console.WriteLine("La probabilidad de lluvia es media"); }
                            else { Console.WriteLine(); Console.WriteLine("La probabilidad de lluvia es baja"); }; break;
                        case 2: Console.WriteLine(); Console.WriteLine("La probabilidad de lluvia es baja"); break;
                    }


                }
            }
        }

        private static void calcwithlowpress(String hum, String[] probs2, String[] probs, int aux)
        {
            String[] cosas = new String[] { "lluvia", "sol", "frío" };
            for (int i = 0; i < 3; i++)
            {
                if (hum.Equals(probs2[i].ToLower()))
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (aux - 1 == j)
                        {
                            Console.WriteLine($"La probabilidad de {cosas[j]} es {probs[i]}");
                        }
                    }
                }
            }
        }

        private static bool checkstring(string? presionat)
        {
            string press = presionat.ToLower();
            if (press.Equals("alta") || press.Equals("media") || press.Equals("baja"))
            {
                return true;
            }
            return false;
        }


    }
}
