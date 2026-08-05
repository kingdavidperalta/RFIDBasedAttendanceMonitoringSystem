using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFIDBasedAttendanceMonitoringSystem.Models
{
    public class Attendance
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public string EmployeeTag { get; set; }
        public string FullName { get; set; }
        public string DepartmentName { get; set; }
        public string PositionName { get; set; }
        public DateTime AttendanceDate { get; set; }
        public DateTime? TimeIn { get; set; }
        public DateTime? TimeOut { get; set; }
        public AttendanceStatus Status { get; set; }
        public string PhotoPath { get; set; }
        public DateTime CreatedAt { get; set; }
    }

    public enum AttendanceStatus
    {
        PRESENT,
        LATE,
        ABSENT,
        HOLIDAY
    }


}
