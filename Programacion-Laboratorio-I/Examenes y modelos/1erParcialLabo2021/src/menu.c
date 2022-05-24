/*
 * menu.c
 *
 *  Created on: 8 may. 2021
 *      Author: Pedro
 */
#include <ctype.h>
#include <stdio.h>
#include <stdlib.h>
#include "utn.h"
#include <string.h>

int mostrarMenu(int* punteroMenu,char* mensajeBienvenida)
{
	int ret = -1;
	if(punteroMenu != NULL && mensajeBienvenida != NULL)
	{
		int comandoLocal;
		comandoLocal = *punteroMenu;
		printf("%s",mensajeBienvenida);
		fflush(stdin);
		if(getInt(&comandoLocal) != 0)
		{
			printf("\nEl comando ingresado no es un numero");
		}
		else
		{
			*punteroMenu = comandoLocal;
			ret = 0;
		}
	}
	return ret;

}//FIN FUNCION mostrarMenu()
int confirmCommand(char* pMenu,char* message,char* eMessage,int tries)
{
	int ret = -1;
	int aux;
	char buffer;
	int i;
	char lowLimit = 'n';
	char hiLimit = 's';
	if(pMenu != NULL &&  message != NULL && eMessage != NULL && tries >0 )
	{
		for (i = 0; i < tries; i++)
		{
			fflush(stdin);
			utn_getChar(&buffer, message, eMessage, lowLimit, hiLimit, 3);
			aux = isdigit(buffer);
			buffer = tolower(buffer);
			if((buffer == 's' || buffer == 'n') && aux == 0)
			{
				*pMenu = buffer;
				ret = 0;
				break;
			}
			else
			{
				printf("\n %s \t",eMessage);
			}

		}//FIN FOR
	}
	return ret;
}//FIN confirmCommand()
