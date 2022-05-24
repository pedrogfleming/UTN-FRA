using System;

namespace _36_Ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Random azar = new Random();
            Competencia formulaUno = new Competencia(10, 20, Competencia.tipoCompetencia.F1);
            AutoF1[] autos = new AutoF1[10];
            try
            {
                for (int i = 0; i < autos.Length; i++)
                {
                    autos[i] = new AutoF1((short)i, azar.Next(1, 5).ToString());
                    try
                    {
                        if (formulaUno + autos[i])
                        {
                            Console.WriteLine("Se Agrego el siguiente auto a la competencia: {0}", autos[i].MostrarDatos());
                        }
                        else
                        {
                            Console.WriteLine("No se agrego ya que la competencia esta completa: {0}", autos[i].MostrarDatos());
                        }
                    }
                    catch (CompetenciaNoDisponibleException e)
                    {
                        //throw new CompetenciaNoDisponibleException("Excepcion 3",e);
                        throw new CompetenciaNoDisponibleException("Auto no es de  de competencia F1", "Program", "Main", e);
                    }
                }
                MotoCross motoCross = new MotoCross(5, "Motos");
                try
                {
                    if (formulaUno + motoCross)
                    {
                        Console.WriteLine("Se agrego la moto");
                    }
                    else
                    {
                        Console.WriteLine("no se puede agregar la moto");
                    }
                }
                catch (CompetenciaNoDisponibleException e)
                {
                    //throw new CompetenciaNoDisponibleException("Excepcion 4", e);
                    throw new CompetenciaNoDisponibleException("Moto no puede ser de competencia F1","Program", "Main", e);
                }
                Console.WriteLine();
                Console.WriteLine("<-------------------------------------------------------------------------------------------------->");
                Console.WriteLine(formulaUno.MostrarDatos());
            }
            catch (CompetenciaNoDisponibleException e)
            {
                Console.WriteLine(e.ToString());
            }
            Console.ReadKey();
        }
    }
}
