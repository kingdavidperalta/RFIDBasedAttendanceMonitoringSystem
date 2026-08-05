using RFIDBasedAttendanceMonitoringSystem.Models;
using RFIDBasedAttendanceMonitoringSystem.Repositories;
using RFIDBasedAttendanceMonitoringSystem.Shared;
using System.Collections.Generic;
using System.Linq;

namespace RFIDBasedAttendanceMonitoringSystem.Controllers
{
    public class DepartmentController
    {
        private readonly IRepository _repository;

        public DepartmentController(IRepository repository)
        {
            _repository = repository;
        }

        public PagedResult<Department> GetAll(int pageNumber, int pageSize, string searchTerm = null)
        {
            int offset = (pageNumber - 1) * pageSize;
            bool hasSearch = !string.IsNullOrWhiteSpace(searchTerm);

            string pagedQuery = SqlQueries.SELECT_DEPARTMENT_PAGED;
            string countQuery = SqlQueries.SELECT_DEPARTMENT_COUNT;

            object pageParams = new { Offset = offset, PageSize = pageSize };
            object countParams = null;

            if (hasSearch)
            {
                string likeTerm = "%" + searchTerm.Trim() + "%";

                pagedQuery = SqlQueries.SELECT_DEPARTMENT_PAGED_SEARCH;
                countQuery = SqlQueries.SELECT_DEPARTMENT_COUNT_SEARCH;

                pageParams = new { Offset = offset, PageSize = pageSize, Search = likeTerm };
                countParams = new { Search = likeTerm };
            }

           
            List<Department> items = _repository.Pull<Department>(pagedQuery, pageParams).ToList();
            int totalCount = _repository.PullSingle<int>(countQuery, countParams);

            return new PagedResult<Department>
            {
                Items = items,
                TotalCount = totalCount,
                PageNumber = pageNumber,
                PageSize = pageSize
            };
        }

        public int Add(Department department)
        {
            var parameters = new
            {
                department.DepartmentName,
                department.CreatedAt
            };
     
            return _repository.PushAndGetId(SqlQueries.INSERT_DEPARTMENT, parameters);
        }

        public void Update(Department department)
        {
            var parameters = new
            {
                department.Id,
                department.DepartmentName,
                department.CreatedAt
            };

            _repository.Push(SqlQueries.UPDATE_DEPARTMENT, parameters);
        }

        public void Delete(int id)
        {
            _repository.Push(SqlQueries.DELETE_DEPARTMENT, new { Id = id });
        }
    }
}