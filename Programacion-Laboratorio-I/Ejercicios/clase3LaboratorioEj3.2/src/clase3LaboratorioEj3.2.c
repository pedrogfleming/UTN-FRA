/*
 ============================================================================
 Name        : 2.c
 Author      : Geraghty Fleming Pedro 1E
 Version     :
 Copyright   : Your copyright notice
 Description : Ejercicio 3-2:
				Crear una función que muestre por pantalla
				el número flotante que recibe como parámetro.
 ============================================================================
 */

#include <stdio.h>
#include <stdlib.h>
void mostrarNumero(float valor);
int main(void)
{
	setbuf(stdout,NULL);
	float numeroFlotante;
	numeroFlotante = 3.3333333;
	mostrarNumero(numeroFlotante);


	return EXIT_SUCCESS;
}
void mostrarNumero(float valor)
{
	printf("%.2f es el número recibido como parámetro",valor);
}
