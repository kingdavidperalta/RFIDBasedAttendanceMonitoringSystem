using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFIDBasedAttendanceMonitoringSystem.Controllers
{
    public class SqlQueries
    {
        #region USER ___________________________________________________________________________________________________
        public const string SELECT_USER_BY_USERNAME = @"
            SELECT ID, USERNAME, PASSWORDHASH, FULLNAME, ROLE, CREATEDAT
            FROM USERS
            WHERE USERNAME = @Username";

        public const string CHECK_USER_EXISTS = @"
            SELECT COUNT(*) FROM USERS
            WHERE USERNAME = @Username;";

        public const string INSERT_USER = @"
            INSERT INTO USERS (USERNAME, PASSWORDHASH, FULLNAME, ROLE, CREATEDAT)
            VALUES (@Username, @PasswordHash, @FullName, @Role, @CreatedAt);
            SELECT CAST(SCOPE_IDENTITY() AS INT);";
        #endregion

        #region DEPARTMENT _______________________________________________________________________________________________
        public const string SELECT_DEPARTMENT_PAGED = @"
            SELECT ID, DEPARTMENTNAME, CREATEDAT
            FROM DEPARTMENTS
            ORDER BY ID
            OFFSET @Offset ROWS FETCH NEXT @PageSize ROWS ONLY;";

        public const string SELECT_DEPARTMENT_COUNT = @"
            SELECT COUNT(*) FROM DEPARTMENTS;";

        public const string SELECT_DEPARTMENT_PAGED_SEARCH = @"
            SELECT ID, DEPARTMENTNAME, CREATEDAT
            FROM DEPARTMENTS
            WHERE DEPARTMENTNAME LIKE @Search
            ORDER BY ID
            OFFSET @Offset ROWS FETCH NEXT @PageSize ROWS ONLY;";

        public const string SELECT_DEPARTMENT_COUNT_SEARCH = @"
            SELECT COUNT(*) FROM DEPARTMENTS
            WHERE DEPARTMENTNAME LIKE @Search;";

        public const string INSERT_DEPARTMENT = @"
            INSERT INTO DEPARTMENTS (DEPARTMENTNAME, CREATEDAT)
            VALUES (@DEPARTMENTNAME, @CreatedAt);
            SELECT CAST(SCOPE_IDENTITY() AS INT);";

        public const string UPDATE_DEPARTMENT = @"
            UPDATE DEPARTMENTS
            SET DEPARTMENTNAME = @DEPARTMENTNAME
              
            WHERE ID = @Id;";

        public const string DELETE_DEPARTMENT = @"
            DELETE FROM DEPARTMENTS WHERE ID = @Id;";
        #endregion


        #region POSITION _______________________________________________________________________________________________
        public const string SELECT_POSITION_PAGED = @"
            SELECT ID, POSITIONNAME, CREATEDAT
            FROM POSITIONS
            ORDER BY ID
            OFFSET @Offset ROWS FETCH NEXT @PageSize ROWS ONLY;";

        public const string SELECT_POSITION_COUNT = @"
            SELECT COUNT(*) FROM POSITIONS;";

        public const string SELECT_POSITION_PAGED_SEARCH = @"
            SELECT ID, POSITIONNAME, CREATEDAT
            FROM POSITIONS
            WHERE POSITIONNAME LIKE @Search
            ORDER BY ID
            OFFSET @Offset ROWS FETCH NEXT @PageSize ROWS ONLY;";

        public const string SELECT_POSITION_COUNT_SEARCH = @"
            SELECT COUNT(*) FROM POSITIONS
            WHERE POSITIONNAME LIKE @Search;";

        public const string INSERT_POSITION = @"
            INSERT INTO POSITIONS (POSITIONNAME, CREATEDAT)
            VALUES (@POSITIONNAME, @CreatedAt);
            SELECT CAST(SCOPE_IDENTITY() AS INT);";

        public const string UPDATE_POSITION = @"
            UPDATE POSITIONS
            SET POSITIONNAME = @POSITIONNAME
              
            WHERE ID = @Id;";

        public const string DELETE_POSITION = @"
            DELETE FROM POSITIONS WHERE ID = @Id;";
        #endregion


        #region EMPLOYEE _______________________________________________________________________________________________
        public const string SELECT_EMPLOYEE_PAGED = @"
            SELECT
                Id
                ,EmployeeTag
                ,FullName
                ,LastName
                ,FirstName
                ,MiddleName
                ,Suffix
                ,DepartmentId
                ,PositionId
                ,DepartmentName
                ,PositionName
                ,Status
                ,PhotoPath
                ,CreatedAt
            FROM VwEmployeeDetails
            WHERE DeletedAt IS NULL
            ORDER BY Id DESC
            OFFSET @Offset ROWS FETCH NEXT @PageSize ROWS ONLY;";

        public const string CHECK_EMPLOYEE_EXISTS = @"
            SELECT COUNT(*) FROM EMPLOYEES
            WHERE EMPLOYEETAG = @Name;";

        public const string CHECK_EMPLOYEE_EXISTS_EXCLUDING_ID = @"
            SELECT COUNT(*) FROM EMPLOYEES
            WHERE LASTNAME = @Name AND ID != @Id;";

        public const string SELECT_EMPLOYEE_COUNT = @"
            SELECT COUNT(*) FROM EMPLOYEES;";

        public const string SELECT_EMPLOYEE_PAGED_SEARCH = @"
            SELECT
                Id
                ,EmployeeTag
                ,FullName
                ,LastName
                ,FirstName
                ,MiddleName
                ,Suffix
                ,DepartmentId
                ,PositionId
                ,DepartmentName
                ,PositionName
                ,Status
                ,CreatedAt
                ,PhotoPath
                ,DeletedAt
            FROM VwEmployeeDetails
            WHERE DeletedAt IS NULL
                AND (FullName LIKE @Search OR EmployeeTag LIKE @Search)
            ORDER BY Id DESC
            OFFSET @Offset ROWS FETCH NEXT @PageSize ROWS ONLY;";

        public const string SELECT_EMPLOYEE_COUNT_SEARCH = @"
            SELECT COUNT(*)
            FROM VwEmployeeDetails
            WHERE DeletedAt IS NULL
                AND (FullName LIKE @Search OR EmployeeTag LIKE @Search);";

        public const string INSERT_EMPLOYEE = @"
            INSERT INTO EMPLOYEES (
                EmployeeTag, LastName, FirstName, MiddleName, Suffix,
                DepartmentId, PositionId, Status, PhotoPath, CreatedAt)
            VALUES (
                @EmployeeTag, @LastName, @FirstName, @MiddleName, @Suffix,
                @DepartmentId, @PositionId, @Status, @PhotoPath, @CreatedAt);
            SELECT CAST(SCOPE_IDENTITY() AS INT)";

        public const string UPDATE_EMPLOYEE = @"
            UPDATE EMPLOYEES
            SET EmployeeTag   = @EmployeeTag,
                LastName      = @LastName,
                FirstName     = @FirstName,
                MiddleName    = @MiddleName,
                Suffix        = @Suffix,
                DepartmentId  = @DepartmentId,
                PositionId    = @PositionId,
                Status        = @Status,
                PhotoPath     = @PhotoPath
            WHERE ID = @Id;";

        public const string DELETE_EMPLOYEE = @"
          UPDATE EMPLOYEES SET DELETEDAT = @DeletedAt WHERE ID = @Id;";
        #endregion


        #region ARCHIVED EMPLOYEE _______________________________________________________________________________________________
        public const string SELECT_ARCHIVED_EMPLOYEE_PAGED = @"
            SELECT
                Id
                ,EmployeeTag
                ,FullName
                ,LastName
                ,FirstName
                ,MiddleName
                ,Suffix
                ,DepartmentId
                ,PositionId
                ,DepartmentName
                ,PositionName
                ,Status
                ,PhotoPath
                ,CreatedAt
            FROM VwEmployeeDetails
            WHERE DeletedAt IS NOT NULL
            ORDER BY Id DESC
            OFFSET @Offset ROWS FETCH NEXT @PageSize ROWS ONLY;";

        public const string SELECT_ARCHIVED_EMPLOYEE_COUNT = @"
        SELECT COUNT(*) FROM EMPLOYEES WHERE DELETEDAT IS NOT NULL;";

        public const string SELECT_ARCHIVED_EMPLOYEE_PAGED_SEARCH = @"
            SELECT
                Id
                ,EmployeeTag
                ,FullName
                ,LastName
                ,FirstName
                ,MiddleName
                ,Suffix
                ,DepartmentId
                ,PositionId
                ,DepartmentName
                ,PositionName
                ,Status
                ,CreatedAt
                ,PhotoPath
                ,DeletedAt
            FROM VwEmployeeDetails
            WHERE DeletedAt IS NOT NULL
                AND (FullName LIKE @Search OR EmployeeTag LIKE @Search)
            ORDER BY Id DESC
            OFFSET @Offset ROWS FETCH NEXT @PageSize ROWS ONLY;";

        public const string SELECT_ARCHIVED_EMPLOYEE_COUNT_SEARCH = @"
            SELECT COUNT(*)
            FROM VwEmployeeDetails
            WHERE DeletedAt IS NOT NULL
                AND (FullName LIKE @Search OR EmployeeTag LIKE @Search);";

        public const string RESTORE_EMPLOYEE = @"
            UPDATE EMPLOYEES SET DELETEDAT = NULL 
            WHERE ID = @Id;";

        public const string SELECT_ALL_DEPARTMENTS = @"
            SELECT ID, DEPARTMENTNAME, CREATEDAT
            FROM DEPARTMENTS
            ORDER BY DEPARTMENTNAME;";

        public const string SELECT_ALL_POSITIONS = @"
            SELECT ID, POSITIONNAME, CREATEDAT
            FROM POSITIONS
            ORDER BY POSITIONNAME;";
        #endregion


        #region ATTENDANCE _______________________________________________________________________________________________
        public const string SELECT_ATTENDANCE_PAGED = @"
            SELECT
                Id
                ,EmployeeId
                ,EmployeeTag
                ,FullName
                ,DepartmentName
                ,PositionName
                ,AttendanceDate
                ,TimeIn
                ,TimeOut
                ,Status
                ,CreatedAt
            FROM VwAttendanceDetails
            WHERE AttendanceDate = @Date
            ORDER BY Id DESC
            OFFSET @Offset ROWS FETCH NEXT @PageSize ROWS ONLY;";

        public const string SELECT_ATTENDANCE_COUNT = @"
            SELECT COUNT(*)
            FROM ATTENDANCE
            WHERE AttendanceDate = @Date;";

        public const string SELECT_ATTENDANCE_PAGED_SEARCH = @"
            SELECT
                Id
                ,EmployeeId
                ,EmployeeTag
                ,FullName
                ,DepartmentName
                ,PositionName
                ,AttendanceDate
                ,TimeIn
                ,TimeOut
                ,Status
                ,CreatedAt
            FROM VwAttendanceDetails
            WHERE AttendanceDate = @Date
                AND (FullName LIKE @Search OR EmployeeTag LIKE @Search)
            ORDER BY Id DESC
            OFFSET @Offset ROWS FETCH NEXT @PageSize ROWS ONLY;";

        public const string SELECT_ATTENDANCE_COUNT_SEARCH = @"
            SELECT COUNT(*)
            FROM VwAttendanceDetails
            WHERE AttendanceDate = @Date
                AND (FullName LIKE @Search OR EmployeeTag LIKE @Search);";

        public const string SELECT_IS_HOLIDAY = @"
            SELECT COUNT(*) FROM HOLIDAYS WHERE HolidayDate = @Today;";

        public const string SEED_ABSENT_ATTENDANCE = @"
            INSERT INTO ATTENDANCE (EmployeeId, AttendanceDate, TimeIn, TimeOut, Status, CreatedAt)
            SELECT ID, @Today, NULL, NULL, 2, GETDATE()
            FROM EMPLOYEES
            WHERE Status = 0 AND DeletedAt IS NULL
              AND ID NOT IN (SELECT EmployeeId FROM ATTENDANCE WHERE AttendanceDate = @Today);";

        public const string SEED_HOLIDAY_ATTENDANCE = @"
            INSERT INTO ATTENDANCE (EmployeeId, AttendanceDate, TimeIn, TimeOut, Status, CreatedAt)
            SELECT ID, @Today, NULL, NULL, 3, GETDATE()
            FROM EMPLOYEES
            WHERE Status = 0 AND DeletedAt IS NULL
              AND ID NOT IN (SELECT EmployeeId FROM ATTENDANCE WHERE AttendanceDate = @Today);";

        public const string SELECT_ATTENDANCE_BY_TAG_AND_DATE = @"
            SELECT
                Id
                ,EmployeeId
                ,EmployeeTag
                ,FullName
                ,DepartmentName
                ,PositionName
                ,PhotoPath
                ,AttendanceDate
                ,TimeIn
                ,TimeOut
                ,Status
                ,CreatedAt
            FROM VwAttendanceDetails
            WHERE EmployeeTag = @EmployeeTag
              AND AttendanceDate = @Today;";

        public const string UPDATE_ATTENDANCE_TIMEIN = @"
            UPDATE ATTENDANCE
            SET TimeIn = @TimeIn, Status = @Status
            WHERE Id = @Id;";

        public const string UPDATE_ATTENDANCE_TIMEOUT = @"
            UPDATE ATTENDANCE
            SET TimeOut = @TimeOut
            WHERE Id = @Id;";

        public const string SELECT_SHIFT_SCHEDULE = @"
            SELECT TOP 1 ID, TimeInStart, TimeOutEnd, GracePeriodMinutes, CreatedAt
            FROM SHIFTSCHEDULE
            ORDER BY ID;";


        public static readonly string REPORT_DAILY_ATTENDANCE = @"
            SELECT
                Id
                ,EmployeeId
                ,EmployeeTag
                ,FullName
                ,DepartmentName
                ,PositionName
                ,AttendanceDate
                ,TimeIn
                ,TimeOut
                ,Status
                ,CreatedAt
            FROM VwAttendanceDetails
            WHERE AttendanceDate = @Date
            ORDER BY DepartmentName, FullName;";


        public static readonly string REPORT_EMPLOYEE_SUMMARY = @"
            SELECT
                ed.EmployeeTag,
                ed.FullName,
                ed.DepartmentName,
                ed.PositionName,
                SUM(CASE WHEN a.Status = 0 THEN 1 ELSE 0 END) AS PresentCount,
                SUM(CASE WHEN a.Status = 1 THEN 1 ELSE 0 END) AS LateCount,
                SUM(CASE WHEN a.Status = 2 THEN 1 ELSE 0 END) AS AbsentCount,
                SUM(CASE WHEN a.Status = 3 THEN 1 ELSE 0 END) AS HolidayCount,
                COUNT(a.Id) AS TotalDays
            FROM VwEmployeeDetails ed
            LEFT JOIN ATTENDANCE a ON a.EmployeeId = ed.Id
                AND a.AttendanceDate BETWEEN @StartDate AND @EndDate
            WHERE ed.DeletedAt IS NULL
            GROUP BY ed.EmployeeTag, ed.FullName, ed.DepartmentName, ed.PositionName
            ORDER BY ed.DepartmentName, ed.FullName;";


        public static readonly string REPORT_DEPARTMENT_SUMMARY = @"
            SELECT
                ISNULL(DepartmentName, 'UNASSIGNED') AS DepartmentName,
                SUM(CASE WHEN Status = 0 THEN 1 ELSE 0 END) AS PresentCount,
                SUM(CASE WHEN Status = 1 THEN 1 ELSE 0 END) AS LateCount,
                SUM(CASE WHEN Status = 2 THEN 1 ELSE 0 END) AS AbsentCount,
                SUM(CASE WHEN Status = 3 THEN 1 ELSE 0 END) AS HolidayCount,
                COUNT(Id) AS TotalRecords
            FROM VwAttendanceDetails
            WHERE AttendanceDate BETWEEN @StartDate AND @EndDate
            GROUP BY DepartmentName
            ORDER BY DepartmentName;";


        public static readonly string REPORT_LATE_ABSENTEE = @"
            SELECT
                Id
                ,EmployeeId
                ,EmployeeTag
                ,FullName
                ,DepartmentName
                ,PositionName
                ,AttendanceDate
                ,TimeIn
                ,TimeOut
                ,Status
                ,CreatedAt
            FROM VwAttendanceDetails
            WHERE AttendanceDate BETWEEN @StartDate AND @EndDate
              AND Status IN (1, 2)
            ORDER BY AttendanceDate DESC, FullName;";


        public const string DASH_HEADCOUNT = @"
            SELECT COUNT(*) FROM EMPLOYEES
            WHERE DeletedAt IS NULL AND Status = 0;";

        public const string DASH_TODAY_SUMMARY = @"
            SELECT
                SUM(CASE WHEN Status = 0 THEN 1 ELSE 0 END) AS Present,
                SUM(CASE WHEN Status = 1 THEN 1 ELSE 0 END) AS Late,
                SUM(CASE WHEN Status = 2 THEN 1 ELSE 0 END) AS Absent,
                SUM(CASE WHEN Status = 3 THEN 1 ELSE 0 END) AS Holiday
            FROM ATTENDANCE
            WHERE AttendanceDate = @Today;";

        public const string DASH_WEEKLY_TREND = @"
            SELECT
                AttendanceDate,
                SUM(CASE WHEN Status = 0 THEN 1 ELSE 0 END) AS Present,
                SUM(CASE WHEN Status = 1 THEN 1 ELSE 0 END) AS Late,
                SUM(CASE WHEN Status = 2 THEN 1 ELSE 0 END) AS Absent
            FROM ATTENDANCE
            WHERE AttendanceDate BETWEEN @StartDate AND @EndDate
            GROUP BY AttendanceDate
            ORDER BY AttendanceDate;";

        public const string DASH_RECENT_SCANS = @"
            SELECT TOP (@Count)
                Id
                ,EmployeeId
                ,EmployeeTag
                ,FullName
                ,DepartmentName
                ,PositionName
                ,AttendanceDate
                ,TimeIn
                ,TimeOut
                ,Status
                ,CreatedAt
            FROM VwAttendanceDetails
            WHERE AttendanceDate = @Today
              AND TimeIn IS NOT NULL
            ORDER BY COALESCE(TimeOut, TimeIn) DESC;";

        public const string DASH_NEXT_HOLIDAY = @"
            SELECT TOP 1 HolidayDate, Description
            FROM HOLIDAYS
            WHERE HolidayDate >= @Today
            ORDER BY HolidayDate;";
        #endregion


        #region SHIFT SCHEDULE _______________________________________________________________________________________________
        public const string SELECT_SHIFTSCHEDULE_PAGED = @"
            SELECT ID, TimeInStart, TimeOutEnd, GracePeriodMinutes, CreatedAt
            FROM SHIFTSCHEDULE
            ORDER BY ID
            OFFSET @Offset ROWS FETCH NEXT @PageSize ROWS ONLY;";

        public const string SELECT_SHIFTSCHEDULE_COUNT = @"
            SELECT COUNT(*) FROM SHIFTSCHEDULE;";

        public const string SELECT_SHIFTSCHEDULE_BY_ID = @"
            SELECT ID, TimeInStart, TimeOutEnd, GracePeriodMinutes, CreatedAt
            FROM SHIFTSCHEDULE
            WHERE ID = @Id;";

        public const string INSERT_SHIFTSCHEDULE = @"
            INSERT INTO SHIFTSCHEDULE (TimeInStart, TimeOutEnd, GracePeriodMinutes, CreatedAt)
            VALUES (@TimeInStart, @TimeOutEnd, @GracePeriodMinutes, @CreatedAt);
            SELECT CAST(SCOPE_IDENTITY() AS INT);";

        public const string UPDATE_SHIFTSCHEDULE = @"
            UPDATE SHIFTSCHEDULE
            SET TimeInStart = @TimeInStart,
                TimeOutEnd = @TimeOutEnd,
                GracePeriodMinutes = @GracePeriodMinutes
            WHERE ID = @Id;";

        public const string DELETE_SHIFTSCHEDULE = @"
            DELETE FROM SHIFTSCHEDULE WHERE ID = @Id;";
        #endregion


        #region HOLIDAY _______________________________________________________________________________________________
        public const string SELECT_HOLIDAY_PAGED = @"
            SELECT ID, HolidayDate, Description, CreatedAt
            FROM HOLIDAYS
            ORDER BY HolidayDate
            OFFSET @Offset ROWS FETCH NEXT @PageSize ROWS ONLY;";

        public const string SELECT_HOLIDAY_COUNT = @"
            SELECT COUNT(*) FROM HOLIDAYS;";

        public const string SELECT_HOLIDAY_PAGED_SEARCH = @"
            SELECT ID, HolidayDate, Description, CreatedAt
            FROM HOLIDAYS
            WHERE Description LIKE @Search
            ORDER BY HolidayDate
            OFFSET @Offset ROWS FETCH NEXT @PageSize ROWS ONLY;";

        public const string SELECT_HOLIDAY_COUNT_SEARCH = @"
            SELECT COUNT(*) FROM HOLIDAYS
            WHERE Description LIKE @Search;";

        public const string INSERT_HOLIDAY = @"
            INSERT INTO HOLIDAYS (HolidayDate, Description, CreatedAt)
            VALUES (@HolidayDate, @Description, @CreatedAt);
            SELECT CAST(SCOPE_IDENTITY() AS INT);";

        public const string UPDATE_HOLIDAY = @"
            UPDATE HOLIDAYS
            SET HolidayDate = @HolidayDate,
                Description = @Description
            WHERE ID = @Id;";

        public const string DELETE_HOLIDAY = @"
            DELETE FROM HOLIDAYS WHERE ID = @Id;";
        #endregion
    }

}