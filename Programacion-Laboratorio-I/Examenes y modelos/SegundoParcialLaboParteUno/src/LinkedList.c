#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include "LinkedList.h"


static Node* getNode(LinkedList* this, int nodeIndex);
static int addNode(LinkedList* this, int nodeIndex,void* pElement);

/** \brief Crea un nuevo LinkedList en memoria de manera dinamica
 *
 *  \param void
 *  \return LinkedList* Retorna (NULL) en el caso de no conseguir espacio en memoria
 *                      o el puntero al espacio reservado
 */
LinkedList* ll_newLinkedList(void)
{
    LinkedList* this;
    this = (LinkedList*) malloc (sizeof (LinkedList));
    if(this != NULL)
    {
    	this->pFirstNode = NULL;
    	this->size = 0;
    }
    return this;
}

/** \brief Retorna la cantidad de elementos de la lista
 *
 * \param this LinkedList* Puntero a la lista
 * \return int Retorna (-1) si el puntero es NULL o la cantidad de elementos de la lista
 *
 */
int ll_len(LinkedList* this)
{
    int returnAux = -1;
    if(this != NULL)
    {
    	returnAux = this->size;
    }
    return returnAux;
}


/** \brief  Obtiene un nodo de la lista
 *
 * \param this LinkedList* Puntero a la lista
 * \param index int Indice del nodo a obtener
 * \return Node* Retorna  (NULL) Error: si el puntero a la lista es NULL o (si el indice es menor a 0 o mayor al len de la lista)
                        (pNode) Si funciono correctamente
 *
 */
static Node* getNode(LinkedList* this, int nodeIndex)
{
	Node* nodoActual = NULL;
	if(this != NULL && nodeIndex >= 0 && ll_len(this) > nodeIndex)
	{
			nodoActual = this->pFirstNode;
			for (int i = 0;i < nodeIndex;  i++)
			{
				nodoActual = nodoActual->pNextNode;
			}
//			nodoActual = this->pFirstNode;
//			while(auxIndex != nodeIndex-1)
//			{
//				nodoActual = nodoActual->pNextNode;
//				auxIndex++;
//			}
			//nodeIndex = auxIndex;
			//encontrado = nodoActual;
	}
    return nodoActual;
}

/** \brief  Permite realizar el test de la funcion getNode la cual es privada
 *
 * \param this LinkedList* Puntero a la lista
 * \param index int Indice del nodo a obtener
 * \return Node* Retorna  (NULL) Error: si el puntero a la lista es NULL o (si el indice es menor a 0 o mayor al len de la lista)
                        (pElement) Si funciono correctamente
 *
 */
Node* test_getNode(LinkedList* this, int nodeIndex)
{
    return getNode(this, nodeIndex);
}


/** \brief Agrega y enlaza un nuevo nodo a la lista
 *
 * \param this LinkedList* Puntero a la lista
 * \param nodeIndex int Ubicacion donde se agregara el nuevo nodo
 * \param pElement void* Puntero al elemento a ser contenido por el nuevo nodo
 * \return int Retorna  (-1) Error: si el puntero a la lista es NULL o (si el indice es menor a 0 o mayor al len de la lista)
                        ( 0) Si funciono correctamente
 *
 */
static int addNode(LinkedList* this, int nodeIndex,void* pElement)
{
    int returnAux = -1;
    Node* newNode = NULL;
    //Node* nextNode = NULL;
    Node* prevNode = NULL;

	newNode = (Node*)malloc(sizeof(Node));
    if(this != NULL && nodeIndex >= 0 && newNode != NULL)
    {
    	//donde va a ser insertado el nodo?
    	//si es la 1� posicion o en el medio de nodos
    	//Siempre guardo en una aux la referencia al index
    	//Remplazo con la nueva direccion de memoria
    	newNode->pElement = pElement;
		if(nodeIndex == 0)
		{
			newNode->pNextNode = this->pFirstNode;
			this->pFirstNode = newNode; //Ahora si piso el primer elemento
			returnAux = 0;
		}
		else
		{
			prevNode = getNode(this, nodeIndex-1);
			if(prevNode!= NULL)
			{
				newNode->pNextNode = prevNode->pNextNode;
				prevNode->pNextNode= newNode;
				returnAux = 0;
			}
		}
		if(returnAux == 0)
		{
			this->size++;
		}

    }
    return returnAux;
}

