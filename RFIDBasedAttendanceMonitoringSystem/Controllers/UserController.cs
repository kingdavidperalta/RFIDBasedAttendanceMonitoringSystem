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
    public class UserController 
    {
        private readonly IRepository _repository;
        public UserController(IRepository repository)
        {
            this._repository = repository;
        }

        public User Authenticate(string username, string password)
        {
            User user = _repository.PullSingle<User>(
                SqlQueries.SELECT_USER_BY_USERNAME,
                new { Username = username.Trim() });

            if (user == null)
                return null;

            bool valid = PasswordHelper.Verify(password, user.PasswordHash);
            return valid ? user : null;
        }

        public bool UsernameExists(string username)
        {
            int count = _repository.PullSingle<int>(
                SqlQueries.CHECK_USER_EXISTS,
                new { Username = username.Trim() });
            return count > 0;
        }

        public int Register(User user)
        {
            var parameters = new
            {
                 user.Username
                ,user.PasswordHash
                ,user.FullName
                ,user.Role
                ,user.CreatedAt
            };

            return _repository.PushAndGetId(SqlQueries.INSERT_USER, parameters);
        }
    }
}
