/*
 * utn.h
 *
 *  Created on: 27 abr. 2021
 *      Author: Pedro
 */

int utn_getNumero(int* pResultado,char* mensaje, char* mensajeError,int minimo,int maximo,int reintentos);
/**
* \brief ​Solicita​ ​un​ ​numero​ ​al​ ​usuario​, ​leuego​ ​de​ ​verificarlo​ ​devuelve​ el ​resultado
* \​param​ pResultado ​Puntero​ ​al​ ​espacio​ ​de​ ​memoria​ ​donde​ ​se​ ​dejara​ el ​resultado​ ​de​ ​la​ ​funcion
* \​param​ ​mensaje​ ​Es​ el ​mensaje​ a ​ser​ ​mostrado
* \​param​ mensajeError ​Es​ el ​mensaje​ ​de​ Error a ​ser​ ​mostrado
* \​param​ ​minimo​ ​Es​ el ​numero​ ​maximo​ a ​ser​ ​aceptado
* \​param​ ​maximo​ ​Es​ el ​minimo​ ​minimo​ a ​ser​ ​aceptado
* \return ​Retorna​ 0 ​si​ ​se​ ​obtuvo​ el ​numero​ y -1 ​si​ no
*/


int mostrarMenu(int* punteroMenu,int numeroUno, int numeroDos);
//Brief Muestra un menu predeterminado y le pide al usuario que ingrese una opcion
//Recibe como primer parametro un puntero
//Recibe como segundo parametro un int
//Recibe como tercer parametro un int
//Retorna un int, 0 si funcionó y -1 si no funcionó
