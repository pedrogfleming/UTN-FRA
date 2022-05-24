using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    //x  Su índice de contagios será de duplicación del contador.
    public class Covid19 : Microrganismo
    {
        public Covid19(string nombre):base(nombre)
        {
        }
        public override long IndiceDeContagios
        {
            get
            {
                return this.contador * 5;
            }
        }
    }
}
