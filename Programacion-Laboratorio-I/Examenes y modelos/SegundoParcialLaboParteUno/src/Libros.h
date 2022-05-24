#ifndef Libros_H_INCLUDED
#define Libros_H_INCLUDED

typedef struct
{
    int id;
    char titulo[128];
    char autor[128];
    float precio;
    int editorialId; 	//1-PLANETA 2-SIGLO XXI EDITORES 3-PEARSON 4-MONOTAURO 5-SALAMANDRA 6-PENGUIN BOOKS
}eLibro;

int descripcionToInt(char* pString,int* pId);
int idEditorial_to_Descripcion(int Id,char* pString);
eLibro* libro_new();
eLibro* libro_newParametros(char* idStr,char* tituloStr,char* autorStr,char* precioStr,char* editorialIdStr);
void libro_delete(eLibro* this);

int libro_setId(eLibro* this,int id);
int libro_getId(eLibro* this,int* id);

int libro_setTitulo(eLibro* this,char* titulo);
int libro_getTitulo(eLibro* this,char* titulo);

int libro_setAutor(eLibro* this,char* autor);
int libro_getAutor(eLibro* this,char* autor);

int libro_setPrecio(eLibro* this,float precio);
int libro_getPrecio(eLibro* this,float* precio);

int libro_setEditorialId(eLibro* this,int id);
int libro_getEditorialId(eLibro* this,int* id);


int libro_ContarEditorial_Planeta(void* pElement);
//int pelicula_getFacturacion(Venta* this,float* facturacion);
//int pelicula_setFacturacion(Venta* this,float facturacion);
//int pelicula_SetDatos(Venta* this);
//
int sortByAutor_A_Z(void* pElementoA,void* pElementoB);
//int sortByDias(void* pElementoA,void* pElementoB);
//int sortByHorario(void* pElementoA,void* pElementoB);
//int sortById(void* pElementoA,void* pElementoB);
//
void calcularDescuentos(void* pElement);
int libro_ContarEditorial_Planeta(void* pElement);
int libro_PrintElement(eLibro* pElement);

int libro_filterByPigna(void* element);
int libro_filterByPrice(void* element);
#endif // Libros_H_INCLUDED
