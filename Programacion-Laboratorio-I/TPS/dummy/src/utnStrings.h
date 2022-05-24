/*
 * utnStrings.h
 *
 *  Created on: 27 abr. 2021
 *      Author: Pedro
 */

#ifndef UTNSTRINGS_H_
#define UTNSTRINGS_H_


int esNumerica(char* cadena);
/**
* \brief ​Verifica​ ​si​ ​la​ ​cadena​ ​ingresada​ ​es​ ​numerica
* \​param​ ​cadena​ ​Cadena​ ​de​ ​caracteres​ a ​ser​ ​analizada
* \return ​Retorna​ 1 (​vardadero​) ​si​ ​la​ ​cadena​ ​es​ ​numerica​ y 0 (​falso​) ​si​ no ​lo​ ​es
*/
int getInt(int* pResultado);
/**
* \brief ​Verifica​ ​si​ ​la​ ​cadena​ ​ingresada​ ​es​ ​numerica
* \​param​ pResultado ​Puntero​ ​al​ ​espacio​ ​de​ ​memoria​ ​donde​ ​se​ ​dejara​ el ​resultado​ ​de​ ​la​ ​funcion
* \return ​Retorna​ 0 (EXITO) ​si​ ​se​ ​obtiene​ ​un​ ​numero​ ​entero​ y -1 (ERROR) ​si​ no
* *
*/
int myGets(char* cadena,int longitud);
/**
* \brief Lee ​de​ ​stdin​ ​hasta​ ​que​ ​encuentra​ ​un​ '\n' o ​hasta​ ​que​ ​haya​ ​copiado​ ​en​ ​cadena
* un​ ​máximo​ ​de​ '​longitud​ - 1' ​caracteres​.
* \​param​ pResultado ​Puntero​ ​al​ ​espacio​ ​de​ ​memoria​ ​donde​ ​se​ ​copiara​ ​la​ ​cadena​ ​obtenida
* \​param​ ​longitud​ Define el ​tamaño​ ​de​ ​cadena
* \return ​Retorna​ 0 (EXITO) ​si​ ​se​ ​obtiene​ ​una​ ​cadena​ y -1 (ERROR) ​si​ no
* *
*/


#endif /* UTNSTRINGS_H_ */
