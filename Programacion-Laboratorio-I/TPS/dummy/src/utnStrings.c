/*
 * utnStrings.c
 *
 * Created on: 27 abr. 2021
 * 	Author: Pedro
 *
 *
 */
#include <stdio.h>
#include <stdlib.h>
#include <string.h>

int getInt(int* pResultado)
{
	int retorno = -1;
	char buffer[64];
	if(pResultado != NULL)
	{
			if(myGets(buffer,sizeof(buffer)) == 0 && esNumerica(buffer))
			{
				*pResultado = atoi(buffer);
				retorno = 0;
			}
	}
	return retorno;
}//fin getInt()
int myGets(char* cadena,int longitud)
{
	int retorno = -1;
	if(cadena != NULL && longitud > 0 && fgets(cadena,longitud,stdin) == cadena)
	{
		fflush(stdin);//LINUX >>> __fpurge o WINDOWS >>>> fflush o MAC >>> fpurge
		if(cadena[strlen(cadena)-1] == '\n')
		{
			cadena[strlen(cadena)-1] = '\0';
		}
		retorno = 0;
	}
	return retorno;
}//fin myGets()
int esNumerica(char* cadena)
{
	int i=0;
	int retorno = 1;
	if(cadena != NULL && strlen(cadena)>0)
	{
		while(cadena[i] != '\0')
		{
			if(cadena[i] < '0' || cadena[i] > '9')
			{
				retorno = 0;
				break;
			}
			i++;
		}
	}
	return retorno;
}//fin esNumerica()

