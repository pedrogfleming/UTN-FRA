using System;

namespace Entidades
{
    public class Sumador
    {
        private int cantidadSumas;
        private int cantidadRestas;
        public Sumador(int cantidadSumasInstanciado)
        {
            this.cantidadSumas = cantidadSumasInstanciado;
        }
        public Sumador() : this(0)
        {
        }
        public long Sumar(long a, long b)
        {
            this.cantidadSumas++;
            return a + b;
        }
        public string Sumar(string a, string b)
        {
            this.cantidadSumas++;
            return a + b;
        }
        public static explicit operator int(Sumador s)
        {
            return s.cantidadSumas;
        }

        //d.Sobrecargar el operador + (suma) para que puedan sumar cantidadSumas y retornen un long con dicho valor.
        public static  long operator + (Sumador s1, Sumador s2)
        {
            return (long)(s1.cantidadSumas + s2.cantidadSumas);
        }
        public static long operator +(Sumador s1, Sumador s2)
        {
            return (long)(s1.cantidadRestas + s2.cantidadRestas);
        }

        //public static bool operator nombreTipo()
        public static bool operator |(Sumador s1, Sumador s2)
        {
            return (s1.cantidadSumas == s2.cantidadSumas);
        }

        //e.Sobrecargar el operador | (pipe) para que retorne True si ambos sumadores tienen igual cantidadSumas.

    }
}
