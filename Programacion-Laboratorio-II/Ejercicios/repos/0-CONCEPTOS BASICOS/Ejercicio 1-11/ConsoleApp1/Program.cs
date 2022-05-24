using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ClassLibrary1;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numerito;
            //Console.writeline(class1.metodoestatico());
            //Console.writeline($"el mensaje es: (class1.metodoestatico())");
            //Console.writeline("el mensaje es: {0}", class1.metodoestatico());
            //Console.readkey();
            if(int.TryParse(Console.ReadLine(), out numerito))//entra por verdadero
            {
                Console.WriteLine("LOGRO INGRESAR EL NUMERO");
            }
            Console.ReadKey();
        }
               


        
    }

}
