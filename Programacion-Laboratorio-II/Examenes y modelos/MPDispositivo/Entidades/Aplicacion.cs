using System;
using System.Text;
using System.Collections.Generic;
namespace Entidades
{

    public abstract class Aplicacion
    {
        //x  Las propiedades marcadas en cursiva son abstractas.       
        //x  El método ObtenerInformacionApp retornará los datos de la aplicación utilizando StringBuilder.  
        //x  El operador implícito recibirá una lista de aplicaciones y devolverá la instancia de la aplicación que más tamaño tenga.
        //x  El método ToString devolverá el nombre de la aplicación.        
        //x  La sobrecarga del operador == buscará si una aplicación existe en la lista recibida por parámetro comparando por su nombre.Devolverá true si ya existe.
        //x  La sobrecarga del operador + añadirá una aplicación a la lista de aplicaciones pasada por parámetro siempre y cuando sea no exista previamente.Reutilizar código.
        protected string nombre;
        protected ESistemaOperativo sistemaOperativo;
        protected int tamanioMb;
        #region Constructor
        protected Aplicacion(string nombre, ESistemaOperativo sistemaOperativo, int tamanioMb)
        {
            this.nombre = nombre;
            this.sistemaOperativo = sistemaOperativo;
            this.tamanioMb = tamanioMb;
        }
        #endregion
        #region Propiedades
        public ESistemaOperativo SistemaOperativo
        {
            get
            {
                return this.sistemaOperativo;
            }
        }
        protected abstract int Tamanio { get; }
        #endregion
        #region Metodos
        /// <summary>
        /// Retornará los datos de la aplicación utilizando StringBuilder.
        /// </summary>
        /// <returns></returns>
        public virtual string ObtenerInformacionApp()
        {
            StringBuilder aux = new StringBuilder();
            aux.AppendFormat("\nNombre aplicacion: {0}", this.nombre);
            aux.AppendFormat("\nSistema Operativo: {0}", this.sistemaOperativo);
            aux.AppendFormat("\nTamanio ocupado: {0}\n", this.tamanioMb);
            return aux.ToString();
        }
        public override string ToString()
        {
            return ObtenerInformacionApp();
        }
        #endregion
        #region Sobrecarga implicita
        /// <summary>
        /// 
        /// </summary>
        /// <param name="listaApp"></param>
        public static implicit operator Aplicacion(List<Aplicacion> listaApp)
        {
            Aplicacion auxApp = null;
            if (listaApp is not null)
            {
                foreach (Aplicacion item in listaApp)
                {
                    if (auxApp is null || item.Tamanio > auxApp.Tamanio)
                    {
                        auxApp = item;
                    }
                }
            }
            return auxApp;
        }
        #endregion
        #region Sobrecarga == & !=
        /// <summary>
        /// Buscará si una aplicación existe en la lista recibida por parámetro comparando por su nombre.
        /// </summary>
        /// <param name="listaApp"></param>
        /// <param name="app"></param>
        /// <returns>Devolverá true si ya existe.</returns>
        public static bool operator ==(List<Aplicacion> listaApp, Aplicacion app)
        {
            if(listaApp is not null && app is not null)
            {
                foreach (Aplicacion item in listaApp)
                {
                    if(item.nombre == app.nombre)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public static bool operator !=(List<Aplicacion> listaApp, Aplicacion app)
        {
            return !(listaApp == app);
        }
        #endregion
        #region Sobrecarga + Agregar app a la lista de app
        /// <summary>
        /// Añadirá una aplicación a la lista de aplicaciones pasada por parámetro siempre y cuando sea no exista previamente
        /// </summary>
        /// <param name="listaApp"></param>
        /// <param name="app"></param> 
        /// <returns>True si la pudo agregar</returns>
        public static bool operator +(List<Aplicacion> listaApp, Aplicacion app)
        {
            if(listaApp != app)
            {
                listaApp.Add(app);
                return true;
            }
            return false;
        }
        #endregion


    }
}
