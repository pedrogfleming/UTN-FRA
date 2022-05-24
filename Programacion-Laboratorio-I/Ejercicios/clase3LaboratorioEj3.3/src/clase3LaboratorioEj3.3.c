/*
 ============================================================================
 Name        : 3.c
 Author      : Geraghty Fleming Pedro 1E
 Version     :
 Copyright   : Your copyright notice
 Description : Ejercicio 3-3:
				Crear una función que pida el ingreso de un entero y lo retorne.
 ============================================================================
 */

#include <stdio.h>
#include <stdlib.h>

int ingresarNumero(void);

int main(void)
{
	setbuf(stdout,NULL);
	printf("\nEl número entero retornado es: %d",ingresarNumero());

	return EXIT_SUCCESS;
}

int ingresarNumero(void)
{
	int numeroEntero;
	printf("f-Ingrese un número entero\n");
	scanf("%d",&numeroEntero);
	return numeroEntero;
}
