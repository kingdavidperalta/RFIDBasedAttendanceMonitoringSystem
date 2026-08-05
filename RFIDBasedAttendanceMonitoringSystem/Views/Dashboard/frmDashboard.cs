using RFIDBasedAttendanceMonitoringSystem.Controllers;
using RFIDBasedAttendanceMonitoringSystem.Models;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace RFIDBasedAttendanceMonitoringSystem.Views.Dashboard
{
    public partial class frmDashboard : Form
    {
        private readonly AppController _controller;

        private static readonly Color ColorPresent = Color.FromArgb(0, 184, 148);
        private static readonly Color ColorLate = Color.FromArgb(237, 161, 0);
        private static readonly Color ColorAbsent = Color.FromArgb(227, 73, 72);
        private static readonly Color ColorMuted = Color.FromArgb(120, 120, 120);
        private static readonly Color ColorTrack = Color.FromArgb(240, 240, 236);
        private static readonly Color ColorBorder = Color.FromArgb(225, 224, 217);


        public frmDashboard(AppController controller)
        {
            InitializeComponent();
           _controller = controller;
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy");

            ApplyRoundedCorners(panelTrend, 12);
            ApplyRoundedCorners(panelDept, 12);
            ApplyRoundedCorners(panelRight, 12);

            LoadDashboard();
        }

        private void LoadDashboard()
        {
            DateTime today = DateTime.Now.Date;

            int headcount =_controller.Dashboard.GetHeadcount();
            Models.Dashboard summary =_controller.Dashboard.GetDashboard(today);
            var weeklyTrend =_controller.Dashboard.GetWeeklyTrend(today);
            var deptRates =_controller.Dashboard.GetDepartmentRates(today);
            var recentScans =_controller.Dashboard.GetRecentScans(today, 6);
            Models.Holiday nextHoliday =_controller.Dashboard.GetNextHoliday(today);

            BuildKpiCards(headcount, summary);
            BuildTrendChart(weeklyTrend);
            BuildDepartmentBars(deptRates);
            BuildRecentScans(recentScans);

            lblNextHoliday.Text = nextHoliday != null
                ? $"Next holiday: {nextHoliday.HolidayDate:MMM dd, yyyy} \u00b7 {nextHoliday.Description}"
                : "Next holiday: none scheduled";
        }


        private void BuildKpiCards(int headcount, Models.Dashboard summary)
        {
            flpKpis.Controls.Clear();

            double Pct(int part) => headcount == 0 ? 0 : Math.Round(part * 100.0 / headcount);

            AddKpiCard(0, "HEADCOUNT", headcount.ToString(), null,
                Color.White, Color.FromArgb(64, 64, 64));

            AddKpiCard(1, "PRESENT", summary.Present.ToString(),
                $"{Pct(summary.Present)}% of headcount",
                Color.FromArgb(232, 247, 240), ColorPresent);

            AddKpiCard(2, "LATE", summary.Late.ToString(),
                $"{Pct(summary.Late)}% of headcount",
                Color.FromArgb(255, 245, 224), ColorLate);

            AddKpiCard(3, "ABSENT", summary.Absent.ToString(),
                $"{Pct(summary.Absent)}% of headcount",
                Color.FromArgb(252, 232, 231), ColorAbsent);

            AddKpiCard(4, "HOLIDAY", summary.Holiday.ToString(), null,
                Color.White, Color.FromArgb(64, 64, 64));
        }

        private void AddKpiCard(int columnIndex, string title, string value, string subtitle,
            Color backColor, Color accentColor)
        {
            Panel card = CreateKpiCard(title, value, subtitle, backColor, accentColor);
            flpKpis.Controls.Add(card, columnIndex, 0);
        }

        private Panel CreateKpiCard(string title, string value, string subtitle,
            Color backColor, Color accentColor)
        {
            Panel card = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = backColor,
                Margin = new Padding(6, 0, 6, 0),
                Padding = new Padding(14, 12, 14, 10),
                MinimumSize = new Size(0, 90)
            };
            ApplyRoundedCorners(card, 10);

            Label lblTitleText = new Label
            {
                Text = title,
                AutoSize = true,
                Font = new Font("Calibri", 9F),
                ForeColor = ColorMuted,
                Location = new Point(14, 12)
            };

            Label lblValue = new Label
            {
                Text = value,
                AutoSize = true,
                Font = new Font("Calibri", 20F, FontStyle.Regular),
                ForeColor = accentColor,
                Location = new Point(14, 32)
            };

            card.Controls.Add(lblTitleText);
            card.Controls.Add(lblValue);

            if (!string.IsNullOrEmpty(subtitle))
            {
                Label lblSub = new Label
                {
                    Text = subtitle,
                    AutoSize = true,
                    Font = new Font("Calibri", 8.5F),
                    ForeColor = accentColor,
                    Location = new Point(14, 68)
                };
                card.Controls.Add(lblSub);
            }

            return card;
        }



        private void BuildTrendChart(System.Collections.Generic.List<WeeklyTrendPoint> points)
        {
            pnlLegend.Controls.Clear();
            pnlLegend.Controls.Add(CreateLegendItem("Present", ColorPresent));
            pnlLegend.Controls.Add(CreateLegendItem("Late", ColorLate));
            pnlLegend.Controls.Add(CreateLegendItem("Absent", ColorAbsent));

            chartTrend.Series.Clear();
            chartTrend.Legends.Clear();
            chartTrend.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Calibri", 8.5F);
            chartTrend.ChartAreas[0].AxisY.LabelStyle.Font = new Font("Calibri", 8.5F);
            chartTrend.ChartAreas[0].AxisX.MajorGrid.Enabled = false;

            Series present = NewSeries("Present", ColorPresent, ChartDashStyle.Solid);
            Series late = NewSeries("Late", ColorLate, ChartDashStyle.Dash);
            Series absent = NewSeries("Absent", ColorAbsent, ChartDashStyle.Dot);

            foreach (var point in points)
            {
                string label = point.AttendanceDate.ToString("ddd");
                present.Points.AddXY(label, point.Present);
                late.Points.AddXY(label, point.Late);
                absent.Points.AddXY(label, point.Absent);
            }

            chartTrend.Series.Add(present);
            chartTrend.Series.Add(late);
            chartTrend.Series.Add(absent);
        }

        private Series NewSeries(string name, Color color, ChartDashStyle dashStyle)
        {
            return new Series(name)
            {
                ChartType = SeriesChartType.Line,
                Color = color,
                BorderWidth = 2,
                BorderDashStyle = dashStyle,
                MarkerStyle = MarkerStyle.Circle,
                MarkerSize = 6,
                MarkerColor = color,
                MarkerBorderColor = Color.White,
                MarkerBorderWidth = 2,
                IsValueShownAsLabel = false
            };
        }

        private Control CreateLegendItem(string text, Color color)
        {
            FlowLayoutPanel item = new FlowLayoutPanel
            {
                AutoSize = true,
                Margin = new Padding(0, 0, 14, 0),
                FlowDirection = FlowDirection.LeftToRight
            };
            Panel swatch = new Panel
            {
                Size = new Size(10, 10),
                BackColor = color,
                Margin = new Padding(0, 5, 6, 0)
            };
            Label lbl = new Label
            {
                Text = text,
                AutoSize = true,
                ForeColor = ColorMuted,
                Font = new Font("Calibri", 8.5F)
            };
            item.Controls.Add(swatch);
            item.Controls.Add(lbl);
            return item;
        }

       

        private void BuildDepartmentBars(System.Collections.Generic.List<DepartmentAttendanceSummary> rates)
        {
            pnlDeptBars.Controls.Clear();
            pnlDeptBars.AutoScrollPosition = new Point(0, 0);

            int y = 4;
            foreach (var dept in rates)
            {
                int total = dept.TotalRecords == 0 ? 1 : dept.TotalRecords;
                double rate = (double)dept.PresentCount / total;
                rate = Math.Max(0, Math.Min(1, rate)); 

                Color barColor = rate >= 0.8 ? ColorPresent : rate >= 0.6 ? ColorLate : ColorAbsent;

                Label lblName = new Label
                {
                    Text = string.IsNullOrEmpty(dept.DepartmentName) ? "Unassigned" : dept.DepartmentName,
                    AutoSize = true,
                    Location = new Point(0, y),
                    Font = new Font("Calibri", 9.5F)
                };
                Label lblCount = new Label
                {
                    Text = $"{dept.PresentCount} / {dept.TotalRecords}",
                    AutoSize = true,
                    ForeColor = ColorMuted,
                    Font = new Font("Calibri", 9.5F)
                };
                lblCount.Location = new Point(pnlDeptBars.Width - lblCount.PreferredWidth - 4, y);
                lblCount.Anchor = AnchorStyles.Top | AnchorStyles.Right;

                Panel track = new Panel
                {
                    Location = new Point(0, y + 20),
                    Size = new Size(pnlDeptBars.Width - 4, 6),
                    BackColor = ColorTrack,
                    Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
                };
                Panel fill = new Panel
                {
                    Location = new Point(0, 0),
                    Size = new Size((int)(track.Width * rate), 6),
                    BackColor = barColor
                };
              
                track.Resize += (s, e) => fill.Width = (int)(track.Width * rate);
                track.Controls.Add(fill);

                pnlDeptBars.Controls.Add(lblName);
                pnlDeptBars.Controls.Add(lblCount);
                pnlDeptBars.Controls.Add(track);

                y += 34;
            }

            pnlDeptBars.AutoScrollMinSize = new Size(0, y);
        }



        private void BuildRecentScans(System.Collections.Generic.List<Attendance> scans)
        {
            pnlScans.Controls.Clear();

            int y = 4;
            foreach (var scan in scans)
            {
                Panel row = new Panel
                {
                    Location = new Point(0, y),
                    Size = new Size(pnlScans.Width - 4, 46),
                    Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
                };

                PictureBox avatar = new PictureBox
                {
                    Size = new Size(32, 32),
                    Location = new Point(0, 6),
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    BackColor = Color.FromArgb(230, 244, 240)
                };
                ApplyRoundedCorners(avatar, 16);

                avatar.Image = Shared.PhotoHelper.Load(scan.PhotoPath)
                    ?? Shared.PhotoHelper.CreateInitialsAvatar(scan.FullName, 32, Color.FromArgb(230, 244, 240), ColorPresent);

                Label lblName = new Label
                {
                    Text = scan.FullName,
                    AutoSize = true,
                    Location = new Point(42, 6),
                    Font = new Font("Calibri", 9.5F, FontStyle.Bold)
                };
                
                Label lblDept = new Label
                {
                    Text = scan.DepartmentName ?? "\u2014",
                    AutoSize = true,
                    Location = new Point(42, 24),
                    ForeColor = ColorMuted,
                    Font = new Font("Calibri", 8.5F)
                };

                Color timeColor = scan.Status == AttendanceStatus.LATE ? ColorLate
                   : ColorMuted;

                string timeText = scan.TimeOut.HasValue
                    ? $"Out {scan.TimeOut:h:mm tt}"
                    : scan.TimeIn.HasValue ? scan.TimeIn.Value.ToString("h:mm tt") : "\u2014";

                Label lblTime = new Label
                {
                    Text = timeText,
                    AutoSize = true,
                    ForeColor = timeColor,
                    Font = new Font("Calibri", 8.5F),
                    Anchor = AnchorStyles.Top | AnchorStyles.Right
                };
                lblTime.Location = new Point(row.Width - lblTime.PreferredWidth - 4, 14);

                row.Controls.Add(avatar);
                row.Controls.Add(lblName);
                row.Controls.Add(lblDept);
                row.Controls.Add(lblTime);

                Panel divider = new Panel
                {
                    Location = new Point(0, 45),
                    Size = new Size(row.Width, 1),
                    BackColor = ColorBorder,
                    Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
                };
                row.Controls.Add(divider);

                pnlScans.Controls.Add(row);
                y += 50;
            }

            if (scans.Count == 0)
            {
                pnlScans.Controls.Add(new Label
                {
                    Text = "No scans recorded yet today.",
                    ForeColor = ColorMuted,
                    AutoSize = true,
                    Location = new Point(0, 8)
                });
            }
        }
     

        private static void ApplyRoundedCorners(Control control, int radius)
        {
            control.Resize += (s, e) => SetRoundedRegion(control, radius);
            SetRoundedRegion(control, radius);
        }

        private static void SetRoundedRegion(Control control, int radius)
        {
            if (control.Width <= 0 || control.Height <= 0) return;

            GraphicsPath path = new GraphicsPath();
            int d = radius * 2;
            Rectangle rect = new Rectangle(0, 0, control.Width, control.Height);

            path.AddArc(rect.X, rect.Y, d, d, 180, 90);
            path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
            path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
            path.CloseFigure();

            control.Region = new Region(path);
        }

       

        private void btnReports_Click(object sender, EventArgs e)
        {
            var frm = new RFIDBasedAttendanceMonitoringSystem.Views.Reports.frmReports(_controller);
            frm.ShowDialog();
            LoadDashboard();
        }

    }
}