/** \brief Permite realizar el test de la funcion addNode la cual es privada
 *
 * \param this LinkedList* Puntero a la lista
 * \param nodeIndex int Ubicacion donde se agregara el nuevo nodo
 * \param pElement void* Puntero al elemento a ser contenido por el nuevo nodo
  * \return int Retorna  (-1) Error: si el puntero a la lista es NULL o (si el indice es menor a 0 o mayor al len de la lista)
                        ( 0) Si funciono correctamente
 *
 */
int test_addNode(LinkedList* this, int nodeIndex,void* pElement)
{
    return addNode(this,nodeIndex,pElement);
}


/** \brief  Agrega un elemento a la lista
 * \param pList LinkedList* Puntero a la lista
 * \param pElement void* Puntero al elemento a ser agregado
 * \return int Retorna  (-1) Error: si el puntero a la lista es NULL
                        ( 0) Si funciono correctamente
 *
 */
int ll_add(LinkedList* this, void* pElement)
{
    int returnAux = -1;
    if(this != NULL)
    {
    	returnAux = addNode(this, ll_len(this), pElement);
    }
    return returnAux;
}

/** \brief Permite realizar el test de la funcion addNode la cual es privada
 *
 * \param this LinkedList* Puntero a la lista
 * \param nodeIndex int Ubicacion del elemento a obtener
 * \return void* Retorna    (NULL) Error: si el puntero a la lista es NULL o (si el indice es menor a 0 o mayor al len de la lista)
                            (pElement) Si funciono correctamente
 *
 */
void* ll_get(LinkedList* this, int index)
{

    void* returnAux = NULL;
    Node* auxNode = NULL;
    if(this != NULL && index >= 0 && index < ll_len(this))
    {
    	auxNode = getNode(this,index);
    	if(auxNode != NULL)
    	{
    		returnAux = auxNode->pElement;
    	}
    }
    return returnAux;
}


/** \brief Modifica un elemento de la lista
 *
 * \param this LinkedList* Puntero a la lista
 * \param nodeIndex int Ubicacion del elemento a modificar
 * \param pElement void* Puntero al nuevo elemento
 * \return int Retorna  (-1) Error: si el puntero a la lista es NULL o (si el indice es menor a 0 o mayor al len de la lista)
                        ( 0) Si funciono correctamente
 *
 */
int ll_set(LinkedList* this, int index,void* pElement)
{
    int returnAux = -1;
    Node* auxNode = NULL;
    if(this != NULL && index >= 0 && index < ll_len(this))
    {
    	auxNode = getNode(this,index);
    	if(auxNode != NULL)
    	{
    		auxNode->pElement = pElement;
    		returnAux = 0;
    	}
    }
    return returnAux;
}


/** \brief Elimina un NODO!!!! de la lista
 *
 * \param this LinkedList* Puntero a la lista
 * \param nodeIndex int Ubicacion del elemento a eliminar
 * \return int Retorna  (-1) Error: si el puntero a la lista es NULL o (si el indice es menor a 0 o mayor al len de la lista)
                        ( 0) Si funciono correctamente
 *
 */
int ll_remove(LinkedList* this,int index)
{
    int returnAux = -1;
    Node* auxNode = NULL;
    Node* prevNode = NULL;
    Node* nextNode = NULL;
    if(this != NULL && index >= 0 && index < ll_len(this))
    {
    	auxNode = getNode(this,index);
    	if(auxNode != NULL)
    	{
        	if(index == 0)
        	{
        		prevNode = this->pFirstNode;
        		nextNode = auxNode->pNextNode;
        		this->pFirstNode = nextNode; //Ahora si piso el primer elemento
        		returnAux = 0;
        	}
        	else
        	{
        		prevNode = getNode(this, index-1);
        		if(prevNode!= NULL)
        		{
        			prevNode->pNextNode= auxNode->pNextNode;
        			returnAux = 0;
        		}
        	}
        	if(returnAux == 0)
        	{
				this->size--;
				free(auxNode);
        	}
    	}
    }

    return returnAux;
}

