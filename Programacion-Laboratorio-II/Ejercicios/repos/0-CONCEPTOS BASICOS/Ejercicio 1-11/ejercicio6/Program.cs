using System;

namespace ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escribir un programa que determine si un año es bisiesto.
            //Un año es bisiesto si es múltiplo de 4.
            //Los años múltiplos de 100 no son bisiestos, salvo si ellos también son múltiplos de 400.
            //Por ejemplo: el año 2000 es bisiesto pero 1900 no.
            //Pedirle al usuario un año de inicio y otro de fin y mostrar todos los años bisiestos en ese rango.
            //Nota: Utilizar estructuras repetitivas, selectivas y la función módulo (%).
            int anioInicioIngresado;
            int anioFinIngresado;
            Console.WriteLine("Ingrese año de inicio");
            while (!int.TryParse(Console.ReadLine(), out anioInicioIngresado))
            {
                Console.WriteLine("ERROR, vuelva a ingresar el Ingrese año de inicio");
            }//FIN WHILE
            Console.WriteLine("Ingrese año de fin");
            while (!int.TryParse(Console.ReadLine(), out anioFinIngresado))
            {
                Console.WriteLine("ERROR, vuelva a ingresar el Ingrese año de fin");
            }//FIN WHILE

            for(int i= anioInicioIngresado;i< anioFinIngresado;i++)
            {
                
                if ((i%4) != 0)          
                {
                    continue;
                }
                else //Un año es bisiesto si es múltiplo de 4. 
                {                    
                    if ((i%100) == 0)
                    {                        
                        if ((i % 400) == 0)       //Los años múltiplos de 100 no son bisiestos, salvo si ellos también son múltiplos de 400.
                        {
                            Console.WriteLine("El año {0} es bisiesto", i);
                        }
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("El año {0} es bisiesto", i);
                    }                    
                }
                
            }//FIN FOR
            Console.ReadKey();
        }
    }
}
