using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using RFIDBasedAttendanceMonitoringSystem.Repositories;
using System.Data.SqlClient;

namespace RFIDBasedAttendanceMonitoringSystem.Data
{
    public class SqlConn: ISqlConnection
    {
        private readonly string _connectionString;

        public SqlConn()
        {
            _connectionString = ConfigurationManager
                .ConnectionStrings["db_attendance"].ConnectionString;
        }

        public SqlConnection CreateConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}
