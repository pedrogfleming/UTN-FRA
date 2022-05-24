#include <ctype.h>
#include <stdio.h>
#include <stdlib.h>
#include "utn.h"
#include <string.h>

#include "contribuyente.h"
#include "menu.h"

int inicializarEstructuraContribuyente(contribuyente arrayStruc[],int lengArray)
{
	int i;
	int ret;
	ret = -1;
	if(arrayStruc != NULL && lengArray >0)
	{
		for (i = 0; i < lengArray; i++)
		{
			arrayStruc[i].isEmpty=1;
		}
		ret = 0;
	}
	return ret;
}//FIN inicializarEstructuraPantalla()
int altaContribuyente(contribuyente arrayStruc[],int* idContribuyente,int lengArray,int posicion)
{
	char confirmar;
	int ret;
	contribuyente auxiliarStruc;
	ret = -1;
	if(arrayStruc != NULL && idContribuyente != NULL && posicion > -1 && lengArray > 0)
	{
			fflush(stdin);
			if((utn_getString(auxiliarStruc.nombre,20,"\nIngrese nombre del contribuyente","\nError, ha ingresado un nombre del contribuyente invalido\n",3,3) != 0) ||
			(utn_getString(auxiliarStruc.apellido,20,"\nIngrese apellido del contribuyente","\nError, ha ingresado un apellido invalido\n",3,3) != 0)  ||
			 (utn_getCuit(auxiliarStruc.cuil,"\nIngrese CUIL del contribuyente","\nError, ingrese un CUIL del contribuyente\n",3) != 0))
			{
				printf("\nSe ha abortado el alta del contribuyente debido a un error en la carga. Volvera al menu principal");
			}
			else
			{
					confirmCommand(&confirmar,"\n¿Desea confirmar la accion?s/n","\nError, ingrese solo s/n ",3);
					if(confirmar == 's')
					{
						arrayStruc[posicion] = auxiliarStruc;
						arrayStruc[posicion].idContribuyente = *idContribuyente;
						(*idContribuyente)++;
						arrayStruc[posicion].isEmpty = 0;
						ret = 0;
					}
					else
					{
						printf("\nAbortada la operación");
					}

			}

	}

	return ret;
}//FIN AltaEstructura()
int bajaContribuyente(contribuyente arrayContribuyentes[],int posicion)
{
	int ret;
	ret = -1;
	if(arrayContribuyentes != NULL && posicion > -1)
	{

		arrayContribuyentes[posicion].isEmpty = 1;
		ret = 0;
	}
	if(ret != 0)
	{
		printf("\nError, no se pudo realizar la baja");
	}
	return ret;
}//FIN bajaEstructura()
int hayConstribuyentes(contribuyente arrayContribuyentes[],int lengArray)
{
	int ret = -1;
	int i;
	if(arrayContribuyentes != NULL && lengArray > 0)
	{
		for (i = 0; i < lengArray; i++)
		{
			if(arrayContribuyentes[i].isEmpty == 0)
			{
				ret = 0;
				break;
			}
		}
	}
	if(ret != 0)
	{
		printf("\nNo existen contribuyentes cargados en la base de datos.Primero deberá dar de alta uno para poder realizar la gestión solicitada");
	}
	return ret;
}//FIN hayConstribuyentes;
int modificarContribuyente(contribuyente arrayContribuyentes[],int lengArray,int posicion,int campoModificar)
{
	int ret;
	ret = -1;
	int banderaError;
	char confirmar;
	banderaError = 0;

	if(arrayContribuyentes != NULL && posicion > -1 && lengArray> 0)
	{
			switch (campoModificar)
			{
				case 1:
					if(utn_getString(arrayContribuyentes[posicion].nombre,20,"\nIngrese nombre del contribuyente","\nError, ha ingresado nombre del contribuyente invalido",3,3) != 0)
					{
						banderaError = 1;
					}
					break;
				case 2:
					if(utn_getString(arrayContribuyentes[posicion].apellido,20,"\nIngrese apellido del contribuyente","\nError, ha ingresado un apellido del contribuyente invalido",3,3) != 0)
					{
						banderaError = 1;
					}
					break;
				case 3:
					if(utn_getCuit(arrayContribuyentes[posicion].cuil, "\nIngrese cuil del contribuyente", "\nError, ha ingresado un cuil del contribuyente invalido. ", 3) != 0)
					{
						banderaError = 1;
					}
					break;
				default:
					printf("\nError, ha ingresado un comando invalido. Volvera al menu principal.");
					break;
			}//FIN SWITCH
			if(banderaError == 0)
			{
				confirmCommand(&confirmar,"\n¿Desea confirmar la accion?s/n","\nError, ingrese solo s/n",3);
				if(confirmar == 's')
				{
					printf("\nSe ha modificado con exito el campo solicitado");
					ret = 0;
					mostrarContribuyente(arrayContribuyentes,posicion);
				}
				else
				{
					printf("\nAbortada la operación");
				}

			}
	}
	return ret;
}//modificarPantalla()
int existeContribuyente(contribuyente arrayContribuyente[],int lengArray,int* idContribuyente,int maximoId)
{
	int ret = -1;
	int i;
	int auxId;
	if(arrayContribuyente != NULL && lengArray > 0 && idContribuyente != NULL)
	{
		printf("\nSe listarán a continuación todos los contribuyentes cargados en el sistema:\n");
		mostrarArrayContribuyentes(arrayContribuyente, lengArray);
		if(utn_getNumero(&auxId, "\nIngrese numero de id del contribuyente al que se le asociara las recaudaciones", "\nError, ingrese sólo el número de ID del contribuyente", 1000, maximoId, 3)== 0)
		{
			for (i = 0; i < lengArray; i++)
			{

				if(arrayContribuyente[i].isEmpty == 0 && auxId == arrayContribuyente[i].idContribuyente)
				{
					ret = 0;
					*idContribuyente = auxId;
					break;
				}
			}//FIN FOR
			if(ret != 0)
			{
				printf("\nNo existe en la base de datos el ID contribuyente ingresado. Volverá al menu principal");
			}
		}

	}
	return ret;
}//FIN zeroEmployees;
int mostrarArrayContribuyentes(contribuyente arrayStruc[],int lengArray)
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
				mostrarContribuyente(arrayStruc,i);
				ret = 0;
			}
		}//FIN FOR

	}
	return ret;
}//mostrarArrayEstructura
void mostrarContribuyente(contribuyente arrayStruc[],int posicion)
{
	if(arrayStruc != NULL && posicion > -1)
	{

		printf("\n:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::\n");
		printf("   ID CONTRIBUYENTE        NOMBRE        APELLIDO                             CUIL");
		printf("\n:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::\n");

		printf("\n\t %-3d 		%-20s %-28s %s\n",
					arrayStruc[posicion].idContribuyente
					,arrayStruc[posicion].nombre
					,arrayStruc[posicion].apellido
					,arrayStruc[posicion].cuil);
		printf("\n:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::\n");


	}
}//FIN mostrarEstructura()
int buscarIdContribuyente(contribuyente arrayStruc[],int lengArray,int idMaximo)
{
	int ret;
	int i;
	ret = -1;
	int idBusqueda;
	if(arrayStruc != NULL && lengArray > 0)
	{
			printf("\nSe listarán a continuación todos los contribuyentes cargados en el sistema\n");
			mostrarArrayContribuyentes(arrayStruc, lengArray);
			printf("\nIngrese el ID a buscar");
			if(getInt(&idBusqueda) == 0 )
			{
				if(idBusqueda <= idMaximo)
				{
					for (i = 0; i < lengArray; i++)
					{
						if(arrayStruc[i].isEmpty==0 && arrayStruc[i].idContribuyente == idBusqueda)
						{
							ret = i;
							break;
						}
					}//FIN FOR
				}
			}
	}
	if(ret == -1)
	{
		printf("\n No existe el ID solicitado");
	}
	return ret;
}//FIN buscarIdContribuyente()
int buscarContribuyenteLibre(contribuyente arrayStruc[],int lengArray)
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
int get_PosicionContribuyentePorId(contribuyente arrayStruc[],int arrayLeng,int* posicionContribuyente,int idContribuyente)
{
	int ret;
	int i;
	ret = -1;
	if(arrayStruc != NULL && arrayLeng > 0 &&idContribuyente > 999 && posicionContribuyente != NULL)
	{
		for (i = 0; i < arrayLeng; i++)
		{
			if(idContribuyente == arrayStruc[i].idContribuyente)
			{
				*posicionContribuyente = i;
				ret = 0;
				break;
			}
		}

	}
	return ret;
}//FIN get_IdContribuyentePorPosicionRecaudacion()
int ordenarContribuyentes(contribuyente arrayStruc[],int lengArray,int order)
{
	//order int [1] indicates UP -[0] indicates DOWN
	int ret = -1;

	if(lengArray > 0 && (order == 0 || order == 1))
	{
		if(order == 0)
		{
			ordenarAscendentemente_Contribuyentes(arrayStruc,lengArray);			//UP
			printf("\nSe ha ordenado de manera ascendente a los empleados");
			mostrarArrayContribuyentes(arrayStruc, lengArray);
			ret = 0;
		}
		else
		{
			ordenarDescendentemente_Entero_Cadena(arrayStruc,lengArray);			//DOWN
			printf("\nSe ha ordenado de manera descendente a los empleados");
			mostrarArrayContribuyentes(arrayStruc,lengArray);
			ret = 0;
		}
	}
	return ret;
}//FIN sortEmployees()
int ordenarAscendentemente_Contribuyentes(contribuyente arrayStruc[],int lengArray)
{
	int ret;
	ret = -1;
	int i;
	int j;
	int lengAux;
	contribuyente auxiliarStruc;
	if(arrayStruc != NULL && lengArray > 0)
	{
		for (i = 0; i < lengArray-1; i++)
		{
			for (j = i+1; j < lengArray; j++)
			{
				if(arrayStruc[i].idContribuyente == arrayStruc[j].idContribuyente)
				{
					lengAux = sizeof(arrayStruc[i].apellido);
					//printf("\n %d",lengAux);
					if(strncmp(arrayStruc[i].apellido,arrayStruc[j].apellido,lengAux) > 0)
					{
						auxiliarStruc = arrayStruc[i];
						arrayStruc[i] = arrayStruc[j];
						arrayStruc[j] = auxiliarStruc;
					}
				}
				else
				{
					if(arrayStruc[i].idContribuyente < arrayStruc[j].idContribuyente)
					{
						auxiliarStruc = arrayStruc[i];
						arrayStruc[i] = arrayStruc[j];
						arrayStruc[j] = auxiliarStruc;
					}
				}
			}
		}//FIN FOR i
		ret = 0;
	}
	return ret;
}//FIN ordenarAscendentemente_Entero_Cadena()
int ordenarDescendentemente_Entero_Cadena(contribuyente arrayStruc[],int lengArray)
{
	int ret;
	ret = -1;
	int i;
	int j;
	contribuyente auxStruct;
	int lengAux;
	if(arrayStruc != NULL && lengArray > 0)
	{
		for (i = 0; i < lengArray-1; i++)
		{
			for (j = i+1; j < lengArray; j++)
			{

				if(arrayStruc[i].idContribuyente == arrayStruc[j].idContribuyente)
				{

					lengAux = sizeof(arrayStruc[i].apellido);
					printf("\n %d",lengAux);
					if(strncmp(arrayStruc[i].apellido,arrayStruc[j].apellido,lengAux) < 0)
					{

						//swaps for last lastname when id sector are the same
						auxStruct = arrayStruc[i];
						arrayStruc[i] = arrayStruc[j];
						arrayStruc[j] = auxStruct;
					}


				}
				else
				{
					printf("\nElse...");
					if(arrayStruc[i].idContribuyente > arrayStruc[j].idContribuyente)
					{

						//swap for sector id
						auxStruct = arrayStruc[i];
						arrayStruc[i] = arrayStruc[j];
						arrayStruc[j] = auxStruct;
					}
				}
			}
		}//FIN FOR i
		ret = 0;
	}
	return ret;
}//FIN ordenarDescendentemente_Entero_Cadena()
