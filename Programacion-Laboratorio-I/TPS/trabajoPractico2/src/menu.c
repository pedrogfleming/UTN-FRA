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

void mostrarMenu(int* punteroMenu,char* mensajeBienvenida,int  maximo)
{

	int exit;
	exit = -1;
	if(punteroMenu != NULL && mensajeBienvenida != NULL)
	{
		do
		{
			int comandoLocal;
			comandoLocal = *punteroMenu;
			fflush(stdin);
			if(utn_getNumero(&comandoLocal, mensajeBienvenida, "\nEl comando ingresado no esta dentro del rango solicitado", 0, maximo, 3) == 0)
			{
				*punteroMenu = comandoLocal;
				exit = 0;
			}
			else
			{
				printf("\nSolo se aceptan numeros según las opciones ofrecidas. Le volveremos a mostrar el menu para que seleccione la opcion qu desea realizar");
				system("pause");
			}
		}while (exit == -1);

	}
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
		for (i = 0; i < tries; ++i)
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
			else//Error al ingrese el tipo de dato por fuera de los limites establecidos
			{
				printf("\n %s \t",eMessage);
				system("pause");
			}

		}//FIN FOR
	}
	return ret;
}//FIN confirmCommand()
/*
void continueMenu(void)
{
	char anyKey;
	printf("\n\nIngrese cualquier tecla para continuar...\n");
	fflush(stdin);
	gets(anyKey);
}*/
