using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperaturas
{
    public class Fahrenheit
    {
        private static float ebullicion;
        private static float congelamiento;
        public float temperatura;
        #region Constructores
        static Fahrenheit()
        {
            ebullicion = 212;
            congelamiento = 32;
        }
        public Fahrenheit()
        {
            temperatura = congelamiento;
        }
        public Fahrenheit(float temperatura)
        {
            this.temperatura = temperatura;
        }
        #endregion
        #region Getters
        public float GetTemperatura()
        {
            return this.temperatura;
        }
        public static float GetEbullicion()
        {
            return ebullicion;
        }
        public static float GetCongelamiento()
        {
            return congelamiento;
        }
        #endregion
        public static implicit operator Fahrenheit(float temperatura)
        {
            return new Fahrenheit(temperatura);
        }
        #region Sobrecargas explicitas F°>>>C° & F°>>>K°
        public static explicit operator Celcius(Fahrenheit x)
        {
            return new Celcius((x.temperatura - 32)*((float)5 /9));
        }
        public static explicit operator Kelvin(Fahrenheit x)
        {
            return new Kelvin(((x.temperatura - 32)* (float)((float)5 /9)+ (float)273.15));
        }
        #endregion
        #region operator +
        public static Fahrenheit operator +(Fahrenheit f, Kelvin k)
        {
            return (f.temperatura + (((Fahrenheit)k).temperatura));
        }
        public static Fahrenheit operator +(Fahrenheit f, Celcius c)
        {
            return (f.temperatura + (((Fahrenheit)c).temperatura));
        }
        #endregion
    }
}
