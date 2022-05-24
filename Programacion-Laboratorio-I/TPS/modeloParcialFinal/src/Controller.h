
#include "Peliculas.h"
int controller_loadFromText(char* path , LinkedList* pArrayListPeliculas);
int controller_loadFromBinary(char* path , LinkedList* pArrayListPeliculas);
int controller_addPelicula(LinkedList* pArrayListPeliculas);
int controller_editPelicula(LinkedList* pArrayListPeliculas);
int controller_removePelicula(LinkedList* pArrayListPeliculas);
int controller_ListPelicula(LinkedList* pArrayListPeliculas);
int controller_sortPelicula(LinkedList* pArrayListPeliculas);
int controller_saveAsText(char* path , LinkedList* pArrayListPeliculas);
int controller_saveAsBinary(char* path , LinkedList* pArrayListPeliculas);
int controller_seek_Max_Id(LinkedList* pArrayListPeliculas);
Venta* controller_seek_Id(LinkedList* pArrayListPeliculas,int SalaSearch);
int controller_AsignarMontoFacturacion(LinkedList* pArrayListPeliculas);
void controller_PrintPelicula(Venta* index);
int controller_ElegirArchivoDestino(char* path,int formatoArchivo);
Venta* controller_Informes(LinkedList* pArrayListPeliculas);
