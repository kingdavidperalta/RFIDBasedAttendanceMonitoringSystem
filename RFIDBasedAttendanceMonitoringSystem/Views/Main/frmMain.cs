using RFIDBasedAttendanceMonitoringSystem.Controllers;
using RFIDBasedAttendanceMonitoringSystem.Views.Auth;
using RFIDBasedAttendanceMonitoringSystem.Views.Dashboard;
using RFIDBasedAttendanceMonitoringSystem.Views.Holiday;
using RFIDBasedAttendanceMonitoringSystem.Views.Reports;
using RFIDBasedAttendanceMonitoringSystem.Views.ShiftSchedule;
using RFIDBasedAttendanceMonitoringSystem.VIews.Attendance;
using RFIDBasedAttendanceMonitoringSystem.VIews.Employee;
using RFIDBasedAttendanceMonitoringSystem.VIews.Position;
using System;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace RFIDBasedAttendanceMonitoringSystem.VIews.Main
{
    public partial class frmMain : Form
    {

        private readonly AppController _controller;
        private readonly frmLogin _frmLogin;
        public frmMain(AppController controller, frmLogin frmLogin)
        {
            InitializeComponent();
            this._controller = controller;
            this._frmLogin = frmLogin;
        }
        public void switchPanel(Form frm)
        {
            frm.TopLevel = false;
            MainPanel.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void frmMain_Resize(object sender, EventArgs e)
        {
            int x = Screen.PrimaryScreen.Bounds.Width;
            int y = Screen.PrimaryScreen.Bounds.Height;

            this.Height = y - 40;
            this.Width = x;
            this.Left = 0;
            this.Top = 0;
        }

       

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
               "Are you sure you want to log out?",
               "Confirm Logout",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Hide();
                _frmLogin.Show();
            }
        }
        private void btnEmployees_Click(object sender, EventArgs e)
        {
            frmEmployee frm = new frmEmployee(_controller);
            switchPanel(frm);
        }

        private void btnMaintenance_Click(object sender, EventArgs e)
        {
            panelMaintenanceSub.Visible = !panelMaintenanceSub.Visible;
            btnMaintenance.Text = panelMaintenanceSub.Visible
                ? "MAINTENANCE  ▾"
                : "MAINTENANCE  ▸";
        }

        private void btnAttendances_Click(object sender, EventArgs e)
        {

            frmAttendance frm = new frmAttendance(_controller);
            switchPanel(frm);
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            frmReports frm =   new frmReports(_controller);
            switchPanel(frm);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            frmDashboard frm = new frmDashboard(_controller);
            switchPanel(frm);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            _controller.Attendance.SeedForToday();
            frmDashboard frm = new frmDashboard(_controller);
            switchPanel(frm);
        }

        private void btnDepartment_Click(object sender, EventArgs e)
        {
            frmDepartment frm = new frmDepartment(_controller);
            switchPanel(frm);
        }
        private void btnPosition_Click(object sender, EventArgs e)
        {
            frmPosition frm = new frmPosition(_controller);
            switchPanel(frm);
        }

        private void btnShiftSchedule_Click(object sender, EventArgs e)
        {
            frmShiftSchedule frm = new frmShiftSchedule(_controller);
            switchPanel(frm);
        }

        private void btnHoliday_Click(object sender, EventArgs e)
        {
            frmHoliday frm = new frmHoliday(_controller);
            switchPanel(frm);
        }
    }
}
