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
			UserName varchar(50),
			Password varchar(50)
)

Go

CREATE PROC QLNS_Login
@username nvarchar(50), @pass nvarchar(50)
AS
BEGIN
	SELECT * FROM dbo.Account WHERE UserName = @username AND Password = @pass
END
GO

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

Drop Proc UpdateEmployee
CREATE PROC UpdateEmployee
	
	@FullName nvarchar(20),
	@DateOfBirth DATE,
	@Address NVARCHAR(50),
	@Gender nchar(5),
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

----------------------- Bùi Thị Mỹ Văn --------------

-- Hàm chuyển chuối có dấu thành không dấu
CREATE FUNCTION [dbo].[GetUnsignString](@strInput NVARCHAR(4000)) 
RETURNS NVARCHAR(4000)
AS
BEGIN     
    IF @strInput IS NULL RETURN @strInput
    IF @strInput = '' RETURN @strInput
    DECLARE @RT NVARCHAR(4000)
    DECLARE @SIGN_CHARS NCHAR(136)
    DECLARE @UNSIGN_CHARS NCHAR (136)

    SET @SIGN_CHARS       = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệếìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵýĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ'+NCHAR(272)+ NCHAR(208)
    SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeeeiiiiiooooooooooooooouuuuuuuuuuyyyyyAADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIIIOOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD'

    DECLARE @COUNTER int
    DECLARE @COUNTER1 int
    SET @COUNTER = 1
 
    WHILE (@COUNTER <=LEN(@strInput))
    BEGIN   
      SET @COUNTER1 = 1
      --Tim trong chuoi mau
       WHILE (@COUNTER1 <=LEN(@SIGN_CHARS)+1)
       BEGIN
     IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1)) = UNICODE(SUBSTRING(@strInput,@COUNTER ,1) )
     BEGIN           
          IF @COUNTER=1
              SET @strInput = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)-1)                   
          ELSE
              SET @strInput = SUBSTRING(@strInput, 1, @COUNTER-1) +SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)- @COUNTER)    
              BREAK         
               END
             SET @COUNTER1 = @COUNTER1 +1
       END
      --Tim tiep
       SET @COUNTER = @COUNTER +1
    END
    RETURN @strInput
END

select * from Employee where [dbo].[GetUnsignString](FullName) like N'%' + [dbo].[GetUnsignString](N'Nguyen') + '%'


go




