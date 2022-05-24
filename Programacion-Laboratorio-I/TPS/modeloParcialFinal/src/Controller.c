#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include "LinkedList.h"
#include "Controller.h"
#include "parser.h"
#include "menu.h"
#include "Peliculas.h"
#include "utn.h"
#include "informes.h"

/** \brief Carga los datos de los empleados desde el archivo data.csv (modo texto).
 *
 * \param path char*
 * \param pArrayListEmployee LinkedList*
 * \return int
 *
 */
int controller_loadFromText(char* path , LinkedList* pArrayListPeliculas)
{
	int ret = -1;
	FILE* pFile;
//	char confirmarComando;
//	strcpy(path,"MOCK_DATA.csv");
	pFile = fopen(path,"r");
	if(path != NULL && pArrayListPeliculas != NULL)
	{

		if(pFile == NULL )
		{
			printf("\nNo se pudo abrir el archivo");
		}
		else
		{
			if(ll_isEmpty(pArrayListPeliculas) == 1)
			{
				if(parser_EmployeeFromText(pFile,pArrayListPeliculas) == 0)
				{
					printf("\nSe ha podido parsear el archivo CSV");
					ret = 0;
				}
				else
				{
					printf("\nNo se ha podido parsear el archivo CSV");
				}
			}
//			else
//			{
//				confirmCommand(&confirmarComando,
//						"\nALERTA: Si carga el archivo data.csv, tendrá ID repetidos de los empleados cargados en el programa.\n"
//						"Se le recomienda que previamente guarde los empleados cargados en el programa en un archivo.\n"
//						" ¿Desea hacerlo de todos modos?\n"
//						"s/n", "\nError, ingrese sólo s/n");
//				if(confirmarComando == 's')
//				{
//					if(parser_EmployeeFromText(pFile,pArrayListPeliculas) == 0)
//					{
//						printf("\nSe ha podido parsear el archivo txt");
//						ret = 0;
//					}
//					else
//					{
//
//						printf("\nNo se ha podido parsear el archivo txt");
//					}
//				}
//				else					//Usuario elije destino donde guardará los empleados cargados en el programa
//				{
//					if(utn_GetNombreArchivo(path,2,20) == 0)
//					{
//						if(controller_saveAsText(path,pArrayListPeliculas) == 0)
//						{
//							ll_clear(pArrayListPeliculas);							//Limpio la linkedist y uso recursivamente la funcion
//							if(controller_loadFromText(path,pArrayListPeliculas) == 0)
//							{
//								printf("\nSE ejecuto con exito");
//								ret = 0;
//							}
//							else
//							{
//								printf("\nFallo la recursividad");
//							}
//						}
//						else
//						{
//							printf("\nSe ha abortado la carga del archivo, volverá al menú principal");
//						}
//					}
//					else
//					{
//						printf("\nFallo el utn_GetNombreArchivo");
//					}
//				}
//			}

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
int controller_loadFromBinary(char* path , LinkedList* pArrayListPeliculas)
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
		if(parser_EmployeeFromBinary(pFile,pArrayListPeliculas) == 0)
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
int controller_addPelicula(LinkedList* pArrayListPeliculas)
{
	int ret = -1;
	int idMax;
	Venta* pAux = NULL;
	if(pArrayListPeliculas != NULL)
	{
		idMax = controller_seek_Max_Id(pArrayListPeliculas);
		pAux = pelicula_new();
		if(pAux != NULL)
		{
			if(idMax != -1)
			{
				if(pelicula_SetDatos(pAux) == 0)
				{
					idMax++;
					pelicula_setId(pAux,idMax);
					ll_add(pArrayListPeliculas,pAux);
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
int controller_editPelicula(LinkedList* pArrayListPeliculas)
{
	int ret = -1;
	int salaSearch;
	char confirm;
	int campoModificar;
	char nombre[128];
	int horas;
	int sueldo;
	Venta* auxP = NULL;
	if(pArrayListPeliculas != NULL)
	{
		if(utn_getNumeroMinimo(&salaSearch, "\nIngrese número de sala a buscar", "\nError, ingrese un número válido", 1, 3) == 0)
		{
			auxP = controller_seek_Id(pArrayListPeliculas,salaSearch);
			if(auxP != NULL)
			{
				printf("\nEsta es la sala encontrada:\n");
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
								//REFACTORIZAR
//								if(pelicula_setHora(auxP,sueldo) == 0)
//								{
//									printf("\nSe ha modificado con exito el sueldo del empleado");
//									controller_PrintPelicula(auxP);
//									ret = 0;
//								}
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
int controller_removePelicula(LinkedList* pArrayListPeliculas)
{
	int ret = -1;
	int idSearch;
	char confirm;
	int indexEmployee;
	Venta* auxP = NULL;
	if(pArrayListPeliculas != NULL)
	{
		if(utn_getNumeroMinimo(&idSearch, "\nIngrese el id del empleado a dar de baja", "\nError, ingrese un id válido", 1, 3) == 0)
		{
			auxP = controller_seek_Id(pArrayListPeliculas,idSearch);
			if(auxP != NULL)
			{
				printf("\nEste es el empleado encontrado:\n");
				controller_PrintPelicula(auxP);
				confirmCommand(&confirm, "\nDesea dar de baja al empleado?s/n", "\nError, ingrese solo s/n");
				if(confirm == 's')
				{
					indexEmployee = ll_indexOf(pArrayListPeliculas,auxP);
					if(ll_remove(pArrayListPeliculas,indexEmployee) == 0)
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
int controller_ListPelicula(LinkedList* pArrayListPeliculas)
{
	int ret = -1;
	int i;
	int sizeLinkedList;
	Venta* empleadoMostrar;
	if(pArrayListPeliculas != NULL)
	{
		printf("\nID: \tNOMBRE:  \tDIA: \tHORARIO \tSALA \tCANTIDAD ENTRADAS");
		sizeLinkedList = ll_len(pArrayListPeliculas);
		if(sizeLinkedList != -1)
		{
			for (i = 0; i < sizeLinkedList; i++)
			{
				empleadoMostrar = (Venta*)ll_get(pArrayListPeliculas, i);
				if(empleadoMostrar != NULL)
				{
					pelicula_PrintElement(empleadoMostrar);
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
int controller_sortPelicula(LinkedList* pArrayListPeliculas)
{

	int ret = -1;
	int criterioOrdenamiento;
	int ascendente_Descendente;
	int(*pOrdenar)(void*,void*);
	if(pArrayListPeliculas != NULL)
	{
		if(ll_isEmpty(pArrayListPeliculas) == 0)
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
				if(ll_sort(pArrayListPeliculas,pOrdenar,ascendente_Descendente) == 0)
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
int controller_saveAsText(char* path , LinkedList* pArrayListPeliculas)
{
	int ret = -1;
	FILE* pFile;
	int sizeLinkedList;
	int i;
	int auxId;
	char auxNombre[128];
	int auxDias;
	int auxHora;
	char auxHorario[11];
	char auxString[5];
	int auxMinutos;
	int auxSala;
	int cantidadEntradas;
	float auxFacturacion;
	//int auxEleccionUsuario;

	Venta* pAux = NULL;
	if(path != NULL && pArrayListPeliculas!= NULL)
	{
		pFile = fopen(path,"w");
		if(pFile != NULL)
		{
//				0)ID,1)NOMBRE, 2)DIA, 3)HORARIO, 4)SALA, 5)CANTIDAD ENTRADAS 6) MONTO FACTURADO
				fprintf(pFile,"ID,NOMBRE,DIA,HORARIO,SALA,CANTIDAD ENTRADAS,MONTO FACTURADO\n");
				sizeLinkedList = ll_len(pArrayListPeliculas);
				for (i = 0; i < sizeLinkedList; i++)
				{
					pAux = (Venta*)ll_get(pArrayListPeliculas, i);
					if(pAux != NULL)
					{
						if(		(pelicula_getId(pAux,&auxId)) != 0 ||
								(pelicula_getNombre(pAux,auxNombre)) != 0 ||
								(pelicula_getDias(pAux,&auxDias)) != 0 ||
								(pelicula_getHora(pAux,&auxHora)) != 0 ||
								(pelicula_getMinutos(pAux,&auxMinutos)) != 0 ||
								(pelicula_getSala(pAux,&auxSala)) != 0 ||
								(pelicula_getCantidadEntradas(pAux,&cantidadEntradas)) != 0 ||
								(pelicula_getFacturacion(pAux,&auxFacturacion)) != 0)
						{
							pAux = NULL;
							free(pAux);
							printf("\nError al guardar datos en el archivo %s",path);
							break;
						}
						else
						{
							strcpy(auxHorario,itoa(auxHora,auxHorario,10));
							strcat(auxHorario,":");
							strcat(auxHorario,itoa(auxMinutos,auxString,10));
							cantidadEntradas = fprintf(pFile,"%d,%s,%d,%s,%d,%d,%.2f\n",auxId,auxNombre,auxDias,auxHorario,auxSala,cantidadEntradas,auxFacturacion);
							if(cantidadEntradas < 9)
							{
								printf("\nError guardando en el archivo %s",path);
							}
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
int controller_saveAsBinary(char* path , LinkedList* pArrayListPeliculas)
{
	int ret = -1;
	FILE* pFile;
	int sizeLinkedList;
	int i;
	int cantidadEscrita;
	Venta* pAux = NULL;
	if(path != NULL && pArrayListPeliculas!= NULL)
	{
		pFile = fopen(path,"wb");
		if(pFile != NULL)
		{
			sizeLinkedList = ll_len(pArrayListPeliculas);
			for (i = 0; i < sizeLinkedList; i++)
			{
				pAux = (Venta*)ll_get(pArrayListPeliculas, i);
				if(pAux != NULL)
				{
					cantidadEscrita = fwrite(pAux,sizeof(Venta),1,pFile);
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
int controller_seek_Max_Id(LinkedList* pArrayListPeliculas)
{
	int ret = -1;
	int sizeLinkedList;
	int i;
	int idAux;
	int idMaximo;
	char confirmar;
	Venta* pEmpleado;
	int flagMaxId = 0;
	if(pArrayListPeliculas != NULL)
	{
		if(ll_isEmpty(pArrayListPeliculas) == 0)
		{
			sizeLinkedList=ll_len(pArrayListPeliculas);
			for (i = 0; i < sizeLinkedList; i++)
			{
				pEmpleado = (Venta*)ll_get(pArrayListPeliculas, i);
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
void controller_PrintPelicula(Venta* index)
{
	if(index != NULL)
	{
		int idAux;
		char nombreAux[128];
		int diasAux;
		int horaAux;
		int minutosAux;
		pelicula_getId(index,&idAux);
		pelicula_getNombre(index,nombreAux);
		pelicula_getDias(index,&diasAux);
		pelicula_getHora(index,&horaAux);
		pelicula_getMinutos(index, &minutosAux);
		printf("\nID \t NOMBRE \t HORAS TRABAJADAS \t SUELDO");
		printf("\n %d \t %s \t %d \t %d:%d",idAux,nombreAux,diasAux,horaAux,minutosAux);
	}
}//FIN employee_PrintEmployee()
int controller_AsignarMontoFacturacion(LinkedList* pArrayListPeliculas)
{
	int ret = -1;
	int i;
	int sizeLinkedList;
//	int auxDias;
//	int cantidadEntradas;
//	float facturacion;
	Venta* empleadoMostrar;
	void(*pFuncion)(void* pElement);
	pFuncion = calcularFacturacion;
	if(pArrayListPeliculas != NULL)
	{
		printf("\nID: \tNOMBRE:  \tDIA: \tHORARIO \tSALA \tCANTIDAD ENTRADAS \t FACTURACION");
		sizeLinkedList = ll_len(pArrayListPeliculas);
		if(sizeLinkedList != -1)
		{
			for (i = 0; i < sizeLinkedList; i++)
			{
				empleadoMostrar = (Venta*)ll_get(pArrayListPeliculas, i);
				if(empleadoMostrar != NULL)
				{
					ll_map(pArrayListPeliculas, pFuncion);
					ret = 0;
				}
			}//FIN FOR
		}
	}

	return ret;
}




Venta* controller_seek_Id(LinkedList* pArrayListPeliculas,int idSearch)
{
	Venta* ret = NULL;
	int sizeLinkedList;
	int i;
	int idAux;
	Venta* pPelicula;
	if(pArrayListPeliculas != NULL)
	{
		if(ll_isEmpty(pArrayListPeliculas) == 0)
		{
			sizeLinkedList=ll_len(pArrayListPeliculas);
			for (i = 0; i < sizeLinkedList; i++)
			{
				pPelicula = (Venta*)ll_get(pArrayListPeliculas, i);
				pelicula_getId(pPelicula,&idAux);
				if(idAux == idSearch)
				{
					ret = pPelicula;
					break;
				}
			}//FIN FOR
			if(ret != pPelicula)
			{
				printf("\nNo existe el id ingresado en la base de datos");
			}
		}
		else
		{
			printf("\nNo hay peliculas cargadas en la base de datos");
		}
	}

	return ret;
}//FIN controller_seek_Max_Id()
Venta* controller_Informes(LinkedList* pArrayListPeliculas)
{
	Venta* ret = NULL;
	int sizeLinkedList;
	int salaSearch;
	int auxSala;
	int i;
	float totalFacturacionSala = 0;
	int totalEntradasSala = 0;
	Venta* pPelicula;
	char nombreA[128];
	char AuxNombrePelicula[128];
	int(*pOrdenar)(void*,void*);
	int(*pContar)(void*);

	if(pArrayListPeliculas != NULL && ll_isEmpty(pArrayListPeliculas) == 0)
	{
		pOrdenar = sortByName_A_Z;
		pContar = contarEntradas;
		if(utn_getNumeroMinimo(&salaSearch, "\nIngrese número de sala a buscar"
				, "\nError, ingrese un número de sala válido", 1, 3) == 0)
		{
			ll_sort(pArrayListPeliculas,pOrdenar,1);
			sizeLinkedList=ll_len(pArrayListPeliculas);
			for (i = 0; i < sizeLinkedList; i++)
			{
				pPelicula = (Venta*)ll_get(pArrayListPeliculas, i);
				pelicula_getSala(pPelicula,&auxSala);
				if(auxSala == salaSearch)
				{
					cantidadEntradas_Sala(pPelicula,&totalEntradasSala,&totalFacturacionSala);
					pelicula_getNombre(pPelicula, nombreA);
					ll_count(pArrayListPeliculas,pContar);
					if(i == 0 || strcmp(AuxNombrePelicula,nombreA) != 0)
					{
						printf("\n%s",nombreA);
						strcpy(AuxNombrePelicula,nombreA);
						ret = 0;
					}
				}
			}//FIN FOR
			printf("\nsala %d:\t total entradas es %d y total facturacion es %f",salaSearch,totalEntradasSala,totalFacturacionSala);

//			ll_sort()

			//clojnar una lista
			//recorrer, y hacer pop
		}
	}
	return ret;
}//FIN controller_seek_Max_Id()
int controller_ElegirArchivoDestino(char* path,int formatoArchivo)
{
	int ret = -1;
	int tipoArchivo;
	fflush(stdin);
	if(utn_getNumero(&tipoArchivo, "\nElija el archivo destino donde guardará el listado de peliculas actual:\n"
					"1)MOCK_DATA.csv\n"
					"2)debbugin.csv\n"
					"3)Otro", "\nError,ingrese sólo las siguientes opciones:\n"
							"1)MOCK_DATA.csv\n"
							"2)debbugin.csv\n"
							"3)Otro ", 1, 3, 3) == 0)
	{
		switch (tipoArchivo)
		{
		case 1:
			printf("\nUsted a elegido guardar el archivo en el MOCK_DATA");
			strcpy(path,"MOCK_DATA.csv");
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
