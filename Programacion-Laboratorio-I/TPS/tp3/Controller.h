
#include "Employee.h"
int controller_loadFromText(char* path , LinkedList* pArrayListEmployee);
int controller_loadFromBinary(char* path , LinkedList* pArrayListEmployee);
int controller_addEmployee(LinkedList* pArrayListEmployee);
int controller_editEmployee(LinkedList* pArrayListEmployee);
int controller_removeEmployee(LinkedList* pArrayListEmployee);
int controller_ListEmployee(LinkedList* pArrayListEmployee);
int controller_sortEmployee(LinkedList* pArrayListEmployee);
int controller_saveAsText(char* path , LinkedList* pArrayListEmployee);
int controller_saveAsBinary(char* path , LinkedList* pArrayListEmployee);
int controller_seek_Max_Id(LinkedList* pArrayListEmployee);
Employee* controller_seek_Id(LinkedList* pArrayListEmployee,int idSearch);
void controller_PrintEmployee(Employee* index);
int controller_ElegirArchivoDestino(char* path,int formatoArchivo);
