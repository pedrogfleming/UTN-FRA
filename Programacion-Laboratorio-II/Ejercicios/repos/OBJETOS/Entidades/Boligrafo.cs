using System;

namespace Entidades
{
    public class Boligrafo
    {
        public const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;
        public Boligrafo()       // constructor por defecto
        {
            color = ConsoleColor.White;
            tinta = 100;
        }
        public  Boligrafo(ConsoleColor colorTinta,short tintaDisponible )
        {
            this.color = colorTinta;
            this.tinta = tintaDisponible;
        }
        public ConsoleColor GetColor()
        {
            return this.color;
        }
        public short GetTinta()
        {
            return this.tinta;
        }
        private void SetTinta(short tintaModificar)
        {
            short auxTinta = this.tinta;
            auxTinta = (short)(auxTinta + tintaModificar);
            if (auxTinta >= 0 && auxTinta <= cantidadTintaMaxima)
            {
                //this.tinta = tintaModificar;
                this.tinta = auxTinta;
            }
            else
            {
                if(auxTinta <= 0)
                {
                    this.tinta = 0;
                }
                else
                {
                    this.tinta = cantidadTintaMaxima;
                }
            }
        }
        public void Recargar()
        {
            SetTinta(cantidadTintaMaxima);
        }
        public bool Pintar(short gasto, out string dibujo)
        {
            dibujo = ""; //inicializo
            short aux;
            if (this.tinta > 0)
            {
                if(gasto>=this.tinta) //Si quiero gastar mas de lo q hay, uso solo tinta restante
                {
                    aux = this.tinta;
                    #region omitir
                    //for (int i = 0; i < this.tinta; i++)
                    //{
                    //    dibujo += "*";

                    //}
                    //SetTinta(-100);       //Liquido todo lo que quede de tinta
                    #endregion
                }
                else   //Si quiero gastar menos de lo que hay de tinta, entonces uso que voy a gastar
                {
                    aux = gasto;
                    #region omitir
                    //for (int i = 0; i < gasto; i++)
                    //{
                    //    dibujo += "*";
                    //    SetTinta(gasto);            //A la tinta disponible le resto el gasto
                    //}

                    #endregion
                }
                for (int i = 0; i < aux; i++)
                {
                    dibujo += "*";
                    #region omitir
                    //SetTinta(gasto);            //A la tinta disponible le resto el gasto
                    #endregion
                }
                SetTinta((short)-gasto);
                return true;
            }
            return false;
        }


    }
}
