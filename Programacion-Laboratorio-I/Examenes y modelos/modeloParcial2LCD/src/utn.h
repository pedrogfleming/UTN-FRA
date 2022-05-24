

#ifndef UTN_H_
#define UTN_H_
//**********************************VALIDACIONES*************************************************
int esNumerica(char* cadena);
int esFlotante(char* cadena,int leng);
int myGets(char* cadena,int longitud);
int getInt(int* pResultado);
int getFloat(float* pResultado);
int utn_getNumero(int* pResultado,char* mensaje,char* mensajeError,int minimo,int maximo,int reintentos);
int utn_getFloat(float* pResultado,char* mensaje,char* mensajeError,float minimo,float maximo,int reintentos);


int utn_getChar(char* input,char* mensaje,char* eMensaje,char lowLimit,char hiLimit,int intentos);
int utn_getString(char* array,int lengArray,char* mensaje,char* eMensaje,char lowLimit,int intentos);

//**************************************DATOS****************************************************
int utn_getCuit(char* input,char* mensaje,char* eMensaje,int reintentos);
int esCuit(char* cadena);



//************************************ARRAYS*****************************************************
//********************************Inicializar Arrays*********************************************
void limpiarArrayEntero(int array[],int lengArray);
void limpiarArrayFloat(float array[],int lengArray);
void limpiarArrayChar(char array[],int lengArray);
void limpiarArrayString(char array[][20],int lengArray);
//********************************Carga Secuencial Arrays*********************************************
int ingresarArrayEntero(int array[],int lengArray,char* mensaje,char* mensajeError,int minimo,int maximo,int reintentos);
int ingresarArrayFloat(float array[],int lengArray);
int ingresarArrayChar(char array[],int lengArray);
int ingresarArrayString(char array[][20],int lengArray);
//********************************Mostrar secuencialmente Arrays*********************************************
int mostrarArrayEntero(int array[],int lengArray);
int mostrarArrayChar(char array[],int lengArray);
int mostrarArrayString(char array[][20],int lengArray);
//********************************Transformacion de Arrays*********************************************
int utn_ToUpperString(char string[]);
int utn_ToLowerString(char string[]);
#endif /* UTN_H_ */
