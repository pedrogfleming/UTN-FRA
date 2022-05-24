using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class AppJuegos : Aplicacion
    {
        //La propiedad Tamanio retorna el tamaño de la aplicación.
        #region Constructor
        public AppJuegos(string nombre, ESistemaOperativo sistemaOperativo, int tamanioMb) 
            : base(nombre, sistemaOperativo, tamanioMb)
        {
            this.tamanioMb = tamanioMb;
        }
        #endregion
        #region Propiedad
        protected override int Tamanio 
        {
            get
            {
                return this.tamanioMb;
            }
        
        }
        #endregion
    }
}
