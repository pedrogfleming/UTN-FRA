#include "Libros.h"

#include <stdio.h>
#include <stdlib.h>
#include <string.h>

#include "utn.h"

void libro_delete(eLibro* this)
{
	free(this);
}

eLibro* libro_new()
{
	eLibro* direccionMemoria = NULL;
	direccionMemoria = (eLibro*) malloc(sizeof(eLibro));
	return direccionMemoria;
}//libro_new

eLibro* libro_newParametros(char* idStr,char* tituloStr,char* autorStr,char* precioStr,char* editorialIdStr)
{
	eLibro* nuevoLibro = libro_new();
	int idEditorialAux;
	if(idStr != NULL && tituloStr != NULL && autorStr != NULL && precioStr != NULL && editorialIdStr != NULL)
	{
		if(	(libro_setId(nuevoLibro,atoi(idStr)) != 0) ||
			(libro_setTitulo(nuevoLibro,tituloStr) != 0) ||
			(libro_setAutor(nuevoLibro,autorStr) != 0) ||
			(libro_setPrecio(nuevoLibro,atof(precioStr)) != 0)||
			(descripcionToInt(editorialIdStr,&idEditorialAux) != 0)||
			(libro_setEditorialId(nuevoLibro,idEditorialAux) != 0)
			)
		{
			libro_delete(nuevoLibro);
			nuevoLibro = NULL;
		}
		else
		{
			libro_new(nuevoLibro);
		}
	}
	return nuevoLibro;
}//FIN libro_newParametros()
int libro_setId(eLibro* this,int id)
{
	int ret = -1;
	if(this != NULL && id > 0)
	{
		this->id =id;
		ret = 0;
	}
	return ret;
}//FIN libro_setId()
int libro_setTitulo(eLibro* this,char* titulo)
{
	int ret = -1;
	if(this != NULL && titulo != NULL)
	{
		strcpy(this->titulo,titulo);
		ret = 0;
	}
	return ret;
}//FIN libro_setTitulo()
int libro_setAutor(eLibro* this,char* autor)
{
	int ret = -1;
	if(this != NULL && autor != NULL)
	{
		strcpy(this->autor,autor);
		ret = 0;
	}
	return ret;
}//FIN libro_setAutor()
int libro_setPrecio(eLibro* this,float precio)
{
	int ret = -1;
	if(this != NULL && precio > -1)
	{
		this->precio = precio;
		ret = 0;
	}
	return ret;
}//FIN libro_setPrecio()
int libro_setEditorialId(eLibro* this,int id)
{
	int ret = -1;
	if(this != NULL &&  id >= 1 && id <= 6)
	{
		this->editorialId = id;
		ret = 0;
	}
	return ret;
}//FIN libro_getEditorialId()
int libro_getId(eLibro* this,int* id)
{
	int ret = -1;
	if(this != NULL &&  id != NULL)
	{
		*id = this->id;
		ret = 0;
	}
	return ret;
}//FIN libro_getId()
int libro_getTitulo(eLibro* this,char* titulo)
{
	int ret = -1;
	if(this != NULL &&  titulo != NULL)
	{
		strcpy(titulo,this->titulo);
		ret = 0;
	}
	return ret;
}//FIN libro_getTitulo()
int libro_getAutor(eLibro* this,char* autor)
{
	int ret = -1;
	if(this != NULL &&  autor != NULL)
	{
		strcpy(autor,this->autor);
		ret = 0;
	}
	return ret;
}//FIN libro_getAutor()
int libro_getPrecio(eLibro* this,float* precio)
{
	int ret = -1;
	if(this != NULL &&  precio != NULL)
	{
		*precio = this->precio;
		ret = 0;
	}
	return ret;
}//FIN libro_getPrecio()
int libro_getEditorialId(eLibro* this,int* id)
{
	int ret = -1;
	if(this != NULL &&  id != NULL)
	{
		*id = this->editorialId;
		ret = 0;
	}
	return ret;
}//FIN libro_getEditorialId()




