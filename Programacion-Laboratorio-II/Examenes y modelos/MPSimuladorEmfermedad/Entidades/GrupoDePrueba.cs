using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    //x  La clase es estática.
    //x Su tipo genérico deberá tener una restricción de tipo: deberá ser Microorganismo o uno de sus derivados.
    //x  Por defecto, su población será de 10000000.
    //x  InfectarPoblacion:
    //x  Controlará que su argumento sea del tipo T.
    //x  Establecerá la enfermedad a simular (cargar el atributo de clase), e iniciará el día en 1.

    //x Calculará mediante la propiedad IndiceDeContagios cuantos infectados hay.
    //x  Los infectados no podrán superar la cantidad de población, solo igualarla.
    //x  Se informará mediante el evento InformeDeAvance el estado de la simulación.
    //x  Se incrementará el día, se hará un sleep de 0.75 segundos y se iterará hasta completar la
    //x  infección de toda la población.
    //x  Una vez finalizado el proceso anterior, se deberá informar mediante FinalizaSimulacion
    //x  que toda la población ha sido infectada.
    //x  Tener en cuenta no llamar a eventos que no tienen suscriptores.
    public static class GrupoDePrueba<T> where T : Microrganismo
    {
        private static T emfermedad;
        private static long poblacion;
        //public delegate void AvanceInfectados(int dia, long infectados);
        //public delegate void FinInfectacion();
        public static AvanceInfectados delAvanceInfectados;
        public static FinInfectacion delFinInfectacion;
        public static event FinInfectacion FinalizaSimulacion;
        public static event AvanceInfectados InformeDeAvance;

        static GrupoDePrueba()
        {
            GrupoDePrueba<T>.poblacion = 10000000;
        }
        public static long Poblacion 
        {
            get
            {
                return GrupoDePrueba<T>.poblacion;
            }
            set
            {
                if(value >= 0)
                {
                    GrupoDePrueba<T>.poblacion = value;
                }
            }
        }
        /// <summary>
        /// InfectarPoblacion:
        /// Controlará que su argumento sea del tipo T.
        /// Establecerá la enfermedad a simular (cargar el atributo de clase), e iniciará el día en 1.
        /// </summary>
        /// <param name="obj"></param>
        public static void InfectarPoblacion(object obj)
        {
            T auxParam = obj as T;
            if(auxParam is not null)
            {
                int dia = 1;
                GrupoDePrueba<T>.emfermedad = auxParam;
                if (InformeDeAvance != null && FinalizaSimulacion != null)
                {
                    long contagiados = GrupoDePrueba<T>.emfermedad.IndiceDeContagios;
                    //Se iterara hasta contagiarse toda la poblacion
                    while (contagiados <= Poblacion)
                    {
                        InformeDeAvance.Invoke(dia++, contagiados);
                        Thread.Sleep(750);
                        contagiados *= auxParam.IndiceDeContagios;
                    }
                    //Una vez contagiada toda la poblacion, se finaliza la simulacion
                    FinalizaSimulacion.Invoke();
                }
            }
        }
    }
}
