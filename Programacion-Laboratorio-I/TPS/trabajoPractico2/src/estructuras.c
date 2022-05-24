/*
 * estructuras.c
 *
 *  Created on: 8 may. 2021
 *      Author: Pedro
 */
#include <ctype.h>
#include <stdio.h>
#include <stdlib.h>
#include "utn.h"
#include <string.h>
#include "estructuras.h"
#include "calculos.h"
#include "menu.h"

int inicializarEstructura(employee arrayStruc[],int lengArray)
{
	int i;
	int ret;
	ret = -1;
	if(arrayStruc != NULL && lengArray >0)
	{

		for (i = 0; i < lengArray; ++i)
		{
			arrayStruc[i].isEmpty=1;

		}
		ret = 0;
	}
	return ret;
}//FIN inicializarEstructura()
int bajaEstructura(employee arrayStruc[],int posicion)
{
	int ret;
	ret = -1;
	char userConfirm;
	if(arrayStruc != NULL && posicion > -1)
	{
		mostrarEstructura(arrayStruc,posicion);
		printf("\nEste es el empleado solicitado");
		confirmCommand(&userConfirm, "\n¿Está seguro que desea eliminar al empleado seleccionado?", "\nError, sólo ingrese s/n", 3);
		if(userConfirm == 's')
		{
			arrayStruc[posicion].isEmpty = 1;
			ret = 0;
		}
	}
	if(ret == -1)
	{
		printf("\nSe ha abortado la operación");
	}
	return ret;
}//FIN bajaEstructura()
int altaEstructura(employee arrayStruc[],int* punteroLegajo,int lengArray)
{
	int ret;
	employee auxiliarStruc;
	ret = -1;
	int idAuxiliar;
	if(arrayStruc != NULL && punteroLegajo != NULL)
	{
			fflush(stdin);
			if((utn_getString(auxiliarStruc.firsNameEmployee,51,"\nIngrese nombre del empleado","\nError, ha ingresado un nombre inválido",3,3) != 0) ||
			(utn_getString(auxiliarStruc.lastNameEmployee,51,"\nIngrese apellido del empleado","\nError, ha ingresado un apellido inválido",3,3) != 0)  ||
			 (utn_getFloat(&auxiliarStruc.salaryEmployee,"\nIngrese salario del empleado","\nError, ingrese un salario válido para el empleado",23000,9999999,3) != 0 ||
			(utn_getNumero(&auxiliarStruc.sectorId,"\nIngrese id del sector","\nError, ingrese un numero de ID válido",1000,2000,3) != 0)))
			{
				printf("\nSe ha abortado el alta del empleado debido a un error en la carga. Volverá al menu principal");
			}
			else
			{
				//Una vez confirmado que todos los datos ingresados son correctos, los cargo en el array
				idAuxiliar = *punteroLegajo;
				if(addEmployee(arrayStruc,lengArray,idAuxiliar,auxiliarStruc.firsNameEmployee,auxiliarStruc.lastNameEmployee,auxiliarStruc.salaryEmployee,auxiliarStruc.sectorId))
				{
					printf("\nF-Error en la carga de datos\n");
				}
				else
				{
					printf("\nSe ha cargado exitosamente al empleado\n");


					(*punteroLegajo)++;
					ret = 0;
				}
			}
	}
	return ret;
}//FIN AltaEstructura()
int modificarEstructura(employee arrayStruc[],int posicion,int campoModificar)
{
	int ret;
	ret = -1;
	int errorFlag;
	char confirm;
	errorFlag = 0;

	if(arrayStruc != NULL && posicion > -1)
	{
			switch (campoModificar)
			{
				case 1:
					if(utn_getString(arrayStruc[posicion].firsNameEmployee,20,"\nIngrese nombre del empleado","\nError, ha ingresado nombre del empleado invalido",3,3) != 0)
					{
						errorFlag = 1;
					}
					break;
				case 2:
					if(utn_getString(arrayStruc[posicion].lastNameEmployee,20,"\nIngrese apellido del empleado","\nError, ha ingresado un apellido del empleado invalido",3,3) != 0)
					{
						errorFlag = 1;
					}
					break;
				case 3:
					if(utn_getFloat(&arrayStruc[posicion].salaryEmployee,"\nIngrese salario del empleado","\nError, ingrese un salario válido para el empleado",23000,9999999,3) != 0)
					{
						errorFlag = 1;
					}
					break;
				case 4:
					if(utn_getNumero(&arrayStruc[posicion].sectorId, "\nIngrese id del sector","\nError, ingrese un numero de ID válido",1000,2000,3) != 0)
					{
						errorFlag = 1;
					}
					break;
				default:
					printf("\nError, ha ingresado un comando invalido. Volvera al menu principal.");
					break;
			}//FIN SWITCH
			if(errorFlag == 0)
			{
				confirmCommand(&confirm,"\n¿Desea confirmar la accion?s/n","\nError, ingrese solo s/n",3);
				if(confirm == 's')
				{
					ret = 0;
				}
				else
				{
					printf("\nAbortada la operación");
				}

			}
	}
	return ret;
}
//*************************************BUSCAR EN ARRAY DE ESTRUCTURA*********************************************************
int buscarLibre(employee arrayStruc[],int lengArray)
{
	int ret;
	int i;
	ret = -1;
	if(arrayStruc != NULL && lengArray > 0)
	{
		for (i = 0; i < lengArray; i++)
		{
			if(arrayStruc[i].isEmpty==1)
			{
				ret = i;
				break;
			}
		}//FIN FOR
	}
	return ret;
}//FIN buscarLibre
int buscarLegajo(employee arrayStruc[],int lengArray)
{
	int ret;
	ret = -1;
	int idBusqueda;
	int posicionEncontrada;
	if(arrayStruc != NULL && lengArray > 0 )
	{
			if(utn_getNumero(&idBusqueda,"\nIngrese el ID a buscar","\nError, ingrese un ID valido",1000,2000,3) == 0)
			{
				posicionEncontrada = findEmployeeById(arrayStruc,lengArray,idBusqueda);
				if(posicionEncontrada != -1)
				{
					ret = posicionEncontrada;
				}
			}
			else
			{
				printf("\nHa agotado el número de intentos para ingresar el legajo. Volverá al menu principal");
			}


	}
	return ret;
}
	//FIN buscarLegajo()


