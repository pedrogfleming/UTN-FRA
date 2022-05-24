using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ManejoArchivos
{
    public class SerializacionAJason
    {
        /// <summary>
        /// Genera un archivo Json
        /// </summary>
        /// <typeparam name="T">objeto generico</typeparam>
        /// <param name="ruta">donde va a ir el archivo</param>
        /// <param name="obj">el objeto a serializar</param>
        public static void SerializarAJason<T>(string ruta, T obj) where T : class
        {
            try
            {
                if (obj is null)
                {
                    throw new Exception("objeto nulo");
                }
                JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions { Converters = { new JsonStringEnumConverter() } };
                jsonSerializerOptions.WriteIndented = true;

                string objetoJson = JsonSerializer.Serialize(obj, jsonSerializerOptions);

                File.WriteAllText(ruta, objetoJson);
            }
            catch (Exception ex)
            {
                throw new SerializacionException(ex.Message);
            }
        }
        /// <summary>
        /// Deserealiza un archivo Json
        /// </summary>
        /// <typeparam name="T">objeto generico</typeparam>
        /// <param name="ruta">desde donde se lee el archivo</param>
        /// <returns>El objeto deserealizado</returns>
        public static T DeserealizarDesdeJson<T>(string ruta) where T : class
        {
            try
            {
                string objetoJson = File.ReadAllText(ruta);
                JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions 
                { Converters =
                    { new JsonStringEnumConverter(JsonNamingPolicy.CamelCase) } };
                jsonSerializerOptions.WriteIndented = true;

                T objetoDeserealizado = JsonSerializer.Deserialize<T>(objetoJson, jsonSerializerOptions);

                return objetoDeserealizado;
            }
            catch (Exception ex)
            {
                throw new SerializacionException(ex);
            }
        }
    }
}
