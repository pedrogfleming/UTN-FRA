/*
 * calculos.h
 *
 *  Created on: 8 may. 2021
 *      Author: Pedro
 */

#ifndef CALCULOS_H_
#define CALCULOS_H_

//********************************************************OPERACIONES*********************************************************************************
int sumaDosOperadores(int numeroUno,int numeroDos,int* punteroResultado);
int restaDosOperadores(int numeroUno,int numeroDos,int* punteroResultado);
int divisionDosOperadores(int dividendo, int divisor,float* punteroResultado);
int multiplicacionDosOperadores(int numeroUno,int numeroDos,int* punteroResultado);
int factorial(int numero);
//*************************************************OPERACIONES SIMULTANEAS*****************************************************************************
int calcularOperacionesSimples(int numeroA,int numeroB,int* punteroSuma,int* punteroResta,int* punteroMultiplicacion);
int averageCalculate(int counter,float acumulator,float* averageResult);
/*Brief: toma un contador y un acumulador para calcular el promedio operando esas dos variables entre si
 * Param1: contador de tipo int
 * Param2: acumulador de tipo float
 * Retorna 0 si calculo el promedio, -1 si no pudo
 */
//******************************************************VALIDACION*************************************************************************************
int validarFactorial(int operando);

int calcularOperacionesSimples(int numeroA,int numeroB,int* punteroSuma,int* punteroResta,int* punteroMultiplicacion);
//*************************************************MOSTRAR RESULTADOS**********************************************************************************
void mostrarResultados(int operandoA,int operandoB,int sumaResultado,int restaResultado,int flagDivision
		, float divisionResultado, int multiplicacionResultado,int factorialResultadoA,int flagFactorialA,int factorialResultadoB,int flagFactorialB);
#endif /* CALCULOS_H_ */
