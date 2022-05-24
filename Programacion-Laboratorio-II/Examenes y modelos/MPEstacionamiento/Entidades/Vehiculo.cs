using System;
using System.Text;
namespace Entidades
{
    public abstract class Vehiculo
    {
        public enum EVehiculos { Automovil,Moto};
        private DateTime horaEgreso;
        private DateTime horaIngreso;
        private string patente;

        #region Constructores
        protected Vehiculo(DateTime horaIngreso, string patente)
        {
            this.horaIngreso = horaIngreso;
            Patente = patente;
        }
        #endregion
        #region Propiedades

        public virtual double CostoEstadia { get;}
        public virtual string Descripcion { get;}

        public string Patente 
        {
            get
            {
                return this.patente;
            }
            set
            {
                if(!string.IsNullOrWhiteSpace(value) && ValidarPatente(value))
                {
                    this.patente = value;
                }                
            }         
        }
        public DateTime HoraIngreso 
        {
            get
            {
                return this.horaIngreso;
            }
        }
        public DateTime HoraEgreso
        {
            get
            {
                return this.horaEgreso;
            }
            set
            {
                if (value > this.HoraIngreso)
                {
                    this.horaEgreso = value;
                }
            }
        }
        #endregion
        #region Validacion Patente
        private bool ValidarPatente(string patente)
        {
            return (patente.Length >= 6 && patente.Length <= 7);
        }
        #endregion
        #region Metodos 
        protected virtual double CargoDeEstacionamiento()
        {
            if(this.HoraEgreso> this.HoraIngreso)
            {
                return (double)(this.HoraEgreso.Hour - this.HoraEgreso.Hour);
                //usar total hour
                //(this.HoraEgreso.Hour - this.HoraEgreso.Hour).tt

            }
            return 0;
                       
        }
        protected virtual string MostrarDatos()
        {
            StringBuilder aux = new StringBuilder();
            aux.Append(this.Patente);
            aux.Append(this.HoraIngreso);
            return aux.ToString();
        }
        #endregion
        #region Sobrecargas == & !=
        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            return (v1.Patente == v2.Patente);
        }
        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }
        #endregion
    }
}
