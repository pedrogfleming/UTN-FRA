using System;

namespace _16_Ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno[] listaAlumnos = new Alumno[3];
            listaAlumnos[0] = new Alumno("Jose", "Lopez", 36328);
            listaAlumnos[1] = new Alumno("Juan","Marinaro",36329);
            listaAlumnos[2] = new Alumno("Horacio", "Rottar", 36330);

            listaAlumnos[0].Estudiar(5, 10);
            listaAlumnos[1].Estudiar(7, 2);
            listaAlumnos[2].Estudiar(4, 9);
            for(int i=0;i<3;i++)
            {
                listaAlumnos[i].CalcularFinal();
            }
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(listaAlumnos[i].Mostrar());
            }
            Console.ReadKey();

            #region omitir carga por consola
            //for(int i=0;i<3;i++)
            //{
            //    Console.WriteLine("ingrese nombre");
            //    string nombre = Console.ReadLine();
            //    string apellido = Console.ReadLine();                 
            //    listaAlumnos[i] = new Alumno(nombre, apellido, legajo++);
            //}
            #endregion
        }

    }
}
