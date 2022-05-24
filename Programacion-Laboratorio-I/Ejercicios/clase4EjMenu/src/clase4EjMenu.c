/*
 ============================================================================
 Name        : clase4LaboratioEjB.c
 Author      : Geraghty Fleming Pedro 1E
 Version     :
 Copyright   : Your copyright notice
 Description :  xA- Hacer el menú de un programa con las siguientes opciones:
  	  	  	  	  1. Loguearse, 2. Comprar, 3. Ver mis compras, 4. Vender, 5. Salir
				xB- Al menú anterior chequear que no pueda ingresar a ninguna opción si no se logueó
				xC- Al menú anterior chequear que no pueda ver sus compras, si no ingresó primero a comprar al menos una vez
				xD- Cuando se ingresa a la opción vender del menú, debe abrirse otro menú que contenga:
				 	 	 1. Vender 2. Hacer factura 3. Volver atrás
				XE- A lo anterior sumarle que haya compras para poder vender.
				 	 	 (Si compré una vez y vendí una vez no puedo ingresar a vender).
				F- Pasar las acciones de menú a funciones y llevarlas a una biblioteca
 ============================================================================
 */


#include <stdio.h>
#include <stdlib.h>
#include "bibliotecaMenu.h"



int main(void)
{
	int comandoMenu;
	int comandoSubMenuVender;
	int flagLogueo;
	int contadorStock;
	flagLogueo = 0;
	contadorStock = 0;
	setbuf(stdout,NULL);

	//entrada al menu del programa
	do
	{
		//se le muestran las opciones del menu al usuario
		mostrarMenu(&comandoMenu);
		//Usuario ingresa comando
		//comandoMenu();
		//Se valida si eligio una opcion valida
		//switch para cada opcion del menu
			//1. Loguearse,
			//2. Comprar,
			//3. Ver mis compras,
			//4. Vender,
			//5. Salir
		switch (comandoMenu)
				{
					case 1://LOGUEARSE
					{
						printf("\n- Usted seleccionó 1. Loguearse\n");
						flagLogueo = 1;
						break;
					}
					case 2://COMPRAR
					{
						if(flagLogueo == 1)
						{
							printf("\n- Usted seleccionó 2. Comprar\n");
							contadorStock++;
						}
						else
						{
							printf("\n- Debe loguearse para poder ingresar a cualquier opción");
						}
						break;
					}
					case 3://VER MIS COMPRAS
					{
						if(flagLogueo == 1)
						{
							if(contadorStock > 0)
							{
							printf("\n- Usted seleccionó 3. Ver mis compras\n");
							}
							else
							{
								printf("\n-Para ver sus compras primero debe comprar\n");
							}
						}
						else
						{
							printf("\n- Debe loguearse para poder ingresar a cualquier opción");
						}
						break;
					}
					case 4://VENDER
					{
						if(flagLogueo == 1)
						{
							printf("\n- Usted seleccionó 4. Vender\n");


							do
							{
								mostrarSubMenuVender(&comandoSubMenuVender);
								switch(comandoSubMenuVender)//SUBMENU DE VENTAS
								{
									case 1:
										{
											if(contadorStock > 0)
											{
											printf("\nUsted seleccionó 1-Vender\n");
											contadorStock--;
											}
											else
											{
												printf("No hay stock para vender");
											}
											break;
										}
									case 2:
										{
											printf("\nUsted seleccionó 2-Hacer factura\n");
											break;
										}
									case 3:
										{
											printf("\nUsted seleccionó 3-Volver atrás\n");
											break;
										}
								}
							}while(comandoSubMenuVender != 3);
						}
						else
						{
							printf("\n- Debe loguearse para poder ingresar a cualquier opción\n");
						}
						break;
					}
					case 5://SALIR
					{

						printf("\n- Usted seleccionó 5. Salir\n");
						break;
					}
					default:
						printf("\nError, ha ingresado un comando inválido\n");

						break;
				mostrarMenu(&comandoMenu);
				}

	}while(comandoMenu != 5);

	return EXIT_SUCCESS;
}







