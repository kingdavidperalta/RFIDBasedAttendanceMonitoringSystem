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
    public class EmployeeController:BaseController
    {
        public EmployeeController(IRepository repository) :base(repository)
        {
        }

        public PagedResult<Employee> GetAll(int pageNumber, int pageSize, string searchTerm = null)
        {
            int offset = (pageNumber - 1) * pageSize;
            bool hasSearch = !string.IsNullOrWhiteSpace(searchTerm);

            string pagedQuery = SqlQueries.SELECT_EMPLOYEE_PAGED;
            string countQuery = SqlQueries.SELECT_EMPLOYEE_COUNT;

            object pageParams = new { Offset = offset, PageSize = pageSize };
            object countParams = null;

            if (hasSearch)
            {
                string likeTerm = "%" + searchTerm.Trim() + "%";

                pagedQuery = SqlQueries.SELECT_EMPLOYEE_PAGED_SEARCH;
                countQuery = SqlQueries.SELECT_EMPLOYEE_COUNT_SEARCH;

                pageParams = new { Offset = offset, PageSize = pageSize, Search = likeTerm };
                countParams = new { Search = likeTerm };
            }


            List<Employee> items = _repository.Pull<Employee>(pagedQuery, pageParams).ToList();
           
            int totalCount = _repository.PullSingle<int>(countQuery, countParams);

            return new PagedResult<Employee>
            {
                Items = items,
                TotalCount = totalCount,
                PageNumber = pageNumber,
                PageSize = pageSize
            };
        }
        public List<Department> GetDepartments()
        {
            return _repository.Pull<Department>(SqlQueries.SELECT_ALL_DEPARTMENTS).ToList();
        }

        public List<Position> GetPositions()
        {
            return _repository.Pull<Position>(SqlQueries.SELECT_ALL_POSITIONS).ToList();
        }
        public PagedResult<Employee> GetArchived(int pageNumber, int pageSize, string searchTerm = null)
        {
            int offset = (pageNumber - 1) * pageSize;
            bool hasSearch = !string.IsNullOrWhiteSpace(searchTerm);

            string pagedQuery = SqlQueries.SELECT_ARCHIVED_EMPLOYEE_PAGED;
            string countQuery = SqlQueries.SELECT_ARCHIVED_EMPLOYEE_COUNT;

            object pageParams = new { Offset = offset, PageSize = pageSize };
            object countParams = null;

            if (hasSearch)
            {
                string likeTerm = "%" + searchTerm.Trim() + "%";

                pagedQuery = SqlQueries.SELECT_ARCHIVED_EMPLOYEE_PAGED_SEARCH;
                countQuery = SqlQueries.SELECT_ARCHIVED_EMPLOYEE_COUNT_SEARCH;

                pageParams = new { Offset = offset, PageSize = pageSize, Search = likeTerm };
                countParams = new { Search = likeTerm };
            }


            List<Employee> items = _repository.Pull<Employee>(pagedQuery, pageParams).ToList();
            int totalCount = _repository.PullSingle<int>(countQuery, countParams);

            return new PagedResult<Employee>
            {
                Items = items,
                TotalCount = totalCount,
                PageNumber = pageNumber,
                PageSize = pageSize
            };
        }

        public int Add(Employee employee)
        {
            var parameters = new
            {
                employee.EmployeeTag,
                employee.LastName,
                employee.FirstName,
                employee.MiddleName,
                employee.Suffix,
                employee.DepartmentId,
                employee.PositionId,
                employee.Status,
                employee.PhotoPath,
                employee.CreatedAt
            };

            return _repository.PushAndGetId(SqlQueries.INSERT_EMPLOYEE, parameters);
        }

        public bool Exists(string empTag, int? excludeId = null)
        {
            return Exists(
                 SqlQueries.CHECK_EMPLOYEE_EXISTS
                ,SqlQueries.CHECK_EMPLOYEE_EXISTS_EXCLUDING_ID
                ,empTag
                ,excludeId);
        }


        public void Update(Employee employee)
        {
            var parameters = new
            {
                employee.Id,
                employee.EmployeeTag,
                employee.LastName,
                employee.FirstName,
                employee.MiddleName,
                employee.Suffix,
                employee.DepartmentId,
                employee.PositionId,
                employee.Status,
                employee.PhotoPath
            };

            _repository.Push(SqlQueries.UPDATE_EMPLOYEE, parameters);
        }

        public void Delete(int id)
        {
            _repository.Push(SqlQueries.DELETE_EMPLOYEE, new { Id = id, DeletedAt = DateTime.UtcNow });
        }
    }
}
