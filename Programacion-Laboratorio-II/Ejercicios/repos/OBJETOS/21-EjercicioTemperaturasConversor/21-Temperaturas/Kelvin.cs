using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperaturas
{
    public class Kelvin
    {
        private static float ebullicion;
        private static float congelamiento;
        public float temperatura;
        #region Constructores
        static Kelvin()
        {
            ebullicion = 373;
            congelamiento = 273;
        }
        public Kelvin()
        {
            temperatura = congelamiento;
        }
        public Kelvin(float temperatura)
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
        public static implicit operator Kelvin(float temperatura)
        {
            return new Kelvin(temperatura);
        }
        #region Sobrecargas explicitas K°>>>C° & K°>>>F°
        public static explicit operator Celcius(Kelvin x)
        {
            return new Celcius(x.temperatura - (float)273.15);
        }
        public static explicit operator Fahrenheit(Kelvin x)
        {
            return new Fahrenheit(((x.temperatura - (float)273.15)* (float)(9/5))+32);
        }
        #endregion

        #region operator +
        public static Kelvin operator +(Kelvin k, Fahrenheit f)
        {
            return (k.temperatura + (((Kelvin)f).temperatura));
        }
        public static Celcius operator +(Kelvin k, Celcius c)
        {
            return (k.temperatura + (((Kelvin)c).temperatura));
        }
        #endregion
    }
}
