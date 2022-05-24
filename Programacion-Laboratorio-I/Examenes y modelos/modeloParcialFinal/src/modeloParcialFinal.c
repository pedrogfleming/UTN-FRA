/*
 ============================================================================
 Name        : modeloParcialFinal.c
 Author      : Geraghty Fleming Pedro
 Version     :
 Copyright   : Your copyright notice
 Description : Hello World in C, Ansi-style
 ============================================================================
 */

#include <stdio.h>
#include <stdlib.h>
#include "LinkedList.h"
#include "Controller.h"
#include "utn.h"
#include "menu.h"
#include <string.h>
#include "Peliculas.h"

int main(void)
{
	setbuf(stdout,NULL);
    int option;
    LinkedList* listaPeliculas = ll_newLinkedList();
    char* path = NULL;
    path =(char*)calloc(20,sizeof(char));
    char confirm;
    char exitProgram = {'n'};
    int flagSave = 0;
    int flagFile = 0;
    do{
    	mostrarMenu(&option,"\n\n((((((((((((((((((((((((((((((((MENU PRINCIPAL))))))))))))))))))))))))))))))))\n\n"
    			"1)CARGAR PELICULAS DESDE ARCHIVO CSV\n"
    			"2)IMPRIMIR VENTASn"
    			"3)GENERAR ARCHIVO DE MONTOS\n"
    			"4)INFORMES\n"
//    			"5)BAJA DE EMPLEADO\n"
//    			"6)LISTAR EMPLEADOS\n"
//    			"7)ORDENAR EMPLEADOS\n"
//    			"8)GUARDAR DATOS DE EMPLEADOS EN ARCHIVO CSV\n"
//    			"9)GUARDAR DATOS DE EMPLEADOS EN ARCHIVO BIN\n"
    			"10)SALIR");
        switch(option)
        {
            case 1://CARGAR PELICULAS DESDE ARCHIVO MOCK_DATA.csv
                if(flagFile == 0)
                {
                	if(controller_ElegirArchivoDestino(path,2) == 0)
                	{
                    	if(controller_loadFromText(path,listaPeliculas) == 0)
                    	{
                    		flagFile = 1;
                    	}
                	}
                }
                else
                {
                	printf("\nYa fue importado un archivo csv con la lista de peliculas");
                }
                break;
            case 2:	//IMPRIMIR VENTAS
            	if(flagSave == 1)
            	{
            		controller_ListLibros(listaPeliculas);

            	}
            	else
            	{
            		printf("\nPara poder imprimir ventas deberá primero generar archivo de Montos");
            	}

            	break;
            case 3:	//GENERAR ARCHIVO DE MONTOS
				if(controller_ElegirArchivoDestino(path,2) == 0)
				{
					if(controller_AsignarMontoFacturacion(listaPeliculas) == 0)
					{
						if(controller_saveAsText(path,listaPeliculas) == 0)
						{
							flagSave = 1;
						}
					}
				}
				else
				{
					printf("\nError al elegir la ruta de destino");
				}
				//guardar en el data
				//guardar en el debuggin
				//o guardar en cualquier lado
				break;
            case 4:	//INFORMES
            	if(controller_Informes(listaPeliculas) != 0)
            	{
            		printf("\nError, no se pudo realizar el informe");
            	}
            	break;
//            case 2://CARGAR PELICULAS DESDE ARCHIVO DATA.BIN
//            	if(flagFile == 0)
//            	{
//                	if(controller_loadFromBinary("dataB.bin",listaPeliculas) == 0)
//                	{
//                		flagFile = 1;
//                	}
//            	}
//            	else
//            	{
//            		printf("\nYa fue importado un archivo csv con la lista de peliculas");
//            	}
//            	break;
//            case 3: //ALTA EMPLEADO
//            	controller_addPelicula(listaPeliculas);
//            	break;
//            case 4:	//MODIFICAR DATOS DEL EMPLEADO
//            	controller_editPelicula(listaPeliculas);
//            	break;
//            case 5: //BAJA DE EMPLEADO
//            	controller_removePelicula(listaPeliculas);
//            	break;
//            case 7: //ORDENAR EMPLEADOS
//            	controller_sortPelicula(listaPeliculas);
//            	break;
//            case 8://GUARDAR DATOS DE EMPLEADOS EN ARCHIVO CSV
//            	if(controller_ElegirArchivoDestino(path,2) == 0)
//            	{
//            		if(controller_saveAsText(path,listaPeliculas) == 0)
//            		{
//            			flagSave = 1;
//            		}
//
//            	}
//            	else
//            	{
//            		printf("\nError al elegir la ruta de destino");
//            	}
//            	//guardar en el data
//            	//guardar en el debuggin
//            	//o guardar en cualquier lado
//            	break;
//            case 9://GUARDAR DATOS DE EMPLEADOS EN ARCHIVO BIN
//            	if(controller_ElegirArchivoDestino(path,3) == 0)
//            	{
//            		if(controller_saveAsBinary(path,listaPeliculas) == 0)
//            		{
//            			flagSave = 1;
//            		}
//            	}
//            	else
//            	{
//            		printf("\nError al elegir la ruta de destino");
//            	}
//            	break;
            case 10:
            	//avisar que se esta yendo sin guardar, desea guardar?
            	if(flagSave == 0)
            	{
                	confirmCommand(&confirm, "\nEstá a punto de finalizar el programa sin guardar, ¿Seguro que desea salir?\ns/n", "\nError, ingrese sólo s/n");
                	if(confirm == 's')
                	{
                		ll_deleteLinkedList(listaPeliculas);
                		exitProgram = 's';
                	}
                	else
                	{
                		printf("\nSe ha cancelado la salida del programa, volverá al menú principal");

                	}
            	}
            	else
            	{
            		ll_deleteLinkedList(listaPeliculas);
            		exitProgram = 's';
            	}
            	break;
            default:
            	printf("\nHa ingresado una opción incorrecta");
            	break;
        }
    }while(exitProgram != 's');
    printf("\nHa salido del programa");
    return 0;
}
