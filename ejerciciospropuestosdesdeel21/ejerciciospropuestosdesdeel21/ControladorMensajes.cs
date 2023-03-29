using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciospropuestosdesdeel21
{
    internal class ControladorMensajes
    {
        public static T MensajePredeterminado<T>(string mensaje)
        {
            string n = "sd";
            ConsoleKeyInfo sd = new ConsoleKeyInfo('z', ConsoleKey.Z, false, false, false);
            //StringBuilder prueba = new StringBuilder("<    >");
            bool check = true;
            var contador = 0;
            while (check == true)
            {
                contador = 0;
                try
                {
                    if (mensaje.Equals("menu"))
                    {
                        // al pulsar entre salimos debido a valores de un solo digito como el 0
                        //ya que el cursor está entre < > tenemos en cuenta este if
                        while (sd.Key != ConsoleKey.Enter && contador < 2)
                        {
                            // Limpiar el buffer de entrada

                            sd = Console.ReadKey(true);
                            if (contador == 0)
                            {
                                Console.Write(sd.KeyChar);
                                n = sd.KeyChar.ToString();
                            }
                            else
                            {
                                Console.Write(sd.KeyChar + ">");
                                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                                n = n + sd.KeyChar.ToString();
                            }
                            contador++;

                        }
                        Convert.ChangeType(n, typeof(T));
                        check = false;
                    }
                    else
                    {
                        n = Console.ReadLine().ToString();
                        Convert.ChangeType(n, typeof(T));
                        check = false;
                    }
                    

                    //if (mensaje.Equals("menu"))
                    //{
                    //    //string sd = n.ToString();
                    //    //prueba = sd + " >";
                    //    while( sd.Key != ConsoleKey.Enter)
                    //    {
                    //        sd = Console.ReadKey(true);
                    //        if(contador == 0)
                    //        {
                    //            Console.Write(sd.KeyChar);
                    //        }
                    //        else {
                    //            Console.Write(sd.KeyChar + ">");
                    //            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                    //        }
                    //        contador++;

                    //    }
                    //}
                    //else
                    //{
                    ////n = Console.Read().ToString();
                        Convert.ChangeType(n, typeof(T));
                    //}                   
                    
                    check = false;
                }
                catch(Exception asd)
                {
                    sd = new ConsoleKeyInfo('0', 0, false, false, false);
                    MensajeErrorPredeterminado(mensaje);
                    check = true;
                }
            }
            return (T)Convert.ChangeType(n, typeof(T));
        }
              

        public static void MensajeErrorPredeterminado(string mensaje)
        {
            Console.WriteLine("");
            Console.WriteLine("La información que has introducido no es válida. Por favor, vuelve a introducirlo");
            for (int i = 0; i < 14; i++)
            {
                Console.Write("*");
                Thread.Sleep(100);
            }

            Console.WriteLine("");
            // aqui añadimos filtros(condiciones adicionales) que mostrarán por pantalla el texto del ejercicio dependiendo del contexto del ejercicio que llame a este método
            // gracias al mensaje que pasamos por el parametro.
            if(mensaje.Equals("menu"))
            {
                Ejercicios.MenuEjercicios.TextoMenu();
            }
            else
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine(mensaje);
            }
            //if (mensaje.Equals("Introduce X kilometro y te diré como varía la gravedad a esa altitud hasta tu kilometro introducido."))
            //{
            //    Console.Clear();
            //    Console.WriteLine();
            //    Console.WriteLine(mensaje);
            //}
            //if (mensaje.Equals("Digame su fecha de nacimiento para calcularle el descuento"))
            //{
            //    Console.Clear();
            //    Console.WriteLine();
            //    Console.WriteLine(mensaje);
            //}
            //if (mensaje.Equals("Introduce un numero PAR y te diré que numeros primos sumandos entre si dan como resultado este numero."))
            //{
            //    Console.Clear();
            //    Console.WriteLine();
            //    Console.WriteLine(mensaje);
            //}
            //if

        }
    }
}
