/*
 ============================================================================
 Name        : 1erParcialLabo2021.c
 Author      : Geraghty Fleming Pedro 1E
 Version     :
 Copyright   : Your copyright notice
 Description : Hello World in C, Ansi-style
 ============================================================================
 */
#include <stdio.h>
#include <stdlib.h>
#include "contribuyente.h"
#include "utn.h"
#include "recaudacion.h"
#include "menu.h"
#include "informes.h"
#define TOTALCONTRIBUYENTES 50
#define TOTALRECAUDACIONES 50
int main(void)
{
	setbuf(stdout, NULL);
	int comandoMenu;
	int comandoSubMenu;
	char confirmarAccion;
	int slotLibre;
	int slotBusquedaContribuyente;
	int slotBusquedaRecaudacion;
	int idContadorContribuyente;
	int idContadorRecaudacion;
	int idContribuyenteAux;
	contribuyente arrayContribuyentes[TOTALCONTRIBUYENTES];
	recaudacion arrayRecaudaciones[TOTALRECAUDACIONES];
	idContadorContribuyente = 1000;
	idContadorRecaudacion = 100;
	inicializarEstructuraContribuyente(arrayContribuyentes, TOTALCONTRIBUYENTES);
	inicializarEstructuraRecaudacion(arrayRecaudaciones,TOTALRECAUDACIONES);
	do
	{
		mostrarMenu(&comandoMenu,"\nMENU:\n\n Ingrese a continuación la gestión que desea realizar:\n\n1-ALTA CONTRIBUYENTE\n\n2-MODIFICAR DATOS DEL CONTRIBUYENTE\n\n3-BAJA DE CONTRIBUYENTE\n\n4-RECAUDACION\n\n5-REFINANCIAR RECAUDACION\n\n6-SALDAR RECAUDACION\n\n7-IMPRIMIR CONTRIBUYENTES\n\n8-IMPRIMIR RECAUDACIONES\n\n0-SALIR\n");

			switch (comandoMenu)
			{
				case 0://************************************************SALIR******************************************************************************
					{
							comandoMenu = -1;
							break;
					}
				case 1://*****************************************ALTA CONTRIBUYENTE************************************************************************
					{
							printf("\nALTA CONTRIBUYENTE:\n\n\n");
							slotLibre =buscarContribuyenteLibre(arrayContribuyentes,TOTALCONTRIBUYENTES);
							if ( slotLibre > -1 &&(altaContribuyente(arrayContribuyentes,&idContadorContribuyente,TOTALCONTRIBUYENTES,slotLibre)) == 0)
							{
								printf("\n\n CONTRIBUYENTE DADO DE ALTA EXITOSAMENTE");
								mostrarContribuyente(arrayContribuyentes,slotLibre);
							}
							break;
					}
				case 2://*****************************************MODIFICAR CONTRIBUYENTE*******************************************************************
					{
							printf("\nMODIFICAR CONTRIBUYENTE:\n\n\n");
							if(hayConstribuyentes(arrayContribuyentes,TOTALCONTRIBUYENTES) == 0)
							{
								slotBusquedaContribuyente = buscarIdContribuyente(arrayContribuyentes,TOTALCONTRIBUYENTES,idContadorContribuyente);
								if(slotBusquedaContribuyente > -1)
								{
									mostrarMenu(&comandoSubMenu,
											"\nMenu modificacion CONTRIBUYENTE:Ingrese campo para modificar\n\n"
											"1-Nombre\n\n"
											"2-Apellido\n\n"
											"3-Cuil\n\n");
									if(comandoSubMenu >= 1 && comandoSubMenu <= 3)
									{
										if(modificarContribuyente(arrayContribuyentes, TOTALCONTRIBUYENTES, slotBusquedaContribuyente, comandoSubMenu) != 0)
										{
											printf("\nError, no se pudo realizar la modificacion");
										}
									}
									else
									{
										printf("\nError al ingresar el comando");
									}
								}
							}
							break;
						}
				case 3://*****************************************BAJA CONTRIBUYENTE***********************************************************************
					{
						printf("\nDAR DE BAJA CONTRIBUYENTE:\n\n\n");
						if(hayConstribuyentes(arrayContribuyentes,TOTALCONTRIBUYENTES) == 0)
						{
							slotBusquedaContribuyente = buscarIdContribuyente(arrayContribuyentes,TOTALCONTRIBUYENTES,idContadorContribuyente);		//Primero solicito el id a dar de baja y lo busco
							if(slotBusquedaContribuyente > -1)
							{
								printf("\nEste el contribuyente encontrado:\n\n");
								mostrarContribuyente(arrayContribuyentes,slotBusquedaContribuyente);
								mostrarRecaudacionesPorIdContribuyente(arrayRecaudaciones,TOTALRECAUDACIONES,arrayContribuyentes[slotBusquedaContribuyente].idContribuyente);
								confirmCommand(&confirmarAccion,"\n¿Desea confirmar la accion?s/n","\nError, ingrese solo s/n ",3);
								if(confirmarAccion == 's')
								{
									if(bajaContribuyente(arrayContribuyentes, slotBusquedaContribuyente) == 0)
									{
										printf("\nSe ha dado de baja con exito el siguiente elemento:\n\n");
										bajaRecaudaciones(arrayRecaudaciones,TOTALRECAUDACIONES,arrayContribuyentes[slotBusquedaContribuyente].idContribuyente);
										mostrarContribuyente(arrayContribuyentes,slotBusquedaContribuyente);
									}
								}
								else
								{
									printf("\nAbortada la operación");
								}
							}
						}
						break;
					}
				case 4://*****************************************ALTA RECAUDACION******************************************************************************
					{
						if(hayConstribuyentes(arrayContribuyentes,TOTALCONTRIBUYENTES) == 0)
						{
							printf("\nALTA RECAUDACION:\n\n\n");
							slotLibre =buscarRecaudacionLibre(arrayRecaudaciones,TOTALRECAUDACIONES);
							if ( slotLibre > -1)
							{
								if(existeContribuyente(arrayContribuyentes,TOTALCONTRIBUYENTES,&idContribuyenteAux,idContadorContribuyente) == 0)
								{
									if((altaRecaudacion(arrayRecaudaciones,&idContadorRecaudacion,TOTALRECAUDACIONES,slotLibre,idContribuyenteAux)) == 0)
									{
										printf("\n\n RECAUDACION DADA DE ALTA EXITOSAMENTE");
										mostrarRecaudacion(arrayRecaudaciones,slotLibre);
									}
								}
							}
							else
							{
								printf("\n\n ERROR. SIN ESPACIO PARA ALMACENAR MAS RECAUDACIONES");
							}
						}
						break;
					}
				case 5://*****************************************REFINANCIAR RECAUDACION*************************************************************************
					{
						if(hayRecaudaciones(arrayRecaudaciones,TOTALRECAUDACIONES) == 0)
						{
							printf("\nREFINANCIAR RECAUDACION:\n\n\n");
							slotBusquedaRecaudacion = buscarIdRecaudacion(arrayRecaudaciones,TOTALRECAUDACIONES,&idContribuyenteAux,idContadorRecaudacion);
							if(slotBusquedaRecaudacion > -1)
							{
								if(get_IdContribuyentePorPosicionRecaudacion(arrayRecaudaciones,slotBusquedaRecaudacion,&idContribuyenteAux) == 0)
								{
									if(get_PosicionContribuyentePorId(arrayContribuyentes,TOTALCONTRIBUYENTES,&slotBusquedaContribuyente,idContribuyenteAux) == 0)
									{
										printf("\nEste el contribuyente asociado a la recaudación:\n\n");
										mostrarRecaudacionesPorIdContribuyente(arrayRecaudaciones,TOTALRECAUDACIONES,idContribuyenteAux);
										mostrarContribuyente(arrayContribuyentes,slotBusquedaContribuyente);
										refinanciarRecaudacion(arrayRecaudaciones,slotBusquedaContribuyente);

									}
									else
									{
										printf("\nNo se pudo encontrar el ID ingresado");
									}
								}
							}
						}
						break;
					}
				case 6://*****************************************SALDAR RECAUDACION********************************************************************************
					{
						printf("\nSALDAR RECAUDACION:\n\n\n");
						if(hayRecaudaciones(arrayRecaudaciones,TOTALRECAUDACIONES) == 0)
						{
							slotBusquedaRecaudacion = buscarIdRecaudacion(arrayRecaudaciones,TOTALRECAUDACIONES,&idContribuyenteAux,idContadorRecaudacion);
							if(slotBusquedaRecaudacion != -1)
							{

								if(get_PosicionContribuyentePorId(arrayContribuyentes,TOTALCONTRIBUYENTES,&slotBusquedaContribuyente
										,idContribuyenteAux) == 0)
									{
										printf("\nEste el contribuyente asociado a la recaudación:\n\n");
										mostrarContribuyente(arrayContribuyentes,slotBusquedaContribuyente);
										saldarRecaudacion(arrayRecaudaciones,slotBusquedaRecaudacion);
									}
									else
									{
										printf("\nNo se pudo encontrar el ID Recaudacion ingresado");
									}
							}
						}
						break;
					}
				case 7://*****************************************IMPRIMIR CONTRIBUYENTES*************************************************************************
					{
						if(hayConstribuyentes(arrayContribuyentes,TOTALCONTRIBUYENTES) == 0)
						{
							printf("\nIMPRIMIR CONTRIBUYENTES:\n\n\n");
							informeContribuyentes(arrayContribuyentes,TOTALCONTRIBUYENTES,arrayRecaudaciones,TOTALRECAUDACIONES);
						}
						break;
					}
				case 8://*****************************************IMPRIMIR RECAUDACION***************************************************************************
					{
						if(hayRecaudaciones(arrayRecaudaciones,TOTALRECAUDACIONES) == 0)
						{
							printf("\nIMPRIMIR RECAUDACION:\n\n\n");
							mostrarArrayRecaudacionesSaldadas(arrayRecaudaciones,TOTALRECAUDACIONES,arrayContribuyentes,TOTALCONTRIBUYENTES);
						}
						break;
					}
				case 9:
					{
						if(hayConstribuyentes(arrayContribuyentes,TOTALCONTRIBUYENTES) == 0)
						{
							mostrarMenu(&comandoSubMenu,
									"\nMenu INFORMES:Ingrese informe a realizat\n\n"
									"1-Contribuyentes con mas recaudaciones en estado refinanciar\n\n"
									"2-Cantaidad de recaudaciones saldadas de importe mayor a 1000: se imprimira la cantidad de recaudaciones en estado saldado con ese importe o mayor\n\n"
									"3-Informar todos los datoss de los contribuyenbtes de un tipo de recaudacion ingresea da por el usuario (ARBA, IIB, GANANCIAS)\n\n"
									"4-Nombre y cuil de los contribuyentes que pagaron impuestos en el mes de febrero");
							switch (comandoSubMenu)
							{
								case 1:

									break;
								case 2:
									mostrarRecaudacionesMayoresSaldadas(arrayRecaudaciones,TOTALRECAUDACIONES,arrayContribuyentes,TOTALCONTRIBUYENTES);
									break;
								case 3:
									mostrarArrayRecaudacionesPorTipo(arrayRecaudaciones,TOTALRECAUDACIONES,arrayContribuyentes,TOTALCONTRIBUYENTES);
									break;
								case 4:
									mostrarContribuyentesRecaudacionFebrero(arrayRecaudaciones,TOTALRECAUDACIONES,arrayContribuyentes,TOTALCONTRIBUYENTES);

									break;
								default:
									printf("\nHa ingresado una opcion invalida, volverá al menu principal");
									break;
							}





						}
						//Contribuyentes con mas recaudaciones en estado refinanciar

						//Cantaidad de recaudaciones saldadas de importe mayor a 1000: se imprimira la cantidad de recaudaciones en estado saldado" con ese importe o mayor

						//Informar todos los datoss de los contribuyenbtes de un tipo de recaudacion ingresea da por el usuario (ARBA, IIB, GANANCIAS)

						//Nombre y cuil de los contribuyentes que pagaron impuestos en el mes de febrero
						break;
					}
				default:
					{
						printf("\nHa ingresado un comando de menú inválido.\n");
						break;
					}

			}//FIN SWITCH
		}while(comandoMenu != -1);

	printf("\n... FIN PROGRAMA");

	return 0;
}

