using System;

namespace Temperaturas
{
    class Program
    {
        static void Main(string[] args)
        {
            /*De Celsius a Kelvin: KELVIN = CELSIUS + 273.15
             De Celsius a Farenheit: FARENHEIT = (CELSIUS) *9/5 + 32
             De Farenheit a Celsius: CELSIUS = (FARENHEIT – 32) * (5/9)
             De Farenheit a Kelvin: KELVIN = (FARENHEIT – 32) * (5/9) + 273.15
             De Kelvin a Celsius: CELSIUS = KELVIN – 273.15
             De Kelvin a Farenheit: FARENHEIT = ((KELVIN – 273.15) * 9/5 ) + 32
             * 
             * 
             */


            Celcius experimento1 = 4;   //sobrecarga implicita
            Fahrenheit experimento2 = 50;//10 c°
            Kelvin experimento3 = 284;//10.85 c°
            Celcius suma = (Celcius)(experimento2 + experimento3);
            //Kelvin experimento3 = 273;
            //Console.WriteLine("{0} C° equivale a {1} F°", experimento1.GetTemperatura(), ((Fahrenheit)experimento1).GetTemperatura());
            //Console.WriteLine("{0} C° equivale a {1} K°", experimento1.GetTemperatura(), ((Kelvin)experimento1).GetTemperatura());
            //Console.WriteLine("{0} F° equivale a {1} C°", experimento2.GetTemperatura(), ((Celcius)experimento2).GetTemperatura());
            //Console.WriteLine("{0} F° equivale a {1} K°", experimento2.GetTemperatura(), ((Kelvin)experimento2).GetTemperatura());
            //Console.WriteLine("La suma es {0}", (experimento1+experimento2).temperatura);
            Console.WriteLine("La suma es {0}", (experimento1 + experimento3).temperatura);
            Console.WriteLine("La suma es {0}", suma.temperatura);

            Console.ReadKey();
        }
    }
}
