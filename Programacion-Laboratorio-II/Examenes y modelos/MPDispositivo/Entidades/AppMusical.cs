using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Entidades
{
    public class AppMusical : Aplicacion
    {
        //x La propiedad Tamanio retorna el tamaño de la app,
        //x el cual crecerá en base a la cantidad de canciones que tenga cargada.
        //x Por cada canción cargada, su tamaño crecerá en 2mb más.
        //x Por ejemplo: Si la aplicación pesa 50, y tiene 10 canciones, entonces se retornará 70.
        //x El método ObtenerInformacionApp mostrará también la lista de canciones.
        private List<string> listaCanciones;
        #region Constructores
        public AppMusical(string nombre, ESistemaOperativo sistemaOperativo, int tamanioInicial)
            :base(nombre, sistemaOperativo, tamanioInicial)
        {
            this.listaCanciones = new List<string>();
        }
        public AppMusical(string nombre, ESistemaOperativo sistemaOperativo, int tamanioInicial, List<string> listaCanciones)
            :this(nombre, sistemaOperativo, tamanioInicial)
        {
            this.listaCanciones = listaCanciones;
        }
        #endregion
        #region Propiedades
        /// <summary>
        /// La propiedad Tamanio retorna el tamaño de la app,
        ///el cual crecerá en base a la cantidad de canciones que tenga cargada.
        ///Por cada canción cargada, su tamaño crecerá en 2mb más.
        /// </summary>
        protected override int Tamanio
        {
            get
            {
                int aux = this.tamanioMb;
                foreach (string item in this.listaCanciones)
                {
                    aux += 2;
                }
                return aux;
            }
        }

        #endregion
        #region Metodo
        public override string ObtenerInformacionApp()
        {
            StringBuilder aux = new();
            aux.AppendLine(base.ObtenerInformacionApp());
            foreach (string item in this.listaCanciones)
            {
                aux.AppendLine(item);
            }
            return aux.ToString();            
        }
        #endregion
    }
}
