/*
 ============================================================================
 Name        : modeloParcialLCDLED.c
 Author      : Geraghty Fleming Pedro 1E
 Version     :
 Copyright   : Your copyright notice
 Description : Hello World in C, Ansi-style
 ============================================================================
 */

#include <stdio.h>
#include <stdlib.h>
#include "utn.h"
#include "publicidad.h"
#include "pantalla.h"
#include "menu.h"

#define TOTALPANTALLAS 100
#define TOTALPUBLICIDADES 1000

int main(void)
{
	setbuf(stdout, NULL);

	int comandoMenu;
	int criterioDeOrdenamiento;
	int slotLibre;
	int idPantalla;

	//CREO ARRAY DE ESTRUCTURA
	pantalla arrayPantallas[TOTALPANTALLAS];
	publicidad arrayPublicidad[TOTALPUBLICIDADES];

	idPantalla = 1000;
	//INICIALIAZO ARRAY DE ESTRUCTURA
	inicializarEstructuraPantalla(arrayPantallas, TOTALPANTALLAS);
	inicializarEstructuraPublicidad(arrayPublicidad,TOTALPUBLICIDADES);
	//BUCLE DE MENU
	do {
		//MENU PRINT
		mostrarMenu(&comandoMenu,"\nMENU:\n\n Ingrese a continuación la gestión que desea realizar:\n\n1-ALTA PANTALLA\n\n2-MODIFICAR DATOS DE PANTALLA\\n\n3-BAJA DE PANTALLA\n\n4-CONTRATAR PUBLICIDAD\n\n5-MODIFICAR CONDICIONES DE PUBLICACION\n\n6-CANCELAR CONTRATACION\n\n7-CONSULTA FACTURACION\n\n8-LISTAR CONTRATACIONES\n\n9-LISTAR PANTALLAS\n\n10-INFORMES\n\n0-SALIR");
		//MENU SWITCH
		switch (comandoMenu)
		{
			case 0:
					/** PREGUNTAR SI DESEA SALIR */
					confirmCommand(&comandoMenu,"\n¿Está seguro que desea salir?s/n","\nError, ingrese solo s/n",3);
					break;
			case 1:
				//ALTA PANTALLA
					slotLibre =buscarPantallaLibre(arrayPantallas,TOTALPANTALLAS);
					if ( slotLibre > -1 &&(altaPantalla(arrayPantallas,&idPantalla,TOTALPANTALLAS,slotLibre)))
					{
						printf("\n\n * Producto DADO DE ALTA EXITOSAMENTE");
					} else {
						puts(" * ERROR. SIN ESPACIO PARA ALMACENAR MAS Producto");
					}
					break;
			case 2:
					//BAJA
					if (eProducto_Baja(arrayPantallas, TOTALPANTALLAS)) {
						puts("\n * BAJA DE Producto EXITOSA");
						eProducto_MostrarTodos(arrayPantallas, TOTALPANTALLAS);
					} else {
						puts("\n * BAJA DE Producto CANCELADA");
					}
					system("pause");
					break;
			case 3:
					//MODIFICACION
					if (eProducto_Modificacion(arrayPantallas, TOTALPANTALLAS)) {
						puts("\n * MODIFICACION DE Producto EXITOSA\n");
						eProducto_MostrarTodos(arrayPantallas, TOTALPANTALLAS);
					} else {
						puts("\n * MODIFICACION DE Producto CANCELADA");
					}
					system("pause");
					break;
			case 4:
					//LISTADO Producto
					if(eProducto_MostrarTodos(arrayPantallas, TOTALPANTALLAS)){
						system("pause");
					}else{
						puts("No hay nada para mostrar pa");
					}

					break;
			case 5:
					//ORDENAR Producto
					criterioDeOrdenamiento = -1; //PEDIR CRITERIO DE ORDENAMIENTO
					eProducto_Sort(arrayPantallas, TOTALPANTALLAS, criterioDeOrdenamiento);
					system("pause");
					break;
			}
	} while (comandoMenu != -1);

	puts("\n... FIN PROGRAMA");

	return 0;
}
