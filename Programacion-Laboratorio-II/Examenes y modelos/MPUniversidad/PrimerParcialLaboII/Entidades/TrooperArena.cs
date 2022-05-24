using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class TrooperArena : Troopper
    {
        //x  11. La propiedad tipo retornará "Soldados de asalto de terrenos desérticos"
        public TrooperArena(Blaster armamento)
            :base(armamento)
        {            
        }
        #region Propiedad
        /// <summary>
        /// La propiedad tipo retornará "Soldados de asalto de terrenos desérticos"
        /// </summary>
        public override string Tipo 
        {
            get
            {
                return "Soldados de asalto de terrenos desérticos";
            }
        }
        #endregion
    }
}
