/*
 ============================================================================
 Name        : trabajoPractico2.c
 Author      : 
 Version     :
 Copyright   : Your copyright notice
 Description :
 El sistema deber� tener el siguiente men� de opciones:
1. ALTAS: Se debe permitir ingresar un empleado calculando autom�ticamente el n�mero
de Id. El resto de los campos se le pedir� al usuario.
2. MODIFICAR: Se ingresar� el N�mero de Id, permitiendo modificar: o Nombre o Apellido
o Salario o Sector
3. BAJA: Se ingresar� el N�mero de Id y se eliminar� el empleado del sistema.
4. INFORMAR:
1. Listado de los empleados ordenados alfab�ticamente por Apellido y Sector.
2. Total y promedio de los salarios, y cu�ntos empleados superan el salario promedio.
NOTA: Se deber� realizar el men� de opciones y las validaciones a trav�s de funciones.
Tener en cuenta que no se podr� ingresar a los casos 2, 3 y 4; sin antes haber realizado la
carga de alg�n empleado.
Para la realizaci�n de este programa, se utilizar� una biblioteca llamada �ArrayEmployees� que
facilitar� el manejo de la lista de empleados y su modificaci�n. En la secci�n siguiente se
detallan las funciones que esta biblioteca debe tener.
 ============================================================================
 */



#include <stdio.h>
#include <stdlib.h>
#include "entidades.h"


#define TOTALEMPLOYEES 1000
#define DESCRICPCION
#define TOTALOPCIONESMENU 4

int main(void)
{
	setbuf(stdout,NULL);
	employee arrayEmployees[TOTALEMPLOYEES];
/*
	char minorLetter;
	char mayorLetter;

	int commandSubMenu;

	char confirm;

	int searchSlot;
	int mayorAge;

	int auxSectorId;
	char auxSectorName[20];

	searchSlot = -1;
	countIdEmployee = 1000;
	minorLetter = 'a';
	mayorLetter = 'z';

*/
	int countIdEmployee;
	int commandMenu;
	int subCommandMenu;
	char exitUser;
	int slotSearchEmployee;
	int sortOrder;
	float averageSalaryAux;
	countIdEmployee = 1000;
	initEmployees(arrayEmployees,TOTALEMPLOYEES);

	do
	{
		mostrarMenu(&commandMenu,"\nMenu: Ingrese el numero para acceder a los submenus\n0-Salir \n1-Alta empleado \n2-Modificar empleado\n3-Baja empleado\n4-Informes\n5-Listar empleados",TOTALOPCIONESMENU);
		switch (commandMenu)
					{
							case 0:										//Salir
							{
								exitUser = 'n';
								printf("\nHa salido del programa");
								break;
							}
						case 1:											//Alta empleado
							//fflush(stdin);
							printf("\n2-Alta empleado\nIngrese a continuacion los datos del empleado a dar de alta");
							altaEstructura(arrayEmployees,&countIdEmployee,TOTALEMPLOYEES);
							break;
						case 2:											//Modificar empleado
							{
								if(zeroEmployees(arrayEmployees,TOTALEMPLOYEES) == 0)
								{
									slotSearchEmployee = buscarLegajo(arrayEmployees,TOTALEMPLOYEES);
									if(slotSearchEmployee > -1)
									{
										mostrarMenu(&subCommandMenu,
												"\nMenu modificacion empleado:Ingrese campo para modificar\n\n"
												"1-Nombre\n\n"
												"2-Apellido\n\n"
												"3-Salario\n\n"
												"4-Id Sector",4);
										if(subCommandMenu >= 1 && subCommandMenu <= 4)
										{
											if(modificarEstructura(arrayEmployees, slotSearchEmployee, subCommandMenu) != 0)
											{
												printf("\nError, no se pudo realizar la modificacion\n");
											}
											else
											{
												printf("\nSe ha modificado con exito el siguiente elemento:\n\n");
												mostrarEstructura(arrayEmployees,slotSearchEmployee);
											}
										}
										else
										{
											printf("\nError al ingresar el comando\n");
										}
									}
								}
								else
								{
									printf("\nNo puede modificar empleados dado que no hay ninguno cargado en el sistema");
								}


								break;
							}

						case 3:											//Baja empleado
							{
								if(zeroEmployees(arrayEmployees,TOTALEMPLOYEES) == 0)
								{
									if(removeEmployee(arrayEmployees,TOTALEMPLOYEES) == 0)
									{
										printf("\nSe ha dado de baja el empleado con exito");

									}
								}
								else
								{
									printf("\nNo puede dar de baja empleados dado que no hay ninguno cargado en el sistema");
								}

								break;
							}
						case 4:											//INFORMES
							{
								if(zeroEmployees(arrayEmployees,TOTALEMPLOYEES) == 0)
								{
									mostrarMenu(&subCommandMenu,
												"\nMenu informes:Ingrese informe que desea realizar\n\n"
												"1-Listado de los empleados ordenados alfabeticamente por apellido y sector"
												"2-Total y promedio de los salarios, y cuantos empleados superan el salario promedio"
												,2);
									switch(subCommandMenu)
									{
									case 1:
										{
											if(utn_getNumero(&sortOrder, "\nElija el criterio para ordenar a los empleados: \nAscentente (0)\nDescendente(1)", "\nError, s�lo ingrese:\n Ascentente (0)\nDescendente(1) ", 0, 1, 3) == 0)
											{
												if(sortEmployees(arrayEmployees,TOTALEMPLOYEES,sortOrder))
												{
													printf("\nNo se ha podido realizar lo solicitado\n");
												}
											}

											break;
										}
									case 2:
										{
											//Primero, sumo los salarios y calculo el salario promedio
											if(averageSalary(arrayEmployees,TOTALEMPLOYEES,&averageSalaryAux) == 0)
											{
												//Recorro el array usando como criterio de inclusion los que superan el salario promedio
												findUpperAverageSalary(arrayEmployees,TOTALEMPLOYEES,averageSalaryAux);
											}

											break;
										}
									}//FIN SWITCH
								}
								else
								{
									printf("\nNo puede entrar a informes dado que no hay ningun empleado cargado en el sistema");
								}
								break;
							}
						default:
							printf("\nError, ha ingresado un comando invalido de menu.");
							break;
					}//FIN SWITCH

	}while(exitUser != 'n');

	return EXIT_SUCCESS;




}
