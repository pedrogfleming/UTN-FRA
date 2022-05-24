using System;
using System.Text;

namespace Entidades
{
    sealed public class Automovil : Vehiculo
    {
        //b.Sus atributos marca y valorHora, serán privados.        
        private string marca;
        private static double valorHora;
        #region Constructores
        //valorHora será de clase(estatico) y su valor se inicializará en el constructor de clase, siendo su valor 120.
        static Automovil()
        {
            Automovil.ValorHora = 120;          
        }
        //c.El Constructor de Instancia recibirá: La patente, hora de ingreso y la marca del
        //Automovil.
        public Automovil(string patente, DateTime horaIngreso, string marca) : base(horaIngreso, patente)
        {
            this.marca = marca;
        }
        #endregion
        #region Propiedades
        //d.La propiedad ValorHora será de Clase y solo escritura, desde allí se podrá
        //cambiar el valor de la hora para Automóvil, siempre que el valor recibido sea
        //positivo.
        public static double ValorHora
        {
            set
            {
                if (value > 0)
                {
                    Automovil.valorHora = value;
                }
            }
        }
        //e.La propiedad CostoEstadia, retornara el cargo del estacionamiento para el Automóvil.
        public override double CostoEstadia
        {
            get
            {
                return this.CargoDeEstacionamiento();
            }
        }
        //g.La propiedad Descripcion retornara la marca del Automóvil.
        public override string Descripcion
        {
            get
            {
                return this.marca;
            }
        }
        #endregion
        #region Metodos
        protected override double CargoDeEstacionamiento()
        {
            return base.CargoDeEstacionamiento() * valorHora;
        }
        //h.MostrarDatos será protegido, agregara información indicando que es un 
        //"****AUTOMOVIL*****" y la descripción de este.

        protected override string MostrarDatos()
        {
            StringBuilder aux = new StringBuilder();
            aux.Append(base.MostrarDatos());
            aux.Append("****AUTOMOVIL*****");
            aux.Append(this.Descripcion);
            return aux.ToString();
        }
        //i.ToString hará públicos los datos de Automóvil.
        #endregion
        #region Sobrecargar toString()
        //f.El método CargoEstacionemiento, será protegido y retornará el cargo del Automóvil,
        //resultante de multiplicar las horas de la estadía por el valor de la hora.
               
        public override string ToString()
        {
            return this.MostrarDatos();
        }
        #endregion

    }
}
