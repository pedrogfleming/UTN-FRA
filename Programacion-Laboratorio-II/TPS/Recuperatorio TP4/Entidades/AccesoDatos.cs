using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{
    public class AccesoDatos
    {
        #region Atributos

        private static string cadenaConexion;
        private static SqlConnection conexion;
        private static SqlCommand comando;
        private static SqlDataReader lector;

        #endregion

        #region Constructores

        static AccesoDatos()
        {
            AccesoDatos.cadenaConexion = @"Server=localhost\SQLEXPRESS;Database=Geraghty.Pedro.2C.TPFinal;Trusted_Connection=True;";
        }

        public AccesoDatos()
        {
            // CREO UN OBJETO SQLCONECTION
            conexion = new SqlConnection(AccesoDatos.cadenaConexion);
        }

        #endregion

        #region Métodos

        #region Probar conexión

        public bool ProbarConexion()
        {
            bool rta = true;

            try
            {
                conexion.Open();
            }
            catch (Exception)
            {
                rta = false;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }

            return rta;
        }

        #endregion

        #region Select
        public List<Alumno> ObtenerListaAlumnos()
        {
            List<Alumno> lista = new List<Alumno>();

            try
            {                
                comando = new SqlCommand();

                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT * FROM dbo.ALUMNOS";
                comando.Connection = conexion;

                conexion.Open();

                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    
                    Alumno item = new Alumno();
                    item.Id = int.Parse(lector["IdAlumno"].ToString());
                    item.Dni = int.Parse(lector["Dni"].ToString());
                    item.Apellido = lector["Apellido"].ToString();
                    item.Nombre = lector["Nombre"].ToString();
                    item.Edad = (short)lector.GetInt32("Edad");
                    item.Genero = (Alumno.EGenero)Enum.Parse(typeof(Alumno.EGenero), lector["Genero"].ToString());
                    lista.Add(item);
                }
                lector.Close();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            return lista;
        }
        private bool chequearExiste(List<Curso> lista,double idCurso)
        {
            foreach (var item in lista)
            {
                if(item.Id == idCurso)
                {
                    return true;
                }
            }
            return false;
        }
        public List<Curso> ObtenerListaCursos()
        {
            List<Curso> lista = new List<Curso>();

            try
            {
                comando = new SqlCommand();

                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT* FROM ALUMNOS" +
                    " INNER JOIN INSCRIPTOS ON ALUMNOS.IdAlumno = INSCRIPTOS.IdAlumno" +
                    " INNER JOIN Cursos ON INSCRIPTOS.IdCurso = Cursos.IdCurso" +
                    " ORDER BY Cursos.IdCurso;";
                
                comando.Connection = conexion;

                conexion.Open();

                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    double idCurso = double.Parse(lector[7].ToString());
                    bool existe = lista.Exists((x) => x.Id == idCurso);
                    if (!existe)
                    {
                        //Si el curso no existe en mi instituo, instancio un curso y le voy cargando los inscriptos
                        Curso item = new Curso();
                        item.Id = int.Parse(lector[7].ToString());
                        item.Descripcion = lector["Descripcion"].ToString();
                        item.FechaInicio = lector.GetDateTime("FechaInicio");
                        item.FechaInicio = lector.GetDateTime("FechaFin");
                        item.ELearning = lector.GetBoolean("ELearning");

                        Alumno alumno = new Alumno();
                        alumno.Id = int.Parse(lector[0].ToString());
                        alumno.Apellido = lector["Apellido"].ToString();
                        alumno.Nombre = lector["Nombre"].ToString();
                        alumno.Dni = int.Parse(lector["Dni"].ToString());
                        alumno.Edad = short.Parse(lector["Edad"].ToString());
                        alumno.Genero = (Alumno.EGenero)Enum.Parse(typeof(Alumno.EGenero), lector["Genero"].ToString());
                        item.Inscriptos.Add(alumno);
                        lista.Add(item);
                    }
                    else
                    {
                        //si el curso existe, se busca el id del curso existente
                        int id = lista.FindIndex((x) => x.Id == idCurso);
                        //Se carga c/alumno inscripto al curso
                        Alumno alumno = new Alumno();
                        alumno.Id = int.Parse(lector[0].ToString());
                        alumno.Apellido = lector["Apellido"].ToString();
                        alumno.Nombre = lector["Nombre"].ToString();
                        alumno.Dni = int.Parse(lector["Dni"].ToString());
                        alumno.Edad = short.Parse(lector["Edad"].ToString());
                        alumno.Genero = (Alumno.EGenero)Enum.Parse(typeof(Alumno.EGenero), lector["Genero"].ToString());
                        lista[id].Inscriptos.Add(alumno);
                    }                    
                }
                lector.Close();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            return lista;
        }
        #endregion

        #region Insert

        public bool AgregarAlumno(Alumno param)
        {
            bool rta = true;

            try
            {
                string sql = "INSERT INTO dbo.ALUMNOS (Apellido, Nombre,Dni,Edad,Genero) " +
                    "VALUES('"+ param.Apellido +"',' "+ param.Nombre +"', '"+  param.Dni.ToString() + "','" + param.Edad.ToString() + "','" + param.Genero.ToString() + "');";
                


                comando = new SqlCommand();

                comando.CommandType = CommandType.Text;
                comando.CommandText = sql;
                comando.Connection = conexion;


                conexion.Open();

                int filasAfectadas = comando.ExecuteNonQuery();

                if (filasAfectadas == 0)
                {
                    rta = false;
                }
            }
            catch (Exception e)
            {
                string st = e.Message;
                rta = false;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
           }

            return rta;
        }

        #endregion
        public bool AgregarCurso(Curso param)
        {
            bool rta = true;

            try
            {
    
                string sql = "INSERT INTO dbo.Cursos (Descripcion,FechaInicio,FechaFin,ELearning) " +
                    "VALUES('" + param.Descripcion + "',' " + param.FechaInicio.ToString("yyyy-MM-dd") + "', '" + param.FechaFin.ToString("yyyy-MM-dd") + "','" +param.ELearning.ToString() + "');";



                comando = new SqlCommand();

                comando.CommandType = CommandType.Text;
                comando.CommandText = sql;
                comando.Connection = conexion;

                conexion.Open();

                int filasAfectadas = comando.ExecuteNonQuery();

                if (filasAfectadas == 0)
                {
                    rta = false;
                }

            }
            catch (Exception e)
            {
                string st = e.Message;
                rta = false;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            return rta;
        }

        public bool AgregarInscripto(int idCurso,int idAlumno)
        {
            bool rta = true;

            try
            {
                string sql = "INSERT INTO dbo.INSCRIPTOS (IdAlumno,IdCurso) " +
                    "VALUES('" + idAlumno.ToString() + "','" + idCurso.ToString() + "');";



                comando = new SqlCommand();

                comando.CommandType = CommandType.Text;
                comando.CommandText = sql;
                comando.Connection = conexion;

                conexion.Open();

                int filasAfectadas = comando.ExecuteNonQuery();

                if (filasAfectadas == 0)
                {
                    rta = false;
                }

            }
            catch (Exception e)
            {
                string st = e.Message;
                rta = false;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            return rta;
        }

        #region Update

        public bool ModificarAlumno(Alumno param)
        {
            bool rta = true;

            try
            {
                comando = new SqlCommand();

                comando.Parameters.AddWithValue("@Dni", param.Dni);
                comando.Parameters.AddWithValue("@Apellido", param.Apellido);
                comando.Parameters.AddWithValue("@Nombre", param.Nombre);
                comando.Parameters.AddWithValue("@Edad", param.Edad);
                comando.Parameters.AddWithValue("@Genero", param.Genero);

                string sql = "UPDATE dbo.ALUMNOS ";
                sql += "SET Apellido = @Apellido, Nombre = @Nombre, Edad = @Edad , Genero = @Genero ";
                sql += "WHERE Dni = @Dni";

                comando.CommandType = CommandType.Text;
                comando.CommandText = sql;
                comando.Connection = conexion;

                conexion.Open();

                int filasAfectadas = comando.ExecuteNonQuery();

                if (filasAfectadas == 0)
                {
                    rta = false;
                }

            }
            catch (InvalidCastException)
            {
                rta = false;
            }
            catch (System.IO.IOException)
            {
                rta = false;
            }
            catch (ObjectDisposedException)
            {
                rta = false;
            }
            catch (InvalidOperationException)
            {
                rta = false;
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                rta = false;
            }
            catch (Exception)
            {
                rta = false;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }

            return rta;
        }

        #endregion

        #region Delete

        public bool EliminarAlumno(int dni)
        {
            bool rta = true;

            try
            {
                comando = new SqlCommand();

                comando.Parameters.AddWithValue("@dni", dni);

                string sql = "DELETE FROM dbo.ALUMNOS ";
                sql += "WHERE Dni = @Dni";

                comando.CommandType = CommandType.Text;
                comando.CommandText = sql;
                comando.Connection = conexion;

                conexion.Open();

                int filasAfectadas = comando.ExecuteNonQuery();

                if (filasAfectadas == 0)
                {
                    rta = false;
                }

            }
            catch (Exception)
            {
                rta = false;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            return rta;
        }
        public bool EliminarCurso(int idCurso)
        {
            bool rta = true;

            try
            {
                comando = new SqlCommand();

                comando.Parameters.AddWithValue("@idCurso", idCurso);

                string sql = "DELETE FROM dbo.Cursos ";
                sql += "WHERE IdCurso = @idCurso";

                comando.CommandType = CommandType.Text;
                comando.CommandText = sql;
                comando.Connection = conexion;

                conexion.Open();

                int filasAfectadas = comando.ExecuteNonQuery();

                if (filasAfectadas == 0)
                {
                    rta = false;
                }

            }
            catch (Exception)
            {
                rta = false;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            return rta;
        }
        public bool EliminarInscripto(int idCurso, int idAlumno)
        {
            bool rta = true;

            try
            {
                comando = new SqlCommand();

                comando.Parameters.AddWithValue("@idCurso", idCurso);
                comando.Parameters.AddWithValue("@idAlumno", idAlumno);
                string sql = "DELETE FROM dbo.INSCRIPTOS ";
                sql += "WHERE IdAlumno = @idAlumno AND IdCurso = @idCurso";

                comando.CommandType = CommandType.Text;
                comando.CommandText = sql;
                comando.Connection = conexion;

                conexion.Open();

                int filasAfectadas = comando.ExecuteNonQuery();

                if (filasAfectadas == 0)
                {
                    rta = false;
                }

            }
            catch (Exception)
            {
                rta = false;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            return rta;
        }
        #endregion

        #endregion
    }
}

