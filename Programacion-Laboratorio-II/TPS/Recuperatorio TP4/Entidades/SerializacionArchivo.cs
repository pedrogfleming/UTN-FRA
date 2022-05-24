using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
namespace Entidades
{
    public class SerializacionArchivo
    {
        public static string CrearRuta(string nombreArchivo)
        {
            try
            {
                string auxRuta = AppDomain.CurrentDomain.BaseDirectory;
                string rutaArchivo = Path.Combine(auxRuta, nombreArchivo);
                return rutaArchivo;
            }
            catch (Exception ex)
            {

                throw new Exception("Error al intenetar generar la ruta del archivo", ex);
            }

        }
        public static void SerializarAJason<T>(string ruta, T obj) where T : class
        {
            try
            {
                JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions { Converters = { new JsonStringEnumConverter() } };
                jsonSerializerOptions.WriteIndented = true;
                string objetoJson = JsonSerializer.Serialize(obj, jsonSerializerOptions);
                File.WriteAllText(ruta, objetoJson);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static T DeserealizarDesdeJson<T>(string ruta) where T : class
        {
            try
            {
                string objetoJson = File.ReadAllText(ruta);
                JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions { Converters = { new JsonStringEnumConverter(JsonNamingPolicy.CamelCase) } };
                jsonSerializerOptions.WriteIndented = true;

                T objetoDeserealizado = JsonSerializer.Deserialize<T>(objetoJson, jsonSerializerOptions);

                return objetoDeserealizado;
            }
            catch (Exception)
            {

                throw;
            }

        }
        public static void GuardarTxt(string ruta, string data)
        {
            try
            {
                using (StreamWriter streamWriter = new StreamWriter(ruta))
                {
                    streamWriter.WriteLine(data);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static void AppendearTxt(string ruta, string data)
        {
            try
            {
                using (StreamWriter streamWriter = new StreamWriter(ruta,true))
                {
                    streamWriter.WriteLine(data);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
