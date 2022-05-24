using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperaturas
{
    public class Celcius
    {
        private static float ebullicion;
        private static float congelamiento;
        public float temperatura;
        
        #region Constructores
        static Celcius()
        {
            ebullicion = 100;
            congelamiento = 0;
        }
        public Celcius()
        {
            temperatura = congelamiento;
        }
        public Celcius(float temperatura)
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
        public static implicit operator Celcius(float temperatura)
        {
            return new Celcius(temperatura);
        }
        #region Sobrecargas explicitas C°>>>F° & C°>>>K°
        public static explicit operator Fahrenheit(Celcius x)
        {
            return new Fahrenheit((x.temperatura*(float)((float)9 /5))+32);
        }
        public static explicit operator Kelvin(Celcius x)
        {
            return new Kelvin(x.temperatura+(float)273.15);
        }
        #endregion
        #region operator +
        public static Celcius operator +(Celcius c,Fahrenheit f)
        {
            return (c.temperatura + (((Celcius)f).temperatura));
        }
        public static Celcius operator +(Celcius c, Kelvin k)
        {
            return (c.temperatura + (((Celcius)k).temperatura));
        }
        #endregion
    }
}
