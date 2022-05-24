

#ifndef INFORMES_H_
#define INFORMES_H_

int informeContribuyentes(contribuyente arrayContribuyentes[],int lengArrayContribuyentes,recaudacion arrayRecaudaciones[],int lengArrayRecaudaciones);
/*Brief: Imprime una lista de los contribuyentes con todos sus datos junto con las recaudaciones que posee
 * param array de estructuras contribuyentes de tipo contribuyente
 * param largo del array de contribuyentes de tipo int
 * param array de estructuras recaudaciones de tipo recaudacion
 * largo array del array de recaudaciones de tipo int
 * retorna 0 si mostro el informe por lo menos una vez, -1 si no
 */
void mostrarInformeContribuyente(contribuyente arrayContribuyentes[],int idContribuyente,recaudacion arrayRecaudaciones[],int lengArrayRecaudaciones,int posicionContribuyente);
 /*Brief: Imprime a un contribuyente y todas sus recaudaciones asociadas
  * param array de estructuras contribuyentes de tipo contribuyente
  * param id contribuyente de tipo int que asocia las recaudaciones con el contribuyente
  * param array de estructuras recaudaciones de tipo recaudacion
  * largo array del array de recaudaciones de tipo int
  * no retorna nada
  */
int mostrarArrayRecaudacionesSaldadas(recaudacion arrayRecaudacion[],int lengArrayRecaudacion,contribuyente arrayContribuyente[],int lengArrayContribuyente);
/*Brief: Imprime todas las recaudaciones saldadas y el contribuyente asociado
 * param array de estructuras recaudaciones de tipo recaudacion
 * param largo array del array de recaudaciones de tipo int
 * param array de estructuras contribuyentes de tipo contribuyente
 * param largo del array de contribuyentes de tipo int
 * retorna 0 si pudo imprimir un contribuyente y/o una recaudacion, si no -1
 */
int mostrarRecaudacionesMayores(recaudacion arrayRecaudacion[],int lengArrayRecaudacion,contribuyente arrayContribuyente[],int lengArrayContribuyente,float mayorRecaudacion);
/*Brief: Muestra todas las recaudaciones que tengan el importe mas alto
 * param array de estructuras recaudaciones de tipo recaudacion
 * param largo array del array de recaudaciones de tipo int
 * param array de estructuras contribuyentes de tipo contribuyente
 * param largo del array de contribuyentes de tipo int
 * param importe de la recaudacion mas alta de tipo float
 * retorna 0 si encontro la mayor recaudacion, si no -1
 */
int mostrarRecaudacionesMayoresSaldadas(recaudacion arrayRecaudacion[],int lengArrayRecaudacion,contribuyente arrayContribuyente[],int lengArrayContribuyente);
int mostrarArrayRecaudacionesPorTipo(recaudacion arrayRecaudacion[],int lengArrayRecaudacion,contribuyente arrayContribuyente[],int lengArrayContribuyente);
int mostrarContribuyentesRecaudacionFebrero(recaudacion arrayRecaudacion[],int lengArrayRecaudacion,contribuyente arrayContribuyente[],int lengArrayContribuyente);
#endif /* INFORMES_H_ */
