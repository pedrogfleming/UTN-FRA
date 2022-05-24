using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EjercitoImperial
    {
        //x      14. Propiedad Troopers retornará la lista de soldados del ejército imperial.
        //x      15. La lista de troopers sólo podrá ser instanciada en el constructor privado.
        //x      16. El operador + deberá ser capaz de agregar un Trooper al Ejército Imperial.
        //x          a.La capacidad se utilizará para dar un límite a la cantidad de soldados de dicho ejército.
        // x         b.Si hay lugar, se agregará al nuevo soldado y se retornará el ejército modificado.
        //x      17. El operador – deberá ser capaz de sacar a un Trooper del Ejército Imperial.
        //x      a.Se buscará el primer Trooper del mismo tipo (TYPE) para ser removido.
        //x      b.Sólo se quitará la primer aparición de un Trooper que coincida.
        //x      c.Se retornará el ejército modificado.
        private int capacidad;
        private List<Troopper> troopers;
        #region Constructor
        private EjercitoImperial()
        {
            this.troopers = new List<Troopper>();
        }
        public EjercitoImperial(int capacidad) : this()
        {
            this.capacidad = capacidad;
        }
        #endregion
        #region Propiedades
        /// <summary>
        /// Propiedad Troopers retornará la lista de soldados del ejército imperial.
        /// </summary>
        public List<Troopper> Troopers
        {
            get
            {
                return this.troopers;
            }
        }
        #endregion
        #region Sobrecargas + y - (agregar y quitar troopers)
        /// <summary>
        /// Deberá ser capaz de agregar un Trooper al Ejército Imperial.
        ///La capacidad se utilizará para dar un límite a la cantidad de soldados de dicho ejército.
        /// </summary>
        /// <param name="ejercito"></param>
        /// <param name="soldado"></param>
        /// <returns>se retornará el ejército modificado o no</returns>
        public static EjercitoImperial operator +(EjercitoImperial ejercito, Troopper soldado)
        {
            if (ejercito is not null && soldado is not null && ejercito.Troopers.Count < ejercito.capacidad)
            {
                ejercito.Troopers.Add(soldado);
            }
            return ejercito;
        }
        /// <summary>
        ///  El operador – deberá ser capaz de sacar a un Trooper del Ejército Imperial.
        /// Se buscará el primer Trooper del mismo tipo (TYPE) para ser removido.
        /// |Sólo se quitará la primer aparición de un Trooper que coincida.
        /// </summary>
        /// <param name="ejercito"></param>
        /// <param name="soldado"></param>
        /// <returns>Se retornará el ejército modificado.</returns>
        public static EjercitoImperial operator -(EjercitoImperial ejercito, Troopper soldado)
        {
            if(soldado != null)
            {
                foreach (Troopper item in ejercito.Troopers)
                {
                    if (soldado.Equals(item))
                    {
                        ejercito.Troopers.Remove(item);
                        break;
                    }
                }
            } 
            return ejercito;
        }

        #endregion


    }
}
