using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dapper;

namespace RFIDBasedAttendanceMonitoringSystem.Repositories
{
    public class Repository : IRepository
    {
        private readonly ISqlConnection _connection;

        public Repository(ISqlConnection connection)
        {
            _connection = connection;
        }

        public IEnumerable<T> Pull<T>(string sqlQuery, object parameters = null)
        {
            using (SqlConnection conn = _connection.CreateConnection())
            {
               
                return conn.Query<T>(sqlQuery, parameters);
            }
        }

        public T PullSingle<T>(string sqlQuery, object parameters = null)
        {
            using (SqlConnection conn = _connection.CreateConnection())
            {
                return conn.QuerySingleOrDefault<T>(sqlQuery, parameters);
            }
        }

        public int Push(string sqlQuery, object parameters = null)
        {
            using (SqlConnection conn = _connection.CreateConnection())
            {
                return conn.Execute(sqlQuery, parameters);
            }
        }

        public int PushAndGetId(string sqlQuery, object parameters = null)
        {
            using (SqlConnection conn = _connection.CreateConnection())
            {
               
                return conn.QuerySingle<int>(sqlQuery, parameters);
            }
        }
    }
}
