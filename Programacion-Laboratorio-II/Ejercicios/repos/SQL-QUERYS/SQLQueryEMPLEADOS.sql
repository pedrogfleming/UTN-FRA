USE [EMPRESA];
--https://codeutnfra.github.io/programacion_2_laboratorio_2_apuntes/docs/clases/sql/Ejercicios/I01-empleados-y-registrados/
INSERT INTO EMPLEADOS (NOMBRE,APELLIDO,ID_PUESTO,SALARIO,ESTA_ACTIVO,FECHA_ALTA,FECHA_BAJA,MAIL)
VALUES
('Leilani','Kinney',1,383946.80,1,'1996-03-21',null,'lkinney@gmail.com'),
('Igor','England',5,283558.85,1,'2013-03-28',null,'iengland@hotmail.com'),
('Maya','Brock',3,164546.09,1,'1993-10-24',null,null),
('Hayden','Moss',4,211695.50,0,'2012-06-07','2015-02-19','hmoss@gmail.com'),
('Amal','Colon',2,388933.60,1,'2019-09-23',null,null);

SELECT * FROM EMPLEADOS;
SELECT * FROM EMPLEADOS WHERE ESTA_ACTIVO = 1;
SELECT * FROM EMPLEADOS WHERE SALARIO > 200000;
SELECT * FROM EMPLEADOS WHERE FECHA_ALTA >= '2012-06-07';
SELECT * FROM EMPLEADOS WHERE MAIL IS NULL;
SELECT * FROM EMPLEADOS WHERE MAIL IS NOT NULL;
SELECT * FROM EMPLEADOS WHERE MAIL LIKE '%@gmail%';
SELECT * FROM EMPLEADOS WHERE APELLIDO LIKE 'B%';
 
SELECT * FROM EMPLEADOS WHERE APELLIDO LIKE 'C%' OR APELLIDO LIKE 'B%';
SELECT * FROM EMPLEADOS WHERE MAIL IS NOT NULL AND (ESTA_ACTIVO = 1 OR SALARIO = 200000)

SELECT * FROM EMPLEADOS ORDER BY NOMBRE ASC;

--Uno los empleados a partir del id de puesto con la descripcion del puesto en otra tabla
--El nombre y apellido de los empleados, junto al nombre de su puesto.
/*
SELECT EMPLEADOS.NOMBRE,EMPLEADOS.APELLIDO,EMPLEADOS.ID_PUESTO,PUESTOS2.NOMBRE
FROM EMPLEADOS 
LEFT JOIN PUESTOS2 ON PUESTOS2.ID_PUESTO = EMPLEADOS.ID_PUESTO
UNION
SELECT EMPLEADOS.NOMBRE,EMPLEADOS.APELLIDO,EMPLEADOS.ID_PUESTO,PUESTOS2.NOMBRE
FROM EMPLEADOS
RIGHT JOIN PUESTOS2 ON PUESTOS2.ID_PUESTO = EMPLEADOS.ID_PUESTO
*/
--Correcion, me trae mejor asi:
SELECT EMPLEADOS.NOMBRE,EMPLEADOS.APELLIDO,PUESTOS2.NOMBRE
FROM EMPLEADOS
INNER JOIN PUESTOS2 ON EMPLEADOS.ID_EMPLEADOS = PUESTOS2.ID_PUESTO;

--Los empleados que tengan un puesto con nivel de autorización igual a 3.
/*
SELECT EMPLEADOS.NOMBRE,EMPLEADOS.APELLIDO,EMPLEADOS.ID_PUESTO,PUESTOS2.NOMBRE
FROM EMPLEADOS 
LEFT JOIN PUESTOS2 ON PUESTOS2.ID_PUESTO = EMPLEADOS.ID_PUESTO WHERE PUESTOS2.NIVEL_AUTORIZACION = 3
UNION
SELECT EMPLEADOS.NOMBRE,EMPLEADOS.APELLIDO,EMPLEADOS.ID_PUESTO,PUESTOS2.NOMBRE
FROM EMPLEADOS
RIGHT JOIN PUESTOS2 ON PUESTOS2.ID_PUESTO = EMPLEADOS.ID_PUESTO WHERE PUESTOS2.NIVEL_AUTORIZACION = 3;
*/
--Correccion
SELECT EMPLEADOS.NOMBRE,EMPLEADOS.APELLIDO,PUESTOS2.NIVEL_AUTORIZACION
FROM EMPLEADOS
INNER JOIN PUESTOS2 ON EMPLEADOS.ID_EMPLEADOS = PUESTOS2.ID_PUESTO
WHERE PUESTOS2.NIVEL_AUTORIZACION = 3;

