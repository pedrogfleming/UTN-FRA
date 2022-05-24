#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include "LinkedList.h"
#include "Controller.h"
#include "Employee.h"
#include "parser.h"
#include "menu.h"
#include "utn.h"


/** \brief Carga los datos de los empleados desde el archivo data.csv (modo texto).
 *
 * \param path char*
 * \param pArrayListEmployee LinkedList*
 * \return int
 *
 */
int controller_loadFromText(char* path , LinkedList* pArrayListEmployee)
{
	int ret = -1;
	FILE* pFile;
	char confirmarComando;
	strcpy(path,"data.csv");
	pFile = fopen(path,"r");
	if(path != NULL && pArrayListEmployee != NULL)
	{

		if(pFile == NULL )
		{
			printf("\nNo se pudo abrir el archivo");
		}
		else
		{
			if(ll_isEmpty(pArrayListEmployee) == 1)
			{
				if(parser_EmployeeFromText(pFile,pArrayListEmployee) == 0)
				{
					printf("\nSe ha podido parsear el archivo txt");
					ret = 0;
				}
				else
				{
					printf("\nNo se ha podido parsear el archivo txt");
				}
			}
			else
			{
				confirmCommand(&confirmarComando,
						"\nALERTA: Si carga el archivo data.csv, tendrá ID repetidos de los empleados cargados en el programa.\n"
						"Se le recomienda que previamente guarde los empleados cargados en el programa en un archivo.\n"
						" ¿Desea hacerlo de todos modos?\n"
						"s/n", "\nError, ingrese sólo s/n");
				if(confirmarComando == 's')
				{
					if(parser_EmployeeFromText(pFile,pArrayListEmployee) == 0)
					{
						printf("\nSe ha podido parsear el archivo txt");
						ret = 0;
					}
					else
					{

						printf("\nNo se ha podido parsear el archivo txt");
					}
				}
				else					//Usuario elije destino donde guardará los empleados cargados en el programa
				{
					if(utn_GetNombreArchivo(path,2,20) == 0)
					{
						if(controller_saveAsText(path,pArrayListEmployee) == 0)
						{
							ll_clear(pArrayListEmployee);							//Limpio la linkedist y uso recursivamente la funcion
							if(controller_loadFromText(path,pArrayListEmployee) == 0)
							{
								printf("\nSE ejecuto con exito");
								ret = 0;
							}
							else
							{
								printf("\nFallo la recursividad");
							}
						}
						else
						{
							printf("\nSe ha abortado la carga del archivo, volverá al menú principal");
						}
					}
					else
					{
						printf("\nFallo el utn_GetNombreArchivo");
					}
				}
			}

		}
	}
	fclose(pFile);
    return ret;
}

/** \brief Carga los datos de los empleados desde el archivo data.csv (modo binario).
 *
 * \param path char*
 * \param pArrayListEmployee LinkedList*
 * \return int
 *
 */
int controller_loadFromBinary(char* path , LinkedList* pArrayListEmployee)
{
	int ret = -1;
	FILE* pFile;
	pFile = fopen(path,"rb");
	if(pFile == NULL)
	{
		printf("\nNo se pudo abrir el archivo binario");
    	/*
    	binAux = fopen("dataB.bin","wb");
		for (int i = 0; i < ll_len(listaEmpleados); i++)
		{
			Employee* empleadoMostrar = (Employee*)ll_get(listaEmpleados, i);
			int cantidadEscrita = fwrite(empleadoMostrar,sizeof(Employee),1,binAux);
			if(cantidadEscrita == 1)
			{
				printf("\nUN EMPLEADO ADENTRO!!!");
			}
			else
			{
				printf("\nNo pudo ");
			}
		}//FIN FOR
    	fclose(binAux);
		*/
	}
	else
	{
		if(parser_EmployeeFromBinary(pFile,pArrayListEmployee) == 0)
		{
			printf("\nSe ha podido parsear el archivo binario");
			ret = 0;
		}
		else
		{
			printf("\nNo se ha podido parsear el archivo binario");
		}
	}
	fclose(pFile);
    return ret;
}

