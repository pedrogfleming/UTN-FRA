using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class TrooperAsalto : Troopper
    {
        //x      12. La propiedad tipo retornará "Comando para misiones de infiltración".
        //x      13. Siempre será un Clon.Reutilizar constructores para indicarlo.
        public TrooperAsalto(Blaster armamento) : base(armamento, true)
        {
        }
        /// <summary>
        /// La propiedad tipo retornará "Comando para misiones de infiltración".
        /// </summary>
        public override string Tipo
        {
            get
            {
                return "Comando para misiones de infiltración";
            }
        }
    }
}
