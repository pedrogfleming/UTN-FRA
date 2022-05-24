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

int mostrarMenu(int* punteroMenu,int numeroA,int numeroB)
{
	int ret = -1;
	if(punteroMenu != NULL)
	{
		printf("\nIngrese comando para interactuar con el menú de la calculadora:\n"
				"1. Ingresar 1er operando (A=%d)\n"
				"2. Ingresar 2do operando (B=%d)\n"
				"3. Calcular todas las operaciones\n"
				"4. Informar resultados\n5. Salir\n",numeroA,numeroB);
		int comandoLocal;
		comandoLocal = *punteroMenu;
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
void confirmCommand(char* pMenu,char* message,char* eMessage)
{
	int aux;
	char buffer;
	char cancelCommand = 'n';
	char confirmCommand = 's';
	int exitCommand = 0;
	do
	{
		fflush(stdin);
		utn_getChar(&buffer, message, eMessage, cancelCommand, confirmCommand, 1);
		aux = isdigit(buffer);
		buffer = tolower(buffer);
		if((buffer == 's' || buffer == 'n') && aux == 0)
		{
			*pMenu = buffer;
			exitCommand = 1;
		}
		else
		{
			printf("\n %s \t",eMessage);
		}
	}while(exitCommand == 0);
}//FIN confirmCommand()
