#include <stdio.h>
#include <stdlib.h>
#include "LinkedList.h"
#include "parser.h"
#include "Peliculas.h"

/** \brief Parsea los datos los datos de los empleados desde el archivo data.csv (modo texto).
 *
 * \param path char*
 * \param pArrayListEmployee LinkedList*
 * \return int
 *
 */
int parser_EmployeeFromText(FILE* pFile , LinkedList* pArrayListEmployee)
{

	int ret = -1;
	char buffer[6][128];
	int charLeidos;
	Venta* pAux;
	if(pFile != NULL && pArrayListEmployee !=NULL)
	{
//	    int id;
//	    char nombre[128];
//	    int dia;
//	    Hora horario;
//	    int sala;
//	    int cantidadEntradas;
			//			0)ID,1)NOMBRE, 2)DIA, 3)HORARIO, 4)SALA, 5)CANTIDAD ENTRADAS
			fscanf(pFile,"%[^,],%[^,],%[^,],%[^,],%[^,],%[^\n]\n",buffer[0],buffer[1],buffer[2],buffer[3],buffer[4],buffer[5]);

			//printf("%s     %s    %s   %s\n\n",buffer[0],buffer[1],buffer[2],buffer[3]);
			while(!feof(pFile))
			{
				//printf("\nParser: Entro al while");
									//0)ID,1)NOMBRE, 2)DIA, 3)HORA 4)MINUTOS, 5)SALA, 6)CANTIDAD ENTRADAS
											//0		1	2		3	4		5	6		ENTER
				charLeidos = fscanf(pFile,"%[^,],%[^,],%[^,],%[^:]:%[^,],%[^,],%[^\n]\n",
						buffer[0],buffer[1],buffer[2],buffer[3],buffer[4],buffer[5],buffer[6]);
				//printf("hora:%d");
				//printf("\nCharleidos = %d",charLeidos);
				if(charLeidos < 7)
				{
					printf("\nParser: Error de char leidos, break while");
					ret = -1;
					break;
				}
				else
				{
					pAux = pelicula_newParametros(buffer[0],buffer[1],buffer[2],buffer[3],buffer[4],buffer[5],buffer[6]);
					if(pAux == NULL)
					{
						printf("\nParser: nuevoEmpleado es == NULL");
						break;
					}
					else
					{
						ll_add(pArrayListEmployee,(Venta*)pAux);
						ret = 0;
					}
					//printf("\nParser:Se Agrego un elemento al final de la lista");
				}
			}//FIN WHILE
	}
    return ret;
}

/** \brief Parsea los datos los datos de los empleados desde el archivo data.csv (modo binario).
 *
 * \param path char*
 * \param pArrayListEmployee LinkedList*
 * \return int
 *
 */
int parser_EmployeeFromBinary(FILE* pFile , LinkedList* pArrayListEmployee)
{
	int ret = -1;
	int charLeidos;

	if(pFile != NULL && pArrayListEmployee !=NULL)
	{
			//			ID,NOMBRE, HORAS TRABAJADAS, SUELDO
			do
			{
				Venta* nuevoEmpleado = pelicula_new();
				//printf("\nParser: Entro al while");
				if(nuevoEmpleado !=NULL)
				{
					charLeidos = fread(nuevoEmpleado,sizeof(Venta),1,pFile);
					if(charLeidos != 1)
					{

						free(nuevoEmpleado);
						break;
					}
					else
					{
						if(ll_add(pArrayListEmployee,nuevoEmpleado) == 0)
						{
							ret = 0;
						}
					}
				}
			}while(!feof(pFile));
	}
    return ret;
}
int parser_EmployeeToText(FILE* pFile , LinkedList* pArrayListEmployee)
{

	int ret = 0;
	int sizeLinkedList;
	int i;
	int auxId;
	char auxNombre[128];
	int auxHorasTrabajadas;
	int auxHora;
	int auxMinutos;
	Venta* pAux = NULL;
	if(pFile != NULL && pArrayListEmployee !=NULL)
	{
			//			ID,NOMBRE, HORAS TRABAJADAS, SUELDO
			sizeLinkedList = ll_len(pArrayListEmployee);
			for (i = 0; i < sizeLinkedList; i++)
			{
				pAux = (Venta*)ll_get(pArrayListEmployee, i);
				if(pAux != NULL)
				{
					pelicula_getId(pAux,&auxId);
					pelicula_getNombre(pAux,auxNombre);
					pelicula_getDias(pAux,&auxHorasTrabajadas);
					pelicula_getHora(pAux,&auxHora);
					pelicula_getMinutos(pAux,&auxMinutos);
					fprintf(pFile,"%d,%s,%d,%d:%d\n",auxId,auxNombre,auxHorasTrabajadas,auxHora,auxMinutos);
				}
			}//FIN FOR
	}
    return ret;
}
