create database ss01;
go
use ss01;
go
CREATE TABLE Employees (
    EmployeeID INT PRIMARY KEY IDENTITY ,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    Email VARCHAR(100) UNIQUE,
    HireDate DATE
);
-- Thêm dữ liệu vào bảng Employees
INSERT INTO Employees (FirstName, LastName, Email, HireDate) 
VALUES 
    ('John', 'Doe', 'john.doe@example.com', '2022-04-20'),
    ('Jane', 'Smith', 'jane.smith@example.com', '2022-04-21'),
    ('Alice', 'Johnson', 'alice.johnson@example.com', '2022-04-22'),
    ('Bob', 'Brown', 'bob.brown@example.com', '2022-04-23');


select * from [dbo].[Employees];

CREATE PROCEDURE GetEmployeeById
    @EmployeeID INT
AS
BEGIN
    SELECT * FROM Employees WHERE EmployeeID = @EmployeeID;
END
