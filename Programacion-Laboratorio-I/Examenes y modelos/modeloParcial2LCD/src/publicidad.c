#include <stdio.h>
#include <stdlib.h>
#include "publicidad.h"


int inicializarEstructuraPublicidad(publicidad arrayStruc[],int lengArray)
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
}//FIN inicializarEstructuraPublicidad()


int mostrarArrayPublicidades(publicidad arrayStruc[],int lengArray)
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
				mostrarPublicidad(arrayStruc,i);
			}
		}//FIN FOR
		ret = 0;
	}
	return ret;
}//mostrarArrayEstructura
void mostrarPublicidad(publicidad arrayStruc[],int posicion)
{


	if(arrayStruc != NULL && posicion > -1)
	{


		printf("\n:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::\n");
		printf("   ID PUBLICIDAD        CUIT        ARCHIVO        DIAS      ID PANTALLA     ");
		printf("\n:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::\n");

		printf("%8d      %12s	    %2s        %4d       %6d       \t\n",
					arrayStruc[posicion].idPublicidad
					,arrayStruc[posicion].cuit
					,arrayStruc[posicion].archivo
					,arrayStruc[posicion].dias
					,arrayStruc[posicion].idPantalla);
		printf(":::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::\n");


	}
}//FIN mostrarEstructura()
