using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cartuchera1 : ICartuchera
    {
        private List<IAcciones> elementos;

        public Cartuchera1()
        {
            this.elementos = new List<IAcciones>();
        }        
        /// <summary>
        /// Se deberá recorrer la lista y gastará 1 unidades de cada elemento.
        /// ii.Cuando sea necesario, recargará antes de salir del método(cargar 20 unidades).iii.
        /// </summary>
        /// <returns>Retornará true si todos los bolígrafos pudieron gastar exactamente las 1 unidades.</returns>
        public bool ProbarElementos()
        {
            bool flag = false;
            foreach (IAcciones item in this.elementos)
            {
                //float aux = item.UnidadesDeEscritura;
                item.UnidadesDeEscritura -= 1;
                //if(aux > (item).UnidadesDeEscritura)
                //{
                //    flag = true;
                //}
                //else
                //{
                //    flag = false;
                //}
                if(item.UnidadesDeEscritura == 0)
                {
                    item.Recargar(20);
                    return false;
                }
            }
            return flag;
        }
        public static Cartuchera1 operator +(Cartuchera1 cartuchera, IAcciones obj)
        {
            cartuchera.elementos.Add(obj);
            return cartuchera;
        }
    }
}
