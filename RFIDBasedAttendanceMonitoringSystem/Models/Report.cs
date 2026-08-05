using System;

namespace RFIDBasedAttendanceMonitoringSystem.Models
{
 
    public class EmployeeAttendanceSummary
    {
        public string EmployeeTag { get; set; }
        public string FullName { get; set; }
        public string DepartmentName { get; set; }
        public string PositionName { get; set; }
        public int PresentCount { get; set; }
        public int LateCount { get; set; }
        public int AbsentCount { get; set; }
        public int HolidayCount { get; set; }
        public int TotalDays { get; set; }
    }

    
    public class DepartmentAttendanceSummary
    {
        public string DepartmentName { get; set; }
        public int PresentCount { get; set; }
        public int LateCount { get; set; }
        public int AbsentCount { get; set; }
        public int HolidayCount { get; set; }
        public int TotalRecords { get; set; }
    }

    public enum ReportKind
    {
        DailyAttendance = 0,
        MonthlySummary = 1,
        DepartmentSummary = 2,
        LateAbsentee = 3,
        CutoffSummary = 4
    }
}