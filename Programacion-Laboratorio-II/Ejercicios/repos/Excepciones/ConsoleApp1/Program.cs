using System;
using Excepciones;
namespace ConsoleApp1

{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                OtraClase auxOtraClase = new OtraClase();
            }
            catch (MiExcepcion e)
            {
                Exception exInner = e.InnerException;
                Console.WriteLine(e.Message);
                while (exInner != null)
                {
                    Console.WriteLine(exInner.Message);
                    exInner = exInner.InnerException;
                }
                try
                {
                    OtraClase c = new OtraClase();
                    //c.OtroMetodo();
                }
                catch (MiExcepcion excepcion)
                {
                    Exception ex = excepcion;
                    do
                    {
                        Console.WriteLine(ex.Message);
                        ex = ex.InnerException;
                    } while (!object.ReferenceEquals(ex, null));
                }
            }
            Console.ReadKey();
        }
    }
}
