using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFIDBasedAttendanceMonitoringSystem.Models
{
    public class Position
    {
        public int Id { get; set; }
        public string PositionName { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
