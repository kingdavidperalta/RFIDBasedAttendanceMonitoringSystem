
CREATE TABLE [dbo].[Users](
	[ID] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[USERNAME] [nvarchar](30) NULL,
	[PASSWORDHASH] [nvarchar](200) NULL,
	[FULLNAME] [nvarchar](50) NULL,
	[ROLE] [nvarchar](20) NULL,
	[CREATEDAT] [date] NULL,
	[DELETEDAT] [date] NULL
);
GO

CREATE TABLE [dbo].[Departments](
	[ID] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[DEPARTMENTNAME] [varchar](50) NULL,
	[CREATEDAT] [date] NULL,
	[DELETEDAT] [date] NULL
);
GO

CREATE TABLE [dbo].[ShiftSchedule](
	[Id] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[TimeInStart] [time](7) NOT NULL,
	[TimeOutEnd] [time](7) NOT NULL,
	[GracePeriodMinutes] [int] NOT NULL,
	[CreatedAt] [date] NULL,
	[DeletedAt] [date] NULL
);
GO

CREATE TABLE [dbo].[Holidays](
	[ID] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[HOLIDAYDATE] [date] NULL,
	[DESCRIPTION] [varchar](50) NULL,
	[CREATEDAT] [date] NULL,
	[DELETEDAT] [date] NULL
);
GO

CREATE TABLE [dbo].[Positions](
	[ID] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[POSITIONNAME] [varchar](50) NULL,
	[CREATEDAT] [date] NULL,
	[DELETEDAT] [date] NULL
);
GO


CREATE TABLE [dbo].[Employees](
	[ID] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[EMPLOYEETAG] [varchar](10) NULL,
	[LASTNAME] [varchar](50) NULL,
	[FIRSTNAME] [varchar](50) NULL,
	[MIDDLENAME] [varchar](50) NULL,
	[SUFFIX] [varchar](50) NULL,
	[DEPARTMENTID] [int] NULL,
	[POSITIONID] [int] NULL,
	[STATUS] [smallint] NULL,
	[PHOTOPATH] [nvarchar](255) NULL,
	[CREATEDAT] [date] NULL,
	[DELETEDAT] [date] NULL,

	CONSTRAINT FK_Employees_Departments
		FOREIGN KEY (DEPARTMENTID)
		REFERENCES Departments(ID)
		ON DELETE SET NULL,

	CONSTRAINT FK_Employees_Positions
		FOREIGN KEY (POSITIONID)
		REFERENCES Positions(ID)
		ON DELETE SET NULL
);
GO


CREATE TABLE [dbo].[Attendance](
	[ID] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[EMPLOYEEID] [int] NULL,
	[ATTENDANCEDATE] [date] NULL,
	[TIMEIN] [datetime2](7) NULL,
	[TIMEOUT] [datetime2](7) NULL,
	[STATUS] [smallint] NULL,
	[CREATEDAT] [date] NULL,

	CONSTRAINT FK_Attendance_Employees
		FOREIGN KEY (EMPLOYEEID)
		REFERENCES Employees(ID)
		ON DELETE SET NULL
);
GO

CREATE VIEW [dbo].[VwAttendanceDetails]
AS
SELECT
    a.Id
    ,a.EmployeeId
    ,e.EmployeeTag
    ,CONCAT(
        e.LASTNAME,
        ', ',
        e.FIRSTNAME,
        CASE WHEN e.MIDDLENAME IS NOT NULL AND e.MIDDLENAME <> '' THEN ' ' + e.MIDDLENAME ELSE '' END,
        CASE WHEN e.SUFFIX IS NOT NULL AND e.SUFFIX <> '' THEN ' ' + e.SUFFIX ELSE '' END
    ) AS FullName
    ,e.PhotoPath
    ,d.DepartmentName
    ,p.PositionName
    ,a.AttendanceDate
    ,a.TimeIn
    ,a.TimeOut
    ,a.Status
    ,a.CreatedAt
FROM ATTENDANCE a
LEFT JOIN EMPLOYEES e ON e.ID = a.EmployeeId
LEFT JOIN DEPARTMENTS d ON d.ID = e.DepartmentId
LEFT JOIN POSITIONS p ON p.ID = e.PositionId;
GO

CREATE VIEW [dbo].[VwEmployeeDetails]
AS
SELECT
    e.Id
    ,e.EmployeeTag
    ,e.LastName
    ,e.FirstName
    ,e.MiddleName
    ,e.Suffix
    ,CONCAT(
        e.LASTNAME,
        ', ',
        e.FIRSTNAME,
        CASE WHEN e.MIDDLENAME IS NOT NULL AND e.MIDDLENAME <> '' THEN ' ' + e.MIDDLENAME ELSE '' END,
        CASE WHEN e.SUFFIX IS NOT NULL AND e.SUFFIX <> '' THEN ' ' + e.SUFFIX ELSE '' END
    ) AS FullName
    ,d.Id AS DepartmentId
    ,p.Id AS PositionId
    ,d.DepartmentName
    ,p.PositionName
    ,e.Status
    ,e.PhotoPath
    ,e.CreatedAt
    ,e.DeletedAt
FROM EMPLOYEES e
LEFT JOIN DEPARTMENTS d ON d.ID = e.DepartmentId
LEFT JOIN POSITIONS p ON p.ID = e.PositionId;
GO

CREATE INDEX IX_Employees_DepartmentID
ON Employees(DepartmentID);
GO

CREATE INDEX IX_Employees_PositionID
ON Employees(PositionID);
GO

CREATE INDEX IX_Attendance_EmployeeID
ON Attendance(EmployeeID);
GO

CREATE INDEX IX_Attendance_AttendanceDate
ON Attendance(AttendanceDate);
GO