using System;

namespace _31_AtencionCliente
{
    class Program
    {
        static void Main(string[] args)
        {
            Negocio tienda1 = new("Panch8");
            Cliente cliente1 = new("Pepe",1);
            Cliente cliente2 = new("Horacio",2);
            Cliente cliente3 = new("Jose",3);
            Cliente cliente4 = new("Fausto",4);
            if (tienda1 + cliente1)
            {
                Console.WriteLine("El cliente 1 llego a {0}!!!",tienda1.Nombre);
            }
            else
            {
                Console.WriteLine("El cliente 1 esta esperando ser atendido en {0}", tienda1.Nombre);
            }
            if (tienda1 + cliente2)
            {
                Console.WriteLine("El cliente 2 llego a {0}!!!", tienda1.Nombre);
            }
            else
            {
                Console.WriteLine("El cliente 2 esta esperando ser atendido en {0}", tienda1.Nombre);
            }
            if (tienda1 + cliente3)
            {
                Console.WriteLine("El cliente 3 llego a {0}!!!", tienda1.Nombre);
            }
            else
            {
                Console.WriteLine("El cliente 3 esta esperando ser atendido en {0}", tienda1.Nombre);
            }

            while(~tienda1)
            {
                Console.WriteLine("Todavía hay {0} clientes esperando ser atendido en {0}", tienda1.Nombre);
            }            
            Console.WriteLine("Ya no hay clientes en {0}", tienda1.Nombre);
            Console.ReadKey();
        }
    }
}
