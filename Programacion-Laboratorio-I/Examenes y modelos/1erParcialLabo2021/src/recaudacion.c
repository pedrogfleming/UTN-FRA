#include <ctype.h>
#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include "utn.h"
#include "recaudacion.h"
#include "menu.h"

int inicializarEstructuraRecaudacion(recaudacion arrayStruc[],int lengArray)
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
int altaRecaudacion(recaudacion arrayStruc[],int* idRecaudacion,int lengArrayRecaudacion,int posicion,int idContribuyente)
{
	char confirmar;
	int ret;
	recaudacion auxiliarStruc;
	ret = -1;
	if(arrayStruc != NULL && idRecaudacion != NULL && posicion > -1 && lengArrayRecaudacion > 0 && idContribuyente >= 1000 && idContribuyente <= 2000)
	{
			fflush(stdin);
			if((utn_getNumero(&auxiliarStruc.mes,"\nIngrese mes de la recaudacion","\nError, ha ingresado un mes de la recaudacion invalido",1,12,3) != 0) ||
			(utn_getNumero(&auxiliarStruc.tipo,"\nIngrese tipo de recaudacion: \n1-ARBA\n2-IIBB\n3-GANANCIAS","\nError, ha ingresado un tipo de recaudacion invalido. Ingrese: \n1-ARBA\n2-IIBB\n3-GANANCIAS ",1,3,3) != 0)  ||
			 (utn_getFloat(&auxiliarStruc.importe,"\nIngrese importe de la recaudacion","\nError, ingrese un importe de la recaudacion valido",1,99999999999,3) != 0))
			{
				printf("\nSe ha abortado el alta de la recaudacion debido a un error en la carga. Volvera al menu principal");
			}
			else
			{
				confirmCommand(&confirmar,"\n¿Desea confirmar la accion?s/n","\nError, ingrese solo s/n ",3);
				if(confirmar == 's')
				{
					arrayStruc[posicion] = auxiliarStruc;
					arrayStruc[posicion].idContribuyente = idContribuyente;
					arrayStruc[posicion].idRecaudacion = *idRecaudacion;
					arrayStruc[posicion].estado =2;
					(*idRecaudacion)++;
					arrayStruc[posicion].isEmpty = 0;
					asignarDescripcionEstadoRecaudacion(arrayStruc,posicion);
					asignarDescripcionTipo(arrayStruc,posicion);
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
int bajaRecaudacion(recaudacion arrayRecaudacions[],int posicion)
{
	int ret;
	ret = -1;
	if(arrayRecaudacions != NULL && posicion > -1)
	{

		arrayRecaudacions[posicion].isEmpty = 1;
		ret = 0;
	}
	return ret;
}//FIN bajaEstructura()
int refinanciarRecaudacion(recaudacion arrayRecaudaciones[],int posicion)
{
	int ret;
	ret = -1;
	char confirmar;

	if(arrayRecaudaciones != NULL && posicion > -1)
	{

				confirmCommand(&confirmar,"\n¿Desea refinanciar la recaudacion del solicitada?s/n","\nError, ingrese solo s/n",3);
				if(confirmar == 's')
				{
					printf("\nSe ha modificado con exito el campo solicitado");
					arrayRecaudaciones[posicion].estado = 1;
					asignarDescripcionEstadoRecaudacion(arrayRecaudaciones,posicion);
					ret = 0;
				}
				else
				{
					printf("\nAbortada la operación");
				}


	}
	return ret;
}//refinanciarRecaudacion()
int saldarRecaudacion(recaudacion arrayRecaudaciones[],int posicion)
{
	int ret;
	ret = -1;
	char confirmar;

	if(arrayRecaudaciones != NULL && posicion > -1)
	{

				confirmCommand(&confirmar,"\n¿Desea saldar la recaudacion del solicitada?s/n","\nError, ingrese solo s/n",3);
				if(confirmar == 's')
				{
					printf("\nSe ha modificado con exito el campo solicitado");
					arrayRecaudaciones[posicion].estado = 0;
					asignarDescripcionEstadoRecaudacion(arrayRecaudaciones,posicion);
					ret = 0;
				}
				else
				{
					printf("\nAbortada la operación");
				}


	}
	return ret;
}//refinanciarRecaudacion()
int hayRecaudaciones(recaudacion arrayStruc[],int lengArray)
{
	int ret = -1;
	int i;
	if(arrayStruc != NULL && lengArray > 0)
	{
		for (i = 0; i < lengArray; i++)
		{
			if(arrayStruc[i].isEmpty == 0)
			{
				ret = 0;
				break;
			}
		}
	}
	if(ret != 0)
	{
		printf("\nNo existen recaudaciones en la base de datos, deberá antes dar de alta una recaudación para poder realizar la gestión");
	}
	return ret;
}//FIN hayConstribuyentes;

int mostrarArrayRecaudaciones(recaudacion arrayStruc[],int lengArray)
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
				mostrarRecaudacion(arrayStruc,i);
				ret = 0;
			}
		}//FIN FOR

	}
	return ret;
}//mostrarArrayEstructura
void mostrarRecaudacion(recaudacion arrayStruc[],int posicion)
{
	if(arrayStruc != NULL && posicion > -1)
	{
			printf("\n:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::\n");
			printf("   ID RECAUDACION        MES        TIPO               IMPORTE			ID CONTRIBUYENTE	ESTADO RECAUDACION");
			printf("\n:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::\n");

			printf("\n\t %d              %d \t    %s    \t        %.2f               %d 	\t %s\n",
						arrayStruc[posicion].idRecaudacion
						,arrayStruc[posicion].mes
						,arrayStruc[posicion].descripcionTipoRecaudacion
						,arrayStruc[posicion].importe
						,arrayStruc[posicion].idContribuyente
						,arrayStruc[posicion].descripcionEstado);
			printf("\n:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::\n");
	}
}//FIN mostrarEstructura()
void asignarDescripcionEstadoRecaudacion(recaudacion arrayStruc[],int posicion)
{
	if(arrayStruc != NULL && posicion > -1)
	{
		switch (arrayStruc[posicion].estado)
		{
			case 0:
				{
					strcpy(arrayStruc[posicion].descripcionEstado,"SALDADO");

				}
				break;
			case 1:
				{
					strcpy(arrayStruc[posicion].descripcionEstado,"REFINANCIADO");

				}
				break;
			case 2:
				{
					strcpy(arrayStruc[posicion].descripcionEstado,"ADEUDADO");

				}

				break;
			default:
				break;
		}
	}
}//FIN asignarDescripcionRecaudacion
void asignarDescripcionTipo(recaudacion arrayStruc[],int posicion)
{
	if(arrayStruc != NULL && posicion > -1)
	{
		switch (arrayStruc[posicion].tipo)
		{
			case 1:
				{
					strcpy(arrayStruc[posicion].descripcionTipoRecaudacion,"ARBA");

				}
				break;
			case 2:
				{
					strcpy(arrayStruc[posicion].descripcionTipoRecaudacion,"IIBB");

				}
				break;
			case 3:
				{
					strcpy(arrayStruc[posicion].descripcionTipoRecaudacion,"GANANCIAS");

				}

				break;
			default:
				break;
		}
	}
}//FIN asignarDescripcionRecaudacion



int buscarIdRecaudacion(recaudacion arrayStruc[],int lengArray,int* idContribuyente,int idRecaudacionMaximo)
{
	int ret;
	int i;
	ret = -1;
	int idBusqueda;
	if(arrayStruc != NULL && lengArray > 0 && idContribuyente != NULL)
	{
		printf("\nSe listarán a continuación todas las recaudaciones cargadas en el sistema:\n");
		mostrarArrayRecaudaciones(arrayStruc, lengArray);
		printf("\nIngrese el ID de la recaudacion a buscar\t");
			if(getInt(&idBusqueda) == 0)
			{
				if(idBusqueda <= idRecaudacionMaximo)
				{
					for (i = 0; i < lengArray; i++)
					{
						if(arrayStruc[i].isEmpty==0 && arrayStruc[i].idRecaudacion == idBusqueda)
						{
							ret = i;
							*idContribuyente = arrayStruc[i].idContribuyente;
							break;
						}
					}//FIN FOR

				}

			}
			if(ret == -1)
			{
				printf("\n No existe el ID solicitado");
			}
	}
	return ret;
}//FIN buscarIdPantalla()
int buscarRecaudacionLibre(recaudacion arrayStruc[],int lengArray)
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
int get_IdContribuyentePorPosicionRecaudacion(recaudacion arrayStruc[],int posicionRecaudacion,int* idContribuyente)
{
	int ret;
	ret = -1;
	if(arrayStruc != NULL && posicionRecaudacion > -1 && idContribuyente != NULL)
	{
		*idContribuyente = arrayStruc[posicionRecaudacion].idContribuyente;
		ret = 0;
	}

	return ret;
}//FIN get_IdContribuyentePorPosicionRecaudacion()
int get_PosicionRecaudacionPorIdContribuyente(recaudacion arrayStruc[],int lengArray,int* posicionRecaudacion,int idContribuyente)
{
	int ret;
	int i;
	ret = -1;
	if(arrayStruc != NULL && idContribuyente > -1 &&  posicionRecaudacion != NULL && lengArray >0)
	{
		for(i = 0; i<lengArray ; i++)
		{
			if(arrayStruc[i].idContribuyente == idContribuyente)
			{
				*posicionRecaudacion = i;
			}

		}

		ret = 0;
	}

	return ret;
}//FIN get_PosicionRecaudacionPorIdContribuyente()
int getRecaudacionesPorCuil(recaudacion arrayStruc[],int lengArray,char* cuilContribuyente, int idContribuyente)
{
	int ret = -1;
	int i;
	if(arrayStruc != NULL && lengArray > 0 && cuilContribuyente != NULL && idContribuyente > 999)
	{
		utn_getCuit(cuilContribuyente, "\nIngrese el número de CUIL a buscar", "\nError, ingrese un número de CUIL válido", 3);
		for(i=0; i < lengArray; i++)
		{
			if(arrayStruc[i].isEmpty == 0 && arrayStruc[i].idContribuyente == idContribuyente)
			{
				mostrarRecaudacion(arrayStruc, i);
				ret = 0;
			}
		}
		if(ret != 0)
		{
			printf("\nNo existen recaudaciones asociadas al id %s del contribuyente",cuilContribuyente);
		}
	}
	return ret;
}

int getImporteMayorRecaudacion(recaudacion arrayRecaudacion[],int lengArrayRecaudacion, float* mayorRecaudacion)
{
	int ret = -1;
	int i;
	int flagMayorRecaudacion = 0;
	if(arrayRecaudacion != NULL && lengArrayRecaudacion > 0 && mayorRecaudacion != NULL)
	{
		for(i = 0; i < lengArrayRecaudacion; i++)
		{
			if(arrayRecaudacion[i].isEmpty == 1)
			{
				continue;
			}
			else
			{
				if(flagMayorRecaudacion == 0 || arrayRecaudacion[i].importe > *mayorRecaudacion)
				{
					flagMayorRecaudacion = 1;
					*mayorRecaudacion = arrayRecaudacion[i].importe;
					ret = 0;
				}
			}
		}
	}
	return ret;
}//FIN getContribuyentesMayorRecaudacion()
int bajaRecaudaciones(recaudacion arrayStruc[],int lengArray,int idContribuyente)
{
	int ret = -1;
	int i;
	if(arrayStruc != NULL && lengArray > 0 && idContribuyente > -1)
	{
		for(i=0; i < lengArray; i++)
		{
			if(arrayStruc[i].isEmpty == 0 && arrayStruc[i].idContribuyente == idContribuyente)
			{
				bajaRecaudacion(arrayStruc,i);
				ret = 0;
			}
		}
	}
	return ret;
}//FIN bajaRecaudaciones
int mostrarRecaudacionesPorIdContribuyente(recaudacion arrayStruc[],int lengArray,int idContribuyente)
{
	int ret = -1;
	int i;
	if(arrayStruc != NULL && lengArray > 0 && idContribuyente > -1)
	{
		for(i=0; i < lengArray; i++)
		{
			if(arrayStruc[i].isEmpty == 0 && arrayStruc[i].idContribuyente == idContribuyente)
			{
				mostrarRecaudacion(arrayStruc, i);
				ret = 0;
			}
		}
		if(ret != 0)
		{
			printf("\nNo existen recaudaciones asociadas al id %d del contribuyente",idContribuyente);
		}
	}
	return ret;
}//FIN mostrarRecaudacionesPorIdContribuyente()
int ordenarAscendentemente_RecaudacionPorIdContribuyente(recaudacion arrayStruc[],int lengArray)
{
	int ret;
	ret = -1;
	int i;
	int j;
	int lengAux;
	recaudacion auxiliarStruc;
	if(arrayStruc != NULL && lengArray > 0)
	{
		for (i = 0; i < lengArray-1; i++)
		{
			for (j = i+1; j < lengArray; j++)
			{
				if(arrayStruc[i].idContribuyente == arrayStruc[j].idContribuyente)
				{


					if(arrayStruc[i].tipo >arrayStruc[j].tipo)
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
