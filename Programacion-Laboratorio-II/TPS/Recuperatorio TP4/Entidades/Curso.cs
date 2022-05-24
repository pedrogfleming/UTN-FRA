using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Curso : IIdentifier
    {
        private int id;
        private string descripcion;        
        private DateTime fechaInicio;
        private DateTime fechaFin;
        private bool eLearning;
        private List<Alumno> inscriptos;
        #region Constructores
        public Curso():this(0,"",DateTime.Today, DateTime.Today,false)
        {
        }
        public Curso(int id,string descripcion,DateTime fechaInicio,DateTime fechaFin,bool esElearning)            
        {
            this.id = id;
            this.descripcion = descripcion;
            this.fechaInicio = fechaInicio;
            this.fechaFin = fechaFin;
            this.eLearning = esElearning;
            this.inscriptos = new List<Alumno>();
        }
        #endregion 
        #region Propiedades
        public int Id 
        {
            get
            {
                return this.id;
            }
            set
            {
                if(value >= 0)
                {
                    this.id = value;
                }
            }
        }
        public string Descripcion
        {
            get
            {
                return this.descripcion;
            }
            set
            {
                if(!string.IsNullOrWhiteSpace(value))
                {
                    this.descripcion = value;
                }
            }
        }
        public List<Alumno> Inscriptos
        {
            get
            {
                return this.inscriptos;
            }
            set
            {
                if(value is not null)
                {
                    this.inscriptos = value;
                }
            }
        }
        public DateTime FechaInicio
        {
            get
            {
                return this.fechaInicio;
            }
            set
            {
                this.fechaInicio = value;
            }
        }
        public DateTime FechaFin
        {
            get
            {
                return this.fechaFin;
            }
            set
            {
                this.fechaFin = value;
            }
        }
        public bool ELearning
        {
            get
            {
                return this.eLearning;
            }
            set
            {
                this.eLearning = value;
            }
        }
        public int DuracionDias
        {
            get
            {
                return (this.FechaFin - this.FechaInicio).Days;
            }
        }
        public int CantidadInscriptos
        {
            get
            {
                return this.Inscriptos.Count;
            }
        }
        #endregion
        #region Sobrecarga
        /// <summary> 
        /// Compara si dos cursos son iguales por fecha de inicio/fin y descripcion. De ser distinta la fecha, compara por id.
        /// </summary>
        /// <param name="c1"></param>
        /// <param name="c2"></param>
        /// <returns>Retornara true si los dos cursos tienen la misma fecha y descricpion o si no compara por id-
        /// </returns>
        public static bool operator ==(Curso c1,Curso c2)
        {
            if(c1 is not null && c2 is not null)
            {
                //return c1.Id == c2.Id && c1.FechaInicio == c2.FechaInicio && c1.FechaFin == c2.FechaFin;
                //Si tienen la misma fecha, comparo por descripcion
                if (c1.FechaInicio.Date == c2.FechaInicio.Date && c1.FechaFin.Date == c2.FechaFin.Date)
                {
                    return c1.Descripcion == c2.Descripcion;
                }
                return c1.Id == c2.Id;                
            }
            return false;
        }
        public static bool operator !=(Curso c1, Curso c2)
        {
            return !(c1 == c2);
        }
        /// <summary>
        /// Revisa si un alumno esta inscripto en el curso.
        /// </summary>
        /// <param name="c"></param>
        /// <param name="a"></param>
        /// <returns>Retorna true si ya esta inscripto</returns>
        public static bool operator ==(Curso c,Alumno a)
        {
            if(c is not null && a is not null)
            {
                foreach (Alumno item in c.Inscriptos)
                {
                    if(item == a)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        /// <summary>
        /// Revisa si un alumno esta inscripto en el curso.
        /// </summary>
        /// <param name="c"></param>
        /// <param name="a"></param>
        /// <returns>Retorna true si no esta inscripto</returns>
        public static bool operator !=(Curso c, Alumno a)
        {
            return !(c == a);
        }

        /// <summary>
        /// Agrega un alumno al curso si no existe previamente.
        /// </summary>
        /// <param name="c"></param>
        /// <param name="a"></param>
        /// <returns>Retorna true si lo pudo agregar</returns>
        public static bool operator +(Curso c,Alumno a)
        {
            if(c != a)
            {
                c.Inscriptos.Add(a);
                return true;
            }
            return false;
        }
        /// <summary>
        /// Quita un alumno al curso si existe previamente.
        /// </summary>
        /// <param name="c"></param>
        /// <param name="a"></param>
        /// <returns>Retorna true si lo pudo agregar</returns>
        public static bool operator -(Curso c, Alumno a)
        {
            if (c == a)
            {
                return c.Inscriptos.Remove(a);
            }
            return false;
        }
        #endregion
        #region Metodos
        /// <summary>
        /// Retorna un string con todos los detalle del curso(omite listado de inscriptos)
        /// </summary>
        /// <returns></returns>
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Id: {0}\n",this.Id);
            sb.AppendFormat("Descripcion: {0}\n", this.Descripcion);
            sb.AppendFormat("Fecha inicio: {0}\n", String.Format("{0:dd/MM/yyyy}", this.FechaInicio));
            sb.AppendFormat("Fecha fin: {0}\n", String.Format("{0:dd/MM/yyyy}", this.FechaFin));
            if(this.ELearning)
            {
                sb.Append("Es E-Learning: SI\n");
            }
            else
            {
                sb.Append("Es E-Learning: NO\n");
            }
            sb.AppendFormat("Cantidad de inscriptos: {0}\n", this.CantidadInscriptos);
            return sb.ToString();
        }
        public string MostrarAlumnosInscriptos()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Alumno item in this.Inscriptos)
            {
                sb.AppendLine(item.MostrarDatos());
            }
            return sb.ToString();
        }
        /// <summary>
        /// Inscribe un alumno en el curso
        /// </summary>
        /// <param name="a"></param>
        /// <returns>Retorna true si lo pudo agregar</returns>
        public bool inscribirAlumno(Alumno a)
        {
            if (a is not null && this != a)
            {
                return this+a;
            }
            return false;
        }
        /// <summary>
        /// Quita un alumno de un curso
        /// </summary>
        /// <param name="a"></param>
        /// <returns>Retorna true si lo pudo eliminar</returns>
        public bool quitarAlumno(Alumno a)
        {
            if(a is not null)
            {
                foreach (Alumno item in this.Inscriptos)
                {
                    if(item == a)
                    {                        
                        return this.Inscriptos.Remove(item);
                    }
                }
            }
            return false;            
        }
        /// <summary>
        /// Filtra una lista de Cursos segun el atributo indicado y la coincidencia de la keyword a partir del atributo
        /// </summary>
        /// <param name="listaBase"></param>
        /// <param name="atributo"></param>
        /// <param name="keyWord"></param>
        /// <returns>Retorna la lista filtrada o la misma lista si no hubo filtro</returns>
        public static List<Curso> FiltrarPorAtributo(List<Curso> listaBase,string atributo,string keyWord)
        {
            if(listaBase is not null && !string.IsNullOrWhiteSpace(atributo) && !string.IsNullOrWhiteSpace(keyWord))
            {
                List<Curso> auxLista = new List<Curso>();
                switch (atributo)
                {
                    case "id":
                        auxLista.Add(listaBase.Find(delegate (Curso c)
                        {
                            return c.Id.ToString() == keyWord;
                        }));
                        break;
                    case "descripcion":
                        auxLista = Curso.Informe_ObtenerDescripcion(listaBase, keyWord);
                        break;
                    case "fechaInicio":  
                            auxLista = Curso.Informe_ObtenerFechaInicio(listaBase, keyWord);                      
                        break;
                    case "fechaFin":
                            auxLista = Curso.Informe_ObtenerFechaInicio(listaBase, keyWord);
                        break;
                    case "eLearning":
                        auxLista = Curso.Informe_ObtenerEsLearning(listaBase, bool.Parse(keyWord));
                        break;
                    case "inscriptos":
                        int auxNumeroInscriptos = 0;
                        if(int.TryParse(keyWord,out auxNumeroInscriptos))
                        {
                            auxLista = Curso.Informe_ObtenerCantidadInscriptos(listaBase, auxNumeroInscriptos);
                        }                        
                        break;
                    default:
                        break;
                }
                return auxLista;
            }
            return listaBase;
        }
        #endregion
        #region Informes
        public static List<Curso> Informe_ObtenerDescripcion(List<Curso> listaBase, string descripcion)
        {
            if (listaBase is not null && listaBase.Count > 0)
            {            
                return listaBase.FindAll((c)=>c.Descripcion == descripcion);
            }
            return listaBase;
        }
        public static List<Curso> Informe_ObtenerEsLearning(List<Curso> listaBase, bool esElearning)
        {
            if (listaBase is not null && listaBase.Count > 0)
            {
                return listaBase.FindAll(delegate (Curso c)
                {
                    return c.ELearning == esElearning;
                });
            }
            return listaBase;
        }
        public static List<Curso> Informe_ObtenerFechaInicio(List<Curso> listaBase, string fechaInicio)
        {
            if (listaBase is not null && listaBase.Count > 0)
            {
                return listaBase.FindAll(delegate (Curso c)
                {
                    string aux = (c.FechaInicio.Date).ToString();
                    return aux.Equals(fechaInicio);
                    //return aux == fechaInicio;
                });
            }
            return listaBase;
        }
        public static List<Curso> Informe_ObtenerFechaFin(List<Curso> listaBase, string fechaFin)
        {
            if (listaBase is not null && listaBase.Count > 0)
            {
                return listaBase.FindAll(delegate (Curso c)
                {
                    return (c.FechaFin.Date).ToString() == fechaFin;
                });
            }
            return listaBase;
        }
        public static List<Curso> Informe_ObtenerCantidadInscriptos(List<Curso> listaBase, int numeroInscriptos)
        {
            if (listaBase is not null && listaBase.Count > 0)
            {
                return listaBase.FindAll(delegate (Curso c)
                {
                    return c.CantidadInscriptos == numeroInscriptos;
                });
            }
            return listaBase;
        }
        #endregion
    }
}
