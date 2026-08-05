using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFIDBasedAttendanceMonitoringSystem.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string EmployeeTag  { get; set; }
        public string FullName { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string Suffix { get; set; }
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public int PositionId { get; set; }
        public string PositionName { get; set; }
        public EmployeeStatus Status { get; set; } = EmployeeStatus.ACTIVE;
        public string PhotoPath { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
    }

    public enum EmployeeStatus
    {
        ACTIVE,
        ONLEAVE,
        RESIGNED,
        TERMINATED
    }
}
