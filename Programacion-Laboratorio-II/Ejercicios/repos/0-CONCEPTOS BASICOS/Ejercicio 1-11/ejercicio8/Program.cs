using System;

namespace ejercicio8
{
    class Program
    {
        //Por teclado se ingresa:
        //el valor hora,
        //el nombre
        //la antigüedad(en años)
        //la cantidad de horas trabajadas en el mes de N empleados de una fábrica.

        //Se pide calcular el importe a cobrar teniendo en cuenta que
        //al total(que resulta de multiplicar el valor hora por la cantidad de horas trabajadas),
        //hay que sumarle la cantidad de años trabajados multiplicados por $ 150,
        //y al total de todas esas operaciones restarle el 13% en concepto de descuentos.
        //Mostrar el recibo correspondiente con el nombre, la antigüedad, el valor hora, el total a cobrar en
        //bruto, el total de descuentos y el valor neto a cobrar de todos los empleados ingresados.
        //Nota: Utilizar estructuras repetitivas y selectivas.
        static void Main(string[] args)
        {
            int valorHora;
            string nombrePersona;
            int antiguedad = 0;
            int horasMensualesTrabajadas;
            string respuestaUsuario;
            float totalBruto;
            float totalNeto;
            float totalDescuentos = 0;
            do
            {
                Console.WriteLine("Ingrese el valor hora");
                while (!int.TryParse(Console.ReadLine(), out valorHora) || valorHora < 1)
                {
                    Console.WriteLine("Error, Ingrese valor hora válida");
                }
                Console.WriteLine("Ingrese el nombre de la persona");
                while ((nombrePersona = Console.ReadLine().Trim()) == null || string.IsNullOrWhiteSpace(nombrePersona))
                {
                    Console.WriteLine("Error, Ingrese el nombre de la persona");
                }
                Console.WriteLine("Ingrese la antiguedad");
                while (!int.TryParse(Console.ReadLine(), out antiguedad) || antiguedad < 0)
                {
                    Console.WriteLine("Error, Ingrese antiguedad válida");
                }
                Console.WriteLine("Ingrese la cantidad de horas trabajadas mensuales");
                while (!int.TryParse(Console.ReadLine(), out horasMensualesTrabajadas) || horasMensualesTrabajadas < 0)
                {
                    Console.WriteLine("Error, Ingrese la cantidad de horas trabajadas mensuales validas");
                }
                #region debbugin
                //Console.WriteLine("El valor hora es {0}", valorHora);
                //Console.WriteLine("El nombre de la persona es {0}", nombrePersona);
                //Console.WriteLine("La antiguedad es {0}", antiguedad);
                //Console.WriteLine("La la cantidad de horas trabajadas mensuales es {0}", horasMensualesTrabajadas);

                #endregion
                Console.WriteLine("¿Desea seguir ingresando empleados?S/N");
                respuestaUsuario = Console.ReadLine().ToUpper();
                totalBruto = (valorHora * horasMensualesTrabajadas) + antiguedad * 150;
                totalNeto = totalBruto *(float) 0.87;
                totalDescuentos += (float)(totalBruto * 0.13);
                //Mostrar el recibo correspondiente con el nombre, la antigüedad, el valor hora, el total a cobrar en
                //bruto, el total de descuentos y el valor neto a cobrar de todos los empleados ingresados.
                Console.WriteLine("Nombre empleado: {0}\n" +
                    "Antiguedad empleado: {1}\n" +
                    "Valor hora: {2}\n" +
                    "Total a cobrar en bruto: {3}\n" +
                    "Total descuentos: {4}\n" +
                    "Total neto: {5}\n",nombrePersona, antiguedad, valorHora, totalBruto, totalDescuentos, totalNeto);
            } while (respuestaUsuario.Contains("S"));

            Console.ReadKey();


        }

    }
}
