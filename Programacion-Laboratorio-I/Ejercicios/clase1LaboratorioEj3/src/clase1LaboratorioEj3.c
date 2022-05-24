/*
 ============================================================================
 Name        : clase1LaboratorioEj3.c
 Author      : Geraghty Fleming Pedro 1E
 Version     :
 Copyright   : Your copyright notice
 Description : Ingresar 3 numeros y mostrar el numero del medio, solo si existe. En caso de que no exista tambien informarlo
 ============================================================================
 */

#include <stdio.h>
#include <stdlib.h>

int main(void)

{
	setbuf(stdout,NULL);
	int i;
	int numeroIngresado;
	int numMaximo;
	int numMinimo;
	int numMedio;
	int banderaNumMedio;
	banderaNumMedio = 0;
	for (i = 0; i < 3; ++i)
	{
		printf("\n Ingrese un número\n");
		scanf("%d",&numeroIngresado);
		if(i == 0 || numeroIngresado >= numMaximo)
		{
			numMaximo = numeroIngresado;
		}
		else
		{
			if(i == 0 || numeroIngresado <= numMinimo)
			{
				numMinimo = numeroIngresado;
			}
			else
			{
				if(numeroIngresado > numMinimo && numeroIngresado<numMaximo)
				{
					numMedio = numeroIngresado;
					banderaNumMedio = 1;
				}
			}
		}

	}//FIN FOR
	if(banderaNumMedio != 1)
	{
	printf("\nEl número del medio es: %d",numMedio);
	}
	else
	{
		printf("\nNo hay numero del medio");
	}
	return EXIT_SUCCESS;
}
