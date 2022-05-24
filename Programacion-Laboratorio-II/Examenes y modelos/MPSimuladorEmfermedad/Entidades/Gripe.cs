using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    //Su índice de contagios será de duplicación del contador.
    public class Gripe : Microrganismo
    {
        public Gripe(string nombre,ETipo tipo,EContagiosidad contagiosidad):base(contagiosidad,nombre,tipo)
        {
        }
        public override long IndiceDeContagios
        {
            get
            {
                return this.contador * 2;
            }
        }
    }
}
