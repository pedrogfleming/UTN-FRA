/*
 * estructuras.h
 *
 *  Created on: 8 may. 2021
 *      Author: Pedro
 */

#ifndef ESTRUCTURAS_H_
#define ESTRUCTURAS_H_
#include "arrayEmployees.h"

//*************************************ALTA,BAJA E INICIALIZACION DE ESTRUCTURAS*********************************************
int inicializarEstructura(employee arrayStruc[],int lengArray);
int bajaEstructura(employee arrayStruc[],int posicion);
int altaEstructura(employee arrayStruc[],int* punteroLegajo,int lengArray);
int modificarEstructura(employee arrayStruc[],int posicion,int campoModificar);
//*************************************BUSCAR EN ARRAY DE ESTRUCTURA*********************************************************
int buscarLibre(employee arrayStruc[],int lengArray);
int buscarLegajo(employee arrayStruc[],int lengArray);


//*************************************ORDENAR ARRAY DE ESTRUCTURAS***********************************************************
int ordenarAscendentemente_Entero_Cadena(employee arrayStruct[],int lengArray);
int ordenarDescendentemente_Entero_Cadena(employee arrayStruct[],int lengArray);
//*************************************MOSTRAR ESTRUCTURAS********************************************************************
int mostrarArrayEstructuras(employee arrayStruc[],int lengArray);
void mostrarEstructura(employee arrayStruc[],int posicion);

#endif /* ESTRUCTURAS_H_ */
