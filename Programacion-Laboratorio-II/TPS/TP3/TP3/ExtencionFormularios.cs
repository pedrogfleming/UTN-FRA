using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using Entidades;
namespace TP3
{
    public static class ExtencionFormularios
    {
        public static void RefrescarDGV<T>(DataGridView d, List<T> lista)
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
        public static List<string> ObtenerAtributosClases<T>(T obj)
        {
            //Obtenemos toda la propiedades de esta clase
            PropertyInfo[] listaAtributos = typeof(T).GetProperties();
            List<string> aux = new List<String>();
            foreach (PropertyInfo item in listaAtributos)
            {
                aux.Add(item.Name);
            }
            return aux;
        }
        public static void MostrarMensajeError(Exception ex)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Error : {ex.Message}");
            sb.AppendLine(ex.StackTrace);
            MessageBox.Show(sb.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
