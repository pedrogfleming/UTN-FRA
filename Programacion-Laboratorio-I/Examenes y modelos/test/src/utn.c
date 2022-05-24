#include <stdio.h>
#include <stdlib.h>
#include "utn.h"
#include <string.h>
#include <ctype.h>
//**********************************VALIDACIONES*************************************************
int esNumerica(char* cadena)
{
	int i=0;
	int ret = 1;
	if(cadena != NULL && strlen(cadena) > 0)
	{
		while(cadena[i] != '\0')
		{
			if(cadena[i] < '0' || cadena[i] > '9')
			{
				ret = 0;
				break;
			}
			i++;
		}
	}
	return ret;
}//FIN esNumerica()
int esFlotante(char* cadena,int leng)
{
	int ret = -1;
	int i;
	int flagPunto;
	if(cadena != NULL && strlen(cadena)>0)
	{
		for(i=0;i < leng && cadena[i]!= '\0';i++)
		{
			if(i==0 && (cadena[i] == '+' || cadena[i] == '-'))
			{
				continue;
			}
			if(cadena[i] == '.' && flagPunto == 0)
			{
				flagPunto = 1;
			}
			else
			{
				ret = 0;
				break;
			}
		}//FIN FOR
	}
	return ret;
}

int myGets(char* cadena,int longitud)
{
	int ret=-1;
	char bufferString[5000];
	if(cadena!=NULL && longitud>0)
	{
		fflush(stdin);
		if(fgets(bufferString, sizeof(bufferString),stdin)!=NULL)
		{
			if(bufferString[strnlen(bufferString, sizeof(bufferString))-1] =='\n')
			{
				bufferString[strnlen(bufferString,sizeof(bufferString))-1] = '\0';
			}
			if(strnlen(bufferString, sizeof(bufferString))<=longitud)
			{
				strncpy(cadena, bufferString, longitud);
				ret=0;
			}
		}
	}
	return ret;
}
int getInt(int* pResultado)
{
	int ret = -1;
	char buffer[64];
	if(pResultado != NULL)
	{
		if(myGets(buffer,sizeof(buffer)) == 0 && esNumerica(buffer))
		{
			*pResultado = atoi(buffer);
			ret = 0;
		}
	}
	return ret;
}//FIN getInt()
int getFloat(float* pResultado)
{
	int ret = -1;
	char buffer[64];
	if(pResultado != NULL)
	{
		if(myGets(buffer,sizeof(buffer)) == 0 && esFlotante(buffer,sizeof(buffer)) == 0)
		{
			*pResultado = atof(buffer);
			ret = 0;
		}
	}
	return ret;
}//FIN getInt()
int utn_getNumero(int* pResultado,char* mensaje,char* mensajeError,int minimo,int maximo,int reintentos)
{
	int bufferInt;
	int ret = -1;
	if(pResultado != NULL && mensaje != NULL && mensajeError != NULL && minimo <= maximo && reintentos > 0)
	{
		while(reintentos > 0)
		{
			reintentos--;
			printf("\n %s \t",mensaje);
			fflush(stdin);
			if(getInt(&bufferInt) == 0)
			{
				if(bufferInt >= minimo && bufferInt <= maximo)
				{
					*pResultado = bufferInt;
					ret = 0;
					break;
				}
			}
			printf("\n %s \t",mensajeError);
		}//FIN WHILE
	}


	return ret;

}//FIN utn_getNumero()
int utn_getFloat(float* pResultado,char* mensaje,char* mensajeError,float minimo,float maximo,int reintentos)
{
	float bufferFloat;
	int ret = -1;
	if(pResultado != NULL && mensaje != NULL && mensajeError != NULL && minimo <= maximo && reintentos > 0)
	{
		while(reintentos > 0)
		{
			reintentos--;
			printf("\n %s \t",mensaje);
			fflush(stdin);
			if(getFloat(&bufferFloat) == 0)
			{
				printf("\n Entro al primer if!!!");
				if(bufferFloat >= minimo && bufferFloat <= maximo)
				{
					*pResultado = bufferFloat;
					ret = 0;
					printf("\n Guardo el valor en el puntero!!!");
					break;
				}
			}
			printf("\n %s \t",mensajeError);
		}//FIN WHILE
	}


	return ret;

}//FIN getNumeroFloat()

