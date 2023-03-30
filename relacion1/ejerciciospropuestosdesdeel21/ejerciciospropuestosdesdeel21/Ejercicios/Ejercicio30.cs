using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciospropuestosdesdeel21.Ejercicios
{
    internal class Ejercicio30
    {
        public static void maqexp()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine(" Veamos al Cálculo de Cambios");
            Console.WriteLine();
            for (int i = 0; i < 10; i++)
            {
                Console.Write("*");
                Thread.Sleep(100);
            }
            Console.Clear();


            Console.WriteLine("");
            Console.WriteLine("Calculemos la cantidad de monedas que necesito devolverte. Introduce el dinero");
            var dinero = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine($"La cantidad de monedas necesarias son {calcularcambiomonedas(dinero)}");
        }
        public static object calcularcambiomonedas(double dinero)
        {
            String frase = "sda";

            if ((dinero / 2) >= 1)
            {
                var auxx = dinero - (2 * ((int)dinero / 2));

                // este if solo sirve para saber si debemos añadir o no al final en la frase 1 moneda 1e o no.
                // Una vez terminado en su else copiar el mismo codigo cambiando esa frase
                if (auxx > 1)
                {
                    //decimal dsd2 = (decimal)(2.33 * 100) % 100;
                    //Console.WriteLine(decimal.Round(dsd2, 1));

                    // perfecto
                    // 
                    decimal dsd = (decimal)(dinero * 100) % 100;
                    if ((decimal.Round(dsd, 1) / 50) >= 1)
                    {
                        var aux = dsd - 50;
                        var aux2 = aux;
                        if (aux2 / 20 > 2)
                        {
                            aux2 = aux2 - 40;
                            if (aux2 / 5 > 1)
                            {
                                var aux3 = aux2 - 5;
                                var cont = 0;
                                while (aux3 > 0)
                                {
                                    cont++;
                                    aux3--;
                                }
                                frase = $"{(int)(dinero / 2)} monedas de 2e, {(int)auxx} monedas de un euro, {(int)dsd / 50} monedas de 50cent, {(int)aux / 20} monedas de 20 cent, {(int)aux2 / 5} monedas de 5 cent y {cont} monedas de 1cent";
                            }
                            else
                            {
                                var aux3 = aux2;
                                var cont = 0;
                                while (aux3 > 0)
                                {
                                    cont++;
                                    aux3--;
                                }
                                frase = $"{(int)(dinero / 2)} monedas de 2e, {(int)auxx} monedas de un euro, {(int)dsd / 50} monedas de 50cent, {(int)aux / 20} monedas de 20 cent y {cont} monedas de 1cent";
                            }
                        }
                        if (aux / 20 > 1)
                        {
                            aux2 = aux2 - 20;
                            if (aux2 / 5 > 1)
                            {
                                var aux3 = aux2 - 5;
                                var cont = 0;
                                while (aux3 > 0)
                                {
                                    cont++;
                                    aux3--;
                                }
                                frase = $"{(int)(dinero / 2)} monedas de 2e, {(int)auxx} monedas de un euro, {(int)dsd / 50} monedas de 50cent, {(int)aux / 20} monedas de 20 cent, {(int)aux2 / 5} monedas de 5 cent y {cont} monedas de 1cent";
                            }
                            else
                            {
                                var aux3 = aux2;
                                var cont = 0;
                                while (aux3 > 0)
                                {
                                    cont++;
                                    aux3--;
                                }
                                frase = $"{(int)(dinero / 2)} monedas de 2e, {(int)auxx} monedas de un euro, {(int)dsd / 50} monedas de 50cent, {(int)aux / 20} monedas de 20 cent y {cont} monedas de 1cent";
                            }
                        }
                        else
                        {
                            aux2 = aux;
                            if (aux2 / 5 > 1)
                            {
                                var aux3 = aux2 - 5;
                                var cont = 0;
                                while (aux3 > 0)
                                {
                                    cont++;
                                    aux3--;
                                }
                                frase = $"{(int)(dinero / 2)} monedas de 2e, {(int)auxx} monedas de un euro, {(int)dsd / 50} monedas de 50cent, {(int)aux / 20} monedas de 20 cent, {(int)aux2 / 5} monedas de 5 cent y {cont} monedas de 1cent";
                            }
                            else
                            {
                                var aux3 = aux2;
                                var cont = 0;
                                while (aux3 > 0)
                                {
                                    cont++;
                                    aux3--;
                                }
                                frase = $"{(int)(dinero / 2)} monedas de 2e, {(int)auxx} monedas de un euro, {(int)dsd / 50} monedas de 50cent, {(int)aux / 20} monedas de 20 cent y {cont} monedas de 1cent";
                            }

                        }

                    }
                    else
                    {
                        var aux = dsd;
                        var aux2 = dsd;
                        if (aux2 / 20 > 2)
                        {
                            aux2 = aux2 - 40;
                            if (aux2 / 5 > 1)
                            {
                                var aux3 = aux2 - 5;
                                var cont = 0;
                                while (aux3 > 0)
                                {
                                    cont++;
                                    aux3--;
                                }
                                frase = $"{(int)(dinero / 2)} monedas de 2e, {(int)auxx} monedas de un euro, {(int)dsd / 50} monedas de 50cent, {(int)aux / 20} monedas de 20 cent, {(int)aux2 / 5} monedas de 5 cent y {cont} monedas de 1cent";
                            }
                            else
                            {
                                var aux3 = aux2;
                                var cont = 0;
                                while (aux3 > 0)
                                {
                                    cont++;
                                    aux3--;
                                }
                                frase = $"{(int)(dinero / 2)} monedas de 2e, {(int)auxx} monedas de un euro, {(int)dsd / 50} monedas de 50cent, {(int)aux / 20} monedas de 20 cent y {cont} monedas de 1cent";
                            }
                        }
                        if (aux / 20 > 1)
                        {
                            aux2 = aux2 - 20;
                            if (aux2 / 5 > 1)
                            {
                                var aux3 = aux2 - (5 * ((int)aux / 5));
                                var cont = 0;
                                while (aux3 > 0)
                                {
                                    cont++;
                                    aux3--;
                                }
                                frase = $"{(int)(dinero / 2)} monedas de 2e, {(int)auxx} monedas de un euro, {(int)dsd / 50} monedas de 50cent, {(int)aux / 20} monedas de 20 cent, {(int)aux2 / 5} monedas de 5 cent y {cont} monedas de 1cent";
                            }
                            else
                            {
                                var aux3 = aux2;
                                var cont = 0;
                                while (aux3 > 0)
                                {
                                    cont++;
                                    aux3--;
                                }
                                frase = $"{(int)(dinero / 2)} monedas de 2e, {(int)auxx} monedas de un euro, {(int)dsd / 50} monedas de 50cent, {(int)aux / 20} monedas de 20 cent y {cont} monedas de 1cent";
                            }
                        }
                        else
                        {
                            aux2 = aux;
                            if (aux2 / 5 > 1)
                            {
                                var aux3 = aux2 - 5;
                                var cont = 0;
                                while (aux3 > 0)
                                {
                                    cont++;
                                    aux3--;
                                }
                                frase = $"{(int)(dinero / 2)} monedas de 2e, {(int)auxx} monedas de un euro, {(int)dsd / 50} monedas de 50cent, {(int)aux / 20} monedas de 20 cent, {(int)aux2 / 5} monedas de 5 cent y {cont} monedas de 1cent";
                            }
                            else
                            {
                                var aux3 = aux2;
                                var cont = 0;
                                while (aux3 > 0)
                                {
                                    cont++;
                                    aux3--;
                                }
                                frase = $"{(int)(dinero / 2)} monedas de 2e, {(int)auxx} monedas de un euro, {(int)dsd / 50} monedas de 50cent, {(int)aux / 20} monedas de 20 cent y {cont} monedas de 1cent";
                            }

                        }
                    }
                }
                else
                {
                    decimal dsd = (decimal)(dinero * 100) % 100;
                    //Console.WriteLine((decimal.Round(dsd, 1) / 50) >= 1);
                    if ((decimal.Round(dsd, 1) / 50) >= 1)
                    {
                        var aux = dsd - 50;
                        if (aux / 20 > 1)
                        {
                            var aux2 = aux;
                            if (aux2 / 20 > 2)
                            {
                                aux2 = aux2 - 40;
                                if (aux2 / 5 > 1)
                                {
                                    var aux3 = aux2 - 5;
                                    var cont = 0;
                                    while (aux3 > 0)
                                    {
                                        cont++;
                                        aux3--;
                                    }
                                    frase = $"{(int)(dinero / 2)} monedas de 2e, {(int)auxx} monedas de un euro, {(int)dsd / 50} monedas de 50cent, {(int)aux / 20} monedas de 20 cent, {(int)aux2 / 5} monedas de 5 cent y {cont} monedas de 1cent";
                                }
                            }
                            else
                            {
                                aux2 = aux2 - 20;
                            }
                        }
                        else
                        {
                            if (aux / 5 > 1)
                            {
                                var aux3 = aux - 5;
                                var cont = 0;
                                while (aux3 > 0)
                                {
                                    cont++;
                                    aux3--;
                                }
                                frase = $"{(int)(dinero / 2)} monedas de 2e, {(int)dsd / 50} monedas de 50cent, {(int)aux / 5} monedas de 5 cent y {cont} monedas de 1cent";
                            }
                            //else
                            //{

                            //}
                        }
                    }
                    else
                    {
                        var aux = dsd - 50;
                        if (aux / 20 > 1)
                        {
                            var aux2 = aux;
                            if (aux2 / 20 > 2)
                            {
                                aux2 = aux2 - 40;
                                if (aux2 / 5 > 1)
                                {
                                    var aux3 = aux2 - 5;
                                    var cont = 0;
                                    while (aux3 > 0)
                                    {
                                        cont++;
                                        aux3--;
                                    }
                                    frase = $"{(int)(dinero / 2)} monedas de 2e, {(int)auxx} monedas de un euro, {(int)dsd / 50} monedas de 50cent, {(int)aux / 20} monedas de 20 cent, {(int)aux2 / 5} monedas de 5 cent y {cont} monedas de 1cent";
                                }
                            }
                            else
                            {
                                aux2 = aux2 - 20;
                                if (aux2 / 5 > 1)
                                {
                                    var aux3 = aux2 - 5;
                                    var cont = 0;
                                    while (aux3 > 0)
                                    {
                                        cont++;
                                        aux3--;
                                    }
                                    frase = $"{(int)(dinero / 2)} monedas de 2e, {(int)auxx} monedas de un euro, {(int)dsd / 50} monedas de 50cent, {(int)aux / 20} monedas de 20 cent, {(int)aux2 / 5} monedas de 5 cent y {cont} monedas de 1cent";
                                }
                            }
                        }
                        else
                        {
                            var aux3 = aux;
                            var cont = 0;
                            while (aux3 > 0)
                            {
                                cont++;
                                aux3--;
                            }
                            frase = $"{(int)(dinero / 2)} monedas de 2e, {(int)auxx} monedas de un euro, {(int)dsd / 50} monedas de 50cent, {(int)aux / 20} monedas de 20 cent, {(int)aux / 5} monedas de 5 cent y {cont} monedas de 1cent";
                        }
                    }
                }
            }
            else
            {
                if (dinero > 1)
                {
                    decimal dsd = (decimal)(dinero * 100) % 100;
                    if ((dinero * 10) % 10 > 0)
                    {
                        if ((decimal.Round(dsd, 1) / 50) >= 1)
                        {
                            dsd = decimal.Round(dsd, 1);
                            if ((double)dsd / 50 > 1.0)
                            {
                                var aux = dsd - 50;
                                if (aux / 20 > 1)
                                {
                                    var aux2 = aux;
                                    if (aux2 / 20 > 2)
                                    {
                                        aux2 = aux2 - 40;
                                        if (aux2 / 5 > 1)
                                        {
                                            var aux3 = aux2 - 5;
                                            var cont = 0;
                                            while (aux3 > 0)
                                            {
                                                cont++;
                                                aux3--;
                                            }
                                            frase = $"{(int)dinero} monedas de un euro, {(int)dsd / 50} monedas de 50cent, {(int)aux / 20} monedas de 20 cent, {(int)aux2 / 5} monedas de 5 cent y {cont} monedas de 1cent";
                                        }
                                    }
                                    else
                                    {
                                        aux2 = aux2 - 20;
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    decimal dsd = (decimal)(dinero * 100) % 100;
                    if ((decimal.Round(dsd, 1) / 50) >= 1)
                    {
                        dsd = decimal.Round(dsd, 1);
                        if ((double)dsd / 50 > 1.0)
                        {
                            var aux = dsd - 50;
                            if (aux / 20 > 1)
                            {
                                var aux2 = aux;
                                if (aux2 / 20 > 2)
                                {
                                    aux2 = aux2 - 40;
                                    if (aux2 / 5 > 1)
                                    {
                                        var aux3 = aux2 - 5;
                                        var cont = 0;
                                        while (aux3 > 0)
                                        {
                                            cont++;
                                            aux3--;
                                        }
                                        frase = $"{(int)dsd / 50} monedas de 50cent, {(int)aux / 20} monedas de 20 cent, {(int)aux2 / 5} monedas de 5 cent y {cont} monedas de 1cent";
                                    }
                                }
                                else
                                {
                                    aux2 = aux2 - 20;
                                }
                            }
                        }
                    }
                    else
                    {
                        var aux = dsd;
                        if (aux / 20 > 1)
                        {
                            var aux2 = aux;
                            if (aux2 / 20 > 2)
                            {
                                aux2 = aux2 - 40;
                                if (aux2 / 5 > 1)
                                {
                                    var aux3 = aux2 - 5;
                                    var cont = 0;
                                    while (aux3 > 0)
                                    {
                                        cont++;
                                        aux3--;
                                    }
                                    frase = $"{(int)dsd / 50} monedas de 50cent, {(int)aux / 20} monedas de 20 cent, {(int)aux2 / 5} monedas de 5 cent y {cont} monedas de 1cent";
                                }
                            }
                            else
                            {
                                aux2 = aux2 - 20;
                            }
                        }
                    }
                }
            }
            return frase;

        }
    }
}
