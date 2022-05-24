using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Torneo
    {
        private static Equipo campeon;
        private static List<Fecha> fixture;
        private static List<Equipo> listaEquipos;
        private static string nombreTorneo;

        static Torneo()
        {
            Torneo.nombreTorneo = "Copa Libertadores de Avellaneda";
            Torneo.fixture = new List<Fecha>();
            Torneo.ListaEquipos = new List<Equipo>();
            CargarEquipos();
            CargarPartidos();
        }
        private static void CargarEquipos()
        {
            //Hardcodeo
            foreach (Equipo item in Torneo.listaEquipos)
            {
                listaEquipos.Add(item);
            }
        }
        private static void CargarPartidos()
        {
            foreach (Fecha item in Torneo.fixture)
            {
                Torneo.fixture.Add(item);
            }
        }
        public static void JugarPartido(int nroFecha)
        {
            foreach (Fecha item in Torneo.fixture)
            {
                if (nroFecha == item.Id)
                {
                    foreach (Partido auxItem in item.Partidos)
                    {
                        auxItem.SimularPartido();
                    }
                    break;
                }
            }
        }
        #region Propiedades
        public static List<Equipo> ListaEquipos
        {
            get
            {
                return Torneo.listaEquipos;
            }
            set
            {
                if (value is not null)
                {
                    Torneo.listaEquipos = value;
                }
            }
        }
        #endregion
    }
}
