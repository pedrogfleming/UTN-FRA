using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Entidades;
namespace Archivos
{
    public class JsonFiler<T> :IMetodosArchivos<T>
    {
        /// <summary>
        /// Retornará la ruta al escritorio (debe ser independiente de la máquina en
        ///la que se abra el programa). Concatenar la barra final \ siendo la ruta retornada: C:\...\Desktop\
        /// </summary>
        public string GenerarRutaCompleta 
        {
            get
            {
                try
                {
                    return Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\";
                }
                catch (Exception ex)
                {

                    throw new ErrorArchivosException("No se pudo generar la ruta", ex);
                }
            }

        }
        /// <summary>
        /// Comprobará si el archivo existe o no y validara el dato recibo por parametro.
        /// </summary>
        /// <param name="nombreArchivo"></param>
        /// <returns>Retorna true si existe</returns>
        public bool ExisteArchivo(string nombreArchivo)
        {
            if(!string.IsNullOrWhiteSpace(nombreArchivo))
            {
                string rutaArchivo = Path.Combine(this.GenerarRutaCompleta, nombreArchivo);
                return File.Exists(rutaArchivo);
            }
            return false;
        }
        /// <summary>
        /// Guardara el objeto generico pasado parametro si es posible y valido el nombre del archivo pasado por parametro
        /// </summary>
        /// <param name="nombreArchivo"></param>
        /// <param name="Objeto"></param>
        public void Guardar(string nombreArchivo, T Objeto)
        {
            try
            {
                if (Objeto is null)
                {
                    throw new Exception("objeto nulo");
                }
                //char aux = (char)92;
                //if(string.IsNullOrWhiteSpace(nombreArchivo) || nombreArchivo.Contains(aux))
                if (string.IsNullOrWhiteSpace(nombreArchivo))
                {
                    throw new ErrorArchivosException("Nombre de archivo invalido");
                }
                JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions { Converters = { new JsonStringEnumConverter() } };
                jsonSerializerOptions.WriteIndented = true;
                string objetoJson = JsonSerializer.Serialize(Objeto, jsonSerializerOptions);
                File.WriteAllText(nombreArchivo, objetoJson);                
            }
            catch (Exception ex)
            {
                throw new ErrorArchivosException("Fallo al guardar",ex);
            }
        }
        /// <summary>
        /// Leera el el archivo y guardara su informacion en el objeto generico pasado por parametro si la ruta es valida y el archivo existe
        /// </summary>
        /// <param name="nombreArchivo"></param>
        /// <param name="objeto"></param>
        public void Leer(string nombreArchivo, out T objeto)
        {
            try
            {
                string objetoJson = File.ReadAllText(nombreArchivo);
                JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions
                {
                    Converters =
                    { new JsonStringEnumConverter(JsonNamingPolicy.CamelCase) }
                };
                jsonSerializerOptions.WriteIndented = true;
                objeto = JsonSerializer.Deserialize<T>(objetoJson, jsonSerializerOptions);    
                
            }
            catch (Exception ex)
            {
                throw new ErrorArchivosException(ex.Message);
            }
        }
    }
}
