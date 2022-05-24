/*
 * bibliotecaA.h
 *
 *  Created on: 7 abr. 2021
 *      Author: Pedro
 */

#ifndef BIBLIOTECAA_H_
#define BIBLIOTECAA_H_

int validarPositivo(int* entero);
//Brief valida que el numero que toma como parametro sea positivo > 1
// si no, vuelve a pedir al usuario que ingrese otro numero entero positivo
//Parametro 1 recibe un puntero
//La validacion se devuelve como puntero
//Retorna un entero que significa que la funcion funciono
int validarEscalaTemperatura(char* escalaV);
//Brief valida que el char ingresado sea celsius(c) o fahrenheit(f)
// si no, vuelve a pedir al usuario que ingrese otro caracter
//Parametro 1 recibe un char
//La validacion itera mientras no se ingrese char c o f
//Retorna un entero que significa que la funcion funciono
int validarTemperaturaCE(float temperaturaV,char escalaV);
//Brief valida que el float ingresado este dentro del rango congelamiento y ebullicion segun celcius o farenheit
// si no, vuelve a pedir al usuario que ingrese otro numero float
//Parametro 1 recibe un float
//Parametro 2 recibe un char
//Retorna un entero que significa que la funcion funciono
int convertirTemperatura(float temperaturaC,float* resultado,char* escala);
//Brief convierte de celsius a faranheit o viceversa
//Parametro 1 recibe un float, la temperatura base a convertir
//Parametro 2 recibe un float con puntero donde guarda el resultado de la conversion
//Parametro 3 recibe un char con puntero, donde se define la escala base (farenheit o celsius)
//Retorna un entero que significa que la funcion funciono
#endif /* BIBLIOTECAA_H_ */
