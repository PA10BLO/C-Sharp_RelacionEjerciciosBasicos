using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciospropuestosdesdeel21.Ejercicios
{
    internal class Ejercicio38
    {
        public static void Goldbach()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Introduce un numero PAR y te diré que numeros primos sumandos entre si dan como resultado este numero.");
            string mensaje = "Introduce un numero PAR y te diré que numeros primos sumandos entre si dan como resultado este numero.";

            int n = ControladorMensajes.MensajePredeterminado<int>(mensaje);

            while (n % 2 != 0)
            {
                ControladorMensajes.MensajeErrorPredeterminado(mensaje);
                n = ControladorMensajes.MensajePredeterminado<int>(mensaje);
            }

            //List<int> sumandos = primos;

            var prueba = (ad : true, a : 34, b : 45  );
            prueba = LaSumaEs(n);

            if(prueba.ad)
            {
                Console.WriteLine($"La suma de numeros primos que componen a {n} es {prueba.a} + {prueba.b}");
            }

        }

        private static (bool, int, int) LaSumaEs(int n)
        {
            List<int> primos = GenerarPrimos(n);
            var a = 0;
            var b = 0;

            //for (int i = 0; i < primos.Count; i++)
            //{
            //    for (int j = 0; j < primos.Count; j++)
            //    {
            //        if ((primos[j] + primos[(primos.Count - 1) - i]) == n)
            //        {
            //            a = primos[j];
            //            b = primos[(primos.Count - 1) - i];
            //            return (true, a, b);
            //        }
            //        if(i>primos.Count/2)
            //        {
            //            break;
            //        }
            //    }
            //}
            for (int i = primos.Count - 1; i >= 0; i--)
            {
                for (int j = 0; j <= i; j++)
                {
                    if (primos[j] + primos[i] == n)
                    {
                        a = primos[j];
                        b = primos[i];
                        return (true, a, b);
                    }
                    else if (primos[j] + primos[i] > n)
                    {
                        break;
                    }                   
                }
            }
            return (false, a, b);
        }

        public static List<int> GenerarPrimos(int n)
        {
            var aux = 11;
            n++;
            List<int> primos = new List<int>();
            primos.Add(2);
            primos.Add(3);
            primos.Add(5);
            primos.Add(7);
            primos.Add(11);
            while (primos[primos.Count - 1] <= n)
            {
                aux += 2;
                if (Ejercicio21.EsPrimo(aux, primos)) { primos.Add(aux); }
            }
            return primos;
        }


    }
}
