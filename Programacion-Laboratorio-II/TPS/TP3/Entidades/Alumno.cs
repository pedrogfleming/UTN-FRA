using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno : IIdentifier
    {
        private int id;
        private string apellido;
        private string nombre;
        private int dni;
        #region Constructores
        public Alumno():this(0,"","",0)
        {
        }
        public Alumno(int id,string nombre,string apellido,int dni)
        {
            this.id = id;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Dni = dni;
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
        public string Apellido 
        {
            get
            {
                return this.apellido;
            }
            set
            {
                if(!string.IsNullOrWhiteSpace(value))
                {
                    this.apellido = value;
                }
            }
        }
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    this.nombre = value;
                }
            }
        }
        public int Dni 
        {
            get
            {
                return this.dni;
            }
            set
            {
                if(value >= 11111111 && value <= 99999999)
                {
                    this.dni = value;
                }
            }
        } 
        #endregion
        #region Sobrecargas
        /// <summary>
        /// Dos alumnos serán iguales si el dni o el ID igual
        /// </summary>
        /// <param name="a1"></param>
        /// <param name="a2"></param>
        /// <returns>Retorna true si coincide el id y el nombre,caso contrario false</returns>
        public static bool operator ==(Alumno a1,Alumno a2)
        {
            if(a1 is not null && a2 is not null)
            {
                //return (a1.Id == a2.Id && a1.Apellido == a2.Apellido && a1.Nombre == a2.Nombre);
                return (a1.Dni == a2.Dni || a1.Id == a2.Id);
            }
            return false;
        }
        public  static bool operator !=(Alumno a1, Alumno a2)
        {
            return !(a1 == a2);
        }    
        public override string ToString()
        {
            return $"{this.Id} {this.Apellido} {this.Nombre} {this.Dni}";
        }
        #endregion
        #region Metodos
        /// <summary>
        /// Retorna un string con solo los datos personales del alumno
        /// </summary>
        /// <returns></returns>
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Id: {0}\n",this.Id);
            sb.AppendFormat("Apellido: {0}\n", this.Apellido);
            sb.AppendFormat("Nombre: {0}\n", this.Nombre);
            sb.AppendFormat("Dni: {0}\n", this.Dni);
            return sb.ToString();
        }
        /// <summary>
        /// Filtra una lista de Alumno segun el atributo indicado y la coincidencia de la keyword a partir del atributo
        /// </summary>
        /// <param name="listaBase"></param>
        /// <param name="atributo"></param>
        /// <param name="keyWord"></param>
        /// <returns>Retorna la lista filtrada o la misma lista si no hubo filtro</returns>
        public static List<Alumno> FiltrarPorAtributo(List<Alumno> listaBase, string atributo, string keyWord)
        {
            if (listaBase is not null && !string.IsNullOrWhiteSpace(atributo) && !string.IsNullOrWhiteSpace(keyWord))
            {
                //private int id;
                //private string apellido;
                //private string nombre;
                //private int dni;
                List<Alumno> auxLista = new List<Alumno>();
                switch (atributo)
                {
                    case "id":
                        //auxLista.Add(listaBase.Find(delegate (Alumno a)
                        //{
                        //    return a.Id.ToString() == keyWord;
                        //}));
                        auxLista.Add(listaBase.Find((a) => a.Id.ToString() == keyWord));
                        break;
                    case "apellido":
                        //auxLista.Add(listaBase.Find(delegate (Alumno a)
                        //{
                        //    return a.Apellido == keyWord;
                        //}));
                        auxLista.Add(listaBase.Find((a) => a.Apellido== keyWord));
                        break;
                    case "nombre":
                        //auxLista.Add(listaBase.Find(delegate (Alumno a)
                        //{
                        //    return a.Nombre == keyWord;
                        //}));
                        auxLista.Add(listaBase.Find((a) => a.Nombre == keyWord));
                        break;
                    case "dni":
                        //auxLista.Add(listaBase.Find(delegate (Alumno a)
                        //{
                        //    return a.Dni.ToString() == keyWord;
                        //}));
                        auxLista.Add(listaBase.Find((a) => a.Dni.ToString() == keyWord));
                        break;
                    default:
                        break;
                }
                return auxLista;
            }
            return listaBase;
        }
        #endregion
    }
}
