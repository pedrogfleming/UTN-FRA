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
	int ret;
	if(punteroMenu != NULL && mensajeBienvenida != NULL)
	{
		int comandoLocal;
		comandoLocal = *punteroMenu;
		printf("%s",mensajeBienvenida);
		fflush(stdin);
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
		ret = -1;//Si recibe NULL como direcci�n de memoria del puntero, retorna -1
	}

	return ret;

}//FIN FUNCION mostrarMenu()
int confirmCommand(int* pMenu,char* message,char* eMessage,int tries)
{
	int ret = -1;
	int aux;
	char buffer;
	int i;
	if(pMenu != NULL &&  message != NULL && eMessage != NULL && tries >0 )
	{
		printf("\n %s \t",message);//Se le pide el tipo de dato a ingresar al usuario
		fflush(stdin);
		scanf("%c",&buffer);
		for (i = 0; i < tries; ++i)
		{
			aux = isdigit(buffer);
			buffer = tolower(buffer);
			if((buffer == 's' || buffer == 'n') && aux == 0)
			{

				*pMenu = buffer;
				ret = 0;
				break;
			}
			else//Error al ingrese el tipo de dato por fuera de los limites establecidos
			{
				printf("\n %s \t",eMessage);
				fflush(stdin);
				scanf("\n %c",&buffer);
			}

		}//FIN FOR
	}
	return ret;
}//FIN confirmCommand()