/** \brief Elimina todos los elementos de la lista
 *
 * \param this LinkedList* Puntero a la lista
 * \return int Retorna  (-1) Error: si el puntero a la lista es NULL
                        ( 0) Si funciono correctamente
 *
 */
int ll_clear(LinkedList* this)
{
    int returnAux = -1;
    int i;
    if(this != NULL)
    {
    	for (i = 0; i< ll_len(this); i++)
    	{
			if(ll_remove(this, i) != 0)
			{
				returnAux = -1;
				break;
			}
			returnAux = 0;
		}
    }
    return returnAux;
}
/** \brief Elimina todos los elementos de la lista y la lista
 *
 * \param this LinkedList* Puntero a la lista
 * \return int Retorna  (-1) Error: si el puntero a la lista es NULL
                        ( 0) Si funciono correctamente
 *
 */
int ll_deleteLinkedList(LinkedList* this)
{
    int returnAux = -1;
    if(this != NULL && ll_clear(this) == 0)
    {
    	free(this);
		returnAux = 0;
    }
    return returnAux;
}

/** \brief Busca el indice de la primer ocurrencia del elemento pasado como parametro
 *
 * \param this LinkedList* Puntero a la lista
 * \param pElement void* Puntero al elemento
 * \return int Retorna  (-1) Error: si el puntero a la lista es NULL
                        (indice del elemento) Si funciono correctamente
 *
 */
int ll_indexOf(LinkedList* this, void* pElement)
{
    int returnAux = -1;
    Node* auxNode = NULL;
    if(this != NULL)
    {
    	for(int i = 0;i<ll_len(this);i++)
    	{
    		auxNode = getNode(this,i);
    		if(auxNode != NULL && (auxNode->pElement == pElement))
    		{
    			returnAux = i;
    			break;
    		}
    	}
    }
    return returnAux;
}

/** \brief Indica si la lista esta o no vacia
 *
 * \param this LinkedList* Puntero a la lista
 * \return int Retorna  (-1) Error: si el puntero a la lista es NULL
                        ( 0) Si la lista NO esta vacia
                        ( 1) Si la lista esta vacia
 *
 */
int ll_isEmpty(LinkedList* this)
{
    int returnAux = -1;
    if(this != NULL)
    {
    	returnAux = 0;
    	if(this->pFirstNode == NULL)
    	{
    		returnAux = 1;
    	}
    }
    return returnAux;
}

/** \brief Inserta un nuevo elemento en la lista en la posicion indicada
 *
 * \param this LinkedList* Puntero a la lista
 * \param nodeIndex int Ubicacion donde se agregara el nuevo elemento
 * \param pElement void* Puntero al nuevo elemento
 * \return int Retorna  (-1) Error: si el puntero a la lista es NULL o (si el indice es menor a 0 o mayor al len de la lista)
                        ( 0) Si funciono correctamente
 *
 */
int ll_push(LinkedList* this, int index, void* pElement)
{
    int returnAux = -1;
    if(this != NULL && index >= 0 && index <= ll_len(this))
    {
    	if(addNode(this,index,pElement) == 0)
    	{
    		returnAux = 0;
    	}
    }
    return returnAux;
}


/** \brief Elimina el elemento de la posicion indicada y retorna su puntero
 *
 * \param this LinkedList* Puntero a la lista
 * \param nodeIndex int Ubicacion del elemento eliminar
 * \return void* Retorna    (NULL) Error: si el puntero a la lista es NULL o (si el indice es menor a 0 o mayor al len de la lista)
                            (pElement) Si funciono correctamente
 *
 */
void* ll_pop(LinkedList* this,int index)
{
    void* returnAux = NULL;
    if(this != NULL && index >= 0 && index <ll_len(this))
    {
    	returnAux =ll_get(this,index);
    	ll_remove(this,index);
    }
    return returnAux;
}


