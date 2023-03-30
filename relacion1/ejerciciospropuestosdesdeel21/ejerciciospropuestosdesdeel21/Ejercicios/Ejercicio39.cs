using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciospropuestosdesdeel21.Ejercicios
{
    internal class Ejercicio39
    {

        public static void Ruleta()
        {
            var saldo = 1000;

            var menu = 1;
            do
            {
                Random random = new Random();
                int nrandom = random.Next(0, 37);

                string mensaje = "";
                mensaje = "Bievenido a la ruleta";


                //menu = menuswtich();
                //if (menu == 0)
                //{
                //    break;
                //}

                if(MostrarRuleta(saldo))
                {
                    break;
                }
                                

                int apuesta = Apuesta(saldo);

                int n = NumeroApostado(saldo);
                
                //MostrarAnimacion();

                var datos = (aux: 34, wow: true);
                datos.aux = Calcular(apuesta, n, nrandom).Item1;
                datos.wow = Calcular(apuesta, n, nrandom).Item2;

                felicidadesodesgracia(datos.wow, datos.aux);
                saldo = saldo + datos.aux;
                MostrarRuleta(saldo);


            } while (menu != 0);
                        
        }

        private static int NumeroApostado(int saldo)
        {

            string mensaje = "Bievenido a la ruleta";

            Console.WriteLine();
            Console.WriteLine("¿ A qué número vas a apostar ? ");

            int n = ControladorMensajes.MensajePredeterminado<int>(mensaje);

            while (n > 40 || n < 0)
            {
                //mensaje = "La apuesta introducida no puede ser superior a tu saldo actual";
                ControladorMensajes.MensajeErrorPredeterminado(mensaje);
                MostrarRuleta(saldo);
                Console.WriteLine();
                Console.WriteLine("El número debe estar comprendido en la ruleta");
                n = ControladorMensajes.MensajePredeterminado<int>(mensaje);
            }
            return n;
        }

        public static int Apuesta(int saldo)
        {
            string mensaje = "Bievenido a la ruleta";

            int apuesta = ControladorMensajes.MensajePredeterminado<int>(mensaje);

            while (apuesta > saldo)
            {
                //mensaje = "La apuesta introducida no puede ser superior a tu saldo actual";
                ControladorMensajes.MensajeErrorPredeterminado(mensaje);
                MostrarRuleta(saldo);
                Console.WriteLine();
                Console.WriteLine("La apuesta introducida no puede ser superior a tu saldo actual");
                apuesta = ControladorMensajes.MensajePredeterminado<int>(mensaje);
            }
            return apuesta;
        }

        private static void felicidadesodesgracia(bool ahlo, int saldo)
        {
            if (ahlo == true)
            {
                Console.WriteLine("");
                Console.WriteLine($"Felicidades, Has ganado {saldo}");
                for (int i = 0; i < 12; i++)
                {
                    Console.Write("*");
                    Thread.Sleep(100);
                }
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Lo siento, has perdido.");
                for (int i = 0; i < 8; i++)
                {
                    Console.Write("*");
                    Thread.Sleep(100);
                }
            }            
        }

        private static (int, bool) Calcular(int apuesta, int n, int nrandom)
        {
            var aux = 0;
            bool wow = false;
                        

            if(nrandom == n){
                aux = apuesta * 10;
                wow = true;
            }
            else
            {
                wow = false;
                aux = -apuesta;
            }
            return (aux, wow);
        }

        private static void MostrarAnimacion()
        {
            //Random random = new Random();
            //int nrandom = random.Next(0,37);

            //for ()
            //{

            //}

        }

        public static bool MostrarRuleta(int saldo)
        { 
        

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Bievenido a la ruleta");
            Console.WriteLine();
            Console.WriteLine();


            
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write(" ");

            var aux = 0;

            for (int i = 3; i > 0; i--)
            {
                if (i == 3)
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    //Console.Write(" ");
                }
                else if (i == 2)
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.Write("0");
                }
                else if (i == 1)
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.Write(" ");
                }
                aux = i;
                for (int j = 3 - i; j < 15 - i; j++)
                {
                    if (aux % 2 == 0)
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                    }
                    Console.Write(aux + " ");
                    aux += 3;
                }
                Console.WriteLine();
            }
            Console.BackgroundColor = ConsoleColor.Black;


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"Tu saldo es de {saldo}");


            var menu = menuswtich();
            if(menu == 0){
                return true;
            }

            Console.WriteLine($"--- Apuesta: ");

            return false;
        }

        private static int menuswtich()
        {
            var menu = 3;
            string mensaje = "";
            Console.WriteLine();
            Console.WriteLine("¿ Qué desea?");
            Console.WriteLine("0: Salir");
            Console.WriteLine("1: Apostar");
            menu = ControladorMensajes.MensajePredeterminado<int>(mensaje);
            //if(menu == 0)
            //{
            //    return menu
            //}
            //switch(menu)
            //{
            //    case 1: break;
            //    case 0: return menu = 0;
            //    //default: ControladorMensajes.MensajeErrorPredeterminado(mensaje); break;
            //}
            return menu;
        }
    }
  
}
