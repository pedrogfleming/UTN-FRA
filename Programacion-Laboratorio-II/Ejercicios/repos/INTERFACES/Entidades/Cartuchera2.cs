using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cartuchera2<T, U> :ICartuchera
        where T : Boligrafo
        where U : Lapiz
        
    {
        //c.Declarar la clase Cartuchera2 que tendrá dos objetos del tipo List con los miembros
        //genéricos Boligrafo y Lapiz respectivamente.
        //Crear el método ProbarElementos para que haga exactamente lo mismo que el de
        //Cartuchera1.Recorrer cada lista por su tipo, por ejemplo foreach(Lapiz l in lista).
        private List<T> boligrafos;
        private List<U> lapices;

        private Cartuchera2()
        {
            this.boligrafos = new List<T>();
            this.lapices = new List<U>();
        }
        public Cartuchera2(List<T> boligrafos, List<U> lapices)
        {
            this.boligrafos = boligrafos;
            this.lapices = lapices;
        }
        public bool ProbarElementos()
        {
            bool flag = false;
            foreach (IAcciones item in this.boligrafos)
            {
                float aux = (item).UnidadesDeEscritura;
                (item).UnidadesDeEscritura -= 1;
                if (aux > (item).UnidadesDeEscritura)
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                }
                if ((item).UnidadesDeEscritura == 0)
                {
                    (item).Recargar(20);
                }
            }
            foreach (IAcciones item in this.lapices)
            {
                float aux = (item).UnidadesDeEscritura;
                (item).UnidadesDeEscritura -= 1;
                if (aux < (item).UnidadesDeEscritura)
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                }
                if ((item).UnidadesDeEscritura == 0)
                {
                    (item).Recargar(20);
                }
            }
            return flag;

        }
        //public static Cartuchera2 operator +(Cartuchera2 cartuchera, T boligrafo)
        //{
        //    cartuchera.elementos.Add(boligrafo);
        //    return cartuchera;
        //}
    }
}
