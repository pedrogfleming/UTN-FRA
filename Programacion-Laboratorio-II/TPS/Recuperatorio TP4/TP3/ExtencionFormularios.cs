using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using Entidades;
namespace TP4
{
    public static class ExtencionFormularios
    {
        /// <summary>
        /// Refresca el datasource de un datagridview de un formulario solo si contiene elementos la lista recibida por parametro
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="d"></param>
        /// <param name="lista"></param>
        public static void RefrescarDGV<T>(this DataGridView d, List<T> lista)
            where T : IIdentifier
        {
            d.DataSource = null;
            if (lista.Count > 0)
            {
                d.DataSource = lista;
                if (typeof(T) == typeof(Curso))
                {
                    d.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
                    d.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
                }
            }
        }
        /// <summary>
        /// Refresca el datasource de una listbox de un formulario solo si contiene elementos la lista recibida por parametro
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="lst"></param>
        /// <param name="lista"></param>
        public static void RefrescarLST<T>(this ListBox lst, List<T> lista)
            where T : IIdentifier
        {
            lst.DataSource = null;
            if (lista.Count > 0)
            {
                lst.DataSource = lista;
            }
        }
        //public static void RefrescarCmb<T>(ComboBox cmb, List<T> lista) 
        //    where T : IIdentifier
        //{
        //    cmb.DataSource = null;
        //    if(lista.Count > 0)
        //    {
        //        cmb.DataSource = lista;
        //    }
        //}
        /// <summary>
        /// Recibe una lista para copiar item a item y retornar una nueva lista
        /// Evita copiar la referencia a memoria de la lista
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="listaBase"></param>
        /// <returns>Una nueva lista instanciada con los mismos items que la recibida</returns>
        public static List<T>CopiaFantasmaLista<T>(this List<T> listaBase)
        {
            List<T> listaRetorno = new List<T>();
            if (listaBase is not null)
            {
                
                foreach (T item in listaBase)
                {
                    listaRetorno.Add(item);
                }
            }
            return listaRetorno;
        }
        /// <summary>
        /// Obtiene los nombres de los atributos de una clase y los retorna en una lista de strings
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static List<string> ObtenerAtributosClases<T>(T obj)
        {
            List<string> aux = new List<String>();
            if (obj is not null)
            {
                //Obtenemos toda la propiedades de esta clase
                PropertyInfo[] listaAtributos = typeof(T).GetProperties();
                
                foreach (PropertyInfo item in listaAtributos)
                {
                    aux.Add(item.Name);
                }
                return aux;
            }
            else
            {
                throw new ArgumentNullException($"{obj.ToString()} es null");
            }
        }
        public static void MostrarMensajeError(this Exception ex)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Error : {ex.Message}");
            sb.AppendLine(ex.StackTrace);
            MessageBox.Show(sb.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            try
            {
                Task tsk = new Task(() => ExtencionFormularios.GuardarLogErrores(ex));
                tsk.Start();
            }
            catch (Exception exArchivoLog)
            {
                MessageBox.Show(exArchivoLog.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private static void GuardarLogErrores(Exception ex)
        {
            string ruta = SerializacionArchivo.CrearRuta("Log.txt");
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Fecha y hora del error:");
            sb.AppendLine(DateTime.Now.ToString());
            sb.AppendLine("Descripcion:");
            sb.AppendLine(ex.Message);
            sb.AppendLine(ex.StackTrace);
            sb.AppendLine("---------------------------------------------------------------------------------------------------------");
            SerializacionArchivo.AppendearTxt(ruta, sb.ToString());
        }
    }
}
