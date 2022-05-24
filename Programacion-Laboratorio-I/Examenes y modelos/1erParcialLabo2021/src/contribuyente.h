
#ifndef CONTRIBUYENTE_H_
#define CONTRIBUYENTE_H_

#include "utn.h"

typedef struct{
	int idContribuyente;
	char nombre[20];
	char apellido[20];
	char cuil[14];
	int isEmpty; // 0 ocupado, 1 libre
}contribuyente;


int inicializarEstructuraContribuyente(contribuyente arrayStruc[],int lengArray);
/*Brief: Inicializar array estructura de tipo contribuyente modificando el campo is.Empty = 1
 * param array de tipo estructura contribuyente
 * entero correspondiente al largo del array
 * retorna 0 si logro inicializar, -1 si no
 */
int altaContribuyente(contribuyente arrayStruc[],int* idContribuyente,int lengArray,int posicion);
/*Brief: Pide datos a cargar, los valida y los asigna a una posición de un array de tipo estructura contribuyente
 *param array estructura contribuyente
 *param puntero de tipo int que apunta al id de contribuyente
 *param largo del array de tipo int
 *param  posición a cargar dentro del array de tipo int
 *retorna 0 si logro tomar los datos y cargarlos en la posicion del array, -1 si no
 */
int modificarContribuyente(contribuyente arrayContribuyentes[],int lengArray,int posicion,int campoModificar);
/*Brief: modifica un campo de una posicion de un array de estructura de tipo contribuyente
 * param array de estructura de tipo contribuyente
 * param largo de ese array de tipo int
 * param posicion donde se va a realizar la modificacion de tipo int
 * param campo que se desea modifar de esa posicion del array de estructura
 * retorna -1 si no lo pudo modificar, si no 0 en caso de exito
 */
int bajaContribuyente(contribuyente arrayContribuyentes[],int posicion);
/*Brief: da de baja un contribuyente marcando su campo is.empty = -1
 * param array de tipo estructura contribuyente
 * param posicion de tipo int que se quiere dar de baja
 * retorna 0 en caso que se pudo dar de baja, -1 en caso de que no
 */
int hayConstribuyentes(contribuyente arrayContribuyentes[],int lengArray);
/*Brief: chequea que exista por lo menos un contribuyente en el array de contribuyente
 * param array de tipo estructura contribuyente donde revisara si hay una posicion cargada previamente
 * param largo del array de estructura de tipo int
 * retorna 0 si encontro un contribuyente cargado en el array, si no -1
 */
int buscarContribuyenteLibre(contribuyente arrayStruc[],int lengArray);
/*Brief: busca la primera posicion dentro del array de contribuyente libre
 *param array estructura contribuyente
 *param largo del array de estructura de tipo int
 *retorna la  posicion de contribuyente que primero encuentre vacia, -1 si no encontro una posicion libre en el array
 */
int buscarIdContribuyente(contribuyente arrayStruc[],int lengArray,int idMaximo);
/*Brief: Se busca un id en el array que ingrese el usuario
 *param array estructura contribuyente
 *param largo del array de estructura de tipo int
 *param id maximo cargado hasta el momento de contribuyentes en el array de tipo int
 *retorna la posicion dentro del array de tipo contribuyente que coincida con el id pedido, -1 si no la encontro
 */
int existeContribuyente(contribuyente arrayContribuyente[],int lengArray,int* idContribuyente,int maximoId);
/*Brief chequea que exista el contribuyente en el array y guarda el id por referencia ingresado
 * param  array estructura contribuyente
 * param largo del array de estructura de tipo int
 * param puntero de tipo int donde se guardara el legajo ingresado y validado
 * retorna 0 si encontro el legajo solicitado, -1 si no
 */
void mostrarContribuyente(contribuyente arrayStruc[],int posicion);
/*Brief: muestra un solo contribuyente
 * param  array estructura contribuyente
 *param posicion dentro del array de contribuyente que se desea mostrar
 *No retorna nada
 */
int mostrarArrayContribuyentes(contribuyente arrayStruc[],int lengArray);
/*Brief: muestra todos los contribuyentes que posee el array de contribuyentes
 * param  array estructura contribuyente
 * param largo del array de estructura de tipo int
 * retorna 0 si por lo menos pudo mostrar un contribuyente, -1 si ninguno *
 */
int get_PosicionContribuyentePorId(contribuyente arrayStruc[],int arrayLeng,int* posicionContribuyente,int idContribuyente);
/*Brief: Obtiene la posicion del contribuyente por id
 * param  array estructura contribuyente
 * param largo del array de estructura de tipo int
 * param puntero de tipo int donde se guardara la posicion asociada a ese id ingresado
 * param id del contribuyente que se va a buscar de tipo int
 * retorna 0 si encontro una posicion que coincida con el id, -1 si no
 */
int ordenarContribuyentes(contribuyente arrayStruc[],int lengArray,int order);
/*Brief:ordena contribuyentes de forma ascendente o descendente según prefiera el usario
 *param array estructura contribuyente
 *param largo del array de estructura de tipo int
 *param orden ascendente(0) o descendente(1) de tipo int
 *retorna 0 si pudo invocar a las funciones de ordenamiento, -1 si no
 */
int ordenarAscendentemente_Contribuyentes(contribuyente arrayStruc[],int lengArray);
/*Brief: ordena de forma ascendente por doble criterio el array, por legajo primero y despues por apellido
 * param array estructura contribuyente
 * param largo del array de estructura de tipo int
 * retorna 0 si pudo ordenarlos, si no -1
 */
int ordenarDescendentemente_Entero_Cadena(contribuyente arrayStruc[],int lengArray);
/*Brief: ordena de forma descendente por doble criterio el array, por legajo primero y despues por apellido
 * param array estructura contribuyente
 * param largo del array de estructura de tipo int
 * retorna 0 si pudo ordenarlos, si no -1
*/
#endif /* CONTRIBUYENTE_H_ */
