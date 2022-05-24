using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_AtencionCliente
{
    public class Cliente
    {
        private string nombre;
        private int numero;
        #region Constructores
        public Cliente(int numero)
        {
            this.numero = numero;
        }
        public Cliente(string nombre, int numero):this(numero)
        {            
            this.Nombre = nombre;
        }
        #endregion
        #region Propiedades
        public string Nombre 
        {
            get
            {
                return nombre;
            }
            set
            {
                if(!string.IsNullOrEmpty(value))
                {
                    this.nombre = value;
                }
                 
            }        
        }
        public int Numero
        {
            get
            {
                return numero;
            }           
        }
        #endregion
        #region Sobrecargas == & !=
        public static bool operator ==(Cliente c1, Cliente c2)
        {
            if(c1.Numero == c2.Numero)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Cliente c1,Cliente c2)
        {
            return !(c1 == c2);
        }

        #endregion


    }
}
