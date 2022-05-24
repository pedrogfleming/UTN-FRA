using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35_DirectorTecnico
{
    public class Persona
    {
        private long dni;
        private string nombre;
        #region Constructores
        public Persona(string nombre)
        {            
            this.Nombre = nombre;
        }
        public Persona(long dni, string nombre): this(nombre)
        {
            this.Dni = dni;
        }
        #endregion
        #region Propiedades
        public long Dni 
        {
            get
            {
                return dni;
            }

            set
            {
                if(value > 0 && value <= 99999999)
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
        #endregion
        public string MostrarDatos()
        {
            StringBuilder aux = new StringBuilder();
            return ((aux.Append(this.Dni)).Append(this.Nombre)).ToString();
        }
    }
}
