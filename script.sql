USE [master]
GO
/****** Object:  Database [QLNS]    Script Date: 6/28/2021 11:01:00 PM ******/
CREATE DATABASE [QLNS]
 CONTAINMENT = NONE

GO
ALTER DATABASE [QLNS] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLNS].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLNS] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLNS] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLNS] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLNS] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLNS] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLNS] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLNS] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLNS] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLNS] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLNS] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLNS] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLNS] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLNS] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLNS] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLNS] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QLNS] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLNS] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLNS] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLNS] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLNS] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLNS] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLNS] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLNS] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QLNS] SET  MULTI_USER 
GO
ALTER DATABASE [QLNS] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLNS] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLNS] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLNS] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QLNS] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QLNS] SET QUERY_STORE = OFF
GO
USE [QLNS]
GO
/****** Object:  UserDefinedFunction [dbo].[GetUnsignString]    Script Date: 6/28/2021 11:01:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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
GO
/****** Object:  Table [dbo].[Department]    Script Date: 6/28/2021 11:01:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Department](
	[DepartmentId] [varchar](10) NOT NULL,
	[DepartmentIdName] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[DepartmentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 6/28/2021 11:01:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FullName] [nvarchar](20) NULL,
	[Gender] [nchar](10) NULL,
	[PhoneNumber] [char](10) NULL,
	[Address] [nvarchar](50) NULL,
	[DateOfBirth] [date] NULL,
	[PositionId] [varchar](10) NULL,
	[DepartmentId] [varchar](10) NULL,
	[SalaryId] [varchar](10) NULL,
 CONSTRAINT [PK__Employee__3214EC0790CC338B] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  UserDefinedFunction [dbo].[EMPLOYEE_LIST_BY_NAME_AND_DEPARTMENTID]    Script Date: 6/28/2021 11:01:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[EMPLOYEE_LIST_BY_NAME_AND_DEPARTMENTID](@department nvarchar(30), @name nvarchar(20))
returns table
as
return 
	select *
	from Employee em
	where [dbo].[GetUnsignString](em.FullName) like N'%' + [dbo].[GetUnsignString](@name) + '%' and
	em.DepartmentId = (select DepartmentId
						from Department
						where Department.DepartmentIdName = @department)
GO
/****** Object:  Table [dbo].[Account]    Script Date: 6/28/2021 11:01:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[UserName] [varchar](50) NULL,
	[Password] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Position]    Script Date: 6/28/2021 11:01:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Position](
	[PositionId] [varchar](10) NOT NULL,
	[PositionName] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[PositionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Salary]    Script Date: 6/28/2021 11:01:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Salary](
	[SalaryId] [varchar](10) NOT NULL,
	[BaseSalary] [float] NULL,
	[LevelSalary] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[SalaryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Account] ([UserName], [Password]) VALUES (N'admin', N'admin')
GO
INSERT [dbo].[Department] ([DepartmentId], [DepartmentIdName]) VALUES (N'1', N'Giám Đốc')
INSERT [dbo].[Department] ([DepartmentId], [DepartmentIdName]) VALUES (N'2', N'Kế Toán')
INSERT [dbo].[Department] ([DepartmentId], [DepartmentIdName]) VALUES (N'3', N'Nhân Sự')
GO
SET IDENTITY_INSERT [dbo].[Employee] ON 

INSERT [dbo].[Employee] ([Id], [FullName], [Gender], [PhoneNumber], [Address], [DateOfBirth], [PositionId], [DepartmentId], [SalaryId]) VALUES (1, N'Nguyễn Văn Hiến', N'Nam       ', N'0949887410', N'Quận Cầu Giấy', CAST(N'2000-04-08' AS Date), N'1', N'1', N'1')
INSERT [dbo].[Employee] ([Id], [FullName], [Gender], [PhoneNumber], [Address], [DateOfBirth], [PositionId], [DepartmentId], [SalaryId]) VALUES (2, N'Kiều Đức Long', N'Nam       ', N'0949887410', N'Quận Cầu Giấy', CAST(N'2000-11-27' AS Date), N'1', N'1', N'1')
INSERT [dbo].[Employee] ([Id], [FullName], [Gender], [PhoneNumber], [Address], [DateOfBirth], [PositionId], [DepartmentId], [SalaryId]) VALUES (3, N'Đỗ Thành Đạt', N'Nam       ', N'0949887410', N'Quận Cầu Giấy', CAST(N'2000-11-27' AS Date), N'1', N'1', N'1')
INSERT [dbo].[Employee] ([Id], [FullName], [Gender], [PhoneNumber], [Address], [DateOfBirth], [PositionId], [DepartmentId], [SalaryId]) VALUES (4, N'Bùi Quang Hải', N'Khác     ', N'0949887410', N'Quận Cầu Giấy', CAST(N'2021-02-04' AS Date), N'3', N'2', N'2')
INSERT [dbo].[Employee] ([Id], [FullName], [Gender], [PhoneNumber], [Address], [DateOfBirth], [PositionId], [DepartmentId], [SalaryId]) VALUES (5, N'Nguyễn Thị Phượng', N'Nữ       ', N'0949887410', N'Quận Cầu Giấy', CAST(N'2021-02-05' AS Date), N'3', N'3', N'2')
INSERT [dbo].[Employee] ([Id], [FullName], [Gender], [PhoneNumber], [Address], [DateOfBirth], [PositionId], [DepartmentId], [SalaryId]) VALUES (8, N'Bùi Công Nam', N'Khác     ', N'0949887410', N'Quận Cầu Giấy', CAST(N'2021-02-09' AS Date), N'3', N'2', N'2')
INSERT [dbo].[Employee] ([Id], [FullName], [Gender], [PhoneNumber], [Address], [DateOfBirth], [PositionId], [DepartmentId], [SalaryId]) VALUES (10, N'Lê Minh Ngọc', N'Nam       ', N'093821245 ', N'Quận Thanh Xuân', CAST(N'1994-09-21' AS Date), N'1', N'2', N'3')
INSERT [dbo].[Employee] ([Id], [FullName], [Gender], [PhoneNumber], [Address], [DateOfBirth], [PositionId], [DepartmentId], [SalaryId]) VALUES (11, N'Lê Minh Ngọc', N'Nam       ', N'093821245 ', N'Quận Thanh Xuân', CAST(N'1994-09-21' AS Date), N'1', N'2', N'3')
INSERT [dbo].[Employee] ([Id], [FullName], [Gender], [PhoneNumber], [Address], [DateOfBirth], [PositionId], [DepartmentId], [SalaryId]) VALUES (12, N'Bùi Thanh Hằng', N'Nam       ', N'093821245 ', N'Quận Cầu Giấy', CAST(N'1994-09-21' AS Date), N'3', N'2', N'1')
INSERT [dbo].[Employee] ([Id], [FullName], [Gender], [PhoneNumber], [Address], [DateOfBirth], [PositionId], [DepartmentId], [SalaryId]) VALUES (13, N'Nguyễn Thành Nam', N'Nam       ', N'093821245 ', N'Quận Hoàn Kiếm', CAST(N'1994-09-21' AS Date), N'1', N'2', N'3')
INSERT [dbo].[Employee] ([Id], [FullName], [Gender], [PhoneNumber], [Address], [DateOfBirth], [PositionId], [DepartmentId], [SalaryId]) VALUES (14, N'Tạ Đức Thắng', N'Nam       ', N'093821245 ', N'Quận Đống Đa', CAST(N'1994-09-21' AS Date), N'2', N'2', N'2')
INSERT [dbo].[Employee] ([Id], [FullName], [Gender], [PhoneNumber], [Address], [DateOfBirth], [PositionId], [DepartmentId], [SalaryId]) VALUES (15, N'Vũ Thành Công', N'Nam       ', N'093821245 ', N'Huyện Thạch Thất', CAST(N'1994-09-21' AS Date), N'2', N'2', N'3')
INSERT [dbo].[Employee] ([Id], [FullName], [Gender], [PhoneNumber], [Address], [DateOfBirth], [PositionId], [DepartmentId], [SalaryId]) VALUES (16, N'Phạm Mai Anh', N'Nam       ', N'093821245 ', N'Huyện Quốc Oai', CAST(N'1994-09-21' AS Date), N'2', N'2', N'3')
INSERT [dbo].[Employee] ([Id], [FullName], [Gender], [PhoneNumber], [Address], [DateOfBirth], [PositionId], [DepartmentId], [SalaryId]) VALUES (17, N'Bùi Nhật Tú', N'Nam       ', N'093821245 ', N'Huyện Thạch Thất', CAST(N'1994-09-21' AS Date), N'1', N'1', N'1')
INSERT [dbo].[Employee] ([Id], [FullName], [Gender], [PhoneNumber], [Address], [DateOfBirth], [PositionId], [DepartmentId], [SalaryId]) VALUES (18, N'Nguyễn Quang Anh', N'Nam       ', N'093821245 ', N'Huyện Thạch Thất', CAST(N'1994-09-21' AS Date), N'2', N'2', N'3')
INSERT [dbo].[Employee] ([Id], [FullName], [Gender], [PhoneNumber], [Address], [DateOfBirth], [PositionId], [DepartmentId], [SalaryId]) VALUES (19, N'Đặng Xuân Tuấn', N'Nam       ', N'093821245 ', N'Huyện Thạch Thất', CAST(N'1994-09-21' AS Date), N'3', N'3', N'3')
INSERT [dbo].[Employee] ([Id], [FullName], [Gender], [PhoneNumber], [Address], [DateOfBirth], [PositionId], [DepartmentId], [SalaryId]) VALUES (20, N'Nguyễn Tuấn Anh', N'Nam       ', N'093821245 ', N'Quận Đống Đa', CAST(N'1994-09-21' AS Date), N'3', N'3', N'3')
INSERT [dbo].[Employee] ([Id], [FullName], [Gender], [PhoneNumber], [Address], [DateOfBirth], [PositionId], [DepartmentId], [SalaryId]) VALUES (21, N'Trần Huy Chí', N'Nam       ', N'093821245 ', N'Quận Đống Đa', CAST(N'1994-09-21' AS Date), N'2', N'2', N'2')
INSERT [dbo].[Employee] ([Id], [FullName], [Gender], [PhoneNumber], [Address], [DateOfBirth], [PositionId], [DepartmentId], [SalaryId]) VALUES (22, N'Đào Công Ba', N'Nam       ', N'093821245 ', N'Quận Đống Đa', CAST(N'1994-09-21' AS Date), N'1', N'2', N'1')
INSERT [dbo].[Employee] ([Id], [FullName], [Gender], [PhoneNumber], [Address], [DateOfBirth], [PositionId], [DepartmentId], [SalaryId]) VALUES (23, N'Vũ Đức Trọng', N'Nam       ', N'093821245 ', N'Quận Đống Đa', CAST(N'1994-09-21' AS Date), N'1', N'2', N'1')
INSERT [dbo].[Employee] ([Id], [FullName], [Gender], [PhoneNumber], [Address], [DateOfBirth], [PositionId], [DepartmentId], [SalaryId]) VALUES (24, N'Phạm Đức Thuận', N'Nam       ', N'093821245 ', N'Quận Thanh Xuân', CAST(N'1994-09-21' AS Date), N'1', N'1', N'3')
SET IDENTITY_INSERT [dbo].[Employee] OFF
GO
INSERT [dbo].[Position] ([PositionId], [PositionName]) VALUES (N'1', N'Giám Đốc')
INSERT [dbo].[Position] ([PositionId], [PositionName]) VALUES (N'2', N'Quản Lí')
INSERT [dbo].[Position] ([PositionId], [PositionName]) VALUES (N'3', N'Nhân Viên')
GO
INSERT [dbo].[Salary] ([SalaryId], [BaseSalary], [LevelSalary]) VALUES (N'1', 1000, 2)
INSERT [dbo].[Salary] ([SalaryId], [BaseSalary], [LevelSalary]) VALUES (N'2', 1000, 3)
INSERT [dbo].[Salary] ([SalaryId], [BaseSalary], [LevelSalary]) VALUES (N'3', 1000, 4)
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [FK__Employee__Depart__2B3F6F97] FOREIGN KEY([DepartmentId])
REFERENCES [dbo].[Department] ([DepartmentId])
GO
ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [FK__Employee__Depart__2B3F6F97]
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [FK__Employee__Positi__2A4B4B5E] FOREIGN KEY([PositionId])
REFERENCES [dbo].[Position] ([PositionId])
GO
ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [FK__Employee__Positi__2A4B4B5E]
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [FK__Employee__Salary__2C3393D0] FOREIGN KEY([SalaryId])
REFERENCES [dbo].[Salary] ([SalaryId])
GO
ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [FK__Employee__Salary__2C3393D0]
GO
/****** Object:  StoredProcedure [dbo].[GetEmployeeListByName]    Script Date: 6/28/2021 11:01:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetEmployeeListByName]
	@name nvarchar(20), 
	@department nvarchar(30)
as
begin
	select *
	from Employee em
	where [dbo].[GetUnsignString](em.FullName) like N'%' + [dbo].[GetUnsignString](@name) + '%' and
	em.DepartmentId = (select DepartmentId
						from Department
						where Department.DepartmentIdName = @department)
end
GO
/****** Object:  StoredProcedure [dbo].[InsertEmployee]    Script Date: 6/28/2021 11:01:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[InsertEmployee]
@fullName nvarchar(20),@gender nchar(5),@phoneNumber char(10),@address nvarchar(50),@dateOfBirth date
,@positionId varchar(10),@departmentId varchar(10), @salaryId varchar(10) 
AS
BEGIN
	Insert into Employee 
	Values(@fullName,@gender,@phoneNumber,@address,@dateOfBirth,@positionId,@departmentId,@salaryId) 
END
GO
/****** Object:  StoredProcedure [dbo].[QLNS_Login]    Script Date: 6/28/2021 11:01:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[QLNS_Login]
@username nvarchar(50), @pass nvarchar(50)
AS
BEGIN
	SELECT * FROM dbo.Account WHERE UserName = @username AND Password = @pass
END
GO
/****** Object:  StoredProcedure [dbo].[UpdateEmployee]    Script Date: 6/28/2021 11:01:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[UpdateEmployee]
	
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
USE [master]
GO
ALTER DATABASE [QLNS] SET  READ_WRITE 
GO
