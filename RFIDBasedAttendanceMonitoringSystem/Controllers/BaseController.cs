using RFIDBasedAttendanceMonitoringSystem.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFIDBasedAttendanceMonitoringSystem.Controllers
{
    public abstract class BaseController
    {
        protected readonly IRepository _repository;

        protected BaseController(IRepository repository)
        {
            this._repository = repository;
        }

        protected bool Exists(string existsQuery, string existsExcludingIdQuery,
            string name, int? excludeId = null)
        {
            string normalizedName = name.Trim().ToUpper();

            if (excludeId.HasValue)
            {
                int count = _repository.PullSingle<int>(
                            existsExcludingIdQuery,
                            new { Name = normalizedName, Id = excludeId.Value });
                return count > 0;
            }

            int countAll = _repository.PullSingle<int>(
                            existsQuery,
                            new { Name = normalizedName });
            return countAll > 0;
        }
    }
}
