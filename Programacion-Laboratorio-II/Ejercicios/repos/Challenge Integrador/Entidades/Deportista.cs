using System;

namespace Entidades
{
    public abstract class Deportista
    {
        private int cantidadPartidos;
        private int edad;
        private string nombreApellido;

        #region Constructor
        protected Deportista(string nombreApe,int edad,int cantPart)
        {
            this.nombreApellido = nombreApe;
            this.Edad = edad;
            this.CantidadPartidos = cantPart;
        }
        #endregion
        #region Propiedades
        public int CantidadPartidos 
        {
            get
            {
                return this.cantidadPartidos;
            }
            set
            {
                if(value >= 0)
                {
                    this.cantidadPartidos = value;
                }
            }
        }
        public int Edad
        {
            get
            {
                return this.edad;
            }
            set
            {
                if (value >= 0)
                {
                    this.edad = value;
                }
            }
        }
        public string NombreApellido 
        {
            get
            {
                return this.nombreApellido;
            }
        }
        #endregion
    }
}
