/*
 ============================================================================
 Name        : clase4LaboratorioEj2.c
 Author      : Geraghty Fleming Pedro 1E
 Version     : Ejercicio 4-2
 Copyright   : Your copyright notice
 Description : Realizar un programa que permita la carga de temperaturas en celsius y fahrenheit ,
  	  	  	  	validando que las temperaturas ingresadas estén:
					X -entre el punto de congelación
					X -ebullición del agua para cada tipo de escala.
			x	Las validaciones se hacen en una biblioteca.
			x	Las funciones de transformación de fahrenheit a celsius y de celsius a fahrenheit
				se hacen en otra biblioteca.
 ============================================================================
 */

#include <stdio.h>
#include <stdlib.h>
#include "bibliotecaA.h"


int main(void)
{
	setbuf(stdout,NULL);
	char escalaTemperatura;
	float temperaturaIngresada;
	float temperaturaConvertida;
	printf("Elija una escala de temperatura, celsius(c) o fahrenheit(f)\n");
	fflush(stdin);
	scanf("%c",&escalaTemperatura);
	validarEscalaTemperatura(&escalaTemperatura);
	if(escalaTemperatura == 'c')
	{
		printf("\nIngrese temperatura en grados centigrados entre el punto de congelación y ebullición del agua\n");
		scanf("%f",&temperaturaIngresada);
		validarTemperaturaCE(temperaturaIngresada,escalaTemperatura);
		convertirTemperatura(temperaturaIngresada,&temperaturaConvertida,&escalaTemperatura);
		printf("\n %.2f celsius equivalen a %.2f farenheit\n",temperaturaIngresada,temperaturaConvertida);

	}
	else
	{
		printf("Ingrese temperatura en grados farenheit entre el punto de congelación y ebullición del agua\n");
		scanf("%f",&temperaturaIngresada);
		validarTemperaturaCE(temperaturaIngresada,escalaTemperatura);
		printf("\n %.2f farenheit equivalen a %.2f celsius\n",temperaturaIngresada,temperaturaConvertida);
	}


	return EXIT_SUCCESS;
}

