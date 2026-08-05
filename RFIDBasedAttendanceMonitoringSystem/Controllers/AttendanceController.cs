using RFIDBasedAttendanceMonitoringSystem.Models;
using RFIDBasedAttendanceMonitoringSystem.Repositories;
using RFIDBasedAttendanceMonitoringSystem.Shared;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RFIDBasedAttendanceMonitoringSystem.Controllers
{
    public class AttendanceController
    {
        private readonly IRepository _repository;

        public AttendanceController(IRepository repository)
        {
            this._repository = repository;
        }

        public PagedResult<Attendance> GetAll(int pageNumber, int pageSize, DateTime date, string searchTerm = null)
        {
            int offset = (pageNumber - 1) * pageSize;
            bool hasSearch = !string.IsNullOrWhiteSpace(searchTerm);

            string pagedQuery = SqlQueries.SELECT_ATTENDANCE_PAGED;
            string countQuery = SqlQueries.SELECT_ATTENDANCE_COUNT;

            object pageParams = new { Offset = offset, PageSize = pageSize, Date = date.Date };
            object countParams = new { Date = date.Date };

            if (hasSearch)
            {
                string likeTerm = "%" + searchTerm.Trim() + "%";

                pagedQuery = SqlQueries.SELECT_ATTENDANCE_PAGED_SEARCH;
                countQuery = SqlQueries.SELECT_ATTENDANCE_COUNT_SEARCH;

                pageParams = new { Offset = offset, PageSize = pageSize, Date = date.Date, Search = likeTerm };
                countParams = new { Date = date.Date, Search = likeTerm };
            }

            List<Attendance> items = _repository.Pull<Attendance>(pagedQuery, pageParams).ToList();
            int totalCount = _repository.PullSingle<int>(countQuery, countParams);

            return new PagedResult<Attendance>
            {
                Items       = items,
                TotalCount  = totalCount,
                PageNumber  = pageNumber,
                PageSize    = pageSize
            };
        }

        public void SeedForToday()
        {
            var today = DateTime.Now.Date;

            bool isHoliday = _repository.PullSingle<int>(SqlQueries.SELECT_IS_HOLIDAY, new { Today = today }) > 0;

            if (isHoliday)
            {
                _repository.Push(SqlQueries.SEED_HOLIDAY_ATTENDANCE, new { Today = today });
            }
            else
            {
                _repository.Push(SqlQueries.SEED_ABSENT_ATTENDANCE, new { Today = today });
            }
        }

        public void RecordScan(string employeeTag)
        {
            var today = DateTime.Now.Date;
            var now = DateTime.Now;

            Attendance existing = _repository.PullSingle<Attendance>(
                SqlQueries.SELECT_ATTENDANCE_BY_TAG_AND_DATE,
                new { EmployeeTag = employeeTag, Today = today });

            if (existing == null)
            {
                throw new InvalidOperationException("No attendance record found for this employee today. Make sure the day has been initialized.");
            }

            if (existing.TimeIn == null)
            {
                AttendanceStatus status = DetermineStatus(now);

                _repository.Push(SqlQueries.UPDATE_ATTENDANCE_TIMEIN, new
                {
                    Id = existing.Id,
                    TimeIn = now,
                    Status = (int)status
                });
            }
            else if (existing.TimeOut == null)
            {
                _repository.Push(SqlQueries.UPDATE_ATTENDANCE_TIMEOUT, new
                {
                    Id = existing.Id,
                    TimeOut = now
                });
            }
            else
            {
                throw new InvalidOperationException("This employee has already timed in and out today.");
            }
        }

        private AttendanceStatus DetermineStatus(DateTime scanTime)
        {
            ShiftSchedule schedule = _repository.PullSingle<ShiftSchedule>(SqlQueries.SELECT_SHIFT_SCHEDULE);

            if (schedule == null)
            {
                return AttendanceStatus.PRESENT;
            }

            TimeSpan expectedTimeIn = schedule.TimeInStart + TimeSpan.FromMinutes(schedule.GracePeriodMinutes);
            TimeSpan actualTimeIn = scanTime.TimeOfDay;

            return actualTimeIn <= expectedTimeIn
                ? AttendanceStatus.PRESENT
                : AttendanceStatus.LATE;
        }

        public Attendance GetByTagAndDate(string employeeTag, DateTime date)
        {
            return _repository.PullSingle<Attendance>(
                SqlQueries.SELECT_ATTENDANCE_BY_TAG_AND_DATE,
                new { EmployeeTag = employeeTag, Today = date.Date });
        }
    }
}