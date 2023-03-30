using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciospropuestosdesdeel21.Ejercicios
{
    internal class Ejercicio37
    {
        public partial class ContCifras
        {
            public static void contcifraas()
            {
                Console.WriteLine("");
                Console.WriteLine("Bienvenido, introduce un número y te diré si es cuantas cifras pares e impares posee.");
                string mensaje = "Bienvenido, introduce un número y te diré si es cuantas cifras pares e impares posee.";
                int n = ControladorMensajes.MensajePredeterminado<int>(mensaje);


                cifrasparoimpar(n);

            }
            private static void cifrasparoimpar(int n)
            {
                var aux = n;
                var contpares = 0;
                var contimpares = 0;
                for (int i = 0; i < n.ToString().Length; i++)
                {
                    if ((aux % 10) % 2 == 0)
                    {
                        contpares++;
                    }
                    else
                    {
                        contimpares++;
                    }
                    aux /= 10;
                }
                Console.WriteLine("");
                Console.WriteLine($"El número {n} se compone de {contimpares} cifras impares y {contpares} cifras pares");
            }
        }
    }
}
