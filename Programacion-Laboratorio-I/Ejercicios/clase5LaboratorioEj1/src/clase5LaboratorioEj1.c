/*
 ============================================================================
 Name        : clase5LaboratorioEj1.c
 Author      : Geraghty Fleming Pedro 1E
 Version     : Ejercicio 5-1:
 Copyright   : Your copyright notice
 Description : Pedir el ingreso de 5 números. Mostrarlos y calcular la sumatoria de los mismos.
 ============================================================================
 */

#include <stdio.h>
#include <stdlib.h>

int main(void)
{

	setbuf(stdout,NULL);
	int numerosIngresados[5];
	int i;
	int sumatotal;
	sumatotal = 0;
	for (i = 0; i < 5; ++i)
	{
		printf("Ingrese un numero\n");
		scanf("%d",&numerosIngresados[i]);
		sumatotal = sumatotal+numerosIngresados[i];
	}//FIN FOR INGRESO DE NUMEROS
	for (i = 0; i < 5; ++i)
	{
		printf(" %d ",numerosIngresados[i]);
	}
	printf("\nLa suma de los 5 numeros ingresados es: %d",sumatotal);
	return EXIT_SUCCESS;
}
