/*
 ============================================================================
 Name        : SegundoParcialLaboParteUno.c
 Author      : Geraghty Fleming Pedro 1E
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

int main(void)
{
	setbuf(stdout,NULL);
	    int option;
	    LinkedList* listaLibros = ll_newLinkedList();
//	    LinkedList* listaFiltro = ll_newLinkedList(); //PARA ll_filter()
	    char* path = NULL;
	    path =(char*)calloc(20,sizeof(char));
	    char confirm;
	    char exitProgram = {'n'};
	    int flagSave = 0;		//Para chequear si guardo en un archivo la linkedList
	    int flagFile = 0;		//Para chequear si importo datos desde el CSV
	    int flagMap = 0;		//Para chequear si mapeo la linkedlist actual
	    do{
	    	mostrarMenu(&option,"\n\n((((((((((((((((((((((((((((((((MENU PRINCIPAL))))))))))))))))))))))))))))))))\n\n"
	    			"1)CARGAR DESDE ARCHIVO CSV\n"
	    			"2)ORDENAR LIBROS\n"
	    			"3)IMPRIMIR LIBROS\n"
	    			"4)MODIFICACION MAPEO\n"
	    			"5)GUARDAR EN ARCHIVO CSV\n"
	    			"10)SALIR");
	        switch(option)
	        {
	            case 1://CARGAR LIBROS DESDE ARCHIVO Datos.csv
	                if(flagFile == 0)
	                {
	                	if(controller_ElegirArchivoDestino(path,2) == 0)
	                	{
	                    	if(controller_loadFromText(path,listaLibros) == 0)
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
	            case 2:	//ORDENAR LIBROS
	            	if(controller_sortLibros(listaLibros, 1) == 0)
	            	{
	            		printf("\nSe ha ordenado con exito los libros");
	            	}
	            	break;
	            case 3://IMPRIMIR LIBROS
	            	if(flagFile == 1)
	            	{
	            		controller_ListLibros(listaLibros);
	            	}
	            	else
	            	{
	            		printf("\nPara poder imprimir ventas deberá primero generar archivo de Montos");
	            	}
	            	break;
	            case 4:	//MODIFICACION MAPEO
	            	if(flagMap == 0)
	            	{
		            	if(controller_ModificacionMapeo(listaLibros) != 0)
		            	{
		            		printf("\nError, no se pudo realizar la modificación");
		            	}
		            	else
		            	{
		            		printf("\nSe ha realizado el mapeo de los datos con éxito");
		            		flagMap = 1;
		            	}
	            	}
	            	else
	            	{
	            		printf("\nError, ya ha realizado el mapeo de los datos");
	            	}
	            	break;
				case 5://GUARDAR EN ARCHIVO CSV
					if(flagMap == 1)
					{
						if(controller_saveAsText("mapeado.csv",listaLibros) == 0)
						{
							printf("\nSe ha guardado los datos en el archivo mapeado.csv con éxito");
							flagSave = 1;
						}
					}
					else
					{
						printf("\nNo se puede guardar archivo sin mapeo, deberá primero mapear los datos cargados");
					}
				break;
//				case 6:	//FILTER
//					listaFiltro=controller_Filter(listaLibros);
//					controller_ListLibros(listaFiltro);
//					break;
//				case 7: //COUNT
//					if(controller_Count(listaLibros) != 0)
//					{
//						printf("\nNo se pudo contar en la ll");
//					}
//					break;
	            case 10:
	            	//avisar que se esta yendo sin guardar, desea guardar?
	            	if(flagSave == 0)
	            	{
	                	confirmCommand(&confirm, "\nEstá a punto de finalizar el programa sin guardar, ¿Seguro que desea salir?\ns/n", "\nError, ingrese sólo s/n");
	                	if(confirm == 's')
	                	{
	                		ll_deleteLinkedList(listaLibros);
	                		exitProgram = 's';
	                	}
	                	else
	                	{
	                		printf("\nSe ha cancelado la salida del programa, volverá al menú principal");

	                	}
	            	}
	            	else
	            	{
	            		ll_deleteLinkedList(listaLibros);
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
