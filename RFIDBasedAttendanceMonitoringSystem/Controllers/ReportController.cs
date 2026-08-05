using RFIDBasedAttendanceMonitoringSystem.Models;
using RFIDBasedAttendanceMonitoringSystem.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RFIDBasedAttendanceMonitoringSystem.Controllers
{
    public class ReportController
    {
        private readonly IRepository _repository;

        public ReportController(IRepository repository)
        {
            this._repository = repository;
        }

        public List<Attendance> GetDailyAttendance(DateTime date)
        {
            return _repository.Pull<Attendance>(SqlQueries.REPORT_DAILY_ATTENDANCE,new { Date = date.Date })
                .ToList();
        }

        public List<EmployeeAttendanceSummary> GetMonthlySummary(DateTime startDate, DateTime endDate)
        {
            return _repository.Pull<EmployeeAttendanceSummary>(
                SqlQueries.REPORT_EMPLOYEE_SUMMARY,
                new {   StartDate   =   startDate.Date, 
                        EndDate     =   endDate.Date })
                .ToList();
        }

        public List<DepartmentAttendanceSummary> GetDepartmentSummary(DateTime startDate, DateTime endDate)
        {
            return _repository.Pull<DepartmentAttendanceSummary>(
                SqlQueries.REPORT_DEPARTMENT_SUMMARY,
                new {   StartDate   =   startDate.Date, 
                        EndDate     =   endDate.Date })
                .ToList();
        }

        public List<Attendance> GetLateAbsentee(DateTime startDate, DateTime endDate)
        {
            return _repository.Pull<Attendance>(
                SqlQueries.REPORT_LATE_ABSENTEE,
                new {   StartDate   =   startDate.Date, 
                        EndDate     =   endDate.Date })
                .ToList();
        }

      
        public (DateTime Start, DateTime End) GetCutoffRange(DateTime referenceDate)
        {
            if (referenceDate.Day <= 15)
            {
                DateTime start = new DateTime(referenceDate.Year, referenceDate.Month, 1);
                DateTime end = new DateTime(referenceDate.Year, referenceDate.Month, 15);
                return (start, end);
            }
            else
            {
                DateTime start = new DateTime(referenceDate.Year, referenceDate.Month, 16);
                int lastDay = DateTime.DaysInMonth(referenceDate.Year, referenceDate.Month);
                DateTime end = new DateTime(referenceDate.Year, referenceDate.Month, lastDay);
                return (start, end);
            }
        }

     
        public List<EmployeeAttendanceSummary> GetCutoffSummary(DateTime referenceDate, out DateTime rangeStart, out DateTime rangeEnd)
        {
            var range   = GetCutoffRange(referenceDate);
            rangeStart  = range.Start;
            rangeEnd    = range.End;
            return GetMonthlySummary(range.Start, range.End);
        }
    }
}