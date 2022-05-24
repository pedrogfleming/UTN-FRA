#include <ctype.h>
#include <stdio.h>
#include <stdlib.h>
#include "utn.h"
#include <string.h>
#include "pantalla.h"
#include "menu.h"

int inicializarEstructuraPantalla(pantalla arrayStruc[],int lengArray)
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
int altaPantalla(pantalla arrayStruc[],int* idPantalla,int lengArray,int posicion)
{
	char confirmar;
	int ret;
	pantalla auxiliarStruc;
	ret = -1;
	if(arrayStruc != NULL && idPantalla != NULL && posicion > -1)
	{
			fflush(stdin);
			if((utn_getString(auxiliarStruc.nombre,51,"\nIngrese nombre de la pantalla","\nError, ha ingresado un nombre de la pantalla",3,3) != 0) ||
			(utn_getString(auxiliarStruc.direccion,51,"\nIngrese direccion","\nError, ha ingresado una direccion",3,3) != 0)  ||
			 (utn_getFloat(&auxiliarStruc.precio,"\nIngrese precio de la pantalla","\nError, ingrese un precio valido para la pantallao",0,9999999,3) != 0 ||
			(utn_getNumero(&auxiliarStruc.tipo,"\nIngrese tipo de pantalla","\nError, ingrese un tipo de pantalla valido",0,1,3) != 0)))
			{
				printf("\nSe ha abortado el alta de la pantalla debido a un error en la carga. Volvera al menu principal");
			}
			else
			{
					confirmCommand(&confirmar,"\n¿Desea confirmar la accion?s/n","\nError, ingrese solo s/n ",3);
					if(confirmar == 's')
					{
						arrayStruc[posicion] = auxiliarStruc;
						arrayStruc[posicion].idPantalla = *idPantalla;
						(*idPantalla)++;
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
int bajaPantalla(pantalla arraypantallas[],int posicion)
{
	int ret;
	ret = -1;
	if(arraypantallas != NULL && posicion > -1)
	{

		arraypantallas[posicion].isEmpty = 1;
		ret = 0;
	}
	return ret;
}//FIN bajaEstructura()
int modificarPantalla(pantalla arraypantallas[],int lengArray,int posicion,int campoModificar)
{
	int ret;
	ret = -1;
	int banderaError;
	char confirmar;
	banderaError = 0;

	if(arraypantallas != NULL && posicion > -1)
	{
			switch (campoModificar)
			{
				case 1:
					if(utn_getString(arraypantallas[posicion].nombre,20,"\nIngrese nombre de la pantalla","\nError, ha ingresado un nombre de la pantalla invalido",5,3) != 0)
					{
						banderaError = 1;
					}
					break;
				case 2:
					if(utn_getString(arraypantallas[posicion].direccion,20,"\nIngrese direccion de la pantalla","\nError, ha ingresado una direccion  invalido",5,3) != 0)
					{
						banderaError = 1;
					}
					break;
				case 3:
					if(utn_getNumero(&arraypantallas[posicion].tipo, "\nIngrese tipo de pantalla,\n1-LCD\n2-LED", "\nError, ha ingresado un tipo invalido. Reingrese:\n1-LCD\n2-LED", 1, 2, 3) != 0)
					{
						banderaError = 1;
					}
					break;
				case 4:
					if(utn_getFloat(&arraypantallas[posicion].precio, "\nIngrese precio de pantalla", "\nError, ingrese un precio valido", 1, 9999999, 3) == 0)
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
				confirmCommand(&confirmar,"\n¿Desea confirmar la accion?s/n","\nError, ingrese solo s/n ",3);
				if(confirmar == 's')
				{
					printf("\nSe ha modificado con exito el campo solicitado");
					ret = 0;
				}
				else
				{
					printf("\nAbortada la operación");
				}

			}
	}
	return ret;
}//modificarPantalla()


int mostrarArraypantallas(pantalla arrayStruc[],int lengArray)
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
				mostrarpantalla(arrayStruc,i);
				ret = 0;
			}
		}//FIN FOR

	}
	return ret;
}//mostrarArrayEstructura
void mostrarpantalla(pantalla arrayStruc[],int posicion)
{
	if(arrayStruc != NULL && posicion > -1)
	{

		printf("\n:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::\n");
		printf("   ID PANTALLA        NOMBRE PANTALLA        DIRECCION        TIPO      PRECIO     ");
		printf("\n:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::\n");

		printf("\n\t %d \t %s \t   %s    \t    %d    \t   %2.f\n",
					arrayStruc[posicion].idPantalla
					,arrayStruc[posicion].nombre
					,arrayStruc[posicion].direccion
					,arrayStruc[posicion].tipo
					,arrayStruc[posicion].precio);
		printf("\n:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::\n");


	}
}//FIN mostrarEstructura()
int buscarIdPantalla(pantalla arrayStruc[],int lengArray)
{
	int ret;
	int i;
	ret = -1;
	int idBusqueda;
	if(arrayStruc != NULL && lengArray > 0 )
	{
			if(utn_getNumero(&idBusqueda,"\nIngrese el ID a buscar","\nError, ingrese un ID valido",1000,2000,3) == 0)
			{
				for (i = 0; i < lengArray; i++)
				{

					if(arrayStruc[i].isEmpty==0 && arrayStruc[i].idPantalla == idBusqueda)
					{
						ret = i;
						break;
					}
				}//FIN FOR
			}
	}
	else
	{
		printf("\n No existe el ID solicitado");
	}
	return ret;
}//FIN buscarIdPantalla()
int buscarPantallaLibre(pantalla arrayStruc[],int lengArray)
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
