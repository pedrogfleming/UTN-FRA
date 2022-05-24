#include <stdio.h>
#include <stdlib.h>

#include <string.h>
#include <ctype.h>
#include "contribuyente.h"
#include "recaudacion.h"
#include "utn.h"
#include "menu.h"
#include "informes.h"


int informeContribuyentes(contribuyente arrayContribuyentes[],int lengArrayContribuyentes,recaudacion arrayRecaudaciones[],int lengArrayRecaudaciones)
{
	int i;
	int ret;
	ret = -1;
	if(arrayContribuyentes != NULL && lengArrayContribuyentes > 0 && arrayRecaudaciones != NULL && lengArrayRecaudaciones > 0)
	{
		for (i = 0; i < lengArrayContribuyentes; i++)
		{

			if(arrayContribuyentes[i].isEmpty == 0)
			{
				mostrarInformeContribuyente(arrayContribuyentes,arrayContribuyentes[i].idContribuyente,arrayRecaudaciones,lengArrayRecaudaciones,i);
				ret = 0;
			}
		}//FIN FOR

	}
	return ret;
}//mostrarArrayEstructura
void mostrarInformeContribuyente(contribuyente arrayContribuyentes[],int idContribuyente,recaudacion arrayRecaudaciones[],int lengArrayRecaudaciones,int posicionContribuyente)
{

	if(arrayContribuyentes != NULL && idContribuyente > -1 && arrayRecaudaciones != NULL )
	{
		printf("\n:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::\n");
		printf("   ID CONTRIBUYENTE        NOMBRE        APELLIDO        CUIL");
		printf("\n:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::\n");

		printf("\n \t %d \t %s \t   %s    \t %s \t\n",
				arrayContribuyentes[posicionContribuyente].idContribuyente
					,arrayContribuyentes[posicionContribuyente].nombre
					,arrayContribuyentes[posicionContribuyente].apellido
					,arrayContribuyentes[posicionContribuyente].cuil);
		printf("\n:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::\n");
		mostrarRecaudacionesPorIdContribuyente(arrayRecaudaciones,lengArrayRecaudaciones,idContribuyente);

	}
}//FIN mostrarEstructura()
int mostrarArrayRecaudacionesSaldadas(recaudacion arrayRecaudacion[],int lengArrayRecaudacion,contribuyente arrayContribuyente[],int lengArrayContribuyente)
{
	int ret = -1;
	int i;//Array Recaudacion
	int j;//Array Contribuyente
	if(arrayRecaudacion != NULL && lengArrayRecaudacion > 0 && arrayContribuyente != NULL && lengArrayContribuyente>0)
	{
		for(i = 0; i < lengArrayRecaudacion; i++)
		{
			if(arrayRecaudacion[i].isEmpty == 1)
			{
				continue;
			}
			else
			{
				if(arrayRecaudacion[i].estado == 0)
				{
					for(j = 0 ; j < lengArrayContribuyente ; j++)
					{
						if(arrayContribuyente[j].isEmpty == 0 && arrayRecaudacion[i].idContribuyente == arrayContribuyente[j].idContribuyente)	//Comparo la recaudacion saldada a ver con quien se relaciona de contribuyentes
						{
							mostrarContribuyente(arrayContribuyente, j);
							mostrarRecaudacion(arrayRecaudacion,i);
							ret = 0;
						}
					}
				}
			}
		}
	}
	return ret;
}//FIN mostrarArrayRecaudacionesSaldadas()
int mostrarRecaudacionesMayores(recaudacion arrayRecaudacion[],int lengArrayRecaudacion,contribuyente arrayContribuyente[],int lengArrayContribuyente,float mayorRecaudacion)
{
	int ret = -1;
	int i;
	int posicionContribuyente;
	if(arrayRecaudacion != NULL && lengArrayRecaudacion > 0 && mayorRecaudacion > 0 && arrayContribuyente != NULL && lengArrayContribuyente > -1)
	{
		for(i=0; i < lengArrayRecaudacion; i++)
		{
			if(arrayRecaudacion[i].isEmpty == 0 && arrayRecaudacion[i].importe == mayorRecaudacion)
			{
				mostrarRecaudacion(arrayRecaudacion, i);
				get_PosicionContribuyentePorId(arrayContribuyente,lengArrayContribuyente,&posicionContribuyente,arrayRecaudacion[i].idContribuyente);
				mostrarContribuyente(arrayContribuyente, posicionContribuyente);
				ret = 0;
			}
		}
	}
	return ret;
}//FIN mostrarRecaudacionesMayores()

//INFORMES 9
int mostrarContribuyentesMayorRefinanciadas(recaudacion arrayRecaudacion[],int lengArrayRecaudacion,contribuyente arrayContribuyente[],int lengArrayContribuyente,float mayorRecaudacion)
{
	int ret = -1;
	int i;
	int posicionContribuyente;
	int auxiliarIdContribuyente;
	int flagRefinanciada = 0;
	if(arrayRecaudacion != NULL && lengArrayRecaudacion > 0 && mayorRecaudacion > 0 && arrayContribuyente != NULL && lengArrayContribuyente > -1)
	{
		ordenarAscendentemente_RecaudacionPorIdContribuyente(arrayRecaudacion,lengArrayRecaudacion);
		for(i=0; i < lengArrayRecaudacion; i++)
		{
			if(arrayRecaudacion[i].isEmpty == 0 && arrayRecaudacion[i].estado == 1)
			{
				if(flagRefinanciada == 0)		//Si es el primero de los refinanciados, entonces es el contribuyente con mayor refinanciados
				{
					get_PosicionContribuyentePorId(arrayContribuyente,lengArrayContribuyente,&posicionContribuyente,arrayRecaudacion[i].idContribuyente);
					auxiliarIdContribuyente = arrayRecaudacion[i].idContribuyente;
					flagRefinanciada = 1;
				}
				else
				{
					if(auxiliarIdContribuyente != arrayRecaudacion[i].idContribuyente)
					{

					}
				}

				//Si no es el primero
				//mostrarRecaudacion(arrayRecaudacion, i);

				//mostrarContribuyente(arrayContribuyente, posicionContribuyente);
				ret = 0;
			}
		}
	}
	return ret;
}//FIN mostrarRecaudacionesMayores()

