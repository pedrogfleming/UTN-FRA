#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include "Employee.h"
#include "utn.h"

void employee_delete(Employee* this)
{
	free(this);
}

Employee* employee_new()
{
	Employee* direccionMemoria = NULL;
	direccionMemoria = (Employee*) malloc(sizeof(Employee));
	return direccionMemoria;
}

Employee* employee_newParametros(char* idStr,char* nombreStr,char* horasTrabajadasStr,char* sueldoStr)
{
	Employee* nuevoEmpleado = employee_new();
	if(idStr != NULL && nombreStr != NULL && horasTrabajadasStr != NULL && sueldoStr != NULL && nuevoEmpleado  != NULL)
	{
		if(	(employee_setId(nuevoEmpleado,atoi(idStr)) != 0) ||
			(employee_setNombre(nuevoEmpleado,nombreStr) != 0) ||
			(employee_setHorasTrabajadas(nuevoEmpleado,atoi(horasTrabajadasStr)) != 0) ||
			(employee_setSueldo(nuevoEmpleado,atoi(sueldoStr)) != 0))
		{
			employee_delete(nuevoEmpleado);
			nuevoEmpleado = NULL;
			//printf("\nEmployee: direccion de memoria NULL");
		}
	}
	return nuevoEmpleado;
}//FIN employee_newParametros()
int employee_setId(Employee* this,int id)
{
	int ret = -1;
	if(this != NULL && id > 0)
	{
		this->id =id;
		//printf("\nid empleado : %d",this->id);
		ret = 0;
	}
	return ret;
}//FIN employee_setId()
int employee_setNombre(Employee* this,char* nombre)
{
	int ret = -1;
	if(this != NULL && nombre != NULL)
	{
		strcpy(this->nombre,nombre);
		ret = 0;
	}
	return ret;
}//FIN employee_setNombre()
int employee_setHorasTrabajadas(Employee* this,int horasTrabajadas)
{
	int ret = -1;
	if(this != NULL && horasTrabajadas > -1)
	{
		this->horasTrabajadas = horasTrabajadas;
		ret = 0;
	}
	return ret;
}//FIN employee_setHorasTrabajadas()
int employee_setSueldo(Employee* this,int sueldo)
{
	int ret = -1;
	if(this != NULL && sueldo > -1)
	{
		this->sueldo = sueldo;
		ret = 0;
	}
	return ret;
}//FIN employee_setSueldo()
int employee_getId(Employee* this,int* id)
{
	int ret = -1;
	if(this != NULL &&  id != NULL)
	{
		*id = this->id;
		ret = 0;
	}
	return ret;
}//FIN employee_getId()
int employee_getNombre(Employee* this,char* nombre)
{
	int ret = -1;
	if(this != NULL &&  nombre != NULL)
	{
		strcpy(nombre,this->nombre);
		ret = 0;
	}
	return ret;
}//FIN employee_getNombre()
int employee_getHorasTrabajadas(Employee* this,int* horasTrabajadas)
{
	int ret = -1;
	if(this != NULL &&  horasTrabajadas != NULL)
	{
		*horasTrabajadas = this->horasTrabajadas;
		ret = 0;
	}
	return ret;
}//FIN employee_getHorasTrabajadas()
int employee_getSueldo(Employee* this,int* sueldo)
{
	int ret = -1;
	if(this != NULL &&  sueldo != NULL)
	{
		*sueldo = this->sueldo;
		ret = 0;
	}
	return ret;
}//FIN employee_getSueldo()
int employee_SetDatos(Employee* this)
{
	int ret = -1;
	char nombre[128];
	int horas;
	int sueldo;
	if(this != NULL)
	{
		printf("\nA continuación, se le solicitarán los datos del empleado a dar de alta:\n");
		if((utn_getString(nombre, 128, "\nIngrese nombre del empleado", "\nError, ingrese sólo letras", 3, 3)) == 0 &&
			(utn_getNumeroMinimo(&horas, "\nIngrese cantidad de horas trabajadas del empleado", "\nError, ingrese una cantidad de horas válida", 0, 3) == 0) &&
			(utn_getNumeroMinimo(&sueldo, "\nIngrese el sueldo del empleado", "\nError, ingrese un sueldo valido", 0, 3) == 0))
		{
			if(	(employee_setNombre(this,nombre) != 0) ||
				(employee_setHorasTrabajadas(this,horas) != 0) ||
				(employee_setSueldo(this,sueldo) != 0))
			{
				free(this);
				this = NULL;

				//printf("\nEmployee: direccion de memoria NULL");
			}
			else
			{

				ret = 0;
			}

		}
	}
	return ret;
}//FIN employee_SetDatos()
int sortByName_A_Z(void* pElementoA,void* pElementoB)
{

	Employee* auxElementoA = NULL;
	Employee* auxElementoB = NULL;
	int ret = 0;
	if(pElementoA != NULL && pElementoB != NULL)
	{
		auxElementoA = (Employee*)pElementoA;
		auxElementoB = (Employee*)pElementoB;
		ret = (strcmp((*(auxElementoA)).nombre,(*(auxElementoB)).nombre));
	}
	return ret;
}//FIN sortByName_A_Z()
int sortByHoras(void* pElementoA,void* pElementoB)
{

	int ret = 0;
	int auxHorasA;
	int auxHorasB;
	if(pElementoA != NULL && pElementoB != NULL)
	{
		employee_getHorasTrabajadas((Employee*)pElementoA,&auxHorasA);
		employee_getHorasTrabajadas((Employee*)pElementoB,&auxHorasB);

			if(auxHorasA > auxHorasB)	//Si A es mayor a B...
			{
				ret = 1;
			}
			else
			{
				if(auxHorasA <auxHorasB)
				{
					ret = -1;
				}
			}
	}
	return ret;
}//FIN sortByHoras()
int sortBySueldo(void* pElementoA,void* pElementoB)
{
	int auxSueldoA;
	int auxSueldoB;
	int ret = 0;
	if(pElementoA != NULL && pElementoB != NULL)
	{
		employee_getSueldo((Employee*)pElementoA,&auxSueldoA);
		employee_getSueldo((Employee*)pElementoB,&auxSueldoB);
		if(auxSueldoA > auxSueldoB)	//Si A es mayor a B...
		{
			ret = 1;
		}
		else
		{
			if(auxSueldoA <auxSueldoB)
			{
				ret = -1;
			}
		}
	}
	return ret;
}//FIN sortBySueldo()
int sortById(void* pElementoA,void* pElementoB)
{
	int auxIdA;
	int auxIdB;
	int ret = 0;
	if(pElementoA != NULL && pElementoB != NULL)
	{
		employee_getId((Employee*)pElementoA,&auxIdA);
		employee_getId((Employee*)pElementoB,&auxIdB);
		if(auxIdA > auxIdB)	//Si A es mayor a B...
		{
			ret = 1;
		}
		else
		{
			if(auxIdA <auxIdB)
			{
				ret = -1;
			}
		}

	}
	return ret;
}//FIN sortById()
