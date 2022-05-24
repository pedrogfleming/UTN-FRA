#include <stdio.h>
#include <stdlib.h>
#include <string.h>
/*LECTURA DE ARCHIVOS TEXTO escritura en Estructura*/
/*w = lecto/escritura.  Si no existe->Crea. Si Existe->Pisa
r = lectura. Posición al comienzo.
a = Si no existe->Crea. Si Existe->Agrega al final
*/

//Leo de f, guardo en la estructura, leo de la estructura guardo en f2

typedef struct{
    int legajo;
    char nombre[20];
    char apellido[20];
    float sueldo;
}eEmpleado;

void mostrarEmpleados(eEmpleado* lista, int len);
eEmpleado* new_EmpleadoParam( int leg, char* nombre, char* apellido, float sueldo);
eEmpleado* new_Empleado();

int main()
{
     FILE* f;
     FILE* f2;
     char buffer[4][20];
     eEmpleado* lista = (eEmpleado*) malloc(sizeof(eEmpleado));
     eEmpleado* pAuxEmpleado;
     int cont = 0;
     int cant;
     f = fopen("./empleados.csv","r");
     if(f == NULL)
     {
       printf("No se pudo abrir el archivo. Me voy a cerrar.\n");
       system("pause");
       exit(EXIT_FAILURE);
     }

     f2 = fopen("./empleadosf2.csv","a");
     if(f2 == NULL)
     {
       printf("No se pudo abrir el archivo. Me voy a cerrar.\n");
       system("pause");
       exit(EXIT_FAILURE);
     }

    /*Leer un registro del archivo csv quitando las comas
    []=busca una secuencia de caracteres a leer
    ^={Alt+94} significa que lo leído es negado
    ,=la coma está negada por ^
    */
    // Lectura fantasma
    fscanf(f, "%[^,],%[^,],%[^,],%[^\n]\n", buffer[0], buffer[1], buffer[2], buffer[3]);
    printf("%s   %s    %s    %s\n\n", buffer[0], buffer[1], buffer[2], buffer[3]);

     while( !feof(f) )
    {
        cant = fscanf(f, "%[^,],%[^,],%[^,],%[^\n]\n", buffer[0], buffer[1], buffer[2], buffer[3]);
        if( cant < 4){
            break;
          }
        eEmpleado* nuevoEmpleado = new_EmpleadoParam(atoi(buffer[0]), buffer[1],buffer[2],atof(buffer[3]));
        *(lista + cont) = *nuevoEmpleado;
        cont++;
        pAuxEmpleado = (eEmpleado*) realloc(lista, sizeof(eEmpleado) *(cont+1));
        if(pAuxEmpleado == NULL){
            exit(1);
        }
        lista = pAuxEmpleado;
    }
        //Escribo el archivo f2 desde la estructura
        int i;
        printf("\nCont %d", cont);
        printf("\n");
        fprintf(f2,"id,nombre,apellido,sueldo");
        for(i=0; i<cont; i++)
        {
            fprintf(f2,"%d, %s, %s, %.2f\n", (lista + i)->legajo, (lista + i)->nombre, (lista + i)->apellido, (lista + i)->sueldo);
        }

    mostrarEmpleados(lista, cont);

    fclose(f);
    fclose(f2);
    free(lista);
    free(pAuxEmpleado);

    return 0;
}


void mostrarEmpleados(eEmpleado* lista, int len){

printf("\n Mostrar empleados \n");

for(int i=0; i < len; i++){
    printf(" %5d   %10s   %20s  %8.2f\n", (lista + i)->legajo, (lista + i)->nombre, (lista + i)->apellido, (lista + i)->sueldo);
}
printf("\n\n");

}


eEmpleado* new_Empleado(){

eEmpleado* emp = (eEmpleado*)malloc( sizeof(eEmpleado));

if(emp != NULL){
    emp->legajo = 0;
    strcpy(emp->nombre, "");
    strcpy(emp->apellido, "");
    emp->sueldo = 0;

}
return emp;
}

eEmpleado* new_EmpleadoParam( int leg, char* nombre, char* apellido, float sueldo){

eEmpleado* emp = (eEmpleado*)malloc( sizeof(eEmpleado));

if(emp != NULL){

    emp->legajo = leg;
    strcpy(emp->nombre, nombre);
    strcpy(emp->apellido, apellido);
    emp->sueldo = sueldo;

}
return emp;
}

