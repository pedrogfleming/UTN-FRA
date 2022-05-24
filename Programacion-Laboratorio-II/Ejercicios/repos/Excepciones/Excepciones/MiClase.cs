using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    /// <summary>
    /// Crear una clase llamada MiClase
    /// y dentro colocar un método estático y 2 constructores deinstancia.
    /// </summary>
    public class MiClase
    {
        private bool miAtributoBooleano;
        /// <summary>
        /// Capturar la excepción del punto anterior en un constructor de instancia 
        /// y relanzarla hacia otro constructor de instancia.
        /// </summary>
        public MiClase()
        {
            try
            {
                miAtributoBooleano = miMetodoEstatico();
            }
            catch (DivideByZeroException)
            {
                throw;
            }
        }
        /// <summary>
        /// En este segundo constructor instanciará otro objeto del tipo MiClase capturando su excepción.
        /// Crear una excepción propia llamada UnaException(utilizar innerException para almacenar la excepción original) 
        /// y volver a lanzarla.
        /// </summary>
        /// <param name="miAtributoBooleano"></param>
        public MiClase(bool miAtributoBooleano)
        {
            try
            {
                new MiClase();
            }
            catch (DivideByZeroException e)
            {
                throw new UnaExcepcion("Error de division por cero", e);
            }             
        }
        /// <summary>
        /// Dentro del método estático lanzar una excepción DivideByZeroException (sólo lanzarla).
        /// </summary>
        /// <returns></returns>
        public static bool miMetodoEstatico()
        {
            throw new DivideByZeroException();
        }
    }
}
