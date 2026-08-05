using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFIDBasedAttendanceMonitoringSystem.Models
{
    public class Dashboard
    {
        public int Present { get; set; }
        public int Late { get; set; }
        public int Absent { get; set; }
        public int Holiday { get; set; }
    }

    public class WeeklyTrendPoint
    {
        public DateTime AttendanceDate { get; set; }
        public int Present { get; set; }
        public int Late { get; set; }
        public int Absent { get; set; }
    }
}
