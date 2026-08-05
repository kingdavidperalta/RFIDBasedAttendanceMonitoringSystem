using RFIDBasedAttendanceMonitoringSystem.Models;
using RFIDBasedAttendanceMonitoringSystem.Repositories;
using RFIDBasedAttendanceMonitoringSystem.Shared;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RFIDBasedAttendanceMonitoringSystem.Controllers
{
    public class ShiftScheduleController
    {
        private readonly IRepository _repository;

        public ShiftScheduleController(IRepository repository)
        {
            this._repository = repository;
        }

        public PagedResult<ShiftSchedule> GetAll(int pageNumber, int pageSize)
        {
            int offset = (pageNumber - 1) * pageSize;

            object pageParams = new { Offset = offset, PageSize = pageSize };

            List<ShiftSchedule> items = _repository.Pull<ShiftSchedule>(SqlQueries.SELECT_SHIFTSCHEDULE_PAGED, pageParams).ToList();
            int totalCount = _repository.PullSingle<int>(SqlQueries.SELECT_SHIFTSCHEDULE_COUNT);

            return new PagedResult<ShiftSchedule>
            {
                Items = items,
                TotalCount = totalCount,
                PageNumber = pageNumber,
                PageSize = pageSize
            };
        }

        public ShiftSchedule GetById(int id)
        {
            return _repository.PullSingle<ShiftSchedule>(SqlQueries.SELECT_SHIFTSCHEDULE_BY_ID, new { Id = id });
        }

        public ShiftSchedule GetCurrent()
        {
            return _repository.PullSingle<ShiftSchedule>(SqlQueries.SELECT_SHIFT_SCHEDULE);
        }

        public int Add(ShiftSchedule shiftSchedule)
        {
            var parameters = new
            {
                shiftSchedule.TimeInStart,
                shiftSchedule.TimeOutEnd,
                shiftSchedule.GracePeriodMinutes,
                shiftSchedule.CreatedAt
            };

            return _repository.PushAndGetId(SqlQueries.INSERT_SHIFTSCHEDULE, parameters);
        }

        public void Update(ShiftSchedule shiftSchedule)
        {
            var parameters = new
            {
                shiftSchedule.Id,
                shiftSchedule.TimeInStart,
                shiftSchedule.TimeOutEnd,
                shiftSchedule.GracePeriodMinutes
            };

            _repository.Push(SqlQueries.UPDATE_SHIFTSCHEDULE, parameters);
        }

        public void Delete(int id)
        {
            _repository.Push(SqlQueries.DELETE_SHIFTSCHEDULE, new { Id = id });
        }
    }
}