/** \brief Alta de empleados
 *
 * \param path char*
 * \param pArrayListEmployee LinkedList*
 * \return int
 *
 */
int controller_addPelicula(LinkedList* pArrayListEmployee)
{
	int ret = -1;
	int idMax;
	Employee* pAux = NULL;
	if(pArrayListEmployee != NULL)
	{
		idMax = controller_seek_Max_Id(pArrayListEmployee);
		pAux = pelicula_new();
		if(pAux != NULL)
		{
			if(idMax != -1)
			{
				if(pelicula_SetDatos(pAux) == 0)
				{
					idMax++;
					pelicula_setId(pAux,idMax);
					ll_add(pArrayListEmployee,pAux);
					printf("\nSe ha cargado con exito el nuevo empleado");
					controller_PrintPelicula(pAux);
					ret = 0;
				}
			}
		}
	}
	if(ret == -1)
	{
		printf("\nSe ha abortado el alta de empleado");
		free(pAux);
		pAux = NULL;
	}
    return ret;
}

/** \brief Modificar datos de empleado
 *
 * \param path char*
 * \param pArrayListEmployee LinkedList*
 * \return int
 *
 */
int controller_editPelicula(LinkedList* pArrayListEmployee)
{
	int ret = -1;
	int idSearch;
	char confirm;
	int campoModificar;
	char nombre[128];
	int horas;
	int sueldo;
	Employee* auxP = NULL;
	if(pArrayListEmployee != NULL)
	{
		if(utn_getNumeroMinimo(&idSearch, "\nIngrese el id del empleado a modificar", "\nError, ingrese un id válido", 1, 3) == 0)
		{
			auxP = controller_seek_Id(pArrayListEmployee,idSearch);
			if(auxP != NULL)
			{
				printf("\nEste es el empleado encontrado:\n");
				controller_PrintPelicula(auxP);
				confirmCommand(&confirm, "\nDesea modificar al empleado?s/n", "\nError, ingrese solo s/n");
				if(confirm == 's')
				{
					utn_getNumero(&campoModificar, "\nIngrese el campo que desea modificar del empleado:"
							"\n1-Nombre\n2-Horas Trabajadas\n3-Sueldo",
							"\nError, ingrese el campo que desea modificar del empleado:"
							"\n1-Nombre\n2-Horas Trabajadas\n3-Sueldo", 1, 3, 3);
					switch (campoModificar)
					{
						case 1:
							if(utn_getString(nombre, 128,"\nIngrese nombre del empleado","\nError, ingrese sólo letras",3, 3) == 0)
							{
								if(pelicula_setNombre(auxP,nombre) == 0)
								{
									ret = 0;
									printf("\nSe ha modificado con exito el nombre del empleado");
									controller_PrintPelicula(auxP);
								}

							}
							break;
						case 2:
							if(utn_getNumeroMinimo(&horas, "\nIngrese cantidad de horas trabajadas del empleado", "\nError, ingrese una cantidad de horas válida", 0, 3) == 0)
							{
								if(pelicula_setDias(auxP,horas) == 0)
								{
									ret = 0;
									printf("\nSe ha modificado con exito la cantidad de horas trabajadas del empleado");
									controller_PrintPelicula(auxP);
								}

							}
							break;
						case 3:
							if(utn_getNumeroMinimo(&sueldo, "\nIngrese el sueldo del empleado", "\nError, ingrese un sueldo valido", 0, 3) == 0)
							{
								if(pelicula_setHora(auxP,sueldo) == 0)
								{
									printf("\nSe ha modificado con exito el sueldo del empleado");
									controller_PrintPelicula(auxP);
									ret = 0;
								}
							}
							break;
						default:
							printf("\nSe a abortado la modificación del empleado");
							break;
					}
				}
			}
		}
		if(ret != 0)
		{
			printf("\nSe a abortado la modificación del empleado");
		}
	}
    return ret;
}

