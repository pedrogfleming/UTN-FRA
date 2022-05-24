using System;
using System.Collections.Generic;
namespace _34_EjercicioVehiculos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<VehiculoTerrestre> vh = new List<VehiculoTerrestre>();

            vh.Add(new Camion(4, 4,Colores.Azul,5, 5000));
            vh.Add(new Moto(2, 0, Colores.Negro, 8));
            vh.Add(new Automovil(4, 4, Colores.Gris, 6,5));
            foreach (VehiculoTerrestre item in vh)
            {
                if (item.GetType() == typeof(Camion))
                {
                    Console.WriteLine(((Camion)item).MostrarDatos());
                }
                else if(item.GetType() == typeof(Automovil))
                {
                    Console.WriteLine(((Automovil)item).MostrarDatos());
                }
                else if (item.GetType() == typeof(Moto))
                {
                    Console.WriteLine(((Moto)item).MostrarDatos());
                }
            }
            Console.ReadKey();
        }
    }
}
