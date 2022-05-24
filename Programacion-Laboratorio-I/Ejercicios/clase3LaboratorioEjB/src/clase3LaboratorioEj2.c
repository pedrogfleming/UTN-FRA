/*
 ============================================================================
 Name        : clase3LaboratorioEj2.c
 Author      : Geraghty Fleming Pedro 1E
 Version     :
 Copyright   : Your copyright notice
 Description : b-Funciones
				- Limpie la pantalla
				x- Asigne a las variables numero1 y numero2 los valores solicitados al usuario
				x- Valide los mismos entre 10 y 100
				x- Asigne a la variable operacion el valor solicitado al usuario
				x- Valide el mismo 's'-sumar, 'r'-restar
				- Realice la operación de dichos valores a través de una función
				- Muestre el resultado por pantalla
 ============================================================================
 */

#include <stdio.h>
#include <stdlib.h>
void validarNumeros(int numeroIngresado);
void validarOperacion(char operacionRecibida);
int operacionSuma(int valorUno,int valorDos);
int operacionResta(int valorUno,int valorDos);

int main(void)
{
	setbuf(stdout,NULL);
	int numeroUno;
	int numeroDos;
	char tipoOperacion;

	printf("Ingrese el primer número (entre 10 y 100)\n");
	scanf("%d",&numeroUno);
	validarNumeros(numeroUno);
	printf("\nIngrese el segundo número(entre 10 y 100)\n");
	scanf("%d",&numeroDos);
	validarNumeros(numeroDos);
	printf("\nElija suma(s) o resta(r)\n");
	fflush(stdin);
	scanf("%c",&tipoOperacion);
	validarOperacion(tipoOperacion);
	if(tipoOperacion == 's')
	{
		operacionSuma(numeroUno,numeroDos);
	}
	else
	{
		operacionResta(numeroUno,numeroDos);
	}


	return EXIT_SUCCESS;
}//FIN MAIN
//COMIENZA EL DESARROLLO DE LAS FUNCIONES
void validarNumeros(int numeroIngresado)
{
	while(numeroIngresado < 10 || numeroIngresado > 100)
	{
		printf("\nError-f1, reingrese número entre 10 y 100\n");
		scanf("%d",&numeroIngresado);
	}
	printf("El %d es válido",numeroIngresado);

}
void validarOperacion(char operacionRecibida)
{
	while(operacionRecibida !='s' && operacionRecibida != 'r')
	{
		printf("Error-f2, reingrese operación a realizar. Suma(s) o resta(r)\n");
		fflush(stdin);
		scanf("%c",&operacionRecibida);
	}
	printf("La operación recibida es válida");
}
int operacionSuma(int valorUno,int valorDos)
{
	int resultadoSuma;
	resultadoSuma = valorUno+valorDos;
	printf("\nEl resultado de la suma es: %d",resultadoSuma);
	return resultadoSuma;
}
int operacionResta(int valorUno,int valorDos)
{
	int resultadoResta;
	resultadoResta = valorUno-valorDos;
	printf("\nEl resultado de la resta es: %d",resultadoResta);
	return resultadoResta;
}
