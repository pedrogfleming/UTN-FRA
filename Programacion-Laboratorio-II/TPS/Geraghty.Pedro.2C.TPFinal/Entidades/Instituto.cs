using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Instituto
    {
        private string nombreInstituto;
        private static int idCursos;
        private static int idAlumnos;
        private List<Alumno> alumnos;
        private List<Curso> cursos;
        #region Constructores
        static Instituto()
        {
            Instituto.idCursos = 1000;
            Instituto.idAlumnos = 1;
        }
        private Instituto()
        {
            this.alumnos = new List<Alumno>();
            this.cursos = new List<Curso>();
        }
        public Instituto(string nombre)
            : this()
        {
            this.nombreInstituto = nombre;
        }
        #endregion
        #region Propiedades
        public string Nombre
        {
            get
            {
                return this.nombreInstituto;
            }
        }
        public int IdCursos
        {
            get
            {
                return Instituto.idCursos;
            }
        }
        public int IdAlumnos
        {
            get
            {
                return Instituto.idAlumnos;
            }
        }
        public List<Alumno> Alumnos
        {
            get
            {
                return this.alumnos;
            }
            set
            {
                if (value is not null)
                {
                    this.alumnos = value;
                }
            }
        }
        public List<Curso> Cursos
        {
            get
            {
                return this.cursos;
            }
            set
            {
                if(value is not null)
                {
                    this.cursos = value;
                }
            }
        }
        #endregion
        #region Sobrecargas Instituto/Curso
        /// <summary>
        /// Chequea que un curso este cargado previamente segun id y fechas en el instituto
        /// </summary>
        /// <param name="instituto"></param>
        /// <param name="c"></param>
        /// <returns>Retorna true si ya existe ese curso</returns>
        public static bool operator ==(Instituto instituto, Curso c)
        {
            if (instituto is not null && c is not null)
            {
                foreach (Curso item in instituto.cursos)
                {
                    if (item == c)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        /// <summary>
        /// Chequea que un curso no este cargado previamente segun id en el instituto
        /// </summary>
        /// <param name="instituto"></param>
        /// <param name="c"></param>
        /// <returns>Retorna true si no existe ese curso</returns>
        public static bool operator !=(Instituto instituto, Curso c)
        {
            return !(instituto == c);
        }
        /// <summary>
        /// Agrega un curso a un instituto 
        /// </summary>
        /// <param name="instituto"></param>
        /// <param name="c"></param>
        /// <returns>Retorna true si lo pudo agregar</returns>
        public static bool operator +(Instituto instituto, Curso c)
        {
            if (c.FechaInicio.Date.CompareTo(c.FechaFin.Date) < 1 && instituto != c)
            {
                instituto.cursos.Add(c);
                SumadorIdCursos();
                return true;
            }
            return false;
        }
        /// <summary>
        /// Remueve un curso de un instituto si existe en el instituto
        /// </summary>
        /// <param name="instituto"></param>
        /// <param name="c"></param>
        /// <returns>Retorna true si lo pudo quitar</returns>
        public static bool operator -(Instituto instituto, Curso c)
        {
            if (instituto is not null && c is not null)
            {
                foreach (Curso item in instituto.cursos)
                {
                    if (item == c)
                    {
                        return instituto.cursos.Remove(item);
                    }
                }
            }
            return false;
        }

        #endregion
        #region Sobrecargas Instituto/Alumno
        /// <summary>
        /// Chequea que un alumno exista ya en el instituto
        /// </summary>
        /// <param name="instituto"></param>
        /// <param name="a"></param>
        /// <returns>Retorna true si ya existe el alumno</returns>
        public static bool operator ==(Instituto instituto, Alumno a)
        {
            if (instituto is not null && a is not null)
            {
                foreach (Alumno item in instituto.Alumnos)
                {
                    if (item == a)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        /// <summary>
        /// Chequea que un alumno no esté en el instituto
        /// </summary>
        /// <param name="instituto"></param>
        /// <param name="a"></param>
        /// <returns>Retorna true si no esta</returns>
        public static bool operator !=(Instituto instituto, Alumno a)
        {
            return !(instituto == a);
        }
        /// <summary>
        /// Agrega un alumno al instituto si no existe previamente
        /// </summary>
        /// <param name="instituto"></param>
        /// <param name="a"></param>
        /// <returns>Retorna true si lo pudo agregar</returns>
        public static bool operator +(Instituto instituto, Alumno a)
        {
            if (instituto is not null && a is not null && instituto != a)
            {
                instituto.Alumnos.Add(a);
                Instituto.SumadorIdAlumnos();
                return true;
            }
            return false;
        }
        /// <summary>
        /// Quita un alumno del instituo si existe previamente
        /// </summary>
        /// <param name="instituto"></param>
        /// <param name="a"></param>
        /// <returns>Retorna true si lo pudo quitar</returns>
        public static bool operator -(Instituto instituto, Alumno a)
        {
            if (instituto is not null && a is not null)
            {
                foreach (Alumno item in instituto.Alumnos)
                {
                    if (item == a)
                    {
                        return instituto.Alumnos.Remove(item);
                    }
                }
            }
            return false;
        }

        #endregion
        #region Metodos
 
        /// <summary>
        /// Modifica un item de una lista generica
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="idBusqueda"></param>
        /// <param name="obj"></param>
        /// <param name="listaGenerica"></param>
        /// <returns>Retorna la lista modificada o sin modificaciones</returns>
        public static List<T> modificar<T>(int idBusqueda, T obj, List<T> listaGenerica)
            where T : IIdentifier
        {
            if (idBusqueda > 0)
            {
                foreach (T item in listaGenerica)
                {
                    if (item.Id == idBusqueda)
                    {
                        listaGenerica.Remove(item);
                        listaGenerica.Add(obj);
                        break;
                    }
                }
            }
            return listaGenerica;
        }
        /// <summary>
        /// Desinscribe de todos los cursos tomados a un alumno que fue dado de baja del instituto
        /// </summary>
        /// <param name="a"></param>
        /// <returns>Retorna true si pudo descrisbirlo de todos los cursos que estaba anotado</returns>
        public  bool DesinscribirAlumnoBaja(Alumno a)
        {
            int auxTotalCursosTomados = 0;
            int auxCursosBaja = 0;
            if (a is not null)
            {
                //Chequeo que cursos tomo el alumno
                foreach (Curso item in this.Cursos)
                {
                    //Por c/curso tomado por el alumno, lo voy a desinscribir
                    foreach (Alumno jItem in item.Inscriptos)
                    {
                        if (jItem == a)
                        {
                            auxTotalCursosTomados++;
                            if (item.Inscriptos.Remove(jItem))
                            {
                                //Se actualiza la tabla de inscriptos a cursos con la baja de c/curso al que esta inscripto el alumno
                                AccesoDatos aD = new AccesoDatos();
                                aD.EliminarInscripto(item.Id, jItem.Id);
                                auxCursosBaja++;                    
                                break;
                            }                                
                        }
                    }
                }
                
            }            
            return ((auxTotalCursosTomados - auxCursosBaja) == 0);
        }
        private static void SumadorIdCursos()
        {
            Instituto.idCursos++;
        }
        private static void SumadorIdAlumnos()
        {
            Instituto.idAlumnos++;
        }
        private int statusId<T>(List<T> listaBase) where T : IIdentifier
        {
            int contadorId = 0;
            foreach (T item in listaBase)
            {
                contadorId = item.Id;
            }
            return contadorId;
        }
        public void chequearIdCursosCargados()
        {
            int auxId = this.statusId(this.Cursos);
            if (auxId != 0)
            {
                auxId++;
                Instituto.idCursos = auxId;
            }            
        }
        public static bool ChequearIdRepetidos<T>(List<T> lista) where T : IIdentifier
        {
            for (int i = 0; i < lista.Count-1; i++)
            {
                int auxId = lista[i].Id;
                for (int j = i+1; j < lista.Count; j++)
                {
                    if(lista[i].Id == lista[j].Id)
                    {
                        throw new InstitutoExcepciones($"Se ha encontrado un id repetido en la base de datos {lista[i].MostrarDatos()}{lista[j].MostrarDatos()}");
                    }
                }
            }
            return true;
        }
        public void chequearIdAlumnosCargados()
        {
            int auxId = this.statusId(this.Alumnos);
            if (auxId != 0)
            {
                auxId++;
                Instituto.idAlumnos = auxId;
            }
        }
        public string MostrarTotalCursos()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Curso item in this.cursos)
            {
                sb.AppendLine(item.MostrarDatos());
            }
            return sb.ToString();
        }
        public string MostrarTotalAlumnos()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Alumno item in this.Alumnos)
            {
                sb.AppendLine(item.MostrarDatos());
            }
            return sb.ToString();
        }
        public static string ObtenerDatos<T>(List<T> listaData) where T : IIdentifier
        {
            StringBuilder sb = new StringBuilder();
            if (listaData is not null && listaData.Count > 0)
            {
                foreach (T item in listaData)
                {
                    sb.AppendLine(item.MostrarDatos());
                    if(item is Curso && listaData.Count > 0)
                    {
                        Curso aux = item as Curso;
                        if(aux is not null)
                        {
                            sb.AppendLine(aux.MostrarAlumnosInscriptos());
                        }
                    }
                }                
            }
            return sb.ToString();
        }
        /// <summary>
        /// Retorna un string con todos los cursos tomados por el alumno
        /// </summary>
        /// <returns></returns>
        public string MostrarCursosTomados(Alumno a)
        {
            StringBuilder sb = new StringBuilder();

            List<Curso> cursosTomados = this.BuscarCursosTomados(a);
            if (cursosTomados.Count > 0)
            {
                sb.AppendLine("Listado cursos inscripto: \n");
                foreach (Curso item in cursosTomados)
                {
                    sb.AppendFormat(item.MostrarDatos());
                }
            }
            return sb.ToString();
        } 
        /// <summary>
        /// Busca todos los cursos en los que esta inscripto el alumno
        /// </summary>
        /// <param name="a"></param>
        /// <returns>Retorna la lista de cursos inscripto por el alumno</returns>
        public List<Curso> BuscarCursosTomados(Alumno a)
        {
            List<Curso> listaCursosTomados = new List<Curso>();
            if (a is not null)
            {
                foreach (Curso item in this.Cursos)
                {
                    foreach (Alumno JItem in item.Inscriptos)
                    {
                        if(a == JItem)
                        {
                            listaCursosTomados.Add(item);
                        }
                    }
                }
            }
            return listaCursosTomados;
        }
        #region Filtros
        /// <summary>
        /// Busca al alumno con mas cursos inscripto
        /// </summary>
        /// <returns>Retorna el alummno con mas cursos o null si no habia</returns>
        public Alumno AlumnoConMasCursos()
        {
            Dictionary<Alumno,int> listaAux = new Dictionary<Alumno,int>();
            int cursoTomados = 0;
            foreach (Alumno item in this.Alumnos)
            {
                foreach (Curso JItem in this.Cursos)
                {                    
                    if(JItem == item)
                    {
                        cursoTomados++;                        
                    }
                }
                listaAux.Add(item,cursoTomados);
                cursoTomados = 0;
            }
            bool flag = false;
            int maxCursos = 0;
            Alumno maxAlumno = null;
            foreach (KeyValuePair<Alumno,int> item in listaAux)
            {
                if(flag == false || maxCursos < item.Value)
                {
                    flag = true;
                    maxAlumno = item.Key;
                    maxCursos = item.Value;
                }
            }
            return maxAlumno;
        }
        /// <summary>
        /// Busca al alumno con menos cursos inscripto
        /// </summary>
        /// <returns>Retorna el alummno con menos cursos o null si no habia</returns>
        public Alumno AlumnoConMenosCursos()
        {
            Dictionary<Alumno, int> listaAux = new Dictionary<Alumno, int>();
            int cursoTomados = 0;
            foreach (Alumno item in this.Alumnos)
            {
                foreach (Curso JItem in this.Cursos)
                {
                    if (JItem == item)
                    {
                        cursoTomados++;
                    }
                }
                listaAux.Add(item, cursoTomados);
                cursoTomados = 0;
            }
            bool flag = false;
            int minCursos = 0;
            Alumno maxAlumno = null;
            foreach (KeyValuePair<Alumno, int> item in listaAux)
            {
                if (flag == false || minCursos > item.Value)
                {
                    flag = true;
                    maxAlumno = item.Key;
                    minCursos = item.Value;
                }
            }
            return maxAlumno;
        }
        /// <summary>
        /// Busca al alumno mas viejo
        /// </summary>
        /// <returns>Retorna el alummno mas viejo o null si no habia</returns>
        public Alumno AlumnoMasViejo()
        {
            int maxEdad = int.MaxValue;
            Alumno maxAlumno = null;
            foreach (Alumno item in this.Alumnos)
            {
                if (item.Edad >= maxEdad)
                {
                    maxEdad = item.Edad;
                    maxAlumno = item;
                }                
            }
            return maxAlumno;
        }
        /// <summary>
        /// Busca al alumno mas joven
        /// </summary>
        /// <returns>Retorna el alummno mas viejo o null si no habia</returns>
        public Alumno AlumnoMasJoven()
        {
            int minEdad = int.MaxValue;
            Alumno jovenAlumno = null;
            foreach (Alumno item in this.Alumnos)
            {
                if (item.Edad <= minEdad)
                {
                    minEdad = item.Edad;
                    jovenAlumno = item;
                }
            }
            return jovenAlumno;
        }
        #endregion
        #endregion
        #region Informes
        /// <summary>
        /// Retornara los porcentajes por genero del instituto
        /// </summary>
        /// <returns></returns>
        public string InformeGenero()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("El porcentaje de personas de genero femenino inscriptas en el instituto es de %{0}\n", this.PorcentajeGenero(Alumno.EGenero.femenino));
            sb.AppendFormat("El porcentaje de personas de genero masculino inscriptos en el instituto es de %{0}\n", this.PorcentajeGenero(Alumno.EGenero.masculino));
            sb.AppendFormat("El porcentaje de personas de genero no binario inscriptos en el instituto es de %{0}\n", this.PorcentajeGenero(Alumno.EGenero.noBinario));
            sb.AppendFormat("El porcentaje de personas de genero otre inscriptos en el instituto es de %{0}\n", this.PorcentajeGenero(Alumno.EGenero.otro));
            return sb.ToString();
        }
        public string InformeEdades()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("El porcentaje de menores a 21 años inscriptos en el instituto es de %{0}\n", this.PorcentajeEdad(16,21));
            sb.AppendFormat("El porcentaje de personas entre 22 y 32 años inscriptos en el instituto es de %{0}\n", this.PorcentajeEdad(22,32));
            sb.AppendFormat("El porcentaje de personas entre 33 y 42 años inscriptos en el instituto es de %{0}\n", this.PorcentajeEdad(33,42));
            sb.AppendFormat("El porcentaje de personas entre 43 y 70 años inscriptos en el instituto es de %{0}\n", this.PorcentajeEdad(43,60));
            sb.AppendFormat("El porcentaje de personas entre 61 y 120 años inscriptos en el instituto es de %{0}\n", this.PorcentajeEdad(61,120));
            return sb.ToString();
        }
        public string InformeCursoMasElegidoPorGenero()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("El curso más elegido por personas del genero masculino es {0}\n", this.CursoMasElegidoPorGenero(Alumno.EGenero.masculino));
            sb.AppendFormat("El curso más elegido por personas del genero femenino es {0}\n", this.CursoMasElegidoPorGenero(Alumno.EGenero.femenino));
            sb.AppendFormat("El curso más elegido por personas del genero no binario es {0}\n", this.CursoMasElegidoPorGenero(Alumno.EGenero.noBinario));
            sb.AppendFormat("El curso más elegido por personas del genero otro es {0}\n", this.CursoMasElegidoPorGenero(Alumno.EGenero.otro));
            return sb.ToString();
        }
        /// <summary>
        /// Calculara el percentil de alumnos inscriptos al instituto menores o igual a la edad pasada por parametro
        /// </summary>
        /// <param name="criterioPorcentualMin"></param>
        /// <returns>Retorna el percentil de alumnos analizado</returns>
        public float PorcentajeEdad(int criterioPorcentualMin,int criterioPorcentualMax)
        {
            int contadorAlumnos = 0;
            if(this.Alumnos.Count > 0)
            {
                //foreach (Curso item in this.Cursos)
                //{
                //    foreach (Alumno AlumnoInscripto in item.Inscriptos)
                //    {
                //        if(AlumnoInscripto.Edad >= criterioPorcentualMin && AlumnoInscripto.Edad <= criterioPorcentualMax)
                //        {
                //            contadorAlumnos++;
                //        }
                //    }
                //    if(contadorAlumnos > retornoContador)
                //    {
                //        retornoContador = contadorAlumnos;
                //    }
                //}
                //retornoContador = (float)(retornoContador * 100) / this.Alumnos.Count;
                foreach (Alumno AlumnoInscripto in this.Alumnos)
                {
                    if(AlumnoInscripto.Edad >= criterioPorcentualMin && AlumnoInscripto.Edad <= criterioPorcentualMax)
                    {
                        contadorAlumnos++;
                    }
                }

            }
            return (float)(contadorAlumnos * 100) / this.Alumnos.Count;
        }
        /// <summary>
        /// Calculara el percentil de alumnos inscriptos al instituto al genero pasado por parametro
        /// </summary>
        /// <param name="criterioGenero"></param>
        /// <returns>Retorna el percentil analizado</returns>
        public float PorcentajeGenero(Alumno.EGenero criterioGenero)
        {
            //int contadorGenero = 0;
            float retornoContadorGeneroSeleccionado = 0;
            if (this.Alumnos.Count > 0)
            {
                //foreach (Curso item in this.Cursos)
                //{
                //    foreach (Alumno AlumnoInscripto in item.Inscriptos)
                //    {
                //        if (AlumnoInscripto.Genero == criterioGenero)
                //        {
                //            contadorGenero++;
                //        }
                //    }
                //    if (contadorGenero > retornoContadorGeneroSeleccionado)
                //    {
                //        retornoContadorGeneroSeleccionado = contadorGenero;
                //    }
                //}
                //retornoContadorGeneroSeleccionado = (retornoContadorGeneroSeleccionado * 100) / this.Alumnos.Count;
                foreach (Alumno AlumnoInscripto in this.Alumnos)
                {
                    if (AlumnoInscripto.Genero == criterioGenero)
                    {
                        retornoContadorGeneroSeleccionado++;
                    }
                }
            }
            return (float)(retornoContadorGeneroSeleccionado * 100) /(float) this.Alumnos.Count;
        }
        public Curso CursoMasElegidoPorGenero(Alumno.EGenero criterioGenero)
        {
            int auxContador = 0;
            int retorno = 0;
            Curso auxCurso = null;
            Dictionary<Curso, int> auxListaCursosSegunGenero = new Dictionary<Curso, int>();
            foreach (Curso item in this.Cursos)
            {
                foreach (Alumno alumnoInscripto in item.Inscriptos)
                {
                    if (alumnoInscripto.Genero == criterioGenero)
                    {
                        auxContador++;
                    }
                }
                auxListaCursosSegunGenero.Add(item, auxContador);
                auxContador = 0;
            }
            foreach (KeyValuePair<Curso, int> item in auxListaCursosSegunGenero)
            {
                if (item.Value > retorno)
                {
                    retorno = item.Value;
                    auxCurso = item.Key;
                }
            }
            Dictionary<Curso, int> cursoConMasGenero = new Dictionary<Curso, int>();
            cursoConMasGenero.Add(auxCurso, retorno);
            return auxCurso;
        }
        #endregion
    }
}
