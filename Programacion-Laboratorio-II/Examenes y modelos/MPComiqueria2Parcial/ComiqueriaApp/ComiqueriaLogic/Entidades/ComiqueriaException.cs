using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic.Entidades
{
    //Crear una nueva clase “ComiqueriaException” que funcionará como un nuevo tipo de excepción
    //del sistema.Tendrá un constructor que recibirá un mensaje y una excepción (innerException).
    //Pasarle los argumentos al constructor de la clase base.
    public class ComiqueriaException : Exception
    {
        public ComiqueriaException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
