/*
 ============================================================================
 Name        : clase3LaboratorioEj3.c
 Author      : Geraghty Fleming Pedro 1E
 Version     :
 Copyright   : Your copyright notice
 Description : Ejercicio 3-1:
	Crear una función que permita determinar si un número es par o no.
	La función retorna 1 en caso afirmativo y 0 en caso contrario.
	 Probar en el main.
 ============================================================================
 */

#include <stdio.h>
#include <stdlib.h>
int verificarParImpar(int valorIngresado);
int main(void)
{
	setbuf(stdout,NULL);
	int numeroIngresado;
	int verificacion;

	printf("Ingrese un número\n");
	scanf("%d",&numeroIngresado);
	verificacion = verificarParImpar(numeroIngresado);
	if(verificacion == 0)
	{
		printf("\nEl número ingresado es impar");
	}
	else
	{
		printf("\nEl número ingresado es par");
	}


	return EXIT_SUCCESS;
}
int verificarParImpar(int valorIngresado)
{
	if(valorIngresado % 2 == 0)
	{
		return 1;
	}
	else
	{
		return 0;
	}
}
