/*
 ============================================================================
 Name        : clase4LaboratorioEjA.c
 Author      : Geraghty Fleming Pedro 1E
 Version     :	Ejercicio Menu A
 Copyright   : Your copyright notice
 Description :  Hacer el menú de un programa con las siguientes opciones:
				  1. Loguearse,
				  2. Comprar,
				  3. Ver mis compras,
				  4. Vender,
				  5. Salir
 ============================================================================
 */

#include <stdio.h>
#include <stdlib.h>
int mostrarMenu(int* puntero);

int main(void)
{
	setbuf(stdout,NULL);
	int comandoMenu;
	mostrarMenu(&comandoMenu);
	printf("Desde el main %d",comandoMenu);





	return EXIT_SUCCESS;
}
int mostrarMenu(int* puntero)
{

	printf("Ingrese comando para interactuar con el menú \n1. Loguearse\n2. Comprar\n3. Ver mis compras\n4. Vender\n5. Salir\n");
	*puntero = scanf("%d",puntero);

	return 0;

}

