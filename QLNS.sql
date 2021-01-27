CREATE DATABASE QLNS
GO


Create table Position
(
			PositionId varchar(10) primary key,
			PositionName nvarchar(20),
)

Create table Salary
(
			SalaryId varchar(10) primary key,
			BaseSalary float,
			LevelSalary float
)

Create table Department
(
			DepartmentId varchar(10) primary key,
			DepartmentIdName varchar(20)
)

go


CREATE TABLE Employee
(
			Id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
			FullName nvarchar(20),
			Gender nchar(3),
			PhoneNumber char(10),
			Address nvarchar(50),
			DateOfBirth date,
			PositionId varchar(10) REFERENCES Position(PositionId),
			DepartmentId varchar(10) REFERENCES Department(DepartmentId),
			SalaryId varchar(10) REFERENCES Salary(SalaryId),
)

Create table Account
(
			username varchar(50),
			pass varchar(50)
)

CREATE PROC QLNS_Login
@username nvarchar(50), @pass nvarchar(50)
AS
BEGIN
	SELECT * FROM dbo.Account WHERE username = @username AND pass = @pass
END
GO

CREATE PROC UpdateEmployee
	
	@FullName nvarchar(20),
	@DateOfBirth DATE,
	@Address NVARCHAR(100),
	@Gender nchar(3),
	@PhoneNumber CHAR(10),
	@SalaryId varchar(10),
	@DepartmentId varchar(10),
	@PositionId varchar(10),
	@Id INT
AS
BEGIN
	UPDATE dbo.Employee SET FullName=@FullName,DateOfBirth=@DateOfBirth,Address=@Address,Gender=@Gender,PhoneNumber=@PhoneNumber,SalaryId=@SalaryId,DepartmentId=@DepartmentId,PositionId=@PositionId WHERE Id=@Id
END
GO

EXEC UpdateEmployee 'dat','08/08/2000','ha noi','nam','0911111111','1','1','1',9


