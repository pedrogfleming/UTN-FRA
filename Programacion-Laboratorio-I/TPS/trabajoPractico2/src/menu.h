/*
 * menu.h
 *
 *  Created on: 8 may. 2021
 *      Author: Pedro
 */

#ifndef MENU_H_
#define MENU_H_


void mostrarMenu(int* punteroMenu,char* mensajeBienvenida,int  maximo);
/*Brief:Muestra las opciones de un menu y toma un valor y lo valida en funcion del maximo de opciones disponibles que tenga el menu
 *Param1 : recibe un puntero de tipo int donde se va a guardar el comando que ingrese el usuario
 *Param2: recibe un char puntero con la cadena correspondiente al mensaje que va a mostrar el menu
 *Param3: recibe un int que es el maximo de opciones disponibles con las que cuenta el menu
 *No retorna nada, dado que itera hasta que el usuario ingrese un comando valido
 */
int confirmCommand(char* pMenu,char* message,char* eMessage,int tries);
/*Brief: le pide al usuario que confirme una accion previamente realizada, con s/n, validandolo
 * Param1: recibe un puntero de tipo char donde guardara la confirmacion o negacion del usuario
 * Param2: recibe  un puntero de tipo char cadena con el mensaje preguntandole al usuario que confirme la accion
 * Param3: recibe un puntero de tipo char cadena con el mensaje de error en caso que el usuario no ingrese un caracter valido
 * Param4: recibe un int con la cantidad de intentos con los que cuenta el usuario
 * Retorna 0 si se pudo guardar exitosamente el comando en el puntero del primer parametro, -1 si no pudo
 */
#endif /* MENU_H_ */