int mostrarRecaudacionesMayoresSaldadas(recaudacion arrayRecaudacion[],int lengArrayRecaudacion,contribuyente arrayContribuyente[],int lengArrayContribuyente)
{
	int ret = -1;
	int i;
	int contadorRecaudacionesSaldadasMayores = 0;
	if(arrayRecaudacion != NULL && lengArrayRecaudacion > 0 && arrayContribuyente != NULL && lengArrayContribuyente > -1)
	{
		for(i=0; i < lengArrayRecaudacion; i++)
		{
			if(arrayRecaudacion[i].isEmpty == 0 && arrayRecaudacion[i].importe > 1000)
			{
				contadorRecaudacionesSaldadasMayores++;
				ret = 0;
			}
		}
		if(ret == 0)
		{
			printf("\n La cantidad de recaudaciones saldadas de importe mayor a 1000 es de : %d",contadorRecaudacionesSaldadasMayores);
		}
		else
		{
			printf("\nNo existen recaudaciones mayores a 1000 en la base de datos");
		}
	}
	return ret;
}//FIN mostrarRecaudacionesMayores()
int mostrarArrayRecaudacionesPorTipo(recaudacion arrayRecaudacion[],int lengArrayRecaudacion,contribuyente arrayContribuyente[],int lengArrayContribuyente)
{
	int ret = -1;
	int opcionUsuario;
	int i;//Array Recaudacion
	int j;//Array Contribuyente
	if(arrayRecaudacion != NULL && lengArrayRecaudacion > 0 && arrayContribuyente != NULL && lengArrayContribuyente>0)
	{
		if(mostrarMenu(&opcionUsuario,"\nIngrese el tipo de recaudacion que desea filtrar:\n1-ARBA\n2-IIBB\n3-GANANCIAS") == 0)
		{
			if(opcionUsuario >= 0 && opcionUsuario <= 3)
			{
				for(i = 0; i < lengArrayRecaudacion; i++)
				{
					if(arrayRecaudacion[i].isEmpty == 1)
					{
						continue;
					}
					else
					{
						if(arrayRecaudacion[i].tipo == opcionUsuario)
						{
							for(j = 0 ; j < lengArrayContribuyente ; j++)
							{
								if(arrayContribuyente[j].isEmpty == 0 && arrayRecaudacion[i].idContribuyente == arrayContribuyente[j].idContribuyente)	//Comparo la recaudacion saldada a ver con quien se relaciona de contribuyentes
								{
									mostrarContribuyente(arrayContribuyente, j);
									mostrarRecaudacion(arrayRecaudacion,i);
									ret = 0;
								}
							}
						}
					}
				}//FIN FOR
				if(ret != 0)
				{
					printf("\nNo se han encontrado recaudaciones con ese tipo de recaudacion");
				}

			}
			else
			{
				printf("\nHa ingresado un comando fuera del rango mostrado del menu.Volverá al menu principal.");
			}

		}

	}
	return ret;
}//FIN mostrarArrayRecaudacionesSaldadas()
int mostrarContribuyentesRecaudacionFebrero(recaudacion arrayRecaudacion[],int lengArrayRecaudacion,contribuyente arrayContribuyente[],int lengArrayContribuyente)
{
	int ret = -1;
	int i;//Array Recaudacion
	int j;//Array Contribuyente
	if(arrayRecaudacion != NULL && lengArrayRecaudacion > 0 && arrayContribuyente != NULL && lengArrayContribuyente>0)
	{
		for(i = 0; i < lengArrayRecaudacion; i++)
		{
			if(arrayRecaudacion[i].isEmpty == 1)
			{
				continue;
			}
			else
			{
				if(arrayRecaudacion[i].mes == 2)
				{
					for(j = 0 ; j < lengArrayContribuyente ; j++)
					{
						if(arrayContribuyente[j].isEmpty == 0 && arrayRecaudacion[i].idContribuyente == arrayContribuyente[j].idContribuyente)	//Comparo la recaudacion saldada a ver con quien se relaciona de contribuyentes
						{
							mostrarContribuyente(arrayContribuyente, j);
							printf("\nNOMBRE APELLIDO CUIL");
							printf("\n %s      %s       %s",arrayContribuyente[j].nombre,arrayContribuyente[j].apellido,arrayContribuyente[j].cuil);
							ret = 0;
						}
					}
				}
			}
		}//FIN FOR
		if(ret != 0)
		{
			printf("\nNo se han encontrado recaudaciones del mes de febrero");
		}
	}
	return ret;
}//FIN mostrarArrayRecaudacionesSaldadas()
