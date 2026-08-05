using RFIDBasedAttendanceMonitoringSystem.Models;
using RFIDBasedAttendanceMonitoringSystem.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RFIDBasedAttendanceMonitoringSystem.Controllers
{
    public class DashboardController
    {
        private readonly IRepository _repository;
        private readonly ReportController _reportController;

        public DashboardController(IRepository repository)
        {
            this._repository = repository;
            this._reportController = new ReportController(repository);
        }

        public int GetHeadcount()
        {
            return _repository.PullSingle<int>(SqlQueries.DASH_HEADCOUNT);
        }

        public Dashboard GetDashboard(DateTime date)
        {
            return _repository.PullSingle<Dashboard>(
                SqlQueries.DASH_TODAY_SUMMARY,
                new { Today = date.Date }) ?? new Dashboard();
        }

        public List<WeeklyTrendPoint> GetWeeklyTrend(DateTime referenceDate)
        {
            DateTime monday = GetMondayOfWeek(referenceDate);
            DateTime friday = monday.AddDays(4);

            var results = _repository.Pull<WeeklyTrendPoint>(
                SqlQueries.DASH_WEEKLY_TREND,
                new { StartDate = monday, EndDate = friday }).ToList();

            var filled = new List<WeeklyTrendPoint>();
            for (DateTime day = monday; day <= friday; day = day.AddDays(1))
            {
                var match = results.FirstOrDefault(r => r.AttendanceDate.Date == day.Date);
                filled.Add(match ?? new WeeklyTrendPoint { AttendanceDate = day, Present = 0, Late = 0, Absent = 0 });
            }
            return filled;
        }

        private static DateTime GetMondayOfWeek(DateTime date)
        {
            int diff = (7 + (date.DayOfWeek - DayOfWeek.Monday)) % 7;
            return date.Date.AddDays(-diff);
        }

        public List<DepartmentAttendanceSummary> GetDepartmentRates(DateTime date)
        {
            return _reportController.GetDepartmentSummary(date, date);
        }

        public List<Attendance> GetRecentScans(DateTime date, int count = 5)
        {
            return _repository.Pull<Attendance>(
                SqlQueries.DASH_RECENT_SCANS,
                new { Today = date.Date, Count = count }).ToList();
        }

        public Holiday GetNextHoliday(DateTime fromDate)
        {
            return _repository.PullSingle<Holiday>(
                SqlQueries.DASH_NEXT_HOLIDAY,
                new { Today = fromDate.Date });
        }
    }
}