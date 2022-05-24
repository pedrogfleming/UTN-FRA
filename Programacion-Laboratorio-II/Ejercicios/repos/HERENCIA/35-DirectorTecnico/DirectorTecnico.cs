using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35_DirectorTecnico
{
    public class DirectorTecnico : Persona
    {
        private DateTime fechaNacimiento;
        #region Constructores
        private DirectorTecnico(string nombre) : base(nombre)
        {

        }
        public DirectorTecnico(string nombre, DateTime fechaNacimiento) : this(nombre)
        {
            this.FechaNacimiento = fechaNacimiento;
        }
        #endregion
        #region Propiedades
        public DateTime FechaNacimiento         
        {
            get
            {
                return this.fechaNacimiento;
            }

            set
            {
                if(value.Year >= 1857 )     //Primer club del mundo fue el Sheffield Football Club
                {
                    this.fechaNacimiento = value;
                }
            } 
        
        }

        #endregion
        public string MostradorDatos()
        {
            return base.MostrarDatos() + this.fechaNacimiento.ToString();
        }
        #region Sobrecargas == & !=
        public static bool operator ==(DirectorTecnico dt1, DirectorTecnico dt2)
        {
            if(dt1.Nombre == dt2.Nombre && dt1.FechaNacimiento == dt2.FechaNacimiento)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(DirectorTecnico dt1, DirectorTecnico dt2)
        {
            return !(dt1 == dt2);
        }
        #endregion
    }
}
