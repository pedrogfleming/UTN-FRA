using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoArchivos
{
    public class ArchivosTxt
    {
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
    }
}
