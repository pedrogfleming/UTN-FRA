/*
 ============================================================================
 Name        : clase3LaboratorioEj1.c
 Author      : Geraghty Fleming Pedro 1E
 Version     :
 Copyright   : Your copyright notice
 Description : a-Funciones
			- Limpie la pantalla
			x- Asigne a la variable numero1 un valor solicitado al usuario
			x- Valide el mismo entre 10 y 100
			x- Realice un descuento del 5% a dicho valor a través de una función llamada realizarDescuento()
			x- Muestre el resultado por pantalla
 ============================================================================
 */

#include <stdio.h>
#include <stdlib.h>
#define DESCUENTO 5/100;
float realizarDescuento(float numeroUno);


int main(void)
{
	setbuf(stdout,NULL);
	float numeroUno;
	float numeroConDescuento;


	printf("Ingrese un número entre 10 y 100\n");
	scanf("%f",&numeroUno);
	while(numeroUno < 10 || numeroUno > 100)
	{
		printf("\nError, reingrese un numero entre 10 y 100\n");
		scanf("%f",&numeroUno);
	}
	numeroConDescuento = realizarDescuento(numeroUno);
	printf("\nEl numero con descuento del 5 por ciento es: %f",numeroConDescuento);


	return EXIT_SUCCESS;
}
float realizarDescuento(float numeroUno)
{
	float numeroConDescuento;
	float montoDescuento;
	montoDescuento = numeroUno*DESCUENTO;
	numeroConDescuento = numeroUno-montoDescuento;
	return numeroConDescuento;
}
