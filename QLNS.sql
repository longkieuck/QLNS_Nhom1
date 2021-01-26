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
			DepartmentIdName nvarchar(20)
)
go
CREATE TABLE Employee
(
			Id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
			FullName nvarchar(20),
			Gender nchar(5),
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



--------------Created Procdure 
CREATE PROC QLNS_Login
@username nvarchar(50), @pass nvarchar(50)
AS
BEGIN
	SELECT * FROM dbo.Account WHERE username = @username AND pass = @pass
END
GO


-- Created By : Nguyễn Văn Hiến
CREATE PROC InsertEmployee
@id int,@fullName nvarchar(20),@gender nchar(3),@phoneNumber char(10),@address nvarchar(50),@dateOfBirth date
,@positionId varchar(10),@departmentId varchar(10), @salaryId varchar(10) 
AS
BEGIN
	Insert into Employee 
	Values(@id,@fullName,@gender,@phoneNumber,@address,@dateOfBirth,@positionId,@departmentId,@salaryId) 
END
GO
EXEC InsertEmployee 2,'hien','nam','00000000000','hanoi','04/08/2000','1','1','1'



---------------- Insert 
--- Cteated By : Nguyễn Văn Hiến
insert into Department values('1',N'Giám Đốc')
insert into Department values('2',N'Kế Toán')
insert into Department values('3',N'Nhân Sự')
go
insert into Position values('1',N'Giám Đốc')
insert into Position values('2',N'Quản Lí')
insert into Position values('3',N'Nhân Viên')
go
insert into Salary values('1',1000,2.0)
insert into Salary values('2',1000,3.0)
insert into Salary values('3',1000,4.0)
go


------------------------

