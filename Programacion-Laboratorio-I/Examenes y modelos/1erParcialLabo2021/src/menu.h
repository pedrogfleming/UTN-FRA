/*
 * menu.h
 *
 *  Created on: 8 may. 2021
 *      Author: Pedro
 */

#ifndef MENU_H_
#define MENU_H_


int mostrarMenu(int* punteroMenu,char* mensajeBienvenida);
/*Brief: muestra un menseja de bienvenida de menu y pide al usuario que ingrese un comando y lo valida
 * param puntero de tipo int donde guardara el valor ingresado por el usuario
 * param puntero de tipo char del mensaje de bienvenida
 * retorna 0 si pudo guardar el comando en el puntero, si no -1
 */
int confirmCommand(char* pMenu,char* message,char* eMessage,int tries);
/*Brief: le pide al usuario que confirme una accion a realizar en el programa
 * param puntero de tipo char donde se guardara el caracter ingresado por el usuario s/n
 * param puntero de tipo char donde se guardara el mensaje de confirmacion
 * param puntero de tipo char donde se guardara el mensaje de error
 * numero de intentos que tiene el usuario para confirmar la accion
 * retorna 0 si el usuario ingreso s o n, -1 si no
 */
#endif /* MENU_H_ */
