using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFIDBasedAttendanceMonitoringSystem.Models
{
    public class ShiftSchedule
    {
        public int Id { get; set; }
        public TimeSpan TimeInStart { get; set; }
        public TimeSpan TimeOutEnd { get; set; }
        public int GracePeriodMinutes { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
