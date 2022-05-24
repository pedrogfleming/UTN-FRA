
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
int altaPantalla(pantalla arrayStruc[],int* idPantalla,int lengArray,int posicion);
int modificarPantalla(pantalla arraypantallas[],int lengArray,int posicion,int campoModificar);
int bajaPantalla(pantalla arraypantallas[],int posicion);

int buscarPantallaLibre(pantalla arrayStruc[],int lengArray);
int buscarIdPantalla(pantalla arrayStruc[],int lengArray);

void mostrarpantalla(pantalla arrayStruc[],int posicion);
int mostrarArraypantallas(pantalla arrayStruc[],int lengArray);
#endif /* PANTALLA_H_ */
