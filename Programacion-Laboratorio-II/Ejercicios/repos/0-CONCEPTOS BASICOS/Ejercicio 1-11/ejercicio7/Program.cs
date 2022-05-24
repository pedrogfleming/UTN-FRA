using System;
using ejercicio6;
namespace ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que pida por pantalla la fecha de nacimiento de una persona(día, mes y año) y
            //calcule el número de días vividos por esa persona hasta la fecha actual(tomar la fecha del sistema con DateTime.Now).
            //Nota: Utilizar estructuras selectivas.Tener en cuenta los años bisiestos.
            DateTime fechaNacimientoUsuario;
            Console.WriteLine("Ingrese su fecha de nacimiento");
            while (!DateTime.TryParse(Console.ReadLine(),out fechaNacimientoUsuario))
            {
                Console.WriteLine("ERROR, vuelva a ingresar su fecha de nacimiento");
            }//FIN WHILE
            Console.WriteLine("Su fecha de nacimiento es {0}", fechaNacimientoUsuario);            
            Console.WriteLine("Usted vivió {0} días desde que nacio",((DateTime.Today) - (fechaNacimientoUsuario)));
            //By default, all DateTime and DateTimeOffset values express dates and times in the Gregorian calendar.
            //A leap year in the Gregorian calendar is defined as a year that is evenly divisible by 4, unless it is divisible by 100. However, years that are divisible by 400 are leap years. For example, the year 1900 was not a leap year, but the year 2000 was. A common year has 365 days and a leap year has 366 days.
            #region Intento de hacer manual la contabilizacion de años bisiestos NO TERMINADO

            //totalBisiestos = ejercicio6.BisiestoAnual.ContarBisiestos(fechaNacimientoUsuario, DateTime.Today);
            ////diasAgregar = DateTime.TryParse(totalBisiestos);
            //diasVividos = DateTime.Today - fechaNacimientoUsuario;

            #endregion




            Console.ReadKey();
        }
    }
}
