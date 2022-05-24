#ifndef Peliculas_H_INCLUDED
#define Peliculas_H_INCLUDED

typedef struct
{
    int hora;
    char dosPuntos[0];
    int minutos;
}Hora;

typedef struct
{
    int id;
    char nombre[128];
    int dia;
    Hora horario;
    int sala;
    int cantidadEntradas;
    float facturacion;
}Venta;



Venta* pelicula_new();
Venta* pelicula_newParametros(char* idStr,char* nombreStr,char* diasStr,char* horaStr,char* minutosStr,char* salaStr,char* cantidadEntradasStr);
void pelicula_delete(Venta* this);

int pelicula_setId(Venta* this,int id);
int pelicula_getId(Venta* this,int* id);

int pelicula_setNombre(Venta* this,char* nombre);
int pelicula_getNombre(Venta* this,char* nombre);

int pelicula_setDias(Venta* this,int dia);
int pelicula_getDias(Venta* this,int* dia);

int pelicula_setHora(Venta* this,int hora);
int pelicula_getHora(Venta* this,int* hora);

int pelicula_setMinutos(Venta* this,int minutos);
int pelicula_getMinutos(Venta* this,int* minutos);

int pelicula_getSala(Venta* this,int* sala);
int pelicula_setSala(Venta* this,int sala);

int pelicula_getCantidadEntradas(Venta* this,int* cantidadEntradas);
int pelicula_setCantidadEntradas(Venta* this,int cantidadEntradas);

int pelicula_getFacturacion(Venta* this,float* facturacion);
int pelicula_setFacturacion(Venta* this,float facturacion);
int pelicula_SetDatos(Venta* this);

int sortByName_A_Z(void* pElementoA,void* pElementoB);
int sortByDias(void* pElementoA,void* pElementoB);
int sortByHorario(void* pElementoA,void* pElementoB);
int sortById(void* pElementoA,void* pElementoB);

void calcularFacturacion(void* pElement);
int contarEntradas(void* pElement);
int pelicula_PrintElement(Venta* pElement);
#endif // Peliculas_H_INCLUDED
