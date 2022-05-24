/*
 ============================================================================
 Name        : clase1ej2.c
 Author      : Geraghty Fleming Pedro 1E
 Version     : Ejercicio 2
 Copyright   : Your copyright notice
 Description : Ingresar 5 n�meros. Determinar cu�l es el m�ximo y el m�nimo
 	 	 	 	 e indicar en qu� orden fue ingresado.

 ============================================================================
 */

#include <stdio.h>
#include <stdlib.h>

int main(void)
{
	setbuf(stdout,NULL);
	//fflush(stdin);
	int numeroIngresado;
	int i;
	int numeroMaximo;
	int numeroMinimo;
	int ordenIngresadoMaximo;
	int ordenIngresadoMinimo;

	for (i = 0; i < 5; ++i)
	{
		printf("Ingrese un n�mero\n");
		scanf("%d",&numeroIngresado);

		if(i == 0 || numeroIngresado > numeroMaximo)
		{
			numeroMaximo = numeroIngresado;
			ordenIngresadoMaximo = i;
		}
		else
		{
			if(i == 0 || numeroIngresado < numeroMinimo)
			{
				numeroMinimo = numeroIngresado;
				ordenIngresadoMinimo = i;
			}
		}


	}
	printf("\nEl n�umero m�ximo ingresado es %d y su orden de ingreso fue %d",numeroMaximo,ordenIngresadoMaximo);
	printf("\nEl n�mero m�nimo ingresado es %d y su orden de ingreso fue %d",numeroMinimo,ordenIngresadoMinimo);




	return EXIT_SUCCESS;
}
