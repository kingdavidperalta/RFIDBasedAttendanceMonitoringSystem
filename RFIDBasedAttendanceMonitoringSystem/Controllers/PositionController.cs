using RFIDBasedAttendanceMonitoringSystem.Models;
using RFIDBasedAttendanceMonitoringSystem.Repositories;
using RFIDBasedAttendanceMonitoringSystem.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFIDBasedAttendanceMonitoringSystem.Controllers
{
    public class PositionController
    {
        private readonly IRepository _repository;

        public PositionController(IRepository repository)
        {
            this._repository= repository;
        }

        public PagedResult<Position> GetAll(int pageNumber, int pageSize, string searchTerm = null)
        {
            int offset = (pageNumber - 1) * pageSize;
            bool hasSearch = !string.IsNullOrWhiteSpace(searchTerm);

            string pagedQuery = SqlQueries.SELECT_POSITION_PAGED;
            string countQuery = SqlQueries.SELECT_POSITION_COUNT;

            object pageParams = new { 
                Offset = offset, 
                PageSize = pageSize };

            object countParams = null;

            if (hasSearch)
            {
                string likeTerm = "%" + searchTerm.Trim() + "%";

                pagedQuery = SqlQueries.SELECT_POSITION_PAGED_SEARCH;
                countQuery = SqlQueries.SELECT_POSITION_COUNT_SEARCH;

                pageParams = new { Offset = offset, PageSize = pageSize, Search = likeTerm };
                countParams = new { Search = likeTerm };
            }


            List<Position> items = _repository.Pull<Position>(pagedQuery, pageParams).ToList();
            int totalCount = _repository.PullSingle<int>(countQuery, countParams);

            return new PagedResult<Position>
            {
                Items = items,
                TotalCount = totalCount,
                PageNumber = pageNumber,
                PageSize = pageSize
            };
        }

        public int Add(Position position)
        {
            var parameters = new
            {
                position.PositionName,
                position.CreatedAt
            };


            return _repository.PushAndGetId(SqlQueries.INSERT_POSITION, parameters);
        }

        public void Update(Position position)
        {
            var parameters = new
            {
                position.Id,
                position.PositionName,
                position.CreatedAt
            };

            _repository.Push(SqlQueries.UPDATE_POSITION, parameters);
        }

        public void Delete(int id)
        {
            _repository.Push(SqlQueries.DELETE_POSITION, new { Id = id });
        }
    }
}
