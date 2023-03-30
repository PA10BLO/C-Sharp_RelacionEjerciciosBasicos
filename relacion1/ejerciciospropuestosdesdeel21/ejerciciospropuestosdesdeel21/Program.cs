
using ejerciciospropuestosdesdeel21;
using ejerciciospropuestosdesdeel21.Ejercicios;

internal class Program
{
    private static void Main(string[] args)
    {
        int opcion;
        string mensaje = "menu";
        do {


            //Llamamos metodo que genera el texto del menú.
            MenuEjercicios.TextoMenu();
            //la variable opcion es igualada al valor return del metodo MensajePrederterminado, en el cual se introduce
            // un valor por consola y si es del tìpo adecuado se válida la información introducida
            opcion = ControladorMensajes.MensajePredeterminado<int>(mensaje);
            if ( opcion >= 21 && opcion<=43 || opcion == 0) {
                //Funcion que entra a un menuswtich correspondiente al menu
                MenuEjercicios.menuswitch(opcion);
            }
            else
            {
                mensaje = "";
                //Activamos el error, ya que si introduce un numero que no se adecua a los case del switch el metodo MensajePredeterminado se lo come.
                ControladorMensajes.MensajeErrorPredeterminado(mensaje);
            }                
        } while (opcion != 0);
    } 
}