/** \brief  Determina si la lista contiene o no el elemento pasado como parametro
 *
 * \param this LinkedList* Puntero a la lista
 * \param pElement void* Puntero del elemento a verificar
 * \return int Retorna  (-1) Error: si el puntero a la lista es NULL
                        ( 1) Si contiene el elemento
                        ( 0) si No contiene el elemento
*/
int ll_contains(LinkedList* this, void* pElement)
{
    int returnAux = -1;
    if(this != NULL)
    {
    	if(ll_indexOf(this, pElement) != -1)
    	{
    		returnAux = 1;
    	}
    	else
    	{
    		returnAux = 0;
    	}
    }
    return returnAux;
}

/** \brief  Determina si todos los elementos de la lista (this2)
            estan contenidos en la lista (this)
 *
 * \param this LinkedList* Puntero a la lista
 * \param this2 LinkedList* Puntero a la lista
 * \return int Retorna  (-1) Error: si alguno de los punteros a las listas son NULL
                        ( 1) Si los elementos de (this2) estan contenidos en la lista (this)
                        ( 0) si los elementos de (this2) NO estan contenidos en la lista (this)
*/
int ll_containsAll(LinkedList* this,LinkedList* this2)
{
    int returnAux = -1;
    Node* auxNode = NULL;
    if(this != NULL && this2 != NULL)
    {
    	returnAux = 1;
    	for(int i = 0;i < ll_len(this2);i++)
    	{
    		auxNode = getNode(this2, i);
    		if(auxNode != NULL && ll_contains(this,auxNode->pElement) == 0)
			{
				returnAux = 0;
				break;
			}
    	}
    }
    return returnAux;
}

/** \brief Crea y retorna una nueva lista con los elementos indicados
 *
 * \param pList LinkedList* Puntero a la lista
 * \param from int Indice desde el cual se copian los elementos en la nueva lista
 * \param to int Indice hasta el cual se copian los elementos en la nueva lista (no incluido)
 * \return LinkedList* Retorna  (NULL) Error: si el puntero a la listas es NULL
                                o (si el indice from es menor a 0 o mayor al len de la lista)
                                o (si el indice to es menor o igual a from o mayor al len de la lista)
                         (puntero a la nueva lista) Si ok
*/
LinkedList* ll_subList(LinkedList* this,int from,int to)
{
    LinkedList* auxLinkedList = NULL;
    if(this != NULL && from >= 0  && to > from && to <= ll_len(this))
    {
    	auxLinkedList = ll_newLinkedList();
    	if(auxLinkedList != NULL)
    	{
        	for(int i = 0; i < to; i++)
        	{
        		ll_add(auxLinkedList,ll_get(this,i));
        	}
    	}
    }
    return auxLinkedList;
}



/** \brief Crea y retorna una nueva lista con los elementos de la lista pasada como parametro
 *
 * \param pList LinkedList* Puntero a la lista
 * \return LinkedList* Retorna  (NULL) Error: si el puntero a la listas es NULL
                                (puntero a la nueva lista) Si ok
*/
LinkedList* ll_clone(LinkedList* this)
{
    LinkedList* cloneArray = NULL;
    if(this != NULL)
    {
    	cloneArray = ll_subList(this, 0, ll_len(this));
    }
    return cloneArray;
}


/** \brief Ordena los elementos de la lista utilizando la funcion criterio recibida como parametro
 * \param pList LinkedList* Puntero a la lista
 * \param pFunc (*pFunc) Puntero a la funcion criterio
 * \param order int  [1] Indica orden ascendente - [0] Indica orden descendente
 * \return int Retorna  (-1) Error: si el puntero a la listas es NULL
                                ( 0) Si ok
 */
