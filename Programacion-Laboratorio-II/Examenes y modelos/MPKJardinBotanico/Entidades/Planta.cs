using System;
using System.Text;
namespace Entidades
{
    public abstract class Planta
    {
        //Clase Planta:
        //a.Los métodos y propiedades marcados en cursiva son abstractos. X
        //b.ResumenDeDatos retornará los datos de la Planta utilizando StringBuilder y String.Format. X
        //Completar las palabras en mayúscula con los datos de cada planta según corresponda:X
        //NOMBRE tiene un tamaño de TAMANIO X
        //Tiene flores SI/NO  
        //Tiene fruto SI/NO 
        private string nombre;
        private int tamanio;
        #region Constructor
        public Planta(string nombre, int tamanio)
        {
            if(!string.IsNullOrWhiteSpace(nombre) && tamanio > 0)
            {
                this.nombre = nombre;
                this.tamanio = tamanio;
            }            
        }
        #endregion
        #region Propiedades
        public int Tamanio 
        {
            get
            {
                return this.tamanio;
            }        
        }
        public abstract bool TieneFlores { get;}
        public abstract bool TieneFrutos { get; }
        #endregion
        #region Metodos
        public virtual string ResumenDeDatos()
        {
            StringBuilder aux = new StringBuilder();
            aux.Append(String.Format("Nombre: {0} ", this.nombre.ToUpper()));
            aux.Append(String.Format("Tamanio: {0} ", this.Tamanio));
            if(!this.TieneFlores)
            {
                aux.Append("Tiene flor: NO ");
            }
            else
            {
                aux.Append("Tiene flor: SI ");
            }
            if (!this.TieneFrutos)
            {
                aux.Append("Tiene frutos: NO ");
            }
            else
            {
                aux.Append("Tiene frutos: SI ");
            }
            return aux.ToString();
        }
        #endregion
    }
}