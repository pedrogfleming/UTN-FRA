/*
 * menu.h
 *
 *  Created on: 8 may. 2021
 *      Author: Pedro
 */

#ifndef MENU_H_
#define MENU_H_


int mostrarMenu(int* punteroMenu,char* mensajeBienvenida);
int confirmCommand(int* pMenu,char* message,char* eMessage,int tries);
#endif /* MENU_H_ */
