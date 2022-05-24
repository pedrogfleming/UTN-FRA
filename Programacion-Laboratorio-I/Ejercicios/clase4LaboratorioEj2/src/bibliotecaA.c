/*
 * bibliotecaA.c
 *
 *  Created on: 7 abr. 2021
 *      Author: Pedro
 */
#include <stdio.h>
#include <stdlib.h>

int validarPositivo(int* entero)
{
	if(entero != NULL)
	{
		int numValidado;
		numValidado = *entero;//Asigno el valor del parametro puntero  recibido a una variable local

		while(numValidado < 1)
		{
			printf("\nf-Error, ingrese número entero positivo\n");
			scanf(" %d",&numValidado);
			printf("\nf- %d es el numero ingresado",numValidado);

		}
		*entero = numValidado;//Asigno el valor de la variable local validada al parametro puntero recibdio



	}
	return 0;
}//FIN validarPositivo
int validarEscalaTemperatura(char* escalaV)
{
	if(escalaV != NULL)
	{
		char escalaIngresada = *escalaV;//Asigno el valor del parametro puntero  recibido a una variable local
		while(escalaIngresada !='c' && escalaIngresada !='f')
		{
			printf("f-Error, ha ingresado una escala no válida. Ingrese celsius(c) o fahrenheit(f) \n");
			fflush(stdin);
			scanf(" %c",&escalaIngresada);
		}
		*escalaV = escalaIngresada;
	}
	return 0;
}//FIN validarEscalaTemperatura
int validarTemperaturaCE(float temperaturaV,char escalaV)
{
	if(escalaV == 'c')
	{
		while(temperaturaV < 0 || temperaturaV > 100)
		{
			printf("\nf-Error, ingrese una temperatura en centígrados entre 0 y 100 celcius\n");
			scanf("%f",&temperaturaV);
		}
	}
	else
	{
		while(temperaturaV < 32 || temperaturaV > 212)
				{
					printf("\nf-Error, ingrese una temperatura entre 32 y 212 farenheit\n");
					scanf("%f",&temperaturaV);
				}
	}
	return 0;
}//FIN validarTemperaturaCE
int convertirTemperatura(float temperaturaC,float* resultado,char* escala)
{
	if(resultado != NULL && escala !=NULL)
	{
		float temperaturaFinal;
		char escalaOrigin;
		temperaturaFinal = *resultado;
		escalaOrigin = *escala;
		if(escalaOrigin == 'c')
		{
			temperaturaFinal = (temperaturaC*1.8)+32;
		}
		else
		{
			temperaturaFinal = (temperaturaC-32)*0.5;
		}
		*resultado = temperaturaFinal;
	}


	return 0;
}//FIN convertirTemperatura

