USE master
GO
CREATE DATABASE HR
GO
USE HR
GO
CREATE TABLE Departments
(
Deptno int NOT NULL
CONSTRAINT PK_dept_deptno PRIMARY KEY,
deptname varchar(15) NOT NULL
)
CREATE TABLE Jobs
(
jobid int NOT NULL

CONSTRAINT PK_jobs_jobid PRIMARY KEY,
jobdesc varchar(15) NOT NULL
)
CREATE TABLE Employees
(
empid int NOT NULL
CONSTRAINT PK_emps_empid PRIMARY KEY,
empname varchar(10) NOT NULL,
deptno int NULL
CONSTRAINT FK_emps_depts
REFERENCES Departments(deptno),
jobid int NOT NULL
CONSTRAINT FK_emps_jobs REFERENCES Jobs(jobid),
salary decimal(7,2) NOT NULL
)
INSERT INTO Departments VALUES(100, 'Engineering')
INSERT INTO Departments VALUES(200, 'Production')
INSERT INTO Departments VALUES(300, 'Sanitation')
INSERT INTO Departments VALUES(400, 'Management')
INSERT INTO Jobs VALUES(10, 'Engineer')
INSERT INTO Jobs VALUES(20, 'Worker')
INSERT INTO Jobs VALUES(30, 'Manager')
INSERT INTO Jobs VALUES(40, 'Cleaner')
INSERT INTO Employees VALUES(1, 'Leo', 400, 30, 10000.00)
INSERT INTO Employees VALUES(2, 'George', 200, 20, 1000.00)
INSERT INTO Employees VALUES(3, 'Chris', 100, 10, 2000.00)
INSERT INTO Employees VALUES(4, 'Rob', 400, 30, 3000.00)
INSERT INTO Employees VALUES(5, 'Laura', 400, 30, 3000.00)
INSERT INTO Employees VALUES(6, 'Jeffrey', NULL, 30, 5000.00)