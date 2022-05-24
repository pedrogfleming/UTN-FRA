#include <stdio.h>
#include <stdlib.h>
#include "LinkedList.h"
#include "Controller.h"
#include "Employee.h"
#include "utn.h"
#include "menu.h"
#include <string.h>

/****************************************************
    Menu:
     1. Cargar los datos de los empleados desde el archivo data.csv (modo texto).
     2. Cargar los datos de los empleados desde el archivo data.csv (modo binario).
     3. Alta de empleado
     4. Modificar datos de empleado
     5. Baja de empleado
     6. Listar empleados
     7. Ordenar empleados
     8. Guardar los datos de los empleados en el archivo data.csv (modo texto).
     9. Guardar los datos de los empleados en el archivo data.csv (modo binario).
    10. Salir
*****************************************************/



int main()
{
	setbuf(stdout,NULL);
    int option;
    LinkedList* listaEmpleados = ll_newLinkedList();
    char* path;
    path =(char*)calloc(20,sizeof(char));
    char confirm;
    char exitProgram = {'n'};
    int flagSave = 0;
    int flagFile = 0;
    do{
    	mostrarMenu(&option,"\n\n((((((((((((((((((((((((((((((((MENU PRINCIPAL))))))))))))))))))))))))))))))))\n\n"
    			"1)CARGAR EMPLEADOS DESDE ARCHIVO DATA.CSV\n"
    			"2)CARGAR EMPLEADOS DESDE ARCHIVO DATA.BIN\n"
    			"3)ALTA EMPLEADO\n"
    			"4)MODIFICAR DATOS DEL EMPLEADO\n"
    			"5)BAJA DE EMPLEADO\n"
    			"6)LISTAR EMPLEADOS\n"
    			"7)ORDENAR EMPLEADOS\n"
    			"8)GUARDAR DATOS DE EMPLEADOS EN ARCHIVO CSV\n"
    			"9)GUARDAR DATOS DE EMPLEADOS EN ARCHIVO BIN\n"
    			"10)SALIR");
        switch(option)
        {
            case 1://CARGAR EMPLEADOS DESDE ARCHIVO DATA.TXT
                if(flagFile == 0)
                {

                	if(controller_loadFromText(path,listaEmpleados) == 0)
                	{
                		flagFile = 1;
                	}
                }
                else
                {
                	printf("\nYa fue importado un archivo csv con la nómina de empleados");
                }
                break;
            case 2://CARGAR EMPLEADOS DESDE ARCHIVO DATA.BIN
            	if(flagFile == 0)
            	{
                	if(controller_loadFromBinary("dataB.bin",listaEmpleados) == 0)
                	{
                		flagFile = 1;
                	}
            	}
            	else
            	{
            		printf("\nYa fue importado un archivo csv con la nómina de empleados");
            	}
            	break;
            case 3: //ALTA EMPLEADO
            	controller_addPelicula(listaEmpleados);
            	break;
            case 4:	//MODIFICAR DATOS DEL EMPLEADO
            	controller_editPelicula(listaEmpleados);
            	break;
            case 5: //BAJA DE EMPLEADO
            	controller_removePelicula(listaEmpleados);
            	break;
            case 6:	//LISTAR EMPLEADOS
            	controller_ListPelicula(listaEmpleados);
            	break;
            case 7: //ORDENAR EMPLEADOS
            	controller_sortPelicula(listaEmpleados);
            	break;
            case 8://GUARDAR DATOS DE EMPLEADOS EN ARCHIVO CSV
            	if(controller_ElegirArchivoDestino(path,2) == 0)
            	{
            		if(controller_saveAsText(path,listaEmpleados) == 0)
            		{
            			flagSave = 1;
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
            case 9://GUARDAR DATOS DE EMPLEADOS EN ARCHIVO BIN
            	if(controller_ElegirArchivoDestino(path,3) == 0)
            	{
            		if(controller_saveAsBinary(path,listaEmpleados) == 0)
            		{
            			flagSave = 1;
            		}
            	}
            	else
            	{
            		printf("\nError al elegir la ruta de destino");
            	}
            	break;
            case 10:
            	//avisar que se esta yendo sin guardar, desea guardar?
            	if(flagSave == 0)
            	{
                	confirmCommand(&confirm, "\nEstá a punto de finalizar el programa sin guardar, ¿Seguro que desea salir?\ns/n", "\nError, ingrese sólo s/n");
                	if(confirm == 's')
                	{
                		ll_deleteLinkedList(listaEmpleados);
                		exitProgram = 's';
                	}
                	else
                	{
                		printf("\nSe ha cancelado la salida del programa, volverá al menú principal");

                	}
            	}
            	else
            	{
            		ll_deleteLinkedList(listaEmpleados);
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

