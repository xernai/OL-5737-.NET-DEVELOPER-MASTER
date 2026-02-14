/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [PersonId]
      ,[Name]
  FROM [Person]

-- delete from Person


-- SQL (Structured Query Language)
-- Edgar Frank Codd -> SEQUEL
-- Oracle -> PL/SQL
-- Microsoft -> T-SQL
-- T-SQL
--   DML -> Data Manipulation Language
--   CRUD -> SELECT (Lectura),
--           UPDATE (Escritura, actualiza)
--			 DELETE (Escritura, elimina)
--			 INSERT (Escritura, agrega)
/*
--   DDL -> Data Definition Language
     CREATE, DROP, ALTER,

*/
-- Leer datos de una tabla

select deptno, deptname from [dbo].[Departments]
where deptno < 300

-- DELETE FROM [dbo].[Employees]
-- WHERE [empid] = 6

--UPDATE [dbo].[Employees]
--SET [empname] = 'Giorgio'
--WHERE [empid] = 2

--INSERT INTO Employees VALUES(1, 'Leo', 400, 30, 10000.00)
--INSERT INTO Employees VALUES(2, 'George', 200, 20, 1000.00)
--INSERT INTO Employees VALUES(3, 'Chris', 100, 10, 2000.00)
--INSERT INTO Employees VALUES(4, 'Rob', 400, 30, 3000.00)
--INSERT INTO Employees VALUES(5, 'Laura', 400, 30, 3000.00)
--INSERT INTO Employees VALUES(6, 'Jeffrey', NULL, 30, 5000.00)

-- DROP Table [dbo].[Person]

exec [dbo].[GetDeptos]

select GetDate()

