/*
 * arrayEmployees.c
 *
 *  Created on: 11 may. 2021
 *      Author: Pedro
 */
#include "estructuras.h"
#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include "calculos.h"
#include "menu.h"

//*************************************ALTA,BAJA E INICIALIZACION DE ESTRUCTURAS*********************************************
int initEmployees(employee arrayStruc[],int lengArray)
{
	int i;
	int ret;
	ret = -1;
	if(arrayStruc != NULL && lengArray >0)
	{

		for (i = 0; i < lengArray; ++i)
		{
			arrayStruc[i].isEmpty=1;

		}
		ret = 0;
	}
	return ret;
}//FIN initEmployees()
int addEmployee(employee* list,int len, int id, char name[],char lastName[],float salary,int sector)
{
	int ret = -1;
	int emptySlot;
	if(list != NULL && len > 0)
	{
		emptySlot =	buscarLibre(list,len);
		if(emptySlot != -1)
		{
			list[emptySlot].idEmployee = id;
			strcpy(list[emptySlot].firsNameEmployee,name);
			strcpy(list[emptySlot].lastNameEmployee,lastName);
			list[emptySlot].salaryEmployee = salary;
			list[emptySlot].sectorId = sector;
			list[emptySlot].isEmpty = 0;
			ret = 0;
			mostrarEstructura(list, emptySlot);
		}
		else
		{
			printf("\nNo se encontró una posición libre");
		}
	}
	else
	{
		printf("\nF-Error de ejecucion del programa");
	}
	return ret;
}
int removeEmployee(employee arrayStruc[],int lenArray)
{
	int ret;
	int slotSearchEmployee;
	ret = -1;
	char userConfirm;
	if(arrayStruc != NULL && lenArray > 0)
	{
		slotSearchEmployee = buscarLegajo(arrayStruc,lenArray);
		if(slotSearchEmployee > -1)
		{
			mostrarEstructura(arrayStruc,slotSearchEmployee);
			printf("\nEste es el empleado solicitado");
			confirmCommand(&userConfirm, "\n¿Está seguro que desea eliminar al empleado seleccionado?", "\nError, sólo ingrese s/n", 3);
			if(userConfirm == 's')
			{
				arrayStruc[slotSearchEmployee].isEmpty = 1;
				ret = 0;
			}
		}

	}
	if(ret == -1)
	{
		printf("\nSe ha abortado la operación");
	}
	return ret;
}//FIN bajaEstructura()
//*************************************************BUSQUEDA*****************************************************************
int findEmployeeById(employee arrayStruc[],int lengArray,int id)
{
	int ret;
	int i;
	ret = -1;
	int flagFinded = 0;
	if(arrayStruc != NULL && lengArray > 0 )
	{
		for (i = 0; i < lengArray; i++)
		{
			if(arrayStruc[i].isEmpty==0 && arrayStruc[i].idEmployee == id)
			{
				ret = i;
				flagFinded = 1;
				break;
			}
		}//FIN FOR
	}
	if(flagFinded == 0)
	{
		printf("\n No existe el ID solicitado");
	}
	return ret;
}//FIN employeeById()
int zeroEmployees(employee arrayEmployee[],int lengArray)
{
	int ret = -1;
	int i;
	if(arrayEmployee != NULL && lengArray > 0)
	{
		for (i = 0; i < lengArray; i++)
		{

			if(arrayEmployee[i].isEmpty == 0)
			{
				ret = 0;
				break;
			}

		}
	}

	return ret;
}//FIN zeroEmployees;




//*************************************ORDENAR ARRAY DE ESTRUCTURAS***********************************************************
int sortEmployees(employee arrayEmployee[],int lengArray,int order)
{
	//order int [1] indicates UP -[0] indicates DOWN
	int ret = -1;

	if(lengArray > 0 && (order == 0 || order == 1))
	{
		if(order == 0)								//
		{
			ordenarAscendentemente_Entero_Cadena(arrayEmployee,lengArray);			//UP
			printf("\nSe ha ordenado de manera ascendente a los empleados");
			printEmployees(arrayEmployee,lengArray);
			ret = 0;
		}
		else
		{
			ordenarDescendentemente_Entero_Cadena(arrayEmployee,lengArray);			//DOWN
			printf("\nSe ha ordenado de manera descendente a los empleados");
			printEmployees(arrayEmployee,lengArray);
			ret = 0;
		}
	}
	return ret;
}//FIN sortEmployees()
//************************************MOSTRAR ARRAY DE ESTRUCTURAS***********************************************************
int printEmployees(employee arrayStruc[],int lengArray)
{
	int i;
	int ret;
	ret = -1;
	if(arrayStruc != NULL && lengArray > 0)
	{
		for (i = 0; i < lengArray; i++)
		{

			if(arrayStruc[i].isEmpty == 0)
			{
				mostrarEstructura(arrayStruc,i);
			}
		}//FIN FOR
		ret = 0;
	}
	return ret;
}//mostrarArrayEstructura
int findUpperAverageSalary(employee arrayEmployees[],int lengArray,float pAverageSalary)
{
	int ret;
	ret = -1;
	int i;
	int counterUpperSalary;
	counterUpperSalary = 0;
	if(arrayEmployees != NULL && lengArray > 0 && pAverageSalary > 0)
	{
		for (i = 0; i < lengArray; i++)
		{
			if(arrayEmployees[i].isEmpty == 0 && (arrayEmployees[i].salaryEmployee > pAverageSalary || counterUpperSalary == 0))
			{

				mostrarEstructura(arrayEmployees,i);
				counterUpperSalary++;
				ret = 0;
			}
		}//FIN FOR
		if(counterUpperSalary > 0)
		{
			printf("\nEl total de empleados con un sueldo por arriba del promedio es: %d",counterUpperSalary);
		}
		else
		{
			printf("\nError, volverá al menu principal");
			system("\npause");
		}
	}
	return ret;
}//FIN buscarMayorEnEstructura()
int averageSalary(employee arrayEmployees[],int lengArray, float* pAverageSalary)
{
	int ret = -1;
	float salaryAcumulator = 0;
	int counterEmployees = 0;
	int i;
	if(arrayEmployees != NULL && lengArray > 0 && pAverageSalary != NULL)
		{
			for (i = 0; i < lengArray; i++)
			{
				if(arrayEmployees[i].isEmpty == 0)
				{
					salaryAcumulator = salaryAcumulator + arrayEmployees[i].salaryEmployee;
					counterEmployees++;
					ret = 0;
				}
			}//FIN FOR
			if(counterEmployees > 0 && salaryAcumulator > 0)
			{
				if(averageCalculate(counterEmployees,salaryAcumulator,pAverageSalary))
				{
					printf("\nError, no se pudo calcular el salario promedio");
				}
			}
			else
			{
				printf("\nEl salario promedio es : %.2f",*pAverageSalary);
			}
		}
	return ret;
}
