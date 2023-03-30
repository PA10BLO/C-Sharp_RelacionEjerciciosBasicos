using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciospropuestosdesdeel21.Ejercicios
{
    internal class Ejercicio21
    {
        public static void primo()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Introduce un número y te diré si es Primo.");
            string mensaje = "Introduce un número y te diré si es Primo.";
            int n = ControladorMensajes.MensajePredeterminado<int>(mensaje);

            List<int> primos = new List<int>();
            primos = GenerarPrimosHastaN(n/2);

            if(EsPrimo(n, primos)){
                Console.WriteLine($"El número {n} es Primo.");
            }
            else
            {
                Console.WriteLine($"El número {n} no es primo.");
            }

            //int n;
            //List<int> primos = new List<int>();
            //primos.Add(2);
            //primos.Add(3);
            //primos.Add(5);
            //primos.Add(7);
            //primos.Add(11);
            //n = 11;
            //while (primos.Count < 10)
            //{
            //    n += 2;
            //    if (EsPrimo(n, primos)) { primos.Add(n); }
            //}
            //foreach (var i in primos) { Console.Write(string.Format("{0:#######} ", i)); }
        }

        public static void GenerarPrimos()
        {
            int n;
            List<int> primos = new List<int>();
            primos.Add(2);
            primos.Add(3);
            primos.Add(5);
            primos.Add(7);
            primos.Add(11);
            n = 11;
            while (primos.Count < 10)
            {
                n += 2;
                if (EsPrimo(n, primos)) { primos.Add(n); }
            }
            foreach (var i in primos) { Console.Write(string.Format("{0:#######} ", i)); }

        }


        public static List<int> GenerarPrimosHastaN(int n)
        {
            List<int> primos = new List<int>();
            primos.Add(2);
            primos.Add(3);
            primos.Add(5);
            primos.Add(7);
            primos.Add(11);
            var aux = 11;
            while(aux < n)
            {
                aux += 2;
                if (EsPrimo(aux, primos)) { primos.Add(aux); }
            }
            //foreach (var i in primos) { Console.Write(string.Format("{0:#######} ", i)); }
            return primos;
        }



        public static bool EsPrimo(int n, List<int> primos)
        {
            if (primos.Where(x => x == n).Any()) { return true; }
            var tope = Math.Truncate(Math.Sqrt(n));
            while (tope > primos[primos.Count - 1])
            {
                var aux = primos[primos.Count - 1] + 2;
                if (EsPrimo(aux, primos)) { primos.Add(aux); }
            }
            var posicion = primos.IndexOf(primos.Where(x => x >= tope).First());
            for (int i = 0; i <= posicion; i++)
            {

                if (n % primos[i] == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
    
}
