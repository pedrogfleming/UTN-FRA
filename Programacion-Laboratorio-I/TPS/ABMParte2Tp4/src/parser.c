#include <stdio.h>
#include <stdlib.h>
#include "LinkedList.h"
#include "Employee.h"
#include "parser.h"

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
	char buffer[4][128];
	int charLeidos;
	Employee* pAux;
	if(pFile != NULL && pArrayListEmployee !=NULL)
	{
			//			ID,NOMBRE, HORAS TRABAJADAS, SUELDO
			fscanf(pFile,"%[^,],%[^,],%[^,],%[^\n]\n",buffer[0],buffer[1],buffer[2],buffer[3]);
			//printf("%s     %s    %s   %s\n\n",buffer[0],buffer[1],buffer[2],buffer[3]);
			while(!feof(pFile))
			{
				//printf("\nParser: Entro al while");
				charLeidos = fscanf(pFile,"%[^,],%[^,],%[^,],%[^\n]\n",buffer[0],buffer[1],buffer[2],buffer[3]);
				//printf("\nCharleidos = %d",charLeidos);
				if(charLeidos < 4)
				{
					printf("\nParser: Error de char leidos, break while");
					ret = -1;
					break;
				}
				else
				{
					pAux = pelicula_newParametros(buffer[0],buffer[1],buffer[2],buffer[3]);
					if(pAux == NULL)
					{
						printf("\nParser: nuevoEmpleado es == NULL");
						break;
					}
					else
					{
						ll_add(pArrayListEmployee,(Employee*)pAux);
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
				Employee* nuevoEmpleado = pelicula_new();
				//printf("\nParser: Entro al while");
				if(nuevoEmpleado !=NULL)
				{
					charLeidos = fread(nuevoEmpleado,sizeof(Employee),1,pFile);
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
	int auxSueldos;
	Employee* pAux = NULL;
	if(pFile != NULL && pArrayListEmployee !=NULL)
	{
			//			ID,NOMBRE, HORAS TRABAJADAS, SUELDO
			sizeLinkedList = ll_len(pArrayListEmployee);
			for (i = 0; i < sizeLinkedList; i++)
			{
				pAux = (Employee*)ll_get(pArrayListEmployee, i);
				if(pAux != NULL)
				{
					pelicula_getId(pAux,&auxId);
					pelicula_getNombre(pAux,auxNombre);
					pelicula_getDias(pAux,&auxHorasTrabajadas);
					pelicula_getHorario(pAux,&auxSueldos);
					fprintf(pFile,"%d,%s,%d,%d\n",auxId,auxNombre,auxHorasTrabajadas,auxSueldos);
				}
			}//FIN FOR
	}
    return ret;
}