/** \brief Baja de empleado
 *
 * \param path char*
 * \param pArrayListEmployee LinkedList*
 * \return int
 *
 */
int controller_removePelicula(LinkedList* pArrayListEmployee)
{
	int ret = -1;
	int idSearch;
	char confirm;
	int indexEmployee;
	Employee* auxP = NULL;
	if(pArrayListEmployee != NULL)
	{
		if(utn_getNumeroMinimo(&idSearch, "\nIngrese el id del empleado a dar de baja", "\nError, ingrese un id válido", 1, 3) == 0)
		{
			auxP = controller_seek_Id(pArrayListEmployee,idSearch);
			if(auxP != NULL)
			{
				printf("\nEste es el empleado encontrado:\n");
				controller_PrintPelicula(auxP);
				confirmCommand(&confirm, "\nDesea dar de baja al empleado?s/n", "\nError, ingrese solo s/n");
				if(confirm == 's')
				{
					indexEmployee = ll_indexOf(pArrayListEmployee,auxP);
					if(ll_remove(pArrayListEmployee,indexEmployee) == 0)
					{
						printf("\nSe a eliminado al siguiente empleado:");
						controller_PrintPelicula(auxP);
						pelicula_delete(auxP);
						ret = 0;
					}
				}
			}
		}
		if(ret != 0)
		{
			printf("\nSe a abortado la baja del empleado");
		}
	}
    return ret;
}

/** \brief Listar empleados
 *
 * \param path char*
 * \param pArrayListEmployee LinkedList*
 * \return int
 *
 */
int controller_ListPelicula(LinkedList* pArrayListEmployee)
{
	int ret = -1;
	int i;
	int sizeLinkedList;
	int auxId;
	char auxNombre[128];
	int auxHorasTrabajadas;
	int auxSueldo;
	Employee* empleadoMostrar;
	if(pArrayListEmployee != NULL)
	{
		printf("\nID: \tNOMBRE:  \tHORAS: \tSUELDO");
		sizeLinkedList = ll_len(pArrayListEmployee);
		if(sizeLinkedList != -1)
		{
			for (i = 0; i < sizeLinkedList; i++)
			{
				empleadoMostrar = (Employee*)ll_get(pArrayListEmployee, i);
				if(empleadoMostrar != NULL)
				{
					pelicula_getId(empleadoMostrar,&auxId);
					pelicula_getNombre(empleadoMostrar, auxNombre);
					pelicula_getDias(empleadoMostrar, &auxHorasTrabajadas);
					pelicula_getHorario(empleadoMostrar, &auxSueldo);

					printf("\n %d \t %s \t %d \t %d",auxId,
							auxNombre,
							auxHorasTrabajadas,
							auxSueldo);
					ret = 0;
				}
			}//FIN FOR
		}
	}
    return ret;
}



/** \brief Ordenar empleados
 *
 * \param path char*
 * \param pArrayListEmployee LinkedList*
 * \return int
 *
 */
int controller_sortPelicula(LinkedList* pArrayListEmployee)
{

	int ret = -1;
	int criterioOrdenamiento;
	int ascendente_Descendente;
	int(*pOrdenar)(void*,void*);
	if(pArrayListEmployee != NULL)
	{
		if(ll_isEmpty(pArrayListEmployee) == 0)
		{
			utn_getNumero(&criterioOrdenamiento, "\nElija el criterio de ordenamiento \n1)Nombre"
					"\n2)Horas trabajadas"
					"\n3)Sueldo"
					"\n4)Id", "\nError, ingrese un numero valido", 1, 4, 3);
			switch (criterioOrdenamiento)
			{
				case 1: 	//Por nombre A-Z
					pOrdenar = sortByName_A_Z;
					break;
				case 2: 	//Por horas trabajadas
					pOrdenar = sortByDias;
				break;
				case 3: 	//Sueldo
					pOrdenar = sortByHorario;
				break;
				case 4: 	//Por id
					pOrdenar = sortById;
					break;
				default:
					break;
			}
			if(utn_getNumero(&ascendente_Descendente, "\n¿Desea orden ascendente(1) o descendente(0) ?"
					, "\nError, ingrese solo ascendente(1) o descendente(0)", 0, 1, 3) == 0)
			{
				if(ll_sort(pArrayListEmployee,pOrdenar,ascendente_Descendente) == 0)
				{
					ret = 0;
					//printf("\nPrintf testing!!!");
				}
				else
				{
					printf("\nEl ll_sort no pudo hacerse");
				}
			}
		}
		else
		{
			printf("\nNo hay empleados cargados en la base de datos");
		}
	}
	return ret;
}

