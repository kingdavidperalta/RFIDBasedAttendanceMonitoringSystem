using RFIDBasedAttendanceMonitoringSystem.Controllers;
using RFIDBasedAttendanceMonitoringSystem.Models;
using RFIDBasedAttendanceMonitoringSystem.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RFIDBasedAttendanceMonitoringSystem.VIews.Attendance
{
    public partial class frmRecordScan : Form
    {
        private readonly AppController _controller;
        private readonly System.Windows.Forms.Timer _clockTimer;
        private readonly System.Windows.Forms.Timer _resetTimer;

        private static readonly Color PresentBg = Color.FromArgb(226, 246, 232);
        private static readonly Color PresentFg = Color.FromArgb(40, 150, 90);
        private static readonly Color LateBg = Color.FromArgb(255, 241, 224);
        private static readonly Color LateFg = Color.FromArgb(200, 130, 40);
        private static readonly Color ErrorBg = Color.FromArgb(252, 228, 226);
        private static readonly Color ErrorFg = Color.FromArgb(190, 60, 50);
        private static readonly Color IdleFg = Color.FromArgb(21, 101, 71);

        public frmRecordScan(AppController controller)
        {
            InitializeComponent();

            this._controller = controller;

            _clockTimer = new System.Windows.Forms.Timer { Interval = 1000 };
            _clockTimer.Tick += ClockTimer_Tick;

            _resetTimer = new System.Windows.Forms.Timer { Interval = 10000 };
            _resetTimer.Tick += ResetTimer_Tick;

            this.Load += frmRecordScan_Load;
            btnClose.Click += btnClose_Click;
        }

        private void frmRecordScan_Load(object sender, EventArgs e)
        {
            try
            {
                _controller.Attendance.SeedForToday();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to initialize today's attendance: " + ex.Message,
                    "Startup Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            UpdateClock();
            _clockTimer.Start();
            ShowIdleState();
            txtScanInput.Focus();
        }

        private void ClockTimer_Tick(object sender, EventArgs e)
        {
            UpdateClock();

            if (!txtScanInput.Focused)
            {
                txtScanInput.Focus();
            }
        }

        private void UpdateClock()
        {
            lblDateTime.Text = DateTime.Now.ToString("dddd, MMMM d, yyyy   hh:mm:ss tt");
        }

        private void ProcessScan(string tag)
        {
            var today = DateTime.Now.Date;

            Models.Attendance record;
            try
            {
                record = _controller.Attendance.GetByTagAndDate(tag, today);
            }
            catch (Exception ex)
            {
                ShowErrorState(null, "Scan failed: " + ex.Message);
                return;
            }

            if (record == null)
            {
                ShowErrorState(null, "Tag not recognized for today.");
                return;
            }

            try
            {
                _controller.Attendance.RecordScan(tag);
                record = _controller.Attendance.GetByTagAndDate(tag, today);

                string message = record.TimeOut != null ? "Time Out recorded" : "Time In recorded";

                ShowSuccessState(record, message);
            }
            catch (InvalidOperationException ex)
            {
                ShowErrorState(record, ex.Message);
            }
            catch (Exception ex)
            {
                ShowErrorState(record, "Unexpected error: " + ex.Message);
            }

            _resetTimer.Stop();
            _resetTimer.Start();
        }

        private void ShowSuccessState(Models.Attendance record, string message)
        {
            PopulateCard(record);

            bool late = record.Status == AttendanceStatus.LATE;
            pnlStatusBadge.BackColor = late ? LateBg : PresentBg;
            lblStatus.ForeColor = late ? LateFg : PresentFg;
            lblStatus.Text = late ? "Recorded (Late)" : "Recorded";

            lblScanInstruction.Text = message;
            lblScanInstruction.ForeColor = late ? LateFg : PresentFg;
            lblScanSubtext.Text = record.FullName + " — have a great day!";
        }

        private void ShowErrorState(Models.Attendance record, string message)
        {
            if (record != null)
            {
                PopulateCard(record);
            }

            pnlStatusBadge.BackColor = ErrorBg;
            lblStatus.ForeColor = ErrorFg;
            lblStatus.Text = "Scan Not Recorded";

            lblScanInstruction.Text = "Scan Error";
            lblScanInstruction.ForeColor = ErrorFg;
            lblScanSubtext.Text = message;
        }

        private void ShowIdleState()
        {
            lblUserName.Text = string.Empty;
            lblUserTag.Text = string.Empty;
            lblDepartment.Text = string.Empty;
            lblPosition.Text = string.Empty;
            lblTimeInValue.Text = "--:-- --";
            lblTimeOutValue.Text = "--:-- --";

            picUserPhoto.Image?.Dispose();
            picUserPhoto.Image = PhotoHelper.CreateInitialsAvatar(string.Empty, picUserPhoto.Width);

            pnlStatusBadge.BackColor = PresentBg;
            lblStatus.ForeColor = PresentFg;
            lblStatus.Text = "Ready to Scan";

            lblScanInstruction.Text = "Tap your ID Card";
            lblScanInstruction.ForeColor = IdleFg;
            lblScanSubtext.Text = "Hold your RFID card near the scanner to record your attendance.";
        }

        private void PopulateCard(Models.Attendance record)
        {
            lblUserName.Text = record.FullName;
            lblUserTag.Text = record.EmployeeTag;
            lblDepartment.Text = record.DepartmentName;
            lblPosition.Text = record.PositionName;
            lblTimeInValue.Text = record.TimeIn?.ToString("hh:mm tt") ?? "--:-- --";
            lblTimeOutValue.Text = record.TimeOut?.ToString("hh:mm tt") ?? "--:-- --";

            LoadUserPhoto(record.PhotoPath, record.FullName);
        }

        private void LoadUserPhoto(string photoPath, string fullName)
        {
            picUserPhoto.Image?.Dispose();
            picUserPhoto.Image = PhotoHelper.Load(photoPath)
                ?? PhotoHelper.CreateInitialsAvatar(fullName, picUserPhoto.Width);
        }

        private void ResetTimer_Tick(object sender, EventArgs e)
        {
            _resetTimer.Stop();
            ShowIdleState();
            txtScanInput.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            _clockTimer.Stop();
            _resetTimer.Stop();
            picUserPhoto.Image?.Dispose();
            this.Dispose();
        }

        private void txtScanInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;

            e.SuppressKeyPress = true;
            string tag = txtScanInput.Text.Trim();
            txtScanInput.Clear();

            if (!string.IsNullOrEmpty(tag))
            {
                ProcessScan(tag);
            }
        }
    }
}