//int pelicula_SetDatos(Venta* this)
//{
//	int ret = -1;
//	char nombre[128];
//	int dia;
//	Hora horario;
//	if(this != NULL)
//	{
////	    int id;
////	    char nombre[128];
////	    int dia;
////	    Hora horario;
////	    int sala;
////	    int cantidadEntradas;
//		printf("\nA continuación, se le solicitarán los datos de la pelicula a dar de alta:\n");
//		if((utn_getString(nombre, 128, "\nIngrese nombre de la pelicula", "\nError, ingrese sólo letras", 3, 3)) == 0 &&
//			(utn_getNumeroMinimo(&dia, "\nIngrese dia de proyeccion de la pelicula", "\nError, ingrese un dia", 0, 3) == 0) &&
//			(utn_getNumeroMinimo(&horario.hora, "\nIngrese hora de proyeccion de la pelicula", "\nError, ingrese una hora de proyeccion valida", 0, 3) == 0) &&
//			(utn_getNumeroMinimo(&horario.minutos, "\nIngrese minutos de proyeccion de la pelicula", "\nError, ingrese minutos de proyeccion valida", 0, 3) == 0))
//		{
//			if(	(pelicula_setNombre(this,nombre) != 0) ||
//				(pelicula_setDias(this,dia) != 0) ||
//				(pelicula_setHora(this,horario.hora) != 0))
//			{
//				free(this);
//				this = NULL;
//			}
//			else
//			{
//				ret = 0;
//			}
//
//		}
//	}
//	return ret;
//}//FIN employee_SetDatos()
int sortByAutor_A_Z(void* pElementoA,void* pElementoB)
{

	eLibro* auxElementoA = NULL;
	eLibro* auxElementoB = NULL;
	int ret = 0;
	if(pElementoA != NULL && pElementoB != NULL)
	{
		auxElementoA = (eLibro*)pElementoA;
		auxElementoB = (eLibro*)pElementoB;
		ret = (strcmp((*(auxElementoA)).autor,(*(auxElementoB)).autor));
	}
	return ret;
}//FIN sortByName_A_Z()
//int sortByDias(void* pElementoA,void* pElementoB)
//{
//
//	int ret = 0;
//	int auxDiasA;
//	int auxDiasB;
//	if(pElementoA != NULL && pElementoB != NULL)
//	{
//		pelicula_getDias((Venta*)pElementoA,&auxDiasA);
//		pelicula_getDias((Venta*)pElementoB,&auxDiasB);
//
//			if(auxDiasA > auxDiasB)	//Si A es mayor a B...
//			{
//				ret = 1;
//			}
//			else
//			{
//				if(auxDiasA <auxDiasB)
//				{
//					ret = -1;
//				}
//			}
//	}
//	return ret;
//}//FIN sortByHoras()
//int sortByHorario(void* pElementoA,void* pElementoB)
//{
//	Hora auxHorarioA;
//	Hora auxHorarioB;
//	int ret = 0;
//	if(pElementoA != NULL && pElementoB != NULL)
//	{
//		pelicula_getHora((Venta*)pElementoA,&auxHorarioA.hora);
//		pelicula_getHora((Venta*)pElementoB,&auxHorarioB.hora);
//		pelicula_getMinutos((Venta*)pElementoA, &auxHorarioA.minutos);
//		pelicula_getMinutos((Venta*)pElementoB, &auxHorarioB.minutos);
//		if(auxHorarioA.hora > auxHorarioB.hora)	//Si A es mayor a B...
//		{
//			ret = 1;
//		}
//		else
//		{
//			if(auxHorarioA.hora <auxHorarioB.hora)
//			{
//				ret = -1;
//			}
//			else
//			{
//				if(auxHorarioA.minutos > auxHorarioB.minutos)
//				{
//					ret = 1;
//				}
//				else
//				{
//					if(auxHorarioA.minutos <auxHorarioB.minutos)
//					{
//						ret = -1;
//					}
//				}
//			}
//		}
//	}
//	return ret;
//}//FIN sortBySueldo()
//int sortById(void* pElementoA,void* pElementoB)
//{
//	int auxIdA;
//	int auxIdB;
//	int ret = 0;
//	if(pElementoA != NULL && pElementoB != NULL)
//	{
//		pelicula_getId((Venta*)pElementoA,&auxIdA);
//		pelicula_getId((Venta*)pElementoB,&auxIdB);
//		if(auxIdA > auxIdB)	//Si A es mayor a B...
//		{
//			ret = 1;
//		}
//		else
//		{
//			if(auxIdA <auxIdB)
//			{
//				ret = -1;
//			}
//		}
//
//	}
//	return ret;
//}//FIN sortById()
void calcularDescuentos(void* pElement)
{
	int auxEditorialId;
	float precioLibro;
	if(pElement != NULL)
	{
		//1-PLANETA 2-SIGLO XXI EDITORES 3-PEARSON 4-MONOTAURO 5-SALAMANDRA 6-PENGUIN BOOKS
		libro_getEditorialId(pElement, &auxEditorialId);
		libro_getPrecio(pElement, &precioLibro);
		switch (auxEditorialId)
		{
			case 1:	//PLANETA
				if(precioLibro >= 300 )
				{
					precioLibro = precioLibro*0.80;
					libro_setPrecio(pElement, precioLibro);
				}
				break;
			case 2:	//SIGLO XXI EDITORES
				if(precioLibro <= 200 )
				{
					precioLibro = precioLibro*0.90;
					libro_setPrecio(pElement, precioLibro);
				}
				break;
			case 3:	//PEARSON

				break;
			case 4:	//MONOTAURO

				break;
			case 5:	//SALAMANDRA
				break;
			default:
				break;
		}
	}
}//FIN calcularFacturacion
int libro_ContarEditorial_Planeta(void* pElement)
{
	int ret = 0;
	int idAux;
	if(pElement != NULL)
	{
		if(libro_getEditorialId(pElement, &idAux) == 0 && idAux == 1)
		{
			ret = 1;
		}
	}
	return ret;
}//libro_ContarEditorial_Planeta()
int libro_PrintElement(eLibro* pElement)
{
	int ret =-1;
	int auxId;
	char auxTitulo[128];
	char auxAutor[128];
	float auxPrecio;
	int auxEditorialId;
	char descripcionEditorial[30];
	if(pElement != NULL)
	{
		libro_getId(pElement,&auxId);
		libro_getTitulo(pElement, auxTitulo);
		libro_getAutor(pElement, auxAutor);
		libro_getPrecio(pElement, &auxPrecio);
		libro_getEditorialId(pElement, &auxEditorialId);
		if(idEditorial_to_Descripcion(auxEditorialId,descripcionEditorial) == 0)
		{
			printf("%-4d %-50s	%-15s 	%5.2f  	  %-20s\n",
					auxId,
					auxTitulo,
					auxAutor,
					auxPrecio,
					descripcionEditorial);
			ret = 0;
		}
	}
	return ret;
}//FIN pelicula_PrintElement()
int libro_filterByPigna(void* element)
{
	int ret = 0;
	char auxNombreAuthor[128];
	if(element != NULL)
	{
		libro_getAutor(element, auxNombreAuthor);
		if(stricmp(auxNombreAuthor,"pigna") == 0)	//criterio
		{
			ret = 1;
		}
	}
	return ret;
}//FIN libro_filterByAuthor()
int libro_filterByPrice(void* element)
{
	int ret = 0;
	float price;
	if(element != NULL)
	{
		libro_getPrecio(element, &price);
		if(price >= 500) 				//criterio
		{
			ret = 1;
		}
	}
	return ret;
}//FIN libro_filterByPrice()
int descripcionToInt(char* pString,int* pId)
{
	int ret = -1;
	if(pString != NULL && pId != NULL)
	{
		if(strcmp(pString,"Planeta") == 0)
		{
			*pId = 1;
			ret = 0;
		}
		if(strcmp(pString,"SIGLO XXI EDITORES") == 0)
		{
			*pId = 2;
			ret = 0;
		}
		if(strcmp(pString,"Pearson") == 0)
		{
			*pId = 3;
			ret = 0;
		}
		if(strcmp(pString,"Minotauro") == 0)
		{
			*pId = 4;
			ret = 0;
		}
		if(strcmp(pString,"SALAMANDRA") == 0)
		{
			*pId = 5;
			ret = 0;
		}
		if(strcmp(pString,"PENGUIN BOOKS") == 0)
		{
			*pId = 6;
			ret = 0;
		}
	}
	return ret;
}//FIN descripcionToInt()
int idEditorial_to_Descripcion(int Id,char* pString)
{
	int ret = -1;
	if(pString != NULL && Id >= 1 && Id <= 6)
	{
		switch (Id)
		{
			case 1:
				strcpy(pString,"Planeta");
				ret =0;
				break;
			case 2:
				strcpy(pString,"SIGLO XXI EDITORES");
				ret =0;
				break;
			case 3:
				strcpy(pString,"Pearson");
				ret =0;
				break;
			case 4:
				strcpy(pString,"Minotauro");
				ret =0;
				break;
			case 5:
				strcpy(pString,"SALAMANDRA");
				ret =0;
				break;
			case 6:
				strcpy(pString,"PENGUIN BOOKS");
				ret =0;
				break;
			default:
				break;
		}
	}
	return ret;

}//FIN idEditorial_to_Descripcion()
