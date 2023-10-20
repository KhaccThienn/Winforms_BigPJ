CREATE DATABASE EmplManagement
GO

USE EmplManagement
GO

CREATE TABLE Department (
	Id INT PRIMARY KEY IDENTITY(1, 1),
	Name nvarchar(100) NOT NULL UNIQUE CHECK(
		LEN(Name) >= 6
	)
)
GO

CREATE TABLE Levels (
	Id INT PRIMARY KEY IDENTITY(1, 1),
	Name nvarchar(100) NOT NULL UNIQUE,
	Description TEXT
)
GO

CREATE TABLE Employee (
	Id INT PRIMARY KEY IDENTITY(1, 1),
	Name NVARCHAR(150) NOT NULL,
	Email VARCHAR(150) NOT NULL UNIQUE CHECK(
		Email LIKE '%@gmail.com'
	),
	Phone VARCHAR(50) NOT NULL UNIQUE,
	Address Nvarchar(255),
	Gender BIT CHECK(
		Gender = 0 OR
		Gender = 1 OR
		Gender = 2
	),
	BirthDay DATE NOT NULL,
	LevelId INT NOT NULL FOREIGN KEY REFERENCES Levels(Id),
	DepartmentId INT NOT NULL FOREIGN KEY REFERENCES Department(Id),
)
GO

CREATE TABLE Timesheets (
	Id INT PRIMARY KEY IDENTITY(1, 1),
	AttendanceDate DATE NOT NULL DEFAULT GETDATE(),
	EmployeeId INT NOT NULL FOREIGN KEY REFERENCES Employee(Id),
	Value FLOAT NOT NULL DEFAULT 1 CHECK (
		Value = 0 OR
		Value = 0.5 OR
		Value = 1
	),
	UNIQUE(AttendanceDate, EmployeeId, Value)
)	
GO

CREATE TABLE Roles (
	Id INT PRIMARY KEY IDENTITY(1, 1),
	Name NVARCHAR(150) NOT NULL,
)
GO

CREATE TABLE Accounts (
	Id INT PRIMARY KEY IDENTITY(1, 1),
	Username VARCHAR(50) NOT NULL,
	Password VARCHAR(50) NOT NULL,
	EmpId INT NOT NULL FOREIGN KEY REFERENCES Employee(Id),
	RoleId INT NOT NULL FOREIGN KEY REFERENCES Roles(Id)
)
GO

CREATE VIEW v_getEmployeeInfo 
AS
	SELECT emp.Id, emp.Name, emp.Email, emp.Phone, emp.Address, 
	CASE emp.Gender 
		WHEN 0 THEN N'Nữ'
		WHEN 1 THEN N'Nam'
		ELSE N'Khác'
	END AS gender, 
	emp.BirthDay, (YEAR(GETDATE()) - YEAR(emp.BirthDay)) AS Age,
	dp.Name as DepartmentName, lvls.Name as LevelName
	FROM Employee emp 
	INNER JOIN Department dp ON emp.DepartmentId = dp.Id
	INNER JOIN Levels lvls ON emp.LevelId = lvls.Id
GO


CREATE VIEW v_getEmployeeSalaryMax
AS
SELECT  emp.Id, emp.Name, emp.Email, emp.Phone, emp.BirthDay, COUNT(tsh.EmployeeId) AS TotalDay
FROM Employee emp
LEFT JOIN Timesheets tsh ON tsh.EmployeeId = emp.Id
GROUP BY emp.Id, emp.Name, emp.Email, emp.Phone, emp.BirthDay
HAVING COUNT(tsh.EmployeeId) > 18
GO


CREATE PROC addEmployeetInfo
	@name Nvarchar(150),
	@email Varchar(150),
	@phone Varchar(50),
	@address Nvarchar(255),
	@gender Tinyint,
	@birthday DATE,
	@levelId INT,
	@departmentID INT
AS
BEGIN
	INSERT INTO Employee ([Name], [Email], [Phone], [Address], [Gender], [BirthDay], [LevelId], [DepartmentId]) VALUES 
	(@name, @email, @phone, @address, @gender, @birthday, @levelId, @departmentID)
END
GO


CREATE PROC getEmployeePaginate
	 @limit INT,
	 @page INT
AS
BEGIN
	SELECT emp.Id, emp.Name, emp.Email, emp.Phone, emp.Address, 
	CASE emp.Gender 
		WHEN 0 THEN N'Nữ'
		WHEN 1 THEN N'Nam'
		ELSE N'Khác'
	END AS gender, 
	emp.BirthDay, (YEAR(GETDATE()) - YEAR(emp.BirthDay)) AS Age,
	dp.Name as DepartmentName, lvls.Name as LevelName
	FROM Employee emp 
	INNER JOIN Department dp ON emp.DepartmentId = dp.Id
	INNER JOIN Levels lvls ON emp.LevelId = lvls.Id
	ORDER BY emp.id
	OFFSET @limit * (@page - 1)ROWS 
	FETCH NEXT @limit ROWS ONLY
END
GO



INSERT INTO Department ([Name]) VALUES 
(N'Managerment'),
(N'Developers')
GO

INSERT INTO Levels ([Name], [Description])
VALUES 
(N'Intern', N'Thực Tập Sinh'),
(N'Entry-level Employee', N'Nhân viên cấp đầu vào'),
(N'Junior Employee', N'Nhân viên cấp trung'),
(N'Senior Employee', N'Nhân viên cấp cao'),
(N'Manager', N'Người Quản Lý'),
(N'Executive', N'Người Điều Hành')
GO

INSERT INTO Employee ([Name], [Email], [Phone], [Address], [Gender], [BirthDay], [LevelId], [DepartmentId]) VALUES 
(N'Taka Admin', 'Admin@gmail.com', '0392689213', N'Hoàng Quốc Việt - Cầu Giấy - HN', 1, '2003-10-31', 5, 1),
(N'Taka A', 'TakaA@gmail.com', '0974459015', N'Hoàng Quốc Việt - Cầu Giấy - HN', 1, '2004-12-21', 1, 2)
GO

INSERT INTO Roles([Name])
VALUES 
(N'Admin'),
(N'Employee')

INSERT INTO Accounts([EmpId], [RoleId], [Username], [Password])
VALUES 
(1, 2, 'administrator', '12345678'),
(2, 1, 'takaemp01', '12345678')