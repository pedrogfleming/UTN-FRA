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
	int comandoSubMenu;
	int slotLibre;
	int slotBusqueda;
	int idPantalla;

	//CREO ARRAY DE ESTRUCTURA
	pantalla arrayPantallas[TOTALPANTALLAS];
	publicidad arrayPublicidad[TOTALPUBLICIDADES];

	idPantalla = 1000;
	//INICIALIAZO ARRAY DE ESTRUCTURA
	inicializarEstructuraPantalla(arrayPantallas, TOTALPANTALLAS);
	inicializarEstructuraPublicidad(arrayPublicidad,TOTALPUBLICIDADES);
	//BUCLE DE MENU
	do
	{
		//MENU PRINT
		mostrarMenu(&comandoMenu,"\nMENU:\n\n Ingrese a continuación la gestión que desea realizar:\n\n1-ALTA PANTALLA\n\n2-MODIFICAR DATOS DE PANTALLA\n\n3-BAJA DE PANTALLA\n\n4-CONTRATAR PUBLICIDAD\n\n5-MODIFICAR CONDICIONES DE PUBLICACION\n\n6-CANCELAR CONTRATACION\n\n7-CONSULTA FACTURACION\n\n8-LISTAR CONTRATACIONES\n\n9-LISTAR PANTALLAS\n\n10-INFORMES\n\n0-SALIR");
		//MENU SWITCH
			switch (comandoMenu)
			{
				case 0:
					{
							comandoMenu = -1;
							break;
					}

				case 1:
						//ALTA PANTALLA
					{
							slotLibre =buscarPantallaLibre(arrayPantallas,TOTALPANTALLAS);
							if ( slotLibre > -1 &&(altaPantalla(arrayPantallas,&idPantalla,TOTALPANTALLAS,slotLibre)) == 0)
							{
								printf("\n\n PANTALLA DADA DE ALTA EXITOSAMENTE");
								mostrarpantalla(arrayPantallas,slotLibre);
							} else
							{
								printf("\n\n ERROR. SIN ESPACIO PARA ALMACENAR MAS PANTALLAS");
							}
							break;
					}
				case 2:
						//MODIFICAR PANTALLA
					{
						slotBusqueda = buscarIdPantalla(arrayPantallas,TOTALPANTALLAS);
						if(slotBusqueda > -1)
						{
							mostrarMenu(&comandoSubMenu,
									"\nMenu modificacion pantalla:Ingrese campo para modificar\n\n"
									"1-Nombre\n\n"
									"2-Direccion\n\n"
									"3-Tipo\n\n"
									"4-Precio");
							if(comandoSubMenu >= 1 && comandoSubMenu <= 4)
							{
								if(modificarPantalla(arrayPantallas, TOTALPANTALLAS, slotBusqueda, comandoSubMenu) != 0)
								{
									printf("\nError, no se pudo realizar la modificacion");
								}
								else
								{
									printf("\nSe ha modificado con exito el siguiente elemento:\n\n");
									mostrarpantalla(arrayPantallas,slotBusqueda);
								}
							}
							else
							{
								printf("\nError al ingresar el comando");
							}
						}
						else
						{
							printf("\nNo se ha encontrado el ID solicitado");
						}
						break;
					}
				case 3:
					//DAR DE BAJA PANTALLA
					{
						slotBusqueda = buscarIdPantalla(arrayPantallas,TOTALPANTALLAS);
						if(slotBusqueda > -1)
						{
								if(bajaPantalla(arrayPantallas, slotBusqueda) != 0)
								{
									printf("\nError, no se pudo realizar la baja");
								}
								else
								{
									printf("\nSe ha dado de baja con exito el siguiente elemento:\n\n");
									mostrarpantalla(arrayPantallas,slotBusqueda);
								}
						}

						break;
					}
				case 9:
					//MOSTRAR PANTALLAS
				{
					if(mostrarArraypantallas(arrayPantallas, TOTALPANTALLAS) != 0)
					{
						printf("\nNo hay pantallas cargadas en la base de datos para mostrar\n");
					}
					break;
				}
			}//FIN SWITCH
		}while(comandoMenu != -1);

	printf("\n... FIN PROGRAMA");

	return 0;
}


