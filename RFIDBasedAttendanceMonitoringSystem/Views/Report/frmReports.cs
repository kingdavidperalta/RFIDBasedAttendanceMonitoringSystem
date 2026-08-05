using RFIDBasedAttendanceMonitoringSystem.Controllers;
using RFIDBasedAttendanceMonitoringSystem.Models;
using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RFIDBasedAttendanceMonitoringSystem.Views.Reports
{
    public partial class frmReports : Form
    {
        private readonly AppController _controller;

       
        public frmReports(AppController controller)
        {
            InitializeComponent();
            _controller = controller;
        }

        private void frmReports_Load(object sender, EventArgs e)
        {
            cboReportType.Items.Clear();
            cboReportType.Items.Add("Daily Attendance");
            cboReportType.Items.Add("Monthly Summary per Employee");
            cboReportType.Items.Add("Department-wise Summary");
            cboReportType.Items.Add("Late / Absentee Report");
            cboReportType.Items.Add("15-Day Cutoff Summary (Semi-Monthly)");
            cboReportType.SelectedIndex = 0;

            dtpDate.Value = DateTime.Now;
            dtpStart.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpEnd.Value = DateTime.Now;
            dtpCutoffRef.Value = DateTime.Now;
        }

        private void cboReportType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReportKind kind = (ReportKind)cboReportType.SelectedIndex;

            bool showSingleDate = kind == ReportKind.DailyAttendance;
            bool showRange = kind == ReportKind.MonthlySummary || kind == ReportKind.DepartmentSummary || kind == ReportKind.LateAbsentee;
            bool showCutoff = kind == ReportKind.CutoffSummary;

            lblDate.Visible = showSingleDate;
            dtpDate.Visible = showSingleDate;

            lblStart.Visible = showRange;
            dtpStart.Visible = showRange;
            lblEnd.Visible = showRange;
            dtpEnd.Visible = showRange;

            lblCutoffRef.Visible = showCutoff;
            dtpCutoffRef.Visible = showCutoff;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            ReportKind kind = (ReportKind)cboReportType.SelectedIndex;

            try
            {
                switch (kind)
                {
                    case ReportKind.DailyAttendance:
                        {
                            var data = _controller.Report.GetDailyAttendance(dtpDate.Value.Date);
                            BindReport(data);
                            lblStatus.Text = $"Daily Attendance for {dtpDate.Value:MMM dd, yyyy} — {data.Count} record(s).";
                            break;
                        }
                    case ReportKind.MonthlySummary:
                        {
                            ValidateRange();
                            var data = _controller.Report.GetMonthlySummary(dtpStart.Value.Date, dtpEnd.Value.Date);
                            BindReport(data);
                            lblStatus.Text = $"Monthly Summary: {dtpStart.Value:MMM dd, yyyy} to {dtpEnd.Value:MMM dd, yyyy} — {data.Count} employee(s).";
                            break;
                        }
                    case ReportKind.DepartmentSummary:
                        {
                            ValidateRange();
                            var data = _controller.Report.GetDepartmentSummary(dtpStart.Value.Date, dtpEnd.Value.Date);
                            BindReport(data);
                            lblStatus.Text = $"Department Summary: {dtpStart.Value:MMM dd, yyyy} to {dtpEnd.Value:MMM dd, yyyy} — {data.Count} department(s).";
                            break;
                        }
                    case ReportKind.LateAbsentee:
                        {
                            ValidateRange();
                            var data = _controller.Report.GetLateAbsentee(dtpStart.Value.Date, dtpEnd.Value.Date);
                            BindReport(data);
                            lblStatus.Text = $"Late/Absentee: {dtpStart.Value:MMM dd, yyyy} to {dtpEnd.Value:MMM dd, yyyy} — {data.Count} record(s).";
                            break;
                        }
                    case ReportKind.CutoffSummary:
                        {
                            var data = _controller.Report.GetCutoffSummary(dtpCutoffRef.Value.Date, out DateTime rangeStart, out DateTime rangeEnd);
                            BindReport(data);
                            lblStatus.Text = $"Cutoff Summary: {rangeStart:MMM dd, yyyy} to {rangeEnd:MMM dd, yyyy} — {data.Count} employee(s).";
                            break;
                        }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Could not generate report: {ex.Message}", "Report Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ValidateRange()
        {
            if (dtpEnd.Value.Date < dtpStart.Value.Date)
            {
                throw new InvalidOperationException("The 'To' date cannot be earlier than the 'From' date.");
            }
        }

        private void BindReport<T>(System.Collections.Generic.List<T> data)
        {
            dgvReport.DataSource = null;
            dgvReport.Columns.Clear();
            dgvReport.DataSource = data;

          
            TrySetHeader("EmployeeTag", "EMPLOYEE TAG");
            TrySetHeader("FullName", "FULL NAME");
            TrySetHeader("DepartmentName", "DEPARTMENT");
            TrySetHeader("PositionName", "POSITION");
            TrySetHeader("AttendanceDate", "DATE");
            TrySetHeader("TimeIn", "TIME IN");
            TrySetHeader("TimeOut", "TIME OUT");
            TrySetHeader("PresentCount", "PRESENT");
            TrySetHeader("LateCount", "LATE");
            TrySetHeader("AbsentCount", "ABSENT");
            TrySetHeader("HolidayCount", "HOLIDAY");
            TrySetHeader("TotalDays", "TOTAL DAYS");
            TrySetHeader("TotalRecords", "TOTAL RECORDS");

          
            TryHideColumn("Id");
            TryHideColumn("EmployeeId");
            TryHideColumn("CreatedAt");
        }

        private void TrySetHeader(string columnName, string headerText)
        {
            if (dgvReport.Columns.Contains(columnName))
            {
                dgvReport.Columns[columnName].HeaderText = headerText;
            }
        }

        private void TryHideColumn(string columnName)
        {
            if (dgvReport.Columns.Contains(columnName))
            {
                dgvReport.Columns[columnName].Visible = false;
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (dgvReport.Columns.Count == 0 || dgvReport.Rows.Count == 0)
            {
                MessageBox.Show("Generate a report first before exporting.", "Nothing to Export",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.Filter = "CSV file (*.csv)|*.csv";
                dialog.FileName = $"{SanitizeFileName(cboReportType.Text)}_{DateTime.Now:yyyyMMdd_HHmmss}.csv";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    ExportToCsv(dialog.FileName);
                    MessageBox.Show("Report exported successfully.", "Export Complete",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private static string SanitizeFileName(string name)
        {
            string result = name.Replace(" ", "_").Replace("/", "-").Replace("\\", "-");
            foreach (char c in Path.GetInvalidFileNameChars())
            {
                result = result.Replace(c.ToString(), string.Empty);
            }
            return result;
        }

        private void ExportToCsv(string filePath)
        {
            var visibleColumns = dgvReport.Columns
                .Cast<DataGridViewColumn>()
                .Where(c => c.Visible)
                .OrderBy(c => c.DisplayIndex)
                .ToList();

            var sb = new StringBuilder();

            sb.AppendLine(string.Join(",", visibleColumns.Select(c => EscapeCsv(c.HeaderText))));

            foreach (DataGridViewRow row in dgvReport.Rows)
            {
                if (row.IsNewRow) continue;

                var values = visibleColumns.Select(c =>
                    EscapeCsv(row.Cells[c.Index].Value?.ToString() ?? string.Empty));

                sb.AppendLine(string.Join(",", values));
            }

            File.WriteAllText(filePath, sb.ToString(), Encoding.UTF8);
        }

        private static string EscapeCsv(string value)
        {
            if (value.Contains(",") || value.Contains("\"") || value.Contains("\n"))
            {
                return "\"" + value.Replace("\"", "\"\"") + "\"";
            }
            return value;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}