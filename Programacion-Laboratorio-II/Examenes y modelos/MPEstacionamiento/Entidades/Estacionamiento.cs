using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estacionamiento
    {
        // a.Todos sus atributos serán privados.
        //b.El atributo estacionamiento será de clase.
        private int capacidadEstacionamiento;
        private static Estacionamiento estacionamiento;
        private List<Vehiculo> listadoVehiculos;
        private string nombre;

        #region Constructor
        //c.El único constructor será privado y se encargará de inicializar la lista de vehículos,
        //asignar un nombre al estacionamiento y definir su capacidad.
        private Estacionamiento(string nombre,int capacidad)
        {
            this.listadoVehiculos = new List<Vehiculo>();
            this.nombre = nombre;
            this.capacidadEstacionamiento = capacidad;
        }
        #endregion
        #region Singleton Estacionamiento
        //d.GetEstacionamiento será de clase e implementará un patrón singleton para lo cual deberá:        
        public static Estacionamiento GetEstacionamiento(string nombre,int capacidad)
        {
            //i.Si la variable estacionamiento es null, instanciar el objeto.
            if(estacionamiento is null)
            {
                Estacionamiento.estacionamiento = new Estacionamiento(nombre, capacidad);                
            }
            else
            {
                // ii.Si no es null, modificara la capacidad del estacionamiento.
                Estacionamiento.estacionamiento.capacidadEstacionamiento = capacidad;
            }
            //iii.En ambos casos, su última acción será retornar el objeto estacionamiento.
            return Estacionamiento.estacionamiento;
        }
        #endregion
        #region Propiedades
        //e.La propiedad ListadoVehiculos será de solo lectura y retornará la lista de vehículos del estacionamiento.
        public List<Vehiculo> ListadoVehiculos 
        {
            get
            {
                return this.listadoVehiculos;
            }        
        }
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }
        #endregion
        #region Informar Salida
        public string InformarSalida(Vehiculo vehiculo)
        {
            //f.InformarSalida será de instancia, recibirá un Vehículo y retornará una cadena que informará:
            //iv.El cargo del estacionamiento.
            StringBuilder aux = new StringBuilder();
            //i.El nombre del Estacionamiento.
            aux.Append(this.Nombre);
            //ii.Los datos del vehículo.
            aux.Append(vehiculo.ToString());
            //iii.La hora de salida.
            aux.Append(vehiculo.HoraEgreso);
            aux.Append(vehiculo.CostoEstadia);
            return aux.ToString();
        }
        #endregion
        #region Sobrecargas
        /// <summary>
        /// g.Un Estacionamiento y un Vehículo serán iguales, si el Vehículo se encuentra en el estacionamiento.
        /// </summary>
        /// <param name="estacionamiento"></param>
        /// <param name="vehiculo"></param>
        /// <returns></returns>
        public static bool operator ==(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            if(estacionamiento is not null && vehiculo is not null)
            {
                foreach (Vehiculo item in estacionamiento.ListadoVehiculos)
                {
                    if(item == vehiculo)
                    {
                        return true;
                    }
                }                
            }
            return false;
        }
        public static bool operator !=(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            return !(estacionamiento == vehiculo);
        }

        /// <summary>
        /// h.La sobrecargar del operador + (mas) permitirá agregar un Vehículo al Estacionamiento,
        /// siempre y cuando haya espacio disponible y el vehículo no se encuentre en él.
        /// </summary>
        /// <param name="estacionamiento"></param>
        /// <param name="vehiculo"></param>
        /// <returns></returns>
        public static bool operator +(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            if(estacionamiento.ListadoVehiculos.Count < estacionamiento.capacidadEstacionamiento && estacionamiento != vehiculo)
            {
                estacionamiento.ListadoVehiculos.Add(vehiculo);
                return true;
            }
            return false;
        }
        /// <summary>
        /// i.La Sobrecarga del operador – (menos) permitirá retirar un Vehículo del  estacionamiento,
        /// si es que este se encuentra en él.
        /// Antes de remover se deberá asignar una hora de Egreso al vehículo, usar DateTime.Now.
        /// </summary>
        /// <param name="estacionamiento"></param>
        /// <param name="vehiculo"></param>
        /// <returns></returns>
        public static bool operator -(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            if(estacionamiento == vehiculo)
            {
                vehiculo.HoraEgreso = DateTime.Now;
                return estacionamiento.ListadoVehiculos.Remove(vehiculo);
            }
            return false;
        }
        #endregion





        



    }
}
