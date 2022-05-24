using System;

namespace _32_EjercicioJugadores
{
    public class Jugador
    {
        private int dni;
        private string nombre;
        private int partidosJugados;
        private int totalGoles;
        #region Constructores
        private Jugador()
        {
            this.Dni = 0;
            this.partidosJugados = 0;
            this.totalGoles = 0;
        }
        public Jugador(int dni, string nombre)
        {
            if (!String.IsNullOrEmpty(nombre))
            {
                this.Dni = dni;
                this.Nombre = nombre;
            }
        }
        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos) : this(dni, nombre)
        {
            this.totalGoles = totalGoles;
            this.partidosJugados = totalPartidos;
        }
        #endregion
        #region Propiedades
        public int Dni 
        {
            get
            {
                return this.dni;
            }
            set
            {
                if(value >= 0 && value <= 99999999)
                {
                    this.dni = value;
                }
            } 
        
        }
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                if(!string.IsNullOrEmpty(value))
                {
                    this.nombre = value;
                }
            }
        }
        public int PartidosJugados
        {
            get
            {
                return this.partidosJugados;
            }
        }
        public float PromedioGoles
        {
            get
            {
                return (float)partidosJugados / totalGoles;
            }
        }
        public int TotalGoles
        {
            get
            {
                return this.totalGoles;
            }
        }
        #endregion

        public string MostrarDatos()
        {
            string stringAux = this.Dni.ToString() + this.Nombre + this.PartidosJugados.ToString() +
                                this.PromedioGoles.ToString() + this.TotalGoles.ToString();
            return stringAux;
        }
        #region Sobrecarga == & !=
        public static bool operator ==(Jugador j1,Jugador j2)
        {
            if(j1.Dni == j2.Dni)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1.Dni == j2.Dni);
        }
        #endregion
    }
}
