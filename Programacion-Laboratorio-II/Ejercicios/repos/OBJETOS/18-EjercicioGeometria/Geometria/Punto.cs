using System;

namespace Geometria
{
    public class Punto
    {
        private int x;
        private int y;

        public Punto(int x_Param, int y_Param)
        {
            this.x = x_Param;
            this.y = y_Param;
        }
        public int GetX()
        {
            return this.x;
        }
        public int GetY()
        {
            return this.y;
        }


    }
    public class Rectangulo
    {
        private Punto vertice1;
        private Punto vertice2;
        private Punto vertice3;
        private Punto vertice4;
        private float area;
        private float perimetro;
        /// <summary>
        /// constructor de una instancia rectangulo con sus medidas
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v3"></param>
        public Rectangulo(Punto v1, Punto v3)
        {
            this.vertice1 = v1;
            this.vertice2 = new Punto(v1.GetX(), v3.GetY());
            this.vertice3 = v3;
            this.vertice4 = new Punto(v3.GetX(), v1.GetY());
            GetArea();
            GetPerimetro();
        }
        /*
        public static Rectangulo()
        {
            this.area = Math.Abs();
            this.perimetro = Math.Abs(perimetro);
        }
        */
         private float GetArea()
        {
            if(this.area == default)
            {
                float altura = vertice2.GetY() - vertice1.GetY();
                float baseX  = vertice4.GetX() - vertice1.GetX();

                this.area = baseX * altura;                
            }            
            return this.area;
        }
         public float GetPerimetro()
        {
            //return this.perimetro = Math.Abs(perimetro);
            if(this.perimetro == default)
            {
                float alturaY = vertice2.GetY() - vertice1.GetY();
                float baseX = vertice4.GetX() - vertice1.GetX();
                this.perimetro = (alturaY + baseX) * 2;
            }
            return this.perimetro;
        }
        public void Mostrar()
        {
            Console.WriteLine("El area del rectangulo es {0}\nEl perimetro del rectangulo es{1}", this.area, this.perimetro);
        }


    }
}
