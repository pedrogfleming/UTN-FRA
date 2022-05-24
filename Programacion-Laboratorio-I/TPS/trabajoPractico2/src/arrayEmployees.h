/*
 * arrayEmployees.h
 *
 *  Created on: 11 may. 2021
 *      Author: Pedro
 */

#ifndef ARRAYEMPLOYEES_H_
#define ARRAYEMPLOYEES_H_

typedef struct{
	int idEmployee;
	char firsNameEmployee[51];
	char lastNameEmployee[51];
	float salaryEmployee;
	int sectorId;
	int isEmpty;//si es 1, la estructura esta libre par anueva carga, si es 0 esta ocupada
}employee;

//*************************************ALTA,BAJA E INICIALIZACION DE ESTRUCTURAS*********************************************
int initEmployees(employee arrayStruc[],int lengArray);
/** \brief To indicate that all position in the array are empty,
* this function put the flag (isEmpty) in TRUE in all
* position of the array
* \param list Employee* Pointer to array of employees
* \param len int Array length
* \return int Return (-1) if Error [Invalid length or NULL pointer] - (0) if Ok
*
*/
int addEmployee(employee* list,int len, int id, char name[],char lastName[],float salary,int sector);
/** \brief add in a existing list of employees the values received as parameters
* in the first empty position
* \param list employee*
* \param len int
* \param id int
* \param name[] char
* \param lastName[] char
* \param salary float
* \param sector int
* \return int Return (-1) if Error [Invalid length or NULL pointer or without
free space] - (0) if Ok
*
**/
int removeEmployee(employee arrayStruc[],int lenArray);
/** \brief Remove a Employee by Id (put isEmpty Flag in 1)
*
* \param list Employee*
* \param len int
* \param id int
* \return int Return (-1) if Error [Invalid length or NULL pointer or if can't
find a employee] - (0) if Ok
*
*/
//*************************************************BUSQUEDA*****************************************************************
int findEmployeeById(employee arrayStruc[],int lengArray,int id);
/** \brief find an Employee by Id en returns the index position in array.
*
* \param list Employee*
* \param len int
* \param id int
* \return Return employee index position or (-1) if [Invalid length or NULL
pointer received or employee not found]
*
*/
int zeroEmployees(employee arrayEmployee[],int lengArray);
/*Brief check if there are any employee in the array
 * param employee array
 * param leng array
 * return 0 if find one employeed loadead, if not, 0
 */
//***********************************ORDENAR ARRAY DE ESTRUCTURAS***********************************************************
int sortEmployees(employee arrayEmployee[],int lengArray,int order);
/** \brief Sort the elements in the array of employees, the argument order
indicate UP or DOWN order
*
* \param list Employee*
* \param len int
* \param order int [1] indicate UP - [0] indicate DOWN
* \return int Return (-1) if Error [Invalid length or NULL pointer] - (0) if Ok
*
*/

//***********************************MOSTRAR ARRAY DE ESTRUCTURAS***********************************************************
int printEmployees(employee arrayStruc[],int lengArray);
/** \brief print the content of employees array
*
* \param list Employee*
* \param length int
* \return int
*
*/
int averageSalary(employee arrayEmployees[],int lengArray, float* pAverageSalary);
/*Brief calculate the average salary of an array of employees
 * param list employee
 * param leng array employee
 * param pointer float where you save the average salary
 * Retorn 0 if succed in calculte de average salary,-1 if not
 */
int findUpperAverageSalary(employee arrayEmployees[],int lengArray,float pAverageSalary);
/*Brief find the employees with the salary up from the average salary and prints them all
 * param list employee
 * param leng array employee
 * param float with the average salary
 * Retorn 0 if succeded, -1 if cant find employees with the condition
 */
#endif /* ARRAYEMPLOYEES_H_ */
