/*
 ============================================================================
 Name        : clase4LaboratorioEj1.c
 Author      : Geraghty Fleming Pedro 1E
 Version     : Ejercicio 4-1:
 Copyright   : Your copyright notice
 Description : Realizar un programa EN EL MAIN que permita calcular y mostrar el factorial de un número.
					Por ejemplo:
					5! = 5*4*3*2*1 = 120
 ============================================================================
 */

#include <stdio.h>
#include <stdlib.h>
int factorial(int numF);
int validarPositivo(int* entero);
int main(void)
{
	setbuf(stdout,NULL);
	int numero;
	int resultado;
	printf("\nIngrese numero:");
	scanf("%d",&numero);
	printf("\n %d es el numero ingresado",numero);
	validarPositivo(&numero);
	resultado=factorial(numero);

	printf("\nEl factorial es %d",resultado);

	return 0;
}
int factorial(int numF)
{
	int resp;
	if(numF==1)
	{
		return 1;
	}
	resp=numF* factorial(numF-1);
	printf("\nf- El numero multiplicado es %d, y su resultado intermedio es: %d",numF,resp);
	return (resp);
}
int validarPositivo(int* entero)
{
	if(entero != NULL)
	{
		int numValidado;
		numValidado = *entero;//Asigno el valor del parametro puntero  recibido a una variable local

		while(numValidado < 1)
		{
			printf("\nf-Error, el factorial sólo se realiza con números enteros positivos. Ingrese número entero postivo\n");
			scanf(" %d",&numValidado);
			printf("\nf- %d es el numero ingresado",numValidado);

		}
		*entero = numValidado;//Asigno el valor de la variable local validada al parametro puntero recibdio



	}
	return 0;
}
