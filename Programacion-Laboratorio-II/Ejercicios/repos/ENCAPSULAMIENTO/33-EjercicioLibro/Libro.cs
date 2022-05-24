using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33_EjercicioLibro
{
    public class Libro
    {
        private List<string> paginas;
        #region Propiedades
        /*El indexador leerá la página pedida,
         * siempre y cuando el subíndice se encuentre dentro de un rango correcto,
         * sino retornará un string vacío “”.
         */
        public Libro()
        {
            this.paginas = new List<string>();
        }
        public string this[int i]
        {
            get 
            { /* return the specified index here */
                if(i >= 0 && i < paginas.Count)
                {
                    return paginas[i];
                }
                return "";                
            }
            set 
            {/* set the specified index to value here */
                if(i >= 0  && i < paginas.Count)
                {
                    paginas[i] = value;
                }
                else if(i > paginas.Count)
                {
                    paginas.Add(value);
                }
            }
        }
        #endregion
        public int TotalPaginas()
        {
            return this.paginas.Count();
        }

    }
}
