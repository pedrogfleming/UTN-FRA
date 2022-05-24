
#ifndef PANTALLA_H_
#define PANTALLA_H_

#include "utn.h"

typedef struct{
	int idPantalla;
	char nombre[20];
	char direccion[20];
	int tipo;
	float precio;
	int isEmpty; // 0 ocupado, 1 libre
}pantalla;


int inicializarEstructuraPantalla(pantalla arrayStruc[],int lengArray);

#endif /* PANTALLA_H_ */
