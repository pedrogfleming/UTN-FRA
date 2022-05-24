

#ifndef RECAUDACION_H_
#define RECAUDACION_H_
#include "utn.h"
typedef struct{
	int idRecaudacion;
	int mes;
	int tipo;
	float importe;
	int idContribuyente;
	int estado;	// saldado 0, refinanciado 1, 2 adeudado,
	char descripcionEstado[13];
	char descripcionTipoRecaudacion[10];//1-ARBA, 2-IIBB, 3-GANANCIAS
	int isEmpty; // 0 ocupado, 1 libre
}recaudacion;


int inicializarEstructuraRecaudacion(recaudacion arrayStruc[],int lengArray);
/*Brief: Inicializar array estructura de tipo recaudacion modificando el campo is.Empty = 1
 * param array de tipo estructura recaudacion
 * entero correspondiente al largo del array
 * retorna 0 si logro inicializar, -1 si no
 */
int altaRecaudacion(recaudacion arrayStruc[],int* idRecaudacion,int lengArrayRecaudacion,int posicion,int idContribuyente);
/*Brief: Pide datos a cargar, los valida y los asigna a una posición de un array de tipo estructura recaudacion
 *param array estructura recaudacion
 *param puntero de tipo int que apunta al id de recaudacion
 *param largo del array de tipo int
 *param  posición a cargar dentro del array de tipo int
 *retorna 0 si logro tomar los datos y cargarlos en la posicion del array, -1 si no
 */
int refinanciarRecaudacion(recaudacion arrayRecaudaciones[],int posicion);
/*Brief: modifica el estado de la recaudacion a refinanciada de un array de estructura de tipo recaudacion
 * param array de estructura de tipo contribuyente
 * param posicion donde se va a realizar la modificacion de tipo int
 * retorna -1 si no lo pudo modificar, si no 0 en caso de exito
 */
int saldarRecaudacion(recaudacion arrayRecaudaciones[],int posicion);
/*Brief: modifica el estado de la recaudacion a saldada de un array de estructura de tipo recaudacion
 * param array de estructura de tipo contribuyente
 * param posicion donde se va a realizar la modificacion de tipo int
 * retorna -1 si no lo pudo modificar, si no 0 en caso de exito
 */
int bajaRecaudacion(recaudacion arrayRecaudacions[],int posicion);
/*Brief: da de baja una recaudacion marcando su campo is.empty = -1
 * param array de tipo estructura recaudacion
 * param posicion de tipo int que se quiere dar de baja
 * retorna 0 en caso que se pudo dar de baja, -1 en caso de que no
 */
int bajaRecaudaciones(recaudacion arrayStruc[],int lengArray,int idContribuyente);
/*Brief: da de baja todas las recaudaciones asociadas a un contribuyente marcando su campo is.empty = -1
 * param array de tipo estructura recaudacion
 * param posicion de tipo int que se quiere dar de baja
 * retorna 0 en caso que se pudo dar de baja, -1 en caso de que no
 */
int hayRecaudaciones(recaudacion arrayStruc[],int lengArray);
/*Brief: chequea que exista por lo menos un recaudacion en el array de recaudacion
 * param array de tipo estructura recaudacion donde revisara si hay una posicion cargada previamente
 * param largo del array de estructura de tipo int
 * retorna 0 si encontro un contribuyente cargado en el array, si no -1
 */
int buscarRecaudacionLibre(recaudacion arrayStruc[],int lengArray);
/*Brief: busca la primera posicion dentro del array de recaudacion libre
 *param array estructura recaudacion
 *param largo del array de estructura de tipo int
 *retorna la  posicion de recaudacion que primero encuentre vacia, -1 si no encontro una posicion libre en el array
 */
int buscarIdRecaudacion(recaudacion arrayStruc[],int lengArray,int* idContribuyente,int idRecaudacionMaximo);
/*Brief: Se busca un id en el array que ingrese el usuario
 *param array estructura recaudacion
 *param largo del array de estructura de tipo int
 *param id maximo cargado hasta el momento de contribuyente en el array de tipo int
 *param id maximo cargado hasta el momento de recaudacion en el array de tipo int
 *retorna la posicion dentro del array de tipo recaudacion que coincida con el id pedido, -1 si no la encontro
 */
void asignarDescripcionEstadoRecaudacion(recaudacion arrayStruc[],int posicion);
/*Brief: Asigna descripcion estado de recaudacion en funcion de valores 0-Saldado, 1 Refinanciado y 2 adeudado
 * param array estructura recaudacion
 * param posicion del array de estructura recaudacion donde se hara la asignacion
 * no retorna nada
 */
void asignarDescripcionTipo(recaudacion arrayStruc[],int posicion);
/*Brief: Asigna descripcion del tipo de recaudacion en funcion de valores 1-ARBA, 2 IIBB y 3 GANANCIAS
 * param array estructura recaudacion
 * param posicion del array de estructura recaudacion donde se hara la asignacion
 * no retorna nada
 */
void mostrarRecaudacion(recaudacion arrayStruc[],int posicion);
/*Brief: muestra una solo recaudacion
 * param  array estructura recaudacion
 *param posicion dentro del array de contribuyente que se desea mostrar
 *No retorna nada
 */
int mostrarArrayRecaudaciones(recaudacion arrayStruc[],int lengArray);
/*Brief: muestra todos los Recaudaciones que posee el array de Recaudaciones
 * param  array estructura recaudacion
 * param largo del array de estructura de tipo int
 * retorna 0 si por lo menos pudo mostrar un recaudacion, -1 si ninguno *
 */
int mostrarRecaudacionesPorIdContribuyente(recaudacion arrayStruc[],int lengArray,int idContribuyente);
/*Brief: muestra todas los Recaudaciones asociadas a un id contribuyente
 * param  array estructura recaudacion
 * param largo del array de estructura de tipo int
 * param id que se buscara comparar
 * retorna 0 si por lo menos pudo mostrar un recaudacion, -1 si ninguno *
 */
int get_IdContribuyentePorPosicionRecaudacion(recaudacion arrayStruc[],int posicionRecaudacion,int* idContribuyente);
/*Brief : obtiene el id contribuyente en base a una posicion de una recaudacion
 *param array estructura recaudacion
 *param posicion de la recaudacion en el array recaudacion
 *param puntero de tipo int donde se guaradara el id del contribuyente de esa posicion
 *param retorna 0 si pudo ubicarlo, -1 si no
 */
int get_PosicionRecaudacionPorIdContribuyente(recaudacion arrayStruc[],int lengArray,int* posicionRecaudacion,int idContribuyente);
/*Brief: obtiene posicion de la recaudacion por medio de un id contribuyente
 *param array recaudacion
 *param largo array recaudacion de tipo int
 *param puntero de tipo int donde se guardara el valor de la posicon de la recaudacion encontrada
 *param id contribuyente para buscar
 *retorna retorna 0 si lo encontro, -1 si no *
 */
int getImporteMayorRecaudacion(recaudacion arrayRecaudacion[],int lengArrayRecaudacion, float* mayorRecaudacion);
/*Brief: obtiene el importe de la mayor recaudacion de un array de recaudaciones
 * param array recaudacion
 * param largo array recaudacion de tipo int
 * param puntero de tipo float donde se guadara el importe de la mayor recaudacion
 * retorna 0 si encontro la mayor recaudacion y la guardo en el puntero, si no -1
 */
int ordenarAscendentemente_RecaudacionPorIdContribuyente(recaudacion arrayStruc[],int lengArray);
#endif /* RECAUDACION_H_ */
