using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciospropuestosdesdeel21.Ejercicios
{
    internal class Ejercicio23
    {
        public static void Omirps()
        {

            List<int> primos = new List<int>();

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Veamos si es o no Omirp un número");
            Console.WriteLine();
            for (int i = 0; i < 10; i++)
            {
                Console.Write("*");
                Thread.Sleep(100);
            }
            Console.Clear();
            string mensaje = "Introduce un número y te mostraré la lista de omirps entre 0 y este.";


            //Console.WriteLine("Rehacer ejercicio debido alo de los primos");
            Console.WriteLine("Introduce un número y te mostraré la lista de omirps entre 0 y este.");
            int n = ControladorMensajes.MensajePredeterminado<int>(mensaje);

            primos = Ejercicio21.GenerarPrimosHastaN(n);

            if (!Ejercicio21.EsPrimo(n, primos))
            {
                Console.WriteLine("El número introducido no es primo");
                return;
            }

            var aux = n;


            var resultado = 0;

            while(aux > 0)
            {
                resultado = resultado * 10 + aux % 10;
                aux /= 10;
            }

            if(Ejercicio21.EsPrimo(resultado, primos))
            {
                Console.WriteLine($"El número {n} es omirp y su equivalente es {resultado}");
            }
            else { Console.WriteLine($"El número {n} es primo pero no omirp"); }



            //for (int i = 0; i <= n; i++)
            //{
            //    cont = 0;
            //    aux = 0;
            //    for (int j = 1; j <= i; j++)
            //    {
            //        if (i % j == 0) cont++;
            //    }
            //    if (cont <= 2)
            //    {
            //        var cont2 = 0;
            //        aux = 0;
            //        var aux2 = 0;
            //        var aux3 = i;
            //        while (aux3 != 0)
            //        {
            //            aux = aux3 % 10;
            //            aux2 = (aux2 * 10) + aux;
            //            aux3 /= 10;
            //        }
            //        if (Ejercicio21.EsPrimo(aux2, primos))
            //        {
            //            Console.WriteLine($"El número {i} es omirp y su equivalente es {aux2}");
            //        }
            //    }
            //}
        }
    }
}
