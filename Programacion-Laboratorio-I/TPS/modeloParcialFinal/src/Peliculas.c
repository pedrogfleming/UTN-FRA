#include <stdio.h>
#include <stdlib.h>
#include <string.h>

#include "Peliculas.h"
#include "utn.h"

void pelicula_delete(Venta* this)
{
	free(this);
}

Venta* pelicula_new()
{
	Venta* direccionMemoria = NULL;
	direccionMemoria = (Venta*) malloc(sizeof(Venta));
	return direccionMemoria;
}

Venta* pelicula_newParametros(char* idStr,char* nombreStr,char* diasStr,char* horaStr,char* minutosStr,char* salaStr,char* cantidadEntradasStr)
{
	Venta* nuevaPelicula = pelicula_new();
	if(idStr != NULL && nombreStr != NULL && diasStr != NULL && horaStr != NULL && minutosStr != NULL &&
			salaStr != NULL && cantidadEntradasStr != NULL && nuevaPelicula  != NULL)
	{
		if(	(pelicula_setId(nuevaPelicula,atoi(idStr)) != 0) ||
			(pelicula_setNombre(nuevaPelicula,nombreStr) != 0) ||
			(pelicula_setDias(nuevaPelicula,atoi(diasStr)) != 0) ||
			(pelicula_setHora(nuevaPelicula,atoi(horaStr)) != 0)||
			(pelicula_setMinutos(nuevaPelicula,atoi(minutosStr)) != 0) ||
			(pelicula_setSala(nuevaPelicula,atoi(salaStr)) != 0) ||
			(pelicula_setCantidadEntradas(nuevaPelicula, atoi(cantidadEntradasStr)) != 0)
			)
		{
			pelicula_delete(nuevaPelicula);
			nuevaPelicula = NULL;
			//printf("\nEmployee: direccion de memoria NULL");
		}
	}
	return nuevaPelicula;
}//FIN employee_newParametros()
int pelicula_setId(Venta* this,int id)
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
int pelicula_setNombre(Venta* this,char* nombre)
{
	int ret = -1;
	if(this != NULL && nombre != NULL)
	{
		strcpy(this->nombre,nombre);
		ret = 0;
	}
	return ret;
}//FIN employee_setNombre()
int pelicula_setDias(Venta* this,int dia)
{
	int ret = -1;
	if(this != NULL && dia > -1)
	{
		this->dia = dia;
		ret = 0;
	}
	return ret;
}//FIN employee_setHorasTrabajadas()
int pelicula_setHora(Venta* this,int hora)
{
	int ret = -1;
	if(this != NULL && hora > -1)
	{
		this->horario.hora = hora;
		ret = 0;
	}
	return ret;
}//FIN employee_setSueldo()
int pelicula_setMinutos(Venta* this,int minutos)
{
	int ret = -1;
	if(this != NULL && minutos > -1)
	{
		this->horario.minutos = minutos;
		ret = 0;
	}
	return ret;
}//FIN employee_setSueldo()
int pelicula_setSala(Venta* this,int sala)
{
	int ret = -1;
	if(this != NULL && sala > -1)
	{
		this->sala = sala;
		ret = 0;
	}
	return ret;
}//FIN employee_setSueldo()
int pelicula_setCantidadEntradas(Venta* this,int cantidadEntradas)
{
	int ret = -1;
	if(this != NULL && cantidadEntradas > -1)
	{
		this->cantidadEntradas= cantidadEntradas;
		ret = 0;
	}
	return ret;
}//FIN employee_setSueldo()
int pelicula_setFacturacion(Venta* this,float facturacion)
{
	int ret = -1;
	if(this != NULL && facturacion > -1)
	{
		this->facturacion= facturacion;
		ret = 0;
	}
	return ret;
}//FIN employee_setSueldo()
int pelicula_getId(Venta* this,int* id)
{
	int ret = -1;
	if(this != NULL &&  id != NULL)
	{
		*id = this->id;
		ret = 0;
	}
	return ret;
}//FIN employee_getId()
int pelicula_getNombre(Venta* this,char* nombre)
{
	int ret = -1;
	if(this != NULL &&  nombre != NULL)
	{
		strcpy(nombre,this->nombre);
		ret = 0;
	}
	return ret;
}//FIN employee_getNombre()
int pelicula_getDias(Venta* this,int* dia)
{
	int ret = -1;
	if(this != NULL &&  dia != NULL)
	{
		*dia = this->dia;
		ret = 0;
	}
	return ret;
}//FIN employee_getHorasTrabajadas()
int pelicula_getHora(Venta* this,int* hora)
{
	int ret = -1;
	if(this != NULL &&  hora != NULL)
	{
		*hora = this->horario.hora;
		ret = 0;
	}
	return ret;
}//FIN employee_getSueldo()
int pelicula_getMinutos(Venta* this,int* minutos)
{
	int ret = -1;
	if(this != NULL &&  minutos != NULL)
	{
		*minutos = this->horario.minutos;
		ret = 0;
	}
	return ret;
}//FIN employee_getSueldo()
int pelicula_getSala(Venta* this,int* sala)
{
	int ret = -1;
	if(this != NULL &&  sala != NULL)
	{
		*sala = this->sala;
		ret = 0;
	}
	return ret;
}//FIN employee_getSueldo()
int pelicula_getCantidadEntradas(Venta* this,int* cantidadEntradas)
{
	int ret = -1;
	if(this != NULL &&  cantidadEntradas != NULL)
	{
		*cantidadEntradas = this->cantidadEntradas;
		ret = 0;
	}
	return ret;
}//FIN employee_getSueldo()
int pelicula_getFacturacion(Venta* this,float* facturacion)
{
	int ret = -1;
	if(this != NULL &&  facturacion != NULL)
	{
		*facturacion = this->facturacion;
		ret = 0;
	}
	return ret;
}//FIN employee_getSueldo()
int pelicula_SetDatos(Venta* this)
{
	int ret = -1;
	char nombre[128];
	int dia;
	Hora horario;
	if(this != NULL)
	{
//	    int id;
//	    char nombre[128];
//	    int dia;
//	    Hora horario;
//	    int sala;
//	    int cantidadEntradas;
		printf("\nA continuación, se le solicitarán los datos de la pelicula a dar de alta:\n");
		if((utn_getString(nombre, 128, "\nIngrese nombre de la pelicula", "\nError, ingrese sólo letras", 3, 3)) == 0 &&
			(utn_getNumeroMinimo(&dia, "\nIngrese dia de proyeccion de la pelicula", "\nError, ingrese un dia", 0, 3) == 0) &&
			(utn_getNumeroMinimo(&horario.hora, "\nIngrese hora de proyeccion de la pelicula", "\nError, ingrese una hora de proyeccion valida", 0, 3) == 0) &&
			(utn_getNumeroMinimo(&horario.minutos, "\nIngrese minutos de proyeccion de la pelicula", "\nError, ingrese minutos de proyeccion valida", 0, 3) == 0))
		{
			if(	(pelicula_setNombre(this,nombre) != 0) ||
				(pelicula_setDias(this,dia) != 0) ||
				(pelicula_setHora(this,horario.hora) != 0))
			{
				free(this);
				this = NULL;
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

	Venta* auxElementoA = NULL;
	Venta* auxElementoB = NULL;
	int ret = 0;
	if(pElementoA != NULL && pElementoB != NULL)
	{
		auxElementoA = (Venta*)pElementoA;
		auxElementoB = (Venta*)pElementoB;
		ret = (strcmp((*(auxElementoA)).nombre,(*(auxElementoB)).nombre));
	}
	return ret;
}//FIN sortByName_A_Z()
int sortByDias(void* pElementoA,void* pElementoB)
{

	int ret = 0;
	int auxDiasA;
	int auxDiasB;
	if(pElementoA != NULL && pElementoB != NULL)
	{
		pelicula_getDias((Venta*)pElementoA,&auxDiasA);
		pelicula_getDias((Venta*)pElementoB,&auxDiasB);

			if(auxDiasA > auxDiasB)	//Si A es mayor a B...
			{
				ret = 1;
			}
			else
			{
				if(auxDiasA <auxDiasB)
				{
					ret = -1;
				}
			}
	}
	return ret;
}//FIN sortByHoras()
int sortByHorario(void* pElementoA,void* pElementoB)
{
	Hora auxHorarioA;
	Hora auxHorarioB;
	int ret = 0;
	if(pElementoA != NULL && pElementoB != NULL)
	{
		pelicula_getHora((Venta*)pElementoA,&auxHorarioA.hora);
		pelicula_getHora((Venta*)pElementoB,&auxHorarioB.hora);
		pelicula_getMinutos((Venta*)pElementoA, &auxHorarioA.minutos);
		pelicula_getMinutos((Venta*)pElementoB, &auxHorarioB.minutos);
		if(auxHorarioA.hora > auxHorarioB.hora)	//Si A es mayor a B...
		{
			ret = 1;
		}
		else
		{
			if(auxHorarioA.hora <auxHorarioB.hora)
			{
				ret = -1;
			}
			else
			{
				if(auxHorarioA.minutos > auxHorarioB.minutos)
				{
					ret = 1;
				}
				else
				{
					if(auxHorarioA.minutos <auxHorarioB.minutos)
					{
						ret = -1;
					}
				}
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
		pelicula_getId((Venta*)pElementoA,&auxIdA);
		pelicula_getId((Venta*)pElementoB,&auxIdB);
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
void calcularFacturacion(void* pElement)
{

	int auxDias;
	int cantidadEntradas;
	float descuento = 1;
	float facturacion;
	if(pElement != NULL)
	{
		pelicula_getDias(pElement, &auxDias);
		pelicula_getCantidadEntradas(pElement, &cantidadEntradas);
		if(cantidadEntradas > 3)
		{
			descuento = 0.90;
		}
		if(auxDias > 0 && auxDias < 4)//LUNES, MARTES Y MIERCOLES
		{
			facturacion =  (float)240*cantidadEntradas*descuento;
			pelicula_setFacturacion(pElement, facturacion);
		}
		else	//DOMINGO,JUEVES, VIERNES Y SABADOS
		{
			facturacion = (float)350*cantidadEntradas*descuento;
			pelicula_setFacturacion(pElement, facturacion);
		}
	}
}//FIN calcularFacturacion
int contarEntradas(void* pElement)
{
	int ret = -1;
	if(pElement != NULL)
	{
//		if(pElement->Sala == 1)
		pelicula_getCantidadEntradas(pElement, &ret);
	}
	return ret;
}
int pelicula_PrintElement(Venta* pElement)
{
	int ret =-1;
	int auxId;
	char auxNombre[128];
	int auxDias;
	int auxHora;
	int auxMinutos;
	int auxSala;
	int cantidadEntradas;
	char nombreDia[10];
	if(pElement != NULL)
	{
		pelicula_getId(pElement,&auxId);
		pelicula_getNombre(pElement, auxNombre);
		pelicula_getDias(pElement, &auxDias);
		pelicula_getHora(pElement, &auxHora);
		pelicula_getMinutos(pElement, &auxMinutos);
		pelicula_getSala(pElement, &auxSala);
		pelicula_getCantidadEntradas(pElement, &cantidadEntradas);
		if(utn_NombreDia(auxDias,nombreDia) == 0)
		{
			printf("\n %d \t %s \t %s \t %d:%d \t %d \t %d",
					auxId,
					auxNombre,
					nombreDia,
					auxHora,
					auxMinutos,
					auxSala,
					cantidadEntradas);
			ret = 0;
		}
	}
	return ret;
}//FIN pelicula_PrintElement
