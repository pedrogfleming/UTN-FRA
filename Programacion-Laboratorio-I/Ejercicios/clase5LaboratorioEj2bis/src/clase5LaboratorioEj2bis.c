/*
 ============================================================================
 Name        : clase5LaboratorioEj2bis.c
 Author      : Geraghty Fleming Pedro 1E
 Version     : Ejercicio 2 bis
 Copyright   : Your copyright notice
 Description :  De 10 empleados de una fabrica se registra:
 	 	 	 	 	 -número de legajo
 	 	 	 	 	 -edad
 	 	 	 	 	 -sueldo
				Se pide ingresar los datos consecutivamente y calcular el sueldo promedio

 ============================================================================
 */

#include <stdio.h>
#include <stdlib.h>
#define TOTALEMPLEADOS 10

int main(void)
{
	setbuf(stdout,NULL);
	int edadesEmpleados[TOTALEMPLEADOS];
	float sueldosEmpleados[TOTALEMPLEADOS];
	float acumuladorSueldos;
	float promedioSueldos;
	int i;
	acumuladorSueldos = 0;
	for (i = 0; i < TOTALEMPLEADOS; ++i)
	{
		printf("\n Ingrese edad del empleado\n");
		scanf("%d",&edadesEmpleados[i]);
		printf("\n Ingrese sueldo del empleado\n");
		scanf("%f",&sueldosEmpleados[i]);
	}//FIN FOR
	for (i = 0; i < TOTALEMPLEADOS; ++i)
	{
		acumuladorSueldos = acumuladorSueldos+sueldosEmpleados[i];
	}
	promedioSueldos = acumuladorSueldos/TOTALEMPLEADOS;
	printf("%.2f",promedioSueldos);
	return EXIT_SUCCESS;
}
