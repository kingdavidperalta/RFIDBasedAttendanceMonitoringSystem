using RFIDBasedAttendanceMonitoringSystem.Controllers;
using RFIDBasedAttendanceMonitoringSystem.Data;
using RFIDBasedAttendanceMonitoringSystem.Repositories;
using RFIDBasedAttendanceMonitoringSystem.Views.Auth;
using System;

using System.Windows.Forms;

namespace RFIDBasedAttendanceMonitoringSystem
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            ISqlConnection sqlConnection = new SqlConn();
            IRepository repository = new Repository(sqlConnection);


            AppController controller = new AppController(repository);
            Application.Run(new frmLogin(controller));
        }
    }
}
