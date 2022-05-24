using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36_Ejercicio
{
    public class Competencia
    {
        public enum tipoCompetencia { F1, MotoCross };
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<VehiculoDeCarrera> competidores;
        private tipoCompetencia tipo;
        #region Constructores
        private Competencia()
        {
            this.competidores = new List<VehiculoDeCarrera>();
        }
        public Competencia(short cantidadVueltas, short cantidadCompetidores, tipoCompetencia tipoCompetencia) : this()
        {
            if (cantidadVueltas > 0 && cantidadCompetidores >= 0)
            {
                this.CantidadVueltas = cantidadVueltas;
                this.CantidadCompetidores = cantidadCompetidores;
            }
        }
        #endregion
        #region Propiedades
        public short CantidadCompetidores
        {
            get
            {
                return this.cantidadCompetidores;
            }
            set
            {
                if (value > 0)
                {
                    this.cantidadCompetidores = value;
                }
            }
        }
        public short CantidadVueltas
        {
            get
            {
                return this.cantidadVueltas;
            }
            set
            {
                if (value > 0)
                {
                    this.cantidadVueltas = value;
                }
            }
        }
        public tipoCompetencia Tipo
        {
            get
            {
                return this.tipo;
            }
            set
            {
                if (value == tipoCompetencia.F1 || value == tipoCompetencia.MotoCross)
                {
                    this.tipo = value;
                }
            }
        }
        /// <summary>
        /// Agregar una propiedad que haga pública la lista de Vehículos de Competencia.
        /// </summary>
        public List<VehiculoDeCarrera> Competidores
        {
            get
            {
                return this.competidores;
            }
        }
        #endregion
        #region MostrarDatos
        public string MostrarDatos()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Cantidad de vueltas en la competencia: {this.CantidadVueltas}");
            stringBuilder.AppendLine($"Cantidad de competidores: {this.CantidadCompetidores}");
            //Imprimimos luego todos los competidores
            foreach (VehiculoDeCarrera item in this.competidores)
            {
                if(item.GetType() == typeof(AutoF1))
                {
                    stringBuilder.AppendLine(((AutoF1)item).MostrarDatos());
                }
                else if (item.GetType() == typeof(MotoCross))
                {
                    stringBuilder.AppendLine(((MotoCross)item).MostrarDatos());                    
                }
            }
            
            return stringBuilder.ToString();
        }
        #endregion
        #region Sobrecarga - & + (agregar/quitar competidores a la competencia)
        public static bool operator -(Competencia c, VehiculoDeCarrera v)
        {
            if (c == v)
            {
                return c.competidores.Remove(v);
            }
            return false;
        }
        public static bool operator +(Competencia c, VehiculoDeCarrera v)
        {
            //b.La excepción CompetenciaNoDisponibleExcepcion será lanzada dentro de == de Competencia y Vehículo con el mensaje "El vehículo no corresponde a la competencia",
            //capturada dentro del operador + y vuelta a lanzar como una nueva excepción con el mensaje "Competencia incorrecta".
            //Utilizar innerExcepcion para almacenar la excepción original.
            //c.Modificar el Main para agregar un Vehículo que no corresponda con la competencia,
            //capturar la excepción y mostrar el error por pantalla.
            try
            {
                if (c.competidores.Count < c.CantidadCompetidores && c != v)        //si hay espacio y el competidor no forma parte de la lista...
                {
                    c.competidores.Add(v);
                    v.EnCompetencia = true;
                    v.VueltasRestantes = (c.CantidadVueltas);
                    Random auxRandom = new Random();
                    int auxCombustible = auxRandom.Next((int)15, (int)100);
                    v.CantidadCombustible = ((short)auxCombustible);
                    return true;
                }
                return false;
            }
            catch (CompetenciaNoDisponibleException e)
            {
                //throw new CompetenciaNoDisponibleException("Excepcion 2",e);
                throw new CompetenciaNoDisponibleException("No se pudo agregar el vehiculo a la competencia", "Competencia", "Sobrecarga +", e);
            }

        }
        #endregion
        #region Sobrecarga == & !=
        public static bool operator ==(Competencia c, VehiculoDeCarrera competidor)     
        {

            //g. Si la competencia es declarada del tipo CarreraMotoCross, sólo se podrán agregar vehículos
            //    del tipo MotoCross.
            //Si la competencia es del tipo F1, sólo se podrán agregar objetos AutoF1.
            //    Colocar dicha comparación dentro del == de la clase Competencia.                   
            //Comparo el tipo de competencia con el tipo de vehiculo == VehiculoDeCarrera 

            //b.La excepción CompetenciaNoDisponibleExcepcion será lanzada dentro de == de Competencia y Vehículo con el mensaje "El vehículo no corresponde a la competencia",
            //capturada dentro del operador +y vuelta a lanzar como una nueva excepción con el mensaje "Competencia incorrecta".
            try
            {
                if ((c.Tipo == tipoCompetencia.F1 && (competidor.GetType() == typeof(AutoF1))) ||
                    (c.Tipo == tipoCompetencia.MotoCross && (competidor.GetType() == typeof(MotoCross))))
                {
                    foreach (VehiculoDeCarrera item in c.competidores)
                    {
                        if (item == competidor)
                        {                            
                            return true;
                        }
                    }
                    return false;
                }
                throw new CompetenciaNoDisponibleException("El vehículo no corresponde a la competencia","Competencia","Sobrecarga ==");
                //throw new CompetenciaNoDisponibleException("Excepcion 1",null);
            }
            catch (CompetenciaNoDisponibleException)
            {
                throw;
            }            
        }
        public static bool operator !=(Competencia c, VehiculoDeCarrera v)
        {
            return !(c == v);
        }
        #endregion
    }   
}
