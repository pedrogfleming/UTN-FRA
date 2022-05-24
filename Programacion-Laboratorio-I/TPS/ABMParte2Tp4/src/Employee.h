#ifndef employee_H_INCLUDED
#define employee_H_INCLUDED
typedef struct
{
    int id;
    char nombre[128];
    int horasTrabajadas;
    int sueldo;
}Employee;

Employee* pelicula_new();
Employee* pelicula_newParametros(char* idStr,char* nombreStr,char* horasTrabajadasStr,char* sueldoStr);
void pelicula_delete(Employee* this);

int pelicula_setId(Employee* this,int id);
int pelicula_getId(Employee* this,int* id);

int pelicula_setNombre(Employee* this,char* nombre);
int pelicula_getNombre(Employee* this,char* nombre);

int pelicula_setDias(Employee* this,int horasTrabajadas);
int pelicula_getDias(Employee* this,int* horasTrabajadas);

int pelicula_setHora(Employee* this,int sueldo);
int pelicula_getHorario(Employee* this,int* sueldo);

int pelicula_SetDatos(Employee* this);

int sortByName_A_Z(void* pElementoA,void* pElementoB);
int sortByDias(void* pElementoA,void* pElementoB);
int sortByHorario(void* pElementoA,void* pElementoB);
int sortById(void* pElementoA,void* pElementoB);
#endif // employee_H_INCLUDED
