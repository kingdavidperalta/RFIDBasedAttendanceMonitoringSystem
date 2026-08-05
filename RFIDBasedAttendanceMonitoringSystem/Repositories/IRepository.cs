using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFIDBasedAttendanceMonitoringSystem.Repositories
{
    public interface IRepository
    {
        IEnumerable<T> Pull<T>(string sqlQuery, object parameters = null);
        T PullSingle<T>(string sqlQuery, object parameters = null);
        int Push(string sqlQuery, object parameters = null);
        int PushAndGetId(string sqlQuery, object parameters = null);
    }
}
