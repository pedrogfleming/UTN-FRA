using System;
using Entidades;
namespace _48_Contabilidad
{
    class Program
    {
        static void Main(string[] args)
        {
            Factura f1 = new Factura(12);
            Factura f2 = new Factura(56);
            Factura f3 = new Factura(32);
            Factura f4 = new Factura(122);
            Recibo r1 = new Recibo();
            Recibo r2 = new Recibo(12);
            Recibo r3 = new Recibo(32);
            Recibo r4 = new Recibo(2652);

            Contabilidad<Factura, Recibo> c = new Contabilidad<Factura, Recibo>();
            c += f1;
            c += f2;
            c += f3;
            c += f4;
            c += r1;
            c += r2;
            c += r3;
            c += r4;
            Console.WriteLine(c.Mostrar());
            Console.ReadKey();
        }
    }
}
