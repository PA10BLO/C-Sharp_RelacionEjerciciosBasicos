using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciospropuestosdesdeel21.Ejercicios
{
    internal class Ejercicio34
    {
        public partial class TPV
        {
            public static void TpvSimple()
            {

                Console.Clear();
                Console.WriteLine();
                Console.WriteLine(" Veamos al TPV Simplificado");
                Console.WriteLine();
                for (int i = 0; i < 10; i++)
                {
                    Console.Write("*");
                    Thread.Sleep(100);
                }
                Console.Clear();

                //improvisado antes de hacer el login

                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("");
                Console.WriteLine("Digame su fecha de nacimiento para calcularle el descuento");
                string q = "Digame su fecha de nacimiento para calcularle el descuento";
                DateTime fecha = ControladorMensajes.MensajePredeterminado<DateTime>(q);
                DateTime fechaact = DateTime.Now;

                DateTime[] fechas = { fecha, fechaact};
                         
                int edad = Ejercicio32.Edad(fechas);

                //...............................
                
                string mensaje = "Estos son los artículos disponibles actualmente: ";
                // para luego... prefs estas logeado ? Si... menu articulo else { crear usuario / salir }.
                // Crea usuario -> dni, edad, nombre, contraseña

                TextoArt();
                int nart = ControladorMensajes.MensajePredeterminado<int>(mensaje);
                switchtienda(nart, edad);
            }

            private static void TextoArt()
            {
                //Console.Clear();
                Console.WriteLine();
                Console.WriteLine("Estos son los artículos disponibles actualmente: ");
                Console.WriteLine("1: Pasta de dientes (2$)");
                Console.WriteLine("2: Pechuga (4,53$)");
                Console.WriteLine("3: Lomo (3,68$)");
            }

            private static void switchtienda(int menu, int edad)
            {
                double precio;
                switch(menu)
                {
                    case 1:precio = 2; calcularprecio(precio, edad); break;
                    case 2:precio = 4.53; calcularprecio(precio, edad); break;
                    case 3:precio = 3.68; calcularprecio(precio, edad); break;
                }
            }

            private static void calcularprecio(double precio, int edad)
            {
                if(edad >= 65)
                {
                    precio = precio -  (precio * 0.15);
                    Console.WriteLine($"El precio final ajustado con el descuento es de {Math.Round(precio, 2)}");
                }
                else if (edad <= 25)
                {
                    precio = precio - (precio * 0.1);
                    Console.WriteLine($"El precio final ajustado con el descuento es de {Math.Round(precio, 2)}");
                }
                else
                {
                    Console.WriteLine($"A usted no se le aplica ningún descuento y el precio se mantiene en {Math.Round(precio, 2)}");
                }
            }
        }
    }
}