int utn_getChar(char* input,char* mensaje,char* eMensaje,char lowLimit,char hiLimit,int intentos)
{
	int ret = -1;
	char aux;
	char buffer;
	int i;
	if(input != NULL &&  mensaje != NULL && eMensaje != NULL &&  lowLimit <= hiLimit && intentos > 0 )
	{
		printf("\n %s \t",mensaje);//Se le pide el tipo de dato a ingresar al usuario
		fflush(stdin);
		scanf("%c",&buffer);		//Genero un area de intercambio
		for (i = 0; i < intentos; i++)
		{
			aux = isdigit(buffer);
			if(buffer >= lowLimit && buffer <= hiLimit && aux == 0)
			{
				*input = buffer;
				ret = 0;
				break;
			}
			else//Error al ingrese el tipo de dato por fuera de los limites establecidos
			{
				printf("\n %s \t",eMensaje);
				fflush(stdin);
				scanf("\n %c",&buffer);
			}
		}//FIN FOR
	}
	return ret;
}//FIN utn_getChar()
int utn_getString(char* array,int lengArray,char* mensaje,char* eMensaje,char lowLimit,int intentos)
{
	int ret = -1;
	int aux;
	char buffer[lengArray];
	int i;
	if(array != NULL && lengArray > 0 &&  mensaje != NULL && eMensaje != NULL &&  lowLimit <= lengArray && intentos > 0 )
	{

		printf("\t %s",mensaje);//Se le pide el tipo de dato a ingresar al usuario
		printf("\t");
		fflush(stdin);
		gets(buffer);
		for (i = 0; i < intentos; i++)
		{
			aux = strlen(buffer);
			//printf("\n %d",aux);				testing
			//printf("\n %s",buffer[20]);		testing
			//
			if(aux >= lowLimit && aux <= lengArray)
			{
				utn_ToUpperString(buffer);
				strcpy(array,buffer);
				ret = 0;
				break;
			}
			else//Error al ingrese el tipo de dato por fuera de los limites establecidos
			{
				printf("\n %s",eMensaje);
				fflush(stdin);
				gets(buffer);
			}
		}//FIN FOR
	}
	return ret;
}//FIN utn_getString()
//**************************************DATOS****************************************************
int esCuit(char* cadena)
{
	int ret;
	int i;
	int contadorDigito=0;
	int contadorGuion=0;

	if(cadena!=NULL)
	{
		for(i=0;cadena[i]!='\0';i++)
		{
			if(isdigit(cadena[i])!=0)
			{
				contadorDigito++;				//Voy contando los digitos
			}
			else
			{
				if(cadena[i]=='-')
				{
					contadorGuion++;			//Voy contando los guiones
				}
				else
				{
					ret=-1;
					break;
				}
			}
		}
		if(contadorDigito==11 && contadorGuion==2)		//Solo si cumple con el formato cuil retorno 0
		{
			ret=0;
		}
	}
	return ret;
}//FIN esCuit()
int utn_getCuit(char* input,char* mensaje,char* eMensaje,int reintentos)
{
	int ret = -1;
	char buffer[14];
	int i;
	int aux;
	if(input!=NULL && mensaje!= NULL && eMensaje!= NULL && reintentos>0)
	{
		for(i=0;i<reintentos;i++)
		{
			printf("\n %s",mensaje); //Se le pide el tipo de dato a ingresar al usuario
			fflush(stdin);
			fgets(buffer,14,stdin);
			aux=esCuit(buffer);			//Si tiene 11 digitos y 2 guiones en las posiciones correctas ,ES UN CUIL!!!
			if(aux==0)
			{
				if(buffer[2]=='-' && buffer[11]=='-')
				{
					strcpy(input,buffer);
					ret=0;
					break;
				}
			}
			else
			{
				printf("\n %s\n",eMensaje);
			}
		}//FIN FOR
	}
	return ret;
}//FIN utn_getCuit()



