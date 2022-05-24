/*
 * calculos.h
 *
 *  Created on: 27 abr. 2021
 *      Author: Pedro
 */

#ifndef CALCULOS_H_
#define CALCULOS_H_
int sumaDosOperadores(int numeroUno,int numeroDos,int* punteroResultado);
//brief calcula la SUMA entre dos enteros y guarda el resultado en un puntero
//recibe como primer parametro un int
//recibe como segundo parametro un int
//recibe como tercer parametro un int de tipo puntero
//retorna int ,un 0 si logró sumar y retorna un 1 si la direccion de memoria es NULL
int restaDosOperadores(int numeroUno,int numeroDos,int* punteroResultado);
//brief calcula la RESTA entre dos enteros y guarda el resultado en un puntero
//recibe como primer parametro un int
//recibe como segundo parametro un int
//recibe como tercer parametro un int de tipo puntero
//retorna int, un 0 si logró restar y retorna un 1 si la direccion de memoria es NULL
int divisionDosOperadores(int dividendo, int divisor,float* punteroResultado);
//brief calcula la DIVISION entre dos enteros y guarda el resultado en un puntero
//recibe como primer parametro un int
//recibe como segundo parametro un int
//recibe como tercer parametro un float de tipo puntero
//retorna int, un 0 si logró dividir, retorna un -1 si no se pudo dividir y retorna un 1 si la direccion de memoria es NULL
int multiplicacionDosOperadores(int numeroUno,int numeroDos,int* punteroResultado);
//brief calcula la MULTIPLICACION entre dos enteros y guarda el resultado en un puntero
//recibe como primer parametro un int
//recibe como segundo parametro un int
//recibe como tercer parametro un int de tipo puntero
//retorna int, un 0 si logró multiplicar y retorna un 1 si la direccion de memoria es NULL
int factorial(int numero);
//brief calcula el factorial de un numero
//recibe como unico parametro un int
//retorna int ,un 1 cuando se ha terminado de calcular el factorial y va retornando los pasos intermedios de la operatoria de factoreo
int validarFactorial(int operando);
//brief Valida que el numero ingresado este en un rango para resolver factorial con datos de tipo int
//Recibe como parametro de tipo int un numero
//Retorna 0 si el numero puede ser factorizado con variable de tipo int
//Retorna -1 si no puede ser factorizado con variable de tipo int

int calcularOperacionesSimples(int numeroA,int numeroB,int* punteroSuma,int* punteroResta,int* punteroMultiplicacion);
//brief Calcula la suma,resta y multiplicacion de 2 numeros entre si
//Recibe como primer parametro un int que corresponde al primer operando
//Recibe como segundo parametro un int que corresponde al segundo operando
//Recibe como tercer parametro un puntero de tipo int que corresponde a donde se va a guardar el resultado de la suma
//Recibe como cuarto parametro un puntero de tipo int que corresponde a donde se va a guardar el resultado de la resta
//Recibe como quinto parametro un puntero de tipo int que corresponde a donde se va a guardar el resultado de la multiplicacion
#endif /* CALCULOS_H_ */
