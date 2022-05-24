using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    sealed public class Moto : Vehiculo
    {
        //a.Hereda de Vehículo.
        //b.Tendrá un enumerado de ETipo con los ítems: {Ciclomotor, Scooter,Sport}
        //c.Sus atributos tipo y valorHora, serán privados.valorHora será de clase y su
        //valor se inicializará en el constructor de clase, siendo su valor 100.
        public enum ETipo { Ciclomotor, Scooter, Sport };
        private ETipo tipo;
        private static double valorHora;
        #region Constructores
        //d.El Constructor de Instancia recibirá: La patente, hora de ingreso y el tipo de Moto.
        static Moto()
        {
            ValorHora = 100;
        }
        public Moto(string patente, DateTime horaIngreso, ETipo tipo) : base(horaIngreso, patente)
        {
            this.tipo = tipo;
        }
        #endregion        
        #region Propiedades
        public static double ValorHora
        {
            //e.La propiedad ValorHora será de Clase y solo escritura, desde allí se podrá
            //   cambiar el valor de la hora para Moto, siempre que el valor recibido sea
            //   positivo.
            set
            {
                if (value > 0)
                {
                    valorHora = value;
                }
            }
        }
        //   f.La propiedad CostoEstadia, retornara el cargo del estacionamiento para la Moto.
        public override double CostoEstadia
        {
            get
            {
                return this.CargoDeEstacionamiento();
            }
        }
        //h.La propiedad Descripcion retornara el tipo de Moto.
        public override string Descripcion
        {
            get
            {
                return this.tipo.ToString();
            }
        }
        #endregion
        #region Metodos
        //g.El método CargoEstacionamiento, será protegido y retornará el cargo de la
        //   Moto, resultante de multiplicar las horas de la estadía por el valor de la hora.
        protected override double CargoDeEstacionamiento()
        {
            return base.CargoDeEstacionamiento() * valorHora;
        }
        //i.MostrarDatos será protegido, agregara información indicando que es una
        //"****MOTO*****" y la descripción de este.
        protected override string MostrarDatos()
        {
            StringBuilder aux = new StringBuilder();
            aux.Append(base.MostrarDatos());
            aux.Append("****MOTO*****");
            aux.Append(this.Descripcion);
            return aux.ToString();
        }
        #endregion
        #region Sobrecargar toString()
        //   j.ToString hará públicos los datos de Moto.
        public override string ToString()
        {
            return this.MostrarDatos();
        }
        #endregion

    }
}
