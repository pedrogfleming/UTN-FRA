/*
 ============================================================================
 Name        : tp1.c
 Author      : Geraghty Fleming Pedro 1E
 Version     : TP1
 Copyright   : Your copyright notice
 Description : Hacer una calculadora. Para ello el programa iniciará y contará con un menú de opciones:

				1. Ingresar 1er operando (A=x)
				2. Ingresar 2do operando (B=y)
				3. Calcular todas las operaciones:
				x	Xa) Calcular la suma (A+B)
				x	Xb) Calcular la resta (A-B)
				x	Xc) Calcular la division (A/B)
				x	d) Calcular la multiplicacion (A*B)
				x	e) Calcular el factorial (A!) y (B!)
				4. Informar resultados:
				x	a) “El resultado de A+B es: r”
				x	b) “El resultado de A-B es: r”
				x	c) “El resultado de A/B es: r” o “No es posible dividir por cero”
				x	d) “El resultado de A*B es: r”
				x	e) “El factorial de A es: r1 y El factorial de B es: r2”
			 	5. Salir x

				• Todas las funciones matemáticas del menú se deberán realizar en una biblioteca aparte, que contenga las funciones para realizar las cinco operaciones.
				• En el menú deberán aparecer los valores actuales cargados en los operandos A y B (donde dice “x” e “y” en el ejemplo, se debe mostrar el número cargado)
				• Deberán contemplarse los casos de error (división por cero, etc) • Documentar todas las funciones
 ============================================================================
 */

#include <stdio.h>
#include <stdlib.h>
#include "utn.h"
#include "calculos.h"
#include "menu.h"
int main(void)
{
	setbuf(stdout,NULL);
	int operandoUno;
	int operandoDos;
	int resultadoSuma;
	int resultadoResta;
	float resultadoDivision;
	int resultadoMultiplicacion;
	int resultadoFactorialA;
	int resultadoFactorialB;
	int exitoDivision;
	int respuesUsuario;
	int flagOperandoUno;
	int flagOperandoDos;
	int flagCalculo;
	int flagFactorialA;
	int flagFactorialB;

	flagOperandoUno = 0;
	flagOperandoDos = 0;
	operandoUno = 0;
	operandoDos = 0;
	flagCalculo = 0;
	flagFactorialA = 0;
	flagFactorialB = 0;
	do
	{
		mostrarMenu(&respuesUsuario,operandoUno,operandoDos);
		switch (respuesUsuario)
						{
							case 1://1. Ingresar 1er operando (A=x)
							{
								utn_getNumeroSinLimites(&operandoUno,"\nIngrese el primer operando","\nError, ingrese sólo números",3);
								flagOperandoUno = 1;
								flagCalculo = 0;
								break;
							}
							case 2://Ingresar 2do operando (B=y)
							{
								utn_getNumeroSinLimites(&operandoDos,"\nIngrese el segundo operando","\nError, ingrese sólo números",3);
								flagOperandoDos = 1;
								flagCalculo = 0;
								break;
							}
							case 3://3. Calcular todas las operaciones:
							{
								if(flagOperandoUno != 0 && flagOperandoDos != 0)//Solo si ingreso los 2 operandos
								{
									calcularOperacionesSimples(operandoUno,operandoDos,&resultadoSuma,&resultadoResta,&resultadoMultiplicacion);
									exitoDivision = divisionDosOperadores(operandoUno,operandoDos,&resultadoDivision);
									//e) Calcular el factorial (A!) y (B!)
									if(validarFactorial(operandoUno) == 0)
									{
										if(factorial(operandoUno,&resultadoFactorialA) == 0)
										{
											printf("\nSe ha calculado el factorial de %d(A)\n",operandoUno);
											flagFactorialA = 1;
										}
									}
									if(validarFactorial(operandoDos) == 0)
									{
										if(factorial(operandoDos,&resultadoFactorialB) == 0)
										{
											printf("\nSe ha calculado el factorial de %d(B)\n",operandoDos);
											flagFactorialB = 1;
										}

									}
									flagCalculo = 1;
									//printf("\nSe ha calculado la suma,resta,division,multiplicacion entre los numeros ingresados y el factorial de cada uno\n");
								}
								else
								{
									printf("\nError, primero debe ingresar los dos operando para operar\n");
								}
								break;
							}
							case 4://Informar resultados:
							{
								if(flagOperandoUno != 0 && flagOperandoDos != 0)//SOLO si ingreso los dos operandos
								{
									if(flagCalculo != 0)//Se muestran todos los resultados SOLO si previamente los calculo 1 vez
									{
										mostrarResultados(operandoUno,operandoDos,resultadoSuma,resultadoResta,exitoDivision
												,resultadoDivision,resultadoMultiplicacion,resultadoFactorialA,flagFactorialA,resultadoFactorialB,flagFactorialB);
									}
									else
									{
										printf("\nPara mostrar resultados primero ingrese el comando 3 para calcular\n");
									}
								}
								else
								{
									printf("\nError, primero debe ingresar los dos operando para ver los resultados de las operaciones\n");
								}

								break;
							}
							case 5://SALIR
							{

								printf("\n- Usted seleccionó 5. Salir\n");
								break;
							}
							default:
								printf("\nError, ha ingresado un comando inválido\n");
								fflush(stdin);
								break;
						}//FIN SWITCH
		//5. Salir

	}while(respuesUsuario != 5);
	return EXIT_SUCCESS;
}

