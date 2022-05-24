using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Entidades
{
    public class ProductoDAO
    {
        //DAO: Data Access Object
        //Es la clase que se encarga de pegarle a la base de datos
        private SqlConnection conexion;
        private SqlCommand comando;

        public ProductoDAO()
        {
            //Voy a usar variables globales que configure en properties
            this.conexion = new SqlConnection(Properties.Settings.Default.StringConnection);
            this.comando = new SqlCommand();
            //No hace falta ponerlo como Text, es el default
            //this.comando.CommandType = System.Data.CommandType.Text;
            comando.Connection = this.conexion;
        }
        public List<Producto> GetProductos()
        {
            comando.CommandText = "SELECT id, descripcion FROM  Productos";
            //Abro conexcion
            try
            {
                conexion.Open();

                SqlDataReader oDr = comando.ExecuteReader();
                List<Producto> lista = new List<Producto>();
                //Recorro la lista de productos que levante del servidor y los guardo en una lista
                while (oDr.Read())
                {
                    int id = int.TryParse(oDr["id"].ToString(), out id);
                    string descrip = oDr["descripcion"].ToString();
                    Producto prod = new Producto(id, descrip);
                    lista.Add(prod);
                }
                return lista;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if(this.conexion.State  != System.Data.ConnectionState.Closed)
                {
                    this.conexion.Close();
                }
            }
            
        }
    }
}
