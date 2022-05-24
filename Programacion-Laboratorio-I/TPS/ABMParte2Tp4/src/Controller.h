
#include "Employee.h"
int controller_loadFromText(char* path , LinkedList* pArrayListEmployee);
int controller_loadFromBinary(char* path , LinkedList* pArrayListEmployee);
int controller_addPelicula(LinkedList* pArrayListEmployee);
int controller_editPelicula(LinkedList* pArrayListEmployee);
int controller_removePelicula(LinkedList* pArrayListEmployee);
int controller_ListPelicula(LinkedList* pArrayListEmployee);
int controller_sortPelicula(LinkedList* pArrayListEmployee);
int controller_saveAsText(char* path , LinkedList* pArrayListEmployee);
int controller_saveAsBinary(char* path , LinkedList* pArrayListEmployee);
int controller_seek_Max_Id(LinkedList* pArrayListEmployee);
Employee* controller_seek_Id(LinkedList* pArrayListEmployee,int idSearch);
void controller_PrintPelicula(Employee* index);
int controller_ElegirArchivoDestino(char* path,int formatoArchivo);
