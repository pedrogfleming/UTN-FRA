/*
 * bibliotecaMenu.c
 *
 *  Created on: 8 abr. 2021
 *      Author: Pedro
 */
#include <stdio.h>
#include <stdlib.h>
int mostrarMenu(int* punteroMenu)
{
	if(punteroMenu != NULL)
	{
	int comandoLocal;
	comandoLocal = *punteroMenu;
	printf("\nIngrese comando para interactuar con el menú \n1. Loguearse\n2. Comprar\n3. Ver mis compras\n4. Vender\n5. Salir\n");
	scanf("%d",&comandoLocal);
	*punteroMenu = comandoLocal;
	}
	return 0;

}//FIN FUNCION mostrarMenu()
int mostrarSubMenuVender(int* subComandoV)
{
	if(subComandoV != NULL)
	{
	int comandoLocal;
	comandoLocal = *subComandoV;
	printf("\nIngrese comando para interactuar con el sub Menú de Ventas: 1. Vender 2. Hacer factura 3. Volver atrás\n");
	scanf("%d",&comandoLocal);
	*subComandoV = comandoLocal;
	}
	return 0;

}//FIN FUNCION mostrarSubMenuVender()





