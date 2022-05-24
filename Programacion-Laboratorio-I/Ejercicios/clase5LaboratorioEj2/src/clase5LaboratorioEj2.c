/*
 ============================================================================
 Name        : clase5LaboratorioEj2.c
 Author      : Geraghty Fleming Pedro 1E
 Version     : Ejercicio 5-2
 Copyright   : Your copyright notice
 Description : Pedir el ingreso de 10 números enteros entre -1000 y 1000. X
				  Determinar:
					  Cantidad de positivos y negativos.
					  Sumatoria de los pares.
					  El mayor de los impares.
					  Listado de los números ingresados.
					  Listado de los números pares.
					  Listado de los números de las posiciones impares.
				  Se deberán utilizar funciones y vectores.
 ============================================================================
 */

#include <stdio.h>
#include <stdlib.h>
#include "bibliotecaArrays.h"
int main(void)
{
	setbuf(stdout,NULL);
	int numerosIngresados[10];
	int i;
	for (i = 0; i < 10; ++i)
	{
		printf("\nIngrese numero\n");
		scanf("%d",&numerosIngresados[i]);
		while(numerosIngresados[i] < -1000 || numerosIngresados[i] > 1000)
		{
			printf("\nError, ingrese numero entre -1000 y 1000\n");
			scanf("%d",&numerosIngresados[i]);
		}
	}


	return EXIT_SUCCESS;
}
