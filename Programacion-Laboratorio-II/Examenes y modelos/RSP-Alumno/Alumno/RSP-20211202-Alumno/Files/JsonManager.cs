using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using Excepciones;

namespace Files
{
    //x  4.El constructor de la clase JsonManager estática asignará al atributo file el valor CentroDeAtencion.json.
    //5.Guardar(T elemento) guardará el elemento recibido como parámetro en un archivo de texto:
    //x  a.Su contenido será el paramentro "elemento" un objeto y deberá ser convertido a JSON.
    //x  b.Dicho archivo será guardado en donde indique el atributo file.
    //x  c.De haber un error, se lanzará FilesException.
    //x 6.Guardar(string file, T elemento) modificará el atributo file y luego hará lo mismo que Guardar(T).

    public static class JsonManager <T> where T : class
    {
        private static string file;


        static JsonManager()
        {
            JsonManager<T>.file = "CentroDeAtencion.json";
        }
        /// <summary>
        ///x 5.Guardar(T elemento) guardará el elemento recibido como parámetro en un archivo de texto:
        ///x  a.Su contenido será el paramentro "elemento" un objeto y deberá ser convertido a JSON.
        ///x  b.Dicho archivo será guardado en donde indique el atributo file.
        ///x  c.De haber un error, se lanzará FilesException.
        /// </summary>
        /// <param name="elemento"></param>
        public static void Guardar(T elemento)
        {
            try
            {
                string auxRuta = AppDomain.CurrentDomain.BaseDirectory;
                string rutaArchivo = Path.Combine(auxRuta, JsonManager<T>.file);

                JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions { Converters = { new JsonStringEnumConverter() } };
                jsonSerializerOptions.WriteIndented = true;
                string objetoJson = JsonSerializer.Serialize(elemento, jsonSerializerOptions);
                File.WriteAllText(rutaArchivo, objetoJson);
            }
            catch (Exception e)
            {
                throw new FilesException(e.Message,e);
            }
        }
        /// <summary>
        /// 6.Guardar(string file, T elemento) modificará el atributo file y luego hará lo mismo que Guardar(T).
        /// </summary>
        /// <param name="file"></param>
        /// <param name="elemento"></param>
        public static void Guardar(string file,T elemento)
        {
            JsonManager<T>.file = file;
            JsonManager<T>.Guardar(elemento);
        }
        public static T Leer(string ruta)
        {
            try
            {
                string objetoJson = File.ReadAllText(ruta);
                JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions { Converters = { new JsonStringEnumConverter(JsonNamingPolicy.CamelCase) } };
                jsonSerializerOptions.WriteIndented = true;

                T objetoDeserealizado = JsonSerializer.Deserialize<T>(objetoJson, jsonSerializerOptions);

                return objetoDeserealizado;
            }
            catch (Exception e)
            {

                throw new FilesException(e.Message, e);
            }
        }
    }

}