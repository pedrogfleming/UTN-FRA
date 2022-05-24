using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Rosal : Planta
    {
        //3. Clase Rosal:
        //a.Su ResumenDeDatos incorporará el concepto "Flores de color: XXXXX". X
        //b.Tiene flores y no tiene fruto X
        public enum Color { Roja, Blanca, Amarilla, Rosa, Azul };
        private Color florColor;
        #region Constructores
        public Rosal(string nombre,int tamanio) : base(nombre, tamanio)
        {

        }
        public Rosal(string nombre, int tamanio,Color flor) : this(nombre, tamanio)
        {
            this.florColor = flor;
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
                return false;
            }
        }
        #endregion
        #region Metodos
        public override string ResumenDeDatos()
        {
            StringBuilder aux = new StringBuilder();
            aux.Append(base.ResumenDeDatos());
            aux.Append(String.Format("Flores de color: {0}", this.florColor));
            return aux.ToString();
        }
        #endregion
    }
}