using RFIDBasedAttendanceMonitoringSystem.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFIDBasedAttendanceMonitoringSystem.Controllers
{
    public class AppController
    {
        public DepartmentController Department { get;  }
        public PositionController Position { get; }
        public EmployeeController Employee { get;  }
        public  AttendanceController Attendance { get;  }
        public ReportController Report { get; }
        public DashboardController Dashboard { get; }
        public ShiftScheduleController ShiftSchedule { get; }
        public HolidayController Holiday { get; }
        public UserController User { get; }

        public AppController(IRepository repository)
        {
            this.Department     =   new DepartmentController(repository);
            this.Position       =   new PositionController(repository);
            this.Employee       =   new EmployeeController(repository);
            this.Attendance     =   new AttendanceController(repository);
            this.Report         =   new ReportController(repository);
            this.Dashboard      =   new DashboardController(repository);
            this.ShiftSchedule  =   new ShiftScheduleController(repository);
            this.Holiday        =   new HolidayController(repository);
            this.User           =   new UserController(repository);
        }

    }
}
