using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Ejercicio
{
    public class Alumno
    {
        /*16. Crear la clase Alumno de acuerdo al siguiente diagrama:
            a. Se pide crear 3 instancias de la clase Alumno (3 objetos) en la función Main. Colocarle
            nombre, apellido y legajo a cada uno de ellos.
            b. Sólo se podrá ingresar las notas (nota1 y nota2) a través del método Estudiar.
            c. El método CalcularFinal deberá colocar la nota del final sólo si las notas 1 y 2 son mayores o
            iguales a 4, caso contrario la inicializará con -1. Para darle un valor a la nota final utilice
            el método de instancia Next de la clase Random.
            d. El método Mostrar, expondrá en la consola todos los datos de los alumnos. La nota final se
            mostrará sólo si es distinto de -1, caso contrario se mostrará la leyenda "Alumno
            desaprobado".
         * 
         */

        public string nombre;
        public string apellido;
        public int legajo;
        private byte nota1;
        private byte nota2;
        private float notaFinal;
        //el metodo estatico es propio de la clase, no de la instancia
        public Alumno(string nombre, string apellido, int legajo)//constructor de la clase alumno
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }

        public void Estudiar(byte notaUno, byte notaDos)
        {
            // b. Sólo se podrá ingresar las notas (nota1 y nota2) a través del método Estudiar.
            #region Omitir carga por consola
            //Console.WriteLine("Ingrese nota 1");
            //while(byte.TryParse(Console.ReadLine(),out notaUno))
            //{
            //    Console.WriteLine("Ingrese nota 1");
            //}
            //Console.WriteLine("Ingrese nota 2");
            //while(byte.TryParse(Console.ReadLine(), out notaDos))
            //{
            //    Console.WriteLine("Ingrese nota 2");
            //}

            #endregion
            this.nota1 = notaUno;
            this.nota2 = notaDos;
        }
        
        public void CalcularFinal()
        {
           // c.El método CalcularFinal deberá colocar la nota del final sólo si las notas 1 y 2 son mayores o
           //iguales a 4, caso contrario la inicializará con - 1.Para darle un valor a la nota final utilice
           // el método de instancia Next de la clase Random.
            notaFinal = -1;
            if(nota1 >= 4 && nota2 >= 4)
            {
                Random puntaje = new Random();
                notaFinal = puntaje.Next(4,10);
            }
        }
        public string Mostrar()
        {
            //d.El método Mostrar, expondrá en la consola todos los datos de los alumnos. La nota final se
            //mostrará sólo si es distinto de -1, caso contrario se mostrará la leyenda "Alumno
            //desaprobado". 
            //Console.WriteLine("Alumno: {0} {1} {2} \nNotas: {3} {4}", nombre,apellido,legajo,nota1,nota2);
            if (notaFinal != -1)
            {                
                return string.Format("Alumno: {0} {1} {2} \nNotas: {3} {4}\nLa nota final del alumno es {5}", nombre, apellido, legajo, nota1, nota2, notaFinal);
            }
            return string.Format("Alumno: {0} {1} {2} \nNotas: {3} {4}\nEl alumno esta desaprobado", nombre, apellido, legajo, nota1, nota2);
        }


    }
}