int ll_sort(LinkedList* this, int (*pFunc)(void* ,void*), int order)
{
    int returnAux =-1;
    void* auxElementA = NULL;
    void* auxElementB = NULL;
//    int retPFunc;
    if(this != NULL && (order == 1 || order == 0) && pFunc != NULL)
    {
    	for(int i = 0; i < ll_len(this)-1; i++)
    	{
    		for(int j = i+1;j<ll_len(this);j++)
    		{
    			auxElementA = ll_get(this,i);
    			auxElementB = ll_get(this,j);
//    			retPFunc = (*pFunc)(auxElementA,auxElementB);
				if(order == 1 && pFunc(auxElementA,auxElementB) > 0) //ascenente
				{
					//A>B		1
						ll_set(this,i,auxElementB);
						ll_set(this,j,auxElementA);
				}
				if(order == 0 && pFunc(auxElementA,auxElementB) < 0)	//descenndete
				{
					 //A<B  	-1
						ll_set(this,i,auxElementB);
						ll_set(this,j,auxElementA);
				}
    		}//FIN FOR
    		returnAux = 0;
    	}
    }
	return returnAux;

}//ll_sort()
/*Brief: realiza una modificacion masiva a todos los elementos de una lista que cumplan un criterio determinado
 * Param:Puntero a la lista a modificar
 * Param: puntero  a funcion criterio
 * Retorna NULL si no pudo mapear, la linkedlist auxiliar modificada si tuvo exito
 */
LinkedList* ll_map(LinkedList* this,void(*fn)(void* pElement))
{
	int sizeLinkedList;
	int i;
	void* pElement;
	LinkedList* auxLinkedList = NULL;
	if(this != NULL && fn != NULL && ll_isEmpty(this) == 0)
	{
		auxLinkedList = ll_clone(this);
		sizeLinkedList = ll_len(auxLinkedList);
		if(sizeLinkedList != -1)
		{
			for (i = 0; i < sizeLinkedList; i++)
			{
				pElement = ll_get(auxLinkedList, i);
				fn(pElement);
			}//FIN FOR
		}
	}
	return auxLinkedList;
}//ll_map()
//LinkedList* ll_filter(LinkedList* this,int (*pFunc)(void* pElement),int criterio )
//{
//	//Este elemento agregalo, este elemento no lo agregues
//
//	void*auxElement = NULL;
//	LinkedList* listaFiltrada = NULL;
//	if(this != NULL  && pFunc != NULL)
//	{
//		listaFiltrada = ll_newLinkedList();
//		if(listaFiltrada != NULL)
//		{
//			for (int i = 0; i < ll_len(this);  i++)
//			{
//
//			}
//		}
//	}
//
//	return listaFiltrada;
//
//}
/*Brief: cuenta en una linkedlist cuantos elementos cumplen un determinado criterio
 * Param: Puntero a linkedlist con la linkedlist a revisar
 * Param: Puntero a a la funcion criterio
 */
int ll_count(LinkedList* this, int (*fn)(void* pElement))
{
	int ret = 0;
	int sizeLinkedList;
	void* pElement = NULL;
	if(this != NULL && fn != NULL)
	{
		sizeLinkedList = ll_len(this);
		if(sizeLinkedList != -1)
		{
			for (int i = 0; i < sizeLinkedList; i++)
			{
				pElement = ll_get(this, i);
				ret = ret +fn(pElement);
			}//FIN FOR
		}
	}
	return ret;
}//FIN ll_count()
/*Brief: Va guardando los elemetos que cumplen determinado criterio en una linkedlist
 * Param:Puntero a linkdlist que va a ser filtrada
 * Param:Puntero a funcion que es el criterio para filtrar
 * Retorna NULL si la linkedlist y la funcion por parametro es NULL, si no retorna la linkedlist filtrada
 *
 */
LinkedList* ll_filter(LinkedList* this, int (*pFunc)(void* element))
{
	void* pElement=NULL;
	int sizeLinkedList;
	LinkedList* LinkedListFiltered=NULL;
	if(this!=NULL && pFunc!=NULL)
	{
		LinkedListFiltered = ll_newLinkedList();

		if(LinkedListFiltered!=NULL)
		{
			sizeLinkedList = ll_len(this);
			for(int i = 0; i<sizeLinkedList; i++)
			{

					pElement=ll_get(this, i);
					if(pFunc(pElement)== 1) //1 es ok
					{
						ll_add(LinkedListFiltered, pElement);
					}
			}
		}
	}
	return LinkedListFiltered;
}

