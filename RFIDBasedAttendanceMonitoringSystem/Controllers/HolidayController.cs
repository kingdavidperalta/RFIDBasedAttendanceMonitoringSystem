using RFIDBasedAttendanceMonitoringSystem.Models;
using RFIDBasedAttendanceMonitoringSystem.Repositories;
using RFIDBasedAttendanceMonitoringSystem.Shared;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RFIDBasedAttendanceMonitoringSystem.Controllers
{
    public class HolidayController
    {
        private readonly IRepository _repository;

        public HolidayController(IRepository repository)
        {
            this._repository = repository;
        }

        public PagedResult<Holiday> GetAll(int pageNumber, int pageSize, string searchTerm = null)
        {
            int offset = (pageNumber - 1) * pageSize;
            bool hasSearch = !string.IsNullOrWhiteSpace(searchTerm);

            string pagedQuery = SqlQueries.SELECT_HOLIDAY_PAGED;
            string countQuery = SqlQueries.SELECT_HOLIDAY_COUNT;

            object pageParams = new { Offset = offset, PageSize = pageSize };
            object countParams = null;

            if (hasSearch)
            {
                string likeTerm = "%" + searchTerm.Trim() + "%";

                pagedQuery = SqlQueries.SELECT_HOLIDAY_PAGED_SEARCH;
                countQuery = SqlQueries.SELECT_HOLIDAY_COUNT_SEARCH;

                pageParams = new { Offset = offset, PageSize = pageSize, Search = likeTerm };
                countParams = new { Search = likeTerm };
            }

            List<Holiday> items = _repository.Pull<Holiday>(pagedQuery, pageParams).ToList();
            int totalCount = _repository.PullSingle<int>(countQuery, countParams);

            return new PagedResult<Holiday>
            {
                Items = items,
                TotalCount = totalCount,
                PageNumber = pageNumber,
                PageSize = pageSize
            };
        }

        public int Add(Holiday holiday)
        {
            var parameters = new
            {
                holiday.HolidayDate,
                holiday.Description,
                holiday.CreatedAt
            };

            return _repository.PushAndGetId(SqlQueries.INSERT_HOLIDAY, parameters);
        }

        public void Update(Holiday holiday)
        {
            var parameters = new
            {
                holiday.Id,
                holiday.HolidayDate,
                holiday.Description
            };

            _repository.Push(SqlQueries.UPDATE_HOLIDAY, parameters);
        }

        public void Delete(int id)
        {
            _repository.Push(SqlQueries.DELETE_HOLIDAY, new { Id = id });
        }
    }
}