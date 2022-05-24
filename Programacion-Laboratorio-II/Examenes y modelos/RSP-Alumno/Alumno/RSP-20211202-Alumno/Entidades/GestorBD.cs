using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Excepciones;
namespace Entidades
{
    //12.GestorBD:
    //x  a.Sera estática.
    // x b.ObtenerCliente correrá en un hilo secundario, este leerá de la base de datos todos los clientes.
    //x      Mientras no sea el fin de los registros o no se haya cancelado el hilo se informará el cliente leído a través del evento.
    //x  c.Realizar un Sleep de 2 segundos.
    //x  d.En caso de producirse un error encapsular la excepción y lanzar BaseDeDatosException.

    public static class GestorBD
    {
        public delegate void DelegadoCliente(Cliente cliente);
        private static string conexion;
        private static SqlConnection sqlConnection;
        public static event DelegadoCliente InformarCliente;
        static GestorBD()
        {
            GestorBD.conexion = @"Server=localhost\SQLEXPRESS;Database=Final20112021Alumno;Trusted_Connection=True;";

        }
        public static void ObtenerCliente(CancellationToken cancellation)
        {
            if(GestorBD.InformarCliente != null)
            {
                while (!cancellation.IsCancellationRequested)
                {
                    try
                    {
                        SqlDataReader lector;
                        SqlCommand comando = new SqlCommand();
                        comando.CommandType = CommandType.Text;
                        comando.CommandText = "SELECT * FROM dbo.clientes";
                        comando.Connection = sqlConnection;

                        sqlConnection.Open();

                        lector = comando.ExecuteReader();

                        while (lector.Read())
                        {

                            Cliente c = new Cliente(lector["nombre"].ToString(), int.Parse(lector["cantproductos"].ToString()), lector.GetBoolean("prioridad"));      
                            if(c is not null && GestorBD.InformarCliente != null)
                            {
                                GestorBD.InformarCliente.Invoke(c);
                                Thread.Sleep(2000);
                            }
                        }
                        lector.Close();
                    }
                    catch (Exception e)
                    {
                        throw new BaseDeDatosException(e.Message,e);
                    }
                    finally
                    {
                        if (sqlConnection.State == ConnectionState.Open)
                        {
                            sqlConnection.Close();
                           
                        }
                    }
                    break;
                }
            }
        }

    }
}