//*************************************RELACIONAR DOS ARRAYS DE ESTRUCTURAS*********************************************************

//*************************************ORDENAR ARRAY DE ESTRUCTURAS*********************************************************

int ordenarAscendentemente_Entero_Cadena(employee arrayStruct[],int lengArray)
{
	int ret;
	ret = -1;
	int i;
	int j;
	int lengAux;
	employee auxiliarStruc;
	if(arrayStruct != NULL && lengArray > 0)
	{
		for (i = 0; i < lengArray-1; i++)
		{
			for (j = i+1; j < lengArray; j++)
			{
				if(arrayStruct[i].sectorId == arrayStruct[j].sectorId)
				{
					lengAux = sizeof(arrayStruct[i].lastNameEmployee);
					//printf("\n %d",lengAux);
					if(strncmp(arrayStruct[i].lastNameEmployee,arrayStruct[j].lastNameEmployee,lengAux) > 0)
					{
						auxiliarStruc = arrayStruct[i];
						arrayStruct[i] = arrayStruct[j];
						arrayStruct[j] = auxiliarStruc;
					}
				}
				else
				{
					if(arrayStruct[i].sectorId < arrayStruct[j].sectorId)
					{
						auxiliarStruc = arrayStruct[i];
						arrayStruct[i] = arrayStruct[j];
						arrayStruct[j] = auxiliarStruc;
					}
				}
			}
		}//FIN FOR i
		ret = 0;
	}
	return ret;
}//FIN ordenarAscendentemente_Entero_Cadena()
int ordenarDescendentemente_Entero_Cadena(employee arrayStruct[],int lengArray)
{
	int ret;
	ret = -1;
	int i;
	int j;
	employee auxStruct;
	int lengAux;
	if(arrayStruct != NULL && lengArray > 0)
	{
		for (i = 0; i < lengArray-1; i++)
		{
			for (j = i+1; j < lengArray; j++)
			{

				if(arrayStruct[i].sectorId == arrayStruct[j].sectorId)
				{

					lengAux = sizeof(arrayStruct[i].lastNameEmployee);
					printf("\n %d",lengAux);
					if(strncmp(arrayStruct[i].lastNameEmployee,arrayStruct[j].lastNameEmployee,lengAux) < 0)
					{

						//swaps for last lastname when id sector are the same
						auxStruct = arrayStruct[i];
						arrayStruct[i] = arrayStruct[j];
						arrayStruct[j] = auxStruct;
					}


				}
				else
				{
					printf("\nElse...");
					if(arrayStruct[i].sectorId > arrayStruct[j].sectorId)
					{

						//swap for sector id
						auxStruct = arrayStruct[i];
						arrayStruct[i] = arrayStruct[j];
						arrayStruct[j] = auxStruct;
					}
				}
			}
		}//FIN FOR i
		ret = 0;
	}
	return ret;
}//FIN ordenarDescendentemente_Entero_Cadena()



//*************************************MOSTRAR ESTRUCTURAS********************************************************************

int mostrarArrayEstructuras(employee arrayStruc[],int lengArray)
{
	int i;
	int ret;
	ret = -1;
	if(arrayStruc != NULL && lengArray > 0)
	{
		for (i = 0; i < lengArray; i++)
		{

			if(arrayStruc[i].isEmpty == 0)
			{
				mostrarEstructura(arrayStruc,i);
			}
		}//FIN FOR
		ret = 0;
	}
	return ret;
}//mostrarArrayEstructura
void mostrarEstructura(employee arrayStruc[],int posicion)
{
	if(arrayStruc != NULL && posicion > -1)
	{
		printf("\n:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::\n");
		printf("   ID        FIRST NAME        LAST NAME        SALARY      SECTOR ID     ");
		printf("\n:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::\n");

		printf("%8d      %12s	    %2s        %4.2f       %6d       \t",
					arrayStruc[posicion].idEmployee
					,arrayStruc[posicion].firsNameEmployee
					,arrayStruc[posicion].lastNameEmployee
					,arrayStruc[posicion].salaryEmployee
					,arrayStruc[posicion].sectorId);
		printf("\n:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::\n");
	}
}//FIN mostrarEstructura()





