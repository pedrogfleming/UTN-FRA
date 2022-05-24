/*
 * publicidad.h
 *
 *  Created on: 13 may. 2021
 *      Author: Pedro
 */

#ifndef PUBLICIDAD_H_
#define PUBLICIDAD_H_
#include "utn.h"
typedef struct{
	int idPublicidad;
	char cuit[14];
	int dias;
	char archivo[20];
	int idPantalla;
	int isEmpty; // 0 ocupado, 1 libre
}publicidad;

int inicializarEstructuraPublicidad(publicidad arrayStruc[],int lengArray);
int mostrarArrayPublicidades(publicidad arrayStruc[],int lengArray);
void mostrarPublicidad(publicidad arrayStruc[],int posicion);
#endif /* PUBLICIDAD_H_ */
