#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include "LinkedList.h"
#include "Controller.h"
#include "parser.h"
#include "menu.h"
#include "Peliculas.h"
#include "utn.h"

int cantidadEntradas_Sala(void* pElement, int* acumuladorEntradasVendidas, float* totalFacturacion)
{
	int ret = -1;
	int auxCantidadEntradas = 0;
	float auxFacturacion;
	if(pElement != NULL && acumuladorEntradasVendidas != NULL && totalFacturacion != NULL)
	{
		pelicula_getCantidadEntradas(pElement,&auxCantidadEntradas);
		pelicula_getFacturacion(pElement,&auxFacturacion);
		*totalFacturacion = *totalFacturacion+auxFacturacion;
		*acumuladorEntradasVendidas = *acumuladorEntradasVendidas+auxCantidadEntradas;
		ret = 0;
	}
	return ret;
//	if(pLinkedist != NULL && ll_isEmpty(pLinkedist) == 0 && acumuladorEntradasVendidas != NULL)
//	{
//		int acumuladorEntradasVendidas = 0;
//		{
//			for (int i = 0;  i < ll_len(pLinkedist);  i++)
//			{
//				pElement = ll_get(pLinkedist,i);
//				if(pElement != NULL)
//				{
//					pelicula_getSala(pElement,auxSala);
//					if(auxSala == salaSearch)
//					{
//						pelicula_getCantidadEntradas(pElement, auxCantidadEntradas);
//						acumuladorEntradasVendidas = acumuladorEntradasVendidas+auxCantidadEntradas;
//						ret = 0;
//					}
//				}
//				else
//				{
//					ret = 1;
//					break;
//				}
//			}
//		}
//	}
}//FIN cantidadEntradas_Sala()
int print_Sala(void* pElement)
{
	int ret = -1;


	return ret;
}