--El nombre y apellido de los empleados,
--junto al nombre de su puesto,
--ordenados alfabéticamente por apellido del empleado de manera ascendente.
/*
SELECT EMPLEADOS.NOMBRE,EMPLEADOS.APELLIDO,PUESTOS2.NOMBRE
FROM EMPLEADOS 
LEFT JOIN PUESTOS2 ON PUESTOS2.ID_PUESTO = EMPLEADOS.ID_PUESTO
UNION
SELECT EMPLEADOS.NOMBRE,EMPLEADOS.APELLIDO,PUESTOS2.NOMBRE
FROM EMPLEADOS
RIGHT JOIN PUESTOS2 ON PUESTOS2.ID_PUESTO = EMPLEADOS.ID_PUESTO
ORDER BY EMPLEADOS.APELLIDO ASC;
*/
--Correcion
SELECT EMPLEADOS.NOMBRE,EMPLEADOS.APELLIDO,PUESTOS2.NOMBRE
FROM EMPLEADOS
INNER JOIN PUESTOS2 ON EMPLEADOS.ID_EMPLEADOS = PUESTOS2.ID_PUESTO
ORDER BY EMPLEADOS.APELLIDO;

--El nombre y apellido de los empleados,
--junto al nombre de su puesto,
--ordenados alfabéticamente por nombre del puesto de manera ascendente.
/*
SELECT EMPLEADOS.NOMBRE,EMPLEADOS.APELLIDO,PUESTOS2.NOMBRE
FROM EMPLEADOS 
LEFT JOIN PUESTOS2 ON PUESTOS2.ID_PUESTO = EMPLEADOS.ID_PUESTO
UNION
SELECT EMPLEADOS.NOMBRE,EMPLEADOS.APELLIDO,PUESTOS2.NOMBRE
FROM EMPLEADOS
RIGHT JOIN PUESTOS2 ON PUESTOS2.ID_PUESTO = EMPLEADOS.ID_PUESTO
ORDER BY PUESTOS2.NOMBRE ASC;
*/
--Correcion
SELECT EMPLEADOS.NOMBRE,EMPLEADOS.APELLIDO,PUESTOS2.NOMBRE
FROM EMPLEADOS
INNER JOIN PUESTOS2 ON EMPLEADOS.ID_EMPLEADOS = PUESTOS2.ID_PUESTO
ORDER BY PUESTOS2.NOMBRE;

--Nombre, apellido y nombre del puesto de los empleados que estén activos,
--ordenados por su nivel de autorización de forma ascendente.
/*
SELECT EMPLEADOS.NOMBRE,EMPLEADOS.APELLIDO,PUESTOS2.NOMBRE
FROM EMPLEADOS 
LEFT JOIN PUESTOS2 ON PUESTOS2.ID_PUESTO = EMPLEADOS.ID_PUESTO WHERE EMPLEADOS.ESTA_ACTIVO = 1
UNION
SELECT EMPLEADOS.NOMBRE,EMPLEADOS.APELLIDO,PUESTOS2.NOMBRE
FROM EMPLEADOS
RIGHT JOIN PUESTOS2 ON PUESTOS2.ID_PUESTO = EMPLEADOS.ID_PUESTO WHERE EMPLEADOS.ESTA_ACTIVO = 1;
*/
--Correcion
SELECT EMPLEADOS.NOMBRE,EMPLEADOS.APELLIDO,PUESTOS2.NOMBRE, PUESTOS2.NIVEL_AUTORIZACION
FROM EMPLEADOS
INNER JOIN PUESTOS2 ON EMPLEADOS.ID_EMPLEADOS = PUESTOS2.ID_PUESTO
WHERE EMPLEADOS.ESTA_ACTIVO = 1
ORDER BY PUESTOS2.NIVEL_AUTORIZACION;

--Los puestos que no tengan empleados asociados.

SELECT PUESTOS2.* FROM PUESTOS2
LEFT JOIN EMPLEADOS ON EMPLEADOS.ID_PUESTO = PUESTOS2.ID_PUESTO
WHERE EMPLEADOS.ID_EMPLEADOS IS NULL;

--Los puestos que tengan empleados asociados.

SELECT PUESTOS2.* FROM PUESTOS2
LEFT JOIN EMPLEADOS ON EMPLEADOS.ID_PUESTO = PUESTOS2.ID_PUESTO
WHERE EMPLEADOS.ID_EMPLEADOS IS NOT NULL;

--O si no mejor uso el distinc, ya que no me trae los null

SELECT DISTINCT PUESTOS2.* FROM PUESTOS2
INNER JOIN EMPLEADOS ON EMPLEADOS.ID_EMPLEADOS = PUESTOS2.ID_PUESTO;