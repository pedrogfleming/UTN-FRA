using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Entrenador : Deportista
    {
        private bool campeonDelMundo;
        private int cantEquiposDirigidos;

        public Entrenador(string nombreApe, int edad, int cantPart,int cantEqui, bool camp)
            :base(nombreApe, edad, cantPart)
        {
            this.campeonDelMundo = camp;
            this.cantEquiposDirigidos = cantEqui;
        }

        public bool CampeonDelMundo 
        {
            get
            {
                return this.campeonDelMundo;
            } 
        }
        public int CantEquiposDirigidos
        {
            get
            {
                return this.cantEquiposDirigidos;
            }
        }
    }
}