//**************************************ARRAYS****************************************************
//********************************Inicializar Arrays*********************************************
void limpiarArrayEntero(int array[],int lengArray)
{
	int i;
	for (i = 0; i < lengArray; i++)
	{
		array[i] = 0;
	}
}//FIN limpiarArrayEntero()
void limpiarArrayFloat(float array[],int lengArray)
{
	int i;
	for (i = 0; i < lengArray; i++)
	{
		array[i] = 0;
	}
}//FIN limpiarArrayFloat()
void limpiarArrayChar(char array[],int lengArray)
{
	int i;
	for (i = 0; i < lengArray; i++)
	{
		array[i] = ' ';
	}
}//FIN limpiarArraychar()
void limpiarArrayString(char array[][20],int lengArray)
{
	int i;
	for (i = 0; i < lengArray; ++i)
	{
		strcpy(array[i],"a");

	}
}//FIN limpiarArrayString()
//********************************Carga Secuencial Arrays*********************************************
int ingresarArrayEntero(int array[],int lengArray,char* mensaje,char* mensajeError,int minimo,int maximo,int reintentos)
{
	int ret = -1;
	int i;
	int cargaExitosa;
	int contadorErrores = 0;
	if(array != NULL && lengArray > 0 && mensaje != NULL && mensajeError != NULL && minimo < maximo && reintentos > 0)
	{

		for (i = 0; i < lengArray; i++)
		{
			cargaExitosa = utn_getNumero(array[i],mensaje,mensajeError,minimo,maximo,reintentos);
			if(cargaExitosa != 0)
			{
				contadorErrores++;
			}
		}
		if(contadorErrores != 0)
		{
			ret = -1;
		}
	}
	return ret;
}//FIN ingresarArrayEntero
int ingresarArrayFloat(float array[],int lengArray)
{
	int i;
	for (i = 0; i < lengArray; ++i)
	{
		printf("\n Ingrese numero\n");
		scanf("%f",&array[i]);
	}
	return 0;
}//FIN ingresarArrayEntero
int ingresarArrayChar(char array[],int lengArray)
{
	int i;
	for (i = 0; i < lengArray; ++i)
	{
		fflush(stdin);
		printf("\n Ingrese caracter\n");
		scanf("%c",&array[i]);
	}
	return 0;
}//FIN ingresarArrayChar
int ingresarArrayString(char array[][20],int lengArray)																	//INGRESAR DATO EN ARRAY
{
	int i;
	for (i = 0; i < lengArray; ++i)
	{
		printf("\n Ingrese palabra\n");
		fflush(stdin);
		gets(array[i]);

	}
	return 0;
}//FIN ingresarArrayString()
//********************************Mostrar secuencialmente Arrays*********************************************
int mostrarArrayEntero(int array[],int lengArray)								//MOSTRAR ARRAY
{
	int i;
	int ret = -1;
	int exito;
	int contadorErrores = 0;
	if(array != NULL  && lengArray > -1)
	{
		for (i = 0; i < lengArray; ++i)
		{
			exito = printf(" %d ",array[i]);
			if(exito < 0)
			{
				contadorErrores++;
			}
		}
		if(contadorErrores == 0)
		{
			ret = 0;
		}
	}
	return ret;
}//FIN mostrarArrayEntero()
int mostrarArrayChar(char array[],int lengArray)
{
	int i;
	int ret = -1;
	int exito;
	int contadorErrores = 0;
	if(array != NULL  && lengArray > -1)
	{
		for (i = 0; i < lengArray; ++i)
		{
			exito = printf(" %c ",array[i]);
			if(exito < 0)
			{
				contadorErrores++;
			}
		}
		if(contadorErrores == 0)
		{
			ret = 0;
		}
	}
	return ret;
}//FIN mostrarArrayChar()
int mostrarArrayString(char array[][20],int lengArray)
{
	int i;
	int ret = -1;
	int exito;
	int contadorErrores = 0;
	if(array != NULL  && lengArray > -1)
	{
		for (i = 0; i < lengArray; ++i)
		{
			exito = printf(" %s ",array[i]);
			if(exito < 0)
			{
				contadorErrores++;
			}
		}
		if(contadorErrores == 0)
		{
			ret = 0;
		}
	}
	return ret;
}//FIN mostrarArrayString()
//********************************Transformacion de Arrays*********************************************
int utn_ToUpperString(char string[])
{

	int ret = -1;
	int lengString = strlen(string);
	if(lengString > 0)
	{
		for (int i = 0;  i < lengString;  i++)
		{

				string[i] = toupper(string[i]);

		}

		ret = 0;
	}

	return ret;
}//FIN utn_ToUpperString()

int utn_ToLowerString(char string[])
{

	int ret = -1;
	int lengString = strlen(string);
	if(lengString > 0)
	{
		for (int i = 0;  i < lengString;  i++)
		{
			string[i] = tolower(string[i]);

		}

		ret = 0;
	}

	return ret;
}//FIN utn_ToLowerString