/** \brief Guarda los datos de los empleados en el archivo data.csv (modo texto).
 *
 * \param path char*
 * \param pArrayListEmployee LinkedList*
 * \return int
 *
 */
int controller_saveAsText(char* path , LinkedList* pArrayListEmployee)
{
	int ret = -1;
	FILE* pFile;
	int sizeLinkedList;
	int i;
	int auxId;
	char auxNombre[128];
	int auxHorasTrabajadas;
	int auxSueldos;
	//int auxEleccionUsuario;
	Employee* pAux = NULL;
	if(path != NULL && pArrayListEmployee!= NULL)
	{
		pFile = fopen(path,"w");
		if(pFile != NULL)
		{
				fprintf(pFile,"ID,NOMBRE,HORAS TRABAJADAS,SUELDO\n");
				sizeLinkedList = ll_len(pArrayListEmployee);
				for (i = 0; i < sizeLinkedList; i++)
				{
					pAux = (Employee*)ll_get(pArrayListEmployee, i);
					if(pAux != NULL)
					{
						if(		(pelicula_getId(pAux,&auxId)) != 0 ||
								(pelicula_getNombre(pAux,auxNombre)) != 0 ||
								(pelicula_getDias(pAux,&auxHorasTrabajadas)) != 0 ||
								(pelicula_getHorario(pAux,&auxSueldos)) != 0)
						{
							pAux = NULL;
							free(pAux);
							printf("\nError al guardar datos en el archivo %s",path);
							break;
						}
						else
						{
							fprintf(pFile,"%d,%s,%d,%d\n",auxId,auxNombre,auxHorasTrabajadas,auxSueldos);
						}
					}
				}//FIN FOR
		}
		else
		{
			printf("\nNo se pudo abrir el archivo  %s en modo W",path);
		}
	}
	if(pAux != NULL)
	{
		ret = 0;
	}
	fclose(pFile);
    return ret;
}

/** \brief Guarda los datos de los empleados en el archivo data.csv (modo binario).
 *
 * \param path char*
 * \param pArrayListEmployee LinkedList*
 * \return int
 *
 */
