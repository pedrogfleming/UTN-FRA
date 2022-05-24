using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Arbusto : Planta
    {
        //5. Clase Arbusto:
        //a.No tiene flores ni fruto.
        #region Propiedades
        public override bool TieneFlores
        {
            get
            {
                return false;
            }
        }
        public override bool TieneFrutos
        {
            get
            {
                return false;
            }
        }
        #endregion
        #region Constructor
        public Arbusto(string nombre, int tamanio) : base(nombre, tamanio)
        {

        }
        #endregion
    }
}
