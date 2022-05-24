using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Entidades
{
    public static class Dispositivo
    {
        //x Es una clase estática.
        //x El constructor estático instanciará la lista estática appsInstaladas, y seteará el sistema operativo de este dispositivo en ANDROID.
        //x  El método InstalarApp recibirá por parámetro una aplicación para ser instalada.
        //x   Antes de intentar instalarla, debe comprobarse que sea compatible para ese sistema operativo.
        //x  Una vez comprobado que es compatible, intentará añadir esa aplicación a la lista de aplicaciones.
        //x  Devolverá true si logra añadirla.Reutilizar código.
        //x  ObtenerInformacionDispositivo mostrará toda la información del dispositivo, y el detalle de sus aplicaciones instaladas.

        private static List<Aplicacion> appsInstaladas;
        private static ESistemaOperativo sistemaOperativo;
        #region Constructor
        static Dispositivo()
        {
            Dispositivo.appsInstaladas = new List<Aplicacion>();
            Dispositivo.sistemaOperativo = ESistemaOperativo.ANDROID;
        }
        #endregion
        #region InstalarApp
        /// <summary>
        /// El método InstalarApp recibirá por parámetro una aplicación para ser instalada.
        ///Antes de intentar instalarla, debe comprobarse que sea compatible para ese sistema operativo.
        ///Una vez comprobado que es compatible, intentará añadir esa aplicación a la lista de aplicaciones.
        /// </summary>
        /// <param name="app"></param>
        /// <returns>Devolverá true si logra añadirla</returns>
        public static bool InstalarApp(Aplicacion app)
        {
            if(app is not null && app.SistemaOperativo == ESistemaOperativo.ANDROID)
            {
                return appsInstaladas + app;
            }
            return false;
        }
        #endregion
        #region Mostrar informacion del dispositivo
        /// <summary>
        /// mostrará toda la información del dispositivo, y el detalle de sus aplicaciones instaladas.
        /// </summary>
        /// <returns></returns>
        public static string ObtenerInformacionDispositivo()
        {
            StringBuilder aux = new();
            aux.AppendFormat("\nDispositivo: {0}", Dispositivo.sistemaOperativo);
            foreach (Aplicacion item in appsInstaladas)
            {
                aux.AppendLine(item.ObtenerInformacionApp());
            }
            return aux.ToString();
        }

        #endregion
    }
}