int controller_saveAsBinary(char* path , LinkedList* pArrayListEmployee)
{
	int ret = -1;
	FILE* pFile;
	int sizeLinkedList;
	int i;
	int cantidadEscrita;
	Employee* pAux = NULL;
	if(path != NULL && pArrayListEmployee!= NULL)
	{
		pFile = fopen(path,"wb");
		if(pFile != NULL)
		{
			sizeLinkedList = ll_len(pArrayListEmployee);
			for (i = 0; i < sizeLinkedList; i++)
			{
				pAux = (Employee*)ll_get(pArrayListEmployee, i);
				if(pAux != NULL)
				{
					cantidadEscrita = fwrite(pAux,sizeof(Employee),1,pFile);
					if(cantidadEscrita != 1)
					{
						pAux = NULL;
						free(pAux);
						break;
						printf("\nError al guardar datos en el archivo CSV");
					}
				}
			}//FIN FOR
		}
	}
	if(pAux != NULL)
	{
		ret = 0;
	}
	fclose(pFile);
    return ret;
}
int controller_seek_Max_Id(LinkedList* pArrayListEmployee)
{
	int ret = -1;
	int sizeLinkedList;
	int i;
	int idAux;
	int idMaximo;
	char confirmar;
	Employee* pEmpleado;
	int flagMaxId = 0;
	if(pArrayListEmployee != NULL)
	{
		if(ll_isEmpty(pArrayListEmployee) == 0)
		{
			sizeLinkedList=ll_len(pArrayListEmployee);
			for (i = 0; i < sizeLinkedList; i++)
			{
				pEmpleado = (Employee*)ll_get(pArrayListEmployee, i);
				pelicula_getId(pEmpleado,&idAux);
				if(flagMaxId == 0 || idAux > idMaximo)
				{
					idMaximo = idAux;
					flagMaxId = 1;
					ret = idMaximo;
				}
			}//FIN FOR
		}
		else
		{
			printf("\nNo hay empleados cargados en la base de datos");
			confirmCommand(&confirmar,"\nDesea inicializar el id? s/n","\nError, ingrese s/n");
			if(confirmar == 's')
			{
				ret = 0;

			}
			else
			{
				printf("\nVolverá al menú principal");
			}
		}
	}
	return ret;
}//FIN controller_seek_Max_Id()
void controller_PrintPelicula(Employee* index)
{
	if(index != NULL)
	{
		int idAux;
		char nombreAux[128];
		int horasAux;
		int sueldoAux;
		pelicula_getId(index,&idAux);
		pelicula_getNombre(index,nombreAux);
		pelicula_getDias(index,&horasAux);
		pelicula_getHorario(index,&sueldoAux);
		printf("\nID \t NOMBRE \t HORAS TRABAJADAS \t SUELDO");
		printf("\n %d \t %s \t %d \t %d",idAux,nombreAux,horasAux,sueldoAux);
	}
}//FIN employee_PrintEmployee()
Employee* controller_seek_Id(LinkedList* pArrayListEmployee,int idSearch)
{
	Employee* ret = NULL;
	int sizeLinkedList;
	int i;
	int idAux;
	Employee* pEmpleado;
	if(pArrayListEmployee != NULL)
	{
		if(ll_isEmpty(pArrayListEmployee) == 0)
		{
			sizeLinkedList=ll_len(pArrayListEmployee);
			for (i = 0; i < sizeLinkedList; i++)
			{
				pEmpleado = (Employee*)ll_get(pArrayListEmployee, i);
				pelicula_getId(pEmpleado,&idAux);
				if(idAux == idSearch)
				{
					ret = pEmpleado;
					break;
				}
			}//FIN FOR
			if(ret != pEmpleado)
			{
				printf("\nNo existe el id ingresado en la base de datos");
			}
		}
		else
		{
			printf("\nNo hay empleados cargados en la base de datos");
		}
	}

	return ret;
}//FIN controller_seek_Max_Id()
int controller_ElegirArchivoDestino(char* path,int formatoArchivo)
{
	int ret = -1;
	int tipoArchivo;
	fflush(stdin);
	if(utn_getNumero(&tipoArchivo, "\nElija el archivo destino donde guardará el listado de empleados actual:\n"
					"1)data.bin\n"
					"2)debbugin.bin\n"
					"3)Otro", "\nError,ingrese sólo las siguientes opciones:\n"
							"1)data.csv\n"
							"2)debbugin.csv\n"
							"3)Otro ", 1, 3, 3) == 0)
	{
		switch (tipoArchivo)
		{
		case 1:
			printf("\nUsted a elegido guardar el archivo en el data.csv");
			strcpy(path,"data.csv");
			ret = 0;
			break;
		case 2:
			printf("\nUsted ha elegido guardar el archivo en el debbugin.csv");
			strcpy(path,"debbugin.csv");
			ret = 0;
			break;
		case 3:
			if(utn_GetNombreArchivo(path,formatoArchivo,20) == 0)
			{
				ret = 0;
			}
			break;
		default:
			break;
		}

	}
	return ret;
}
