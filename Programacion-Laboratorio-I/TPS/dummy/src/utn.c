/*
 * utn.c
 *
 *  Created on: 27 abr. 2021
 *      Author: Pedro
 */

#ifndef UTN_C_
#define UTN_C_
#include <stdio.h>
#include <stdlib.h>
#include "utn.h"
#include "calculos.h"
#include "ctype.h"
#include "utnStrings.h"

#include <stdio.h>
#include <stdlib.h>
#include "utn.h"
#include "calculos.h"
#include "ctype.h"
#include "utnStrings.h"

int mostrarMenu(int* punteroMenu,int numeroUno, int numeroDos)
{
	int ret;
	if(punteroMenu != NULL)
	{
		int comandoLocal;
		comandoLocal = *punteroMenu;
		printf("\nIngrese comando para interactuar con el menú de la calculadora: \n1. Ingresar 1er operando (A=%d)\n2. Ingresar 2do operando (B=%d)\n3. Calcular todas las operaciones\n4. Informar resultados\n5. Salir\n",numeroUno,numeroDos);
		scanf("%d",&comandoLocal);
		if(isdigit(comandoLocal) != 0)//Valido que sea un numero
		{
			fflush(stdin);
			printf("\nEl comando ingresado no es un numero");
			ret = -1;
		}
		else//Solo si es un numero guardo el valor en el puntero
		{
			*punteroMenu = comandoLocal;
		}

		ret = 0;
	}
	else
	{
		ret = -1;//Si recibe NULL como dirección de memoria del puntero, retorna -1
	}

	return ret;

}//FIN FUNCION mostrarMenu()
int utn_getNumero(int* pResultado,char* mensaje, char* mensajeError,int minimo,int maximo,int reintentos)
{
	int bufferInt;
	int retorno = -1;
	while(reintentos>0)
	{
		reintentos--;
		printf("%s",mensaje);
		if(getInt(&bufferInt) == 0)
		{
			if(bufferInt >= minimo && bufferInt <= maximo)
			{
				*pResultado = bufferInt;
				retorno = 0;
				break;
			}
		}
		printf("%s",mensajeError);
	}
	return retorno;
}//FIN utn_getNumero​()

#endif /* UTN_C_ */
