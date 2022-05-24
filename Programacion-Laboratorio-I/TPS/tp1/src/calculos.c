/*
 * calculos.c
 *
 *  Created on: 11 abr. 2021
 *      Author: Pedro
 */
#include <stdio.h>
#include <stdlib.h>

int sumaDosOperadores(int numeroUno,int numeroDos,int* punteroResultado)
{

	int ret;
	int resultadoLocal;

	if(punteroResultado != NULL)
	{
		resultadoLocal = *punteroResultado;
		resultadoLocal = numeroUno+numeroDos;
		*punteroResultado = resultadoLocal;
		ret = 0;//Si logró sumar, retorna 0
		printf("\nSe ha calculado la suma entre los dos operandos\n");
	}
	else
	{
		ret = 1;//si la direccion de memoria es NULL, retorna 1
		printf("\nNo se ha podido calcular la suma entre los dos operandos\n");
	}

	return ret;
}//FIN sumaDosOperadores()
int restaDosOperadores(int numeroUno,int numeroDos,int* punteroResultado)
{

	int ret;
	int resultadoLocal;
	if(punteroResultado != NULL)
	{
		resultadoLocal = *punteroResultado;
		resultadoLocal = numeroUno-numeroDos;
		*punteroResultado = resultadoLocal;
		printf("\nSe ha calculado la resta entre los dos operandos\n");
		ret = 0;//Si logró restar, retorna 0
	}
	else
	{
		ret = 1;//si la direccion de memoria es NULL, retorna 1
		printf("\nNo se ha podido calcular la resta entre los dos operandos\n");
	}

	return ret;
}//restaDosOperadores
int divisionDosOperadores(int dividendo, int divisor,float* punteroResultado)
{
		int ret;
		if(punteroResultado != NULL)
		{
			float resultadoLocal;
			if(divisor != 0)
			{
				resultadoLocal = *punteroResultado;
				resultadoLocal = (float)dividendo/divisor;
				*punteroResultado = resultadoLocal;
				ret = 0;//Si logro dividir, retorna 0
				printf("\nSe ha calculado la division entre los dos operandos\n");
			}
			else
			{
				ret = -1;//si no se pudo dividir, retorna -1
				printf("\nNo se ha podido calcular la division entre los dos operandos\n");
			}
		}
		else
		{
			ret = 1;//si la direccion de memoria es NULL, retorna 1
			printf("\nNo se ha podido calcular la division entre los dos operandos\n");
		}

		return ret;
}//FIN divisionDosOperadores
int multiplicacionDosOperadores(int numeroUno,int numeroDos,int* punteroResultado)
{
	int ret;
	int resultadoLocal;
	if(punteroResultado != NULL)
	{
		resultadoLocal = *punteroResultado;
		resultadoLocal = numeroUno*numeroDos;
		*punteroResultado = resultadoLocal;
		ret = 0;//Si logró multiplicar, retorna 0
		printf("\nSe ha calculado la multiplicación entre los dos operandos\n");
	}
	else
	{
		ret = 1;//si la direccion de memoria es NULL, retorna 1
		printf("\nNo se ha podido calcular la multiplicación entre los dos operandos\n");
	}

	return ret;
}//FIN multiplicacionDosOperadores
int factorial(int numero,int* pResultado)
{
	int ret = -1;
	int i;
	int auxNumero;
	if(numero >= 0 && pResultado != NULL)
	{
		if(numero==1 || numero ==0)
		{
			*pResultado = 1;//Cuando el resultado de la operacion sea 1, se ha terminado de calcular el factorial
			ret = 0;
		}
		else
		{
			auxNumero = numero;
			for(i=numero;i>1;i--)
			{
				auxNumero = auxNumero*(i-1);

			}
			ret = 0;
			*pResultado = auxNumero;
		}
	}
	return ret;
}
int validarFactorial(int operando)
{
	int ret;
	ret = -1;
	if(operando >= 0 && operando < 13)
	{
		ret = 0;
	}
	else
	{
		if(operando < 0)
		{
			printf("\nNo se puede calcular el factorial de números negativos");
		}
		else
		{
			printf("\nError, no se puede calcular el factorial de %d debido a limitaciones técnicas.\n",operando);
		}
	}
	return ret;
}//FIN validarFactorial()
int calcularOperacionesSimples(int numeroA,int numeroB,int* punteroSuma,int* punteroResta,int* punteroMultiplicacion)
{
	int ret;
	if(punteroSuma != NULL && punteroResta != NULL && punteroMultiplicacion != NULL)
	{

		int sumaLocal;
		int restaLocal;
		int multiplicacionLocal;
		sumaLocal = *punteroSuma;
		restaLocal = *punteroResta;
		multiplicacionLocal = *punteroMultiplicacion;
		//a) Calcular la suma (A+B)
		sumaDosOperadores(numeroA,numeroB,&sumaLocal);
		*punteroSuma = sumaLocal;
		//Calcular la resta (A-B)
		restaDosOperadores(numeroA,numeroB,&restaLocal);
		*punteroResta = restaLocal;
		//d) Calcular la multiplicacion (A*B)
		multiplicacionDosOperadores(numeroA,numeroB,&multiplicacionLocal);
		*punteroMultiplicacion = multiplicacionLocal;
		ret = 0;
	}
	else
	{
		ret = -1;
		printf("\nf-Error de dirección de memoria");
	}
	return ret;
}//FIN calcularOperacionesSimples()
void mostrarResultados(int operandoA,int operandoB,int sumaResultado,int restaResultado,int flagDivision
		, float divisionResultado, int multiplicacionResultado,int factorialResultadoA,int flagFactorialA,int factorialResultadoB,int flagFactorialB)
{
	//a) “El resultado de A+B es: r”
	printf("\nEl resultado de %d+%d es: %d \n",operandoA,operandoB,sumaResultado);
	//b) “El resultado de A-B es: r”
	printf("El resultado de %d-%d es: %d \n",operandoA,operandoB,restaResultado);
	//c) “El resultado de A/B es: r” o “No es posible dividir por cero”
	if(flagDivision == 0)
	{
		printf("El resultado de %d/%d es: %.2f \n",operandoA,operandoB,divisionResultado);
	}
	else
	{
		printf("No es posible realizar la división por cero\n");
	}
	//d) “El resultado de A*B es: r”
	printf("El resultado de %d*%d es: %d \n",operandoA,operandoB,multiplicacionResultado);
	//e) “El factorial de A es: r1 y El factorial de B es: r2”
	if(flagFactorialA == 1)
	{
		printf("El factorial de %d! es :%d\n",operandoA,factorialResultadoA);
	}
	else
	{
		printf("No se ha podido calcular el factorial de %d(A)\n",operandoA);
	}
	if(flagFactorialB == 1)
	{
		printf("El factorial de %d! es :%d\n",operandoB,factorialResultadoB);
	}
	else
	{
		printf("No se ha podido calcular el factorial de %d(B)\n",operandoB);
	}
}//FIN mostrarResultados ()
