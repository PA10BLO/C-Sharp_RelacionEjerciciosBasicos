using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ejerciciospropuestosdesdeel21.Ejercicios.Ejercicio36;
using static ejerciciospropuestosdesdeel21.Ejercicios.Ejercicio37;
using static Program;

namespace ejerciciospropuestosdesdeel21.Ejercicios
{
    internal class MenuEjercicios
    {
        public static string Replicate(string s, int n)
        {
            var aux = string.Empty;
            for (int i = 0; i < n; i++)
            {
                aux += s;
            }
            return aux;
        }

        public static string Centrar(string texto, int columnas)
        {
            int aux = 0;
            var cont = 0;
            if(texto.Length > 8)
            {
                aux = texto.Length - 7;
                aux = texto.Length - aux;
            }
            else
            {
                aux = texto.Length;
            }
            string espacios = Replicate(" ", (columnas - aux) / 2);
            string cadena = espacios + texto + espacios;
            return cadena;
        }

        public static void TextoMenu()
        {
            //Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            //Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("");
            Console.WriteLine(Centrar("Menú de Opciones", 107));
            Console.WriteLine(Centrar("╔══════════════════════════════════════════╗", 80));
            Console.WriteLine();
            Console.WriteLine(Centrar("0: Salir", 98));
            Console.WriteLine(Centrar("21: Primo", 95));
            Console.WriteLine(Centrar("22: Eratostenes", 95));
            Console.WriteLine(Centrar("23: Omirp", 95));
            Console.WriteLine(Centrar("24: Lotería Primitiva", 95));
            Console.WriteLine(Centrar("25: Quinela", 95));
            Console.WriteLine(Centrar("26: Calculadora", 95));
            Console.WriteLine(Centrar("27: Número Secreto", 95));
            Console.WriteLine(Centrar("28: Nóminas", 95));
            Console.WriteLine(Centrar("29: Poligonos", 95));
            Console.WriteLine(Centrar("30: Máquina Expendedora", 95));
            Console.WriteLine(Centrar("31: Probabilidad Meteorológica", 95));
            Console.WriteLine(Centrar("32: Calcular Edad", 95));
            Console.WriteLine(Centrar("33: Contador de dias", 95));
            Console.WriteLine(Centrar("35: Número a letra", 95));
            Console.WriteLine(Centrar("36: Atracción Gravitatoria", 95));
            Console.WriteLine(Centrar("37: Contar Cifras", 95));
            Console.WriteLine(Centrar("38: Conjetura de Goldbach", 95));
            Console.WriteLine(Centrar("39: Ruleta", 95));
            Console.WriteLine(Centrar("40: Dados", 95));
            Console.WriteLine(Centrar("41: Ejercicio de Memoria", 95));
            Console.WriteLine(Centrar("╚══════════════════════════════════════════╝", 80));

            //Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(Centrar("Elija Opción .....  <  >  ", 95));
            Console.SetCursorPosition(Console.CursorLeft - 49, Console.CursorTop);
        }


        public static void menuswitch(int menu)
        {

            switch (menu)
            {
                case 0: break;
                case 20:
                    Ejercicio21.primo();
                    break;
                case 21:
                    Ejercicio21.primo();
                    break;
                case 22:
                    Ejercicio22.Eratostenes();
                    break;
                case 23:
                    Ejercicio23.Omirps();
                    break;
                case 24:
                    Ejercicio24.primitiva();
                    break;
                case 25:
                    Ejercicio25.quinela();
                    break;
                case 26:
                    Ejercicio26.calculadora();
                    break;
                case 27:
                    Ejercicio27.numsecreto();
                    break;
                case 28:
                    Ejercicio28.nominas();
                    break;
                case 29:
                    Ejercicio29.poligonos();
                    break;
                case 30:
                    Ejercicio30.maqexp();
                    break;
                case 31:
                    Ejercicio31.predmeteo();
                    break;
                case 32:
                    Ejercicio32.calcedad();
                    break;
                case 33:
                    Ejercicio33.ContadorDias();
                    break;
                case 34:
                    Ejercicio34.TPV.TpvSimple();
                    break;
                case 35:
                    Ejercicio35.numaletra();
                    break;
                case 36:
                    Grav.atracgrav();
                    break;
                case 37:
                    ContCifras.contcifraas();
                    break;
                case 38:
                    Ejercicio38.Goldbach();
                    break;
                case 39:
                    Ejercicio39.Ruleta();
                    break;
                case 40:
                    Ejercicio40.Dados();
                    break;
                case 41:
                    Ejercicio41.JuegodeMemoria();
                    break;
                default:                     break;
            }
            if (menu != 0)
            {
                MenuoNo(menu);
            }

        }

        private static void MenuoNo(int menu2)
        {
            Console.WriteLine("");
            Console.WriteLine(" Pulsa enter para volver al menú...");
            Console.WriteLine(" Cualquier otra tecla para repetir el ejercicio...");
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            if (keyInfo.Key == ConsoleKey.Enter)
            {
            }
            else
            {
                menuswitch(menu2);
            }
        }
    }
}
