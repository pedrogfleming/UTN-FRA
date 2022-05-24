using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_AutomovilesF1
{
    public class Competencia
    {
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<AutoF1> competidores;
        private Competencia()
        {
            this.competidores = new List<AutoF1>();
        }
        public Competencia(short cantidadVueltas, short cantidadCompetidores):this()
        {
            if(cantidadVueltas > 0 && cantidadCompetidores >= 0)
            {
                this.cantidadVueltas = cantidadVueltas;
                this.cantidadCompetidores = cantidadCompetidores;
            }
        }
        public string MostrarDatos()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Cantidad de vueltas en la competencia: {this.cantidadVueltas}");
            stringBuilder.AppendLine($"Cantidad de competidores: {this.cantidadCompetidores}");
            //Imprimimos luego todos los competidores
            foreach (AutoF1 auto in this.competidores)
            {
                stringBuilder.AppendLine(auto.MostrarDatos());
            }
            return stringBuilder.ToString();
        }
        #region Sobrecarga - & + (agregar/quitar competidores a la competencia)
        public static bool operator -(Competencia c,AutoF1 a)
        {
            if (c==a)         
            {
                return c.competidores.Remove(a);
            }
            return false;
        }
        public static bool operator +(Competencia c,AutoF1 a)
        {
            if(c.competidores.Count < c.cantidadCompetidores && c != a)        //si hay espacio y el competidor no forma parte de la lista...
            {
                c.competidores.Add(a);
                a.SetEnCompetencia(true);
                a.SetVueltasRestantes(c.cantidadVueltas);
                Random auxRandom = new Random();
                int auxCombustible = auxRandom.Next((int)15, (int)100);
                a.SetCantidadCombustible((short)auxCombustible);
                return true;
            }
            return false;
        }
        #endregion
        #region Sobrecarga == & !=
        public static bool operator ==(Competencia c, AutoF1 a)     //Si el competidor se encuentra o no en la lista
        {
            //El contains puede comparar que tengan la misma referencia de memoria pero no los mismos atributos
            foreach (AutoF1 item in c.competidores)
            {
                if(item == a)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Competencia c, AutoF1 a)
        {
            return !(c == a);
        }
        #endregion
    }   
}
