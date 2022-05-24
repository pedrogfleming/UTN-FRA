/*
 ============================================================================
 Name        : clase4LaboratioEjB.c
 Author      : Geraghty Fleming Pedro 1E
 Version     :
 Copyright   : Your copyright notice
 Description : Al menú anterior chequear que no pueda ingresar a ninguna opción si no se logueó
 ============================================================================
 */
int mostrarMenu(int* punteroMenu);

#include <stdio.h>
#include <stdlib.h>

int main(void)
{
	int* comandoMenu;
	setbuf(stdout,NULL);
	mostrarMenu(comandoMenu);
	switch (*comandoMenu)
	{
		case '1':

				break;
		case '2':

				break;
		case '3':

				break;
		case '4':

				break;
		case '5':

				break;

	}




	return EXIT_SUCCESS;
}
int mostrarMenu(int* punteroMenu)
{

	printf("Ingrese comando para interactuar con el menú \n1. Loguearse\n2. Comprar\n3. Ver mis compras\n4. Vender\n5. Salir\n");
	scanf("%p",*punteroMenu);
	return 0;

}


//entrada al menu del programa
/*do
{
	//se le muestran las opciones del menu al usuario
	mostrarMenu();
	//Usuario ingresa comando

	//Se valida si eligio una opcion valida
	//switch para cada opcion del menu
		//1. Loguearse,
		//2. Comprar,
		//3. Ver mis compras,
		//4. Vender,
		//5. Salir

}while();
*/

/*
 * 	switch (comandoMenu)
	{
		case '1':
		{
			printf("\nf- Usted seleccionó 1. Loguearse");
			break;
		}
		case '2':
		{
			printf("\nf- Usted seleccionó 2. Comprar");
			break;
		}
		case '3':
		{
			printf("\nf- Usted seleccionó 3. Ver mis compras");
			break;
		}
		case '4':
		{
			printf("\nf- Usted seleccionó 4. Vender");
			break;
		}
		case '5':
		{
			printf("\nf- Usted seleccionó 5. Salir");
			break;
		}
		default:
			break;
	}
 * */


