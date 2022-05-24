using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Banano : Planta
    {
        //4. Clase Banano:
        //a.Su ResumenDeDatos incorporará el concepto "Código internacional: XXXXX". X
        //b.Tiene flores y tiene fruto. X
        private string codigo;
        #region Constructores
        public Banano(string nombre, int tamanio, string codigo) : base(nombre, tamanio)
        {
            this.codigo = codigo;
        }
        #endregion
        #region Propiedades
        public override bool TieneFlores
        {
            get
            {
                return true;
            }
        }
        public override bool TieneFrutos
        {
            get
            {
                return true;
            }
        }
        #endregion
        #region Metodos
        public override string ResumenDeDatos()
        {
            StringBuilder aux = new StringBuilder();
            aux.Append(base.ResumenDeDatos());
            aux.Append(String.Format("Código internacional: {0} ", this.codigo));
            return aux.ToString();
        }
        #endregion
    }
}
