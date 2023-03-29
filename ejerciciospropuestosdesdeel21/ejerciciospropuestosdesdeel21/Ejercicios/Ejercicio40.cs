using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciospropuestosdesdeel21.Ejercicios
{
    internal class Ejercicio40
    {
        public static void Dados()
        {
            TextoInicialDados();

        }

        private static void TextoInicialDados()
        {
            var menu = 3;
            string mensaje = "";

            while (menu != 0)
            {
                TextoMenuDados();
                menu = ControladorMensajes.MensajePredeterminado<int>(mensaje);
                switch (menu)
                {
                    case 0: menu = 0; break;
                    case 1: JugarDados(); break;
                }
                if (menu == 1)
                {
                    //MenuoNo();
                }
            }
        }

        //private static void MenuoNo()
        //{
        //    Console.WriteLine("");
        //    Console.WriteLine(" Pulsa enter para volver al menú...");
        //    Console.WriteLine(" Cualquier otra tecla para repetir el ejercicio...");
        //    ConsoleKeyInfo keyInfo = Console.ReadKey();
        //    if (keyInfo.Key == ConsoleKey.Enter)
        //    {
        //    }
        //    else
        //    {
        //        TextoInicialDados();
        //    }
        //}

        private static void TextoMenuDados()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("¿ Qué desea?");
            Console.WriteLine("0: Salir");
            Console.WriteLine("1: Jugar");
        }

        private static void JugarDados()
        {
            Console.Clear();
            Console.WriteLine();
            string mensaje = "Dados";
            Console.WriteLine("Tu dinero: ");
            int dinero = ControladorMensajes.MensajePredeterminado<int>(mensaje);

            Console.WriteLine("Apuesta: ");
            int apuesta = Ejercicio39.Apuesta(dinero);

            Random random = new Random();

            int[] dados = { random.Next(1, 6), random.Next(1, 6), random.Next(1, 6) };

            for (int i = 0; i < dados.Length; i++)
            {
                Console.WriteLine($"Los dados son {dados[i]}");
            }

            if ((dados[0] == dados[1]) && dados[0] == dados[2] && dados[1] == dados[2])
            {
                if (dados[0] == 6)
                {
                    dinero *= 5;
                }
                else
                {
                    dinero *= 3;
                }
            }
            else if (DosIguales(dados))
            {
                dinero *= 2;
            }
            else
            {
                dinero -= apuesta;
            }

            Console.WriteLine(dinero);
        }

        private static bool DosIguales(int[] dados)
        {
            var cont = 0;

            for(int i = 0; i<dados.Length; i++)
            {
                for(int j = 0; j<dados.Length; j++)
                {
                    if (dados[i] == dados[j])
                    {
                        cont++;
                    }
                    if(cont > 1){
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
