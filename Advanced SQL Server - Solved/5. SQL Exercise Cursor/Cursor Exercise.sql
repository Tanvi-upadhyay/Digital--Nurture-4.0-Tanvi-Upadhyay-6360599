CREATE DATABASE CursorDB;

USE CursorDB;

CREATE TABLE Department(
  DepartmentId INT PRIMARY KEY,
  DepartmentName VARCHAR(100)
  );

CREATE TABLE Employees(
  EmployeeID INT PRIMARY KEY,
  FirstName VARCHAR(50),
  LastName VARCHAR(50),
  DepartmentID INT FOREIGN KEY REFERENCES Department(DepartmentID),
  SALARY DECIMAL(10,2),
  JoinDate DATE
  );

  INSERT INTO Department(DepartmentID, DepartmentName) VALUES
  (1, 'HR'),
  (2, 'IT'),
  (3, 'FINANCE');

  INSERT INTO Employees(EmployeeID, FirstName, LastName, DepartmentID, Salary, JoinDate) VALUES
  (1, 'John', 'Doe', 1, 5000.00, '2020-01-15'),
  (2, 'Jane', 'Smith', 2, 6000.00, '2019-03-22'),
  (3, 'Bob', 'Johnson', 3, 5500.00, '2021-07-30');

DECLARE @EmpID INT, @FirstName VARCHAR(50), @LastName VARCHAR(50), 
        @DeptID INT, @Salary DECIMAL(10,2), @JoinDate DATE;

-- 1. Declare the cursor
DECLARE employee_cursor CURSOR FOR
SELECT EmployeeID, FirstName, LastName, DepartmentID, Salary, JoinDate
FROM Employees;

-- 2. Open the cursor
OPEN employee_cursor;

-- 3. Fetch the first row
FETCH NEXT FROM employee_cursor INTO @EmpID, @FirstName, @LastName, @DeptID, @Salary, @JoinDate;

-- 4. Loop through the rows
WHILE @@FETCH_STATUS = 0
BEGIN
    PRINT 'EmployeeID: ' + CAST(@EmpID AS VARCHAR) +
          ', Name: ' + @FirstName + ' ' + @LastName +
          ', DeptID: ' + CAST(@DeptID AS VARCHAR) +
          ', Salary: ' + CAST(@Salary AS VARCHAR) +
          ', Join Date: ' + CAST(@JoinDate AS VARCHAR);

    FETCH NEXT FROM employee_cursor INTO @EmpID, @FirstName, @LastName, @DeptID, @Salary, @JoinDate;
END

---- 5. Close and deallocate
CLOSE employee_cursor;
DEALLOCATE employee_cursor;

--Static Cursor
DECLARE static_cursor STATIC CURSOR FOR
SELECT * FROM Employees;

OPEN static_cursor;
-- FETCH and loop like in Exercise 1
CLOSE static_cursor;
DEALLOCATE static_cursor;

-- Dynamic Cursor
DECLARE dynamic_cursor DYNAMIC CURSOR FOR
SELECT * FROM Employees;

OPEN dynamic_cursor;
-- FETCH and loop
CLOSE dynamic_cursor;
DEALLOCATE dynamic_cursor;




--Forward-Only Cursor (Default)
DECLARE forward_cursor CURSOR FORWARD_ONLY FOR
SELECT * FROM Employees;

OPEN forward_cursor;
-- FETCH and loop
CLOSE forward_cursor;
DEALLOCATE forward_cursor;


-- Keyset-Driven Cursor
DECLARE keyset_cursor KEYSET CURSOR FOR
SELECT * FROM Employees;

OPEN keyset_cursor;
-- FETCH and loop
CLOSE keyset_cursor;
DEALLOCATE keyset_cursor;
