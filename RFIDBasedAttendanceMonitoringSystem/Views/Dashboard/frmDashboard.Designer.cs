using System.Windows.Forms.DataVisualization.Charting;

namespace RFIDBasedAttendanceMonitoringSystem.Views.Dashboard
{
    partial class frmDashboard
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnReports = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.flpKpis = new System.Windows.Forms.TableLayoutPanel();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.tlpLeft = new System.Windows.Forms.TableLayoutPanel();
            this.panelTrend = new System.Windows.Forms.Panel();
            this.chartTrend = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlLegend = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTrendTitle = new System.Windows.Forms.Label();
            this.panelDept = new System.Windows.Forms.Panel();
            this.pnlDeptBars = new System.Windows.Forms.Panel();
            this.lblDeptTitle = new System.Windows.Forms.Label();
            this.panelRight = new System.Windows.Forms.Panel();
            this.pnlHolidayFooter = new System.Windows.Forms.Panel();
            this.lblNextHoliday = new System.Windows.Forms.Label();
            this.pnlScans = new System.Windows.Forms.Panel();
            this.lblScansTitle = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.tlpMain.SuspendLayout();
            this.tlpLeft.SuspendLayout();
            this.panelTrend.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTrend)).BeginInit();
            this.panelDept.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.pnlHolidayFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.White;
            this.panelHeader.Controls.Add(this.btnReports);
            this.panelHeader.Controls.Add(this.lblDate);
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Padding = new System.Windows.Forms.Padding(20, 14, 20, 14);
            this.panelHeader.Size = new System.Drawing.Size(1200, 70);
            this.panelHeader.TabIndex = 0;
            // 
            // btnReports
            // 
            this.btnReports.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.btnReports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.ForeColor = System.Drawing.Color.White;
            this.btnReports.Location = new System.Drawing.Point(1093, 27);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(84, 26);
            this.btnReports.TabIndex = 2;
            this.btnReports.Text = "Reports";
            this.btnReports.UseVisualStyleBackColor = false;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.lblDate.Location = new System.Drawing.Point(20, 38);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(180, 24);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Day, Month dd, yyyy";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(18, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(281, 35);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Attendance Dashboard";
            // 
            // flpKpis
            // 
            this.flpKpis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(245)))));
            this.flpKpis.ColumnCount = 5;
            this.flpKpis.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.flpKpis.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.flpKpis.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.flpKpis.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.flpKpis.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.flpKpis.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpKpis.Location = new System.Drawing.Point(0, 70);
            this.flpKpis.Name = "flpKpis";
            this.flpKpis.Padding = new System.Windows.Forms.Padding(20, 14, 20, 6);
            this.flpKpis.RowCount = 1;
            this.flpKpis.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.flpKpis.Size = new System.Drawing.Size(1200, 116);
            this.flpKpis.TabIndex = 1;
            // 
            // tlpMain
            // 
            this.tlpMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(245)))));
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36F));
            this.tlpMain.Controls.Add(this.tlpLeft, 0, 0);
            this.tlpMain.Controls.Add(this.panelRight, 1, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 186);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.Padding = new System.Windows.Forms.Padding(20, 14, 20, 20);
            this.tlpMain.RowCount = 1;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Size = new System.Drawing.Size(1200, 494);
            this.tlpMain.TabIndex = 2;
            // 
            // tlpLeft
            // 
            this.tlpLeft.ColumnCount = 1;
            this.tlpLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpLeft.Controls.Add(this.panelTrend, 0, 0);
            this.tlpLeft.Controls.Add(this.panelDept, 0, 1);
            this.tlpLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpLeft.Location = new System.Drawing.Point(20, 14);
            this.tlpLeft.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.tlpLeft.Name = "tlpLeft";
            this.tlpLeft.RowCount = 2;
            this.tlpLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tlpLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tlpLeft.Size = new System.Drawing.Size(734, 460);
            this.tlpLeft.TabIndex = 0;
            // 
            // panelTrend
            // 
            this.panelTrend.BackColor = System.Drawing.Color.White;
            this.panelTrend.Controls.Add(this.chartTrend);
            this.panelTrend.Controls.Add(this.pnlLegend);
            this.panelTrend.Controls.Add(this.lblTrendTitle);
            this.panelTrend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTrend.Location = new System.Drawing.Point(0, 0);
            this.panelTrend.Margin = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.panelTrend.Name = "panelTrend";
            this.panelTrend.Padding = new System.Windows.Forms.Padding(16);
            this.panelTrend.Size = new System.Drawing.Size(734, 247);
            this.panelTrend.TabIndex = 0;
            // 
            // chartTrend
            // 
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(224)))), ((int)(((byte)(217)))));
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(236)))));
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(224)))), ((int)(((byte)(217)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(236)))));
            chartArea1.BackColor = System.Drawing.Color.White;
            chartArea1.Name = "MainArea";
            this.chartTrend.ChartAreas.Add(chartArea1);
            this.chartTrend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartTrend.Location = new System.Drawing.Point(16, 43);
            this.chartTrend.Name = "chartTrend";
            this.chartTrend.Size = new System.Drawing.Size(702, 188);
            this.chartTrend.TabIndex = 2;
            this.chartTrend.Text = "chartTrend";
            // 
            // pnlLegend
            // 
            this.pnlLegend.AutoSize = true;
            this.pnlLegend.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLegend.Location = new System.Drawing.Point(16, 43);
            this.pnlLegend.Name = "pnlLegend";
            this.pnlLegend.Size = new System.Drawing.Size(702, 0);
            this.pnlLegend.TabIndex = 1;
            // 
            // lblTrendTitle
            // 
            this.lblTrendTitle.AutoSize = true;
            this.lblTrendTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTrendTitle.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold);
            this.lblTrendTitle.Location = new System.Drawing.Point(16, 16);
            this.lblTrendTitle.Name = "lblTrendTitle";
            this.lblTrendTitle.Size = new System.Drawing.Size(173, 27);
            this.lblTrendTitle.TabIndex = 0;
            this.lblTrendTitle.Text = "This week\'s trend";
            // 
            // panelDept
            // 
            this.panelDept.BackColor = System.Drawing.Color.White;
            this.panelDept.Controls.Add(this.pnlDeptBars);
            this.panelDept.Controls.Add(this.lblDeptTitle);
            this.panelDept.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDept.Location = new System.Drawing.Point(0, 265);
            this.panelDept.Margin = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.panelDept.Name = "panelDept";
            this.panelDept.Padding = new System.Windows.Forms.Padding(16);
            this.panelDept.Size = new System.Drawing.Size(734, 195);
            this.panelDept.TabIndex = 1;
            // 
            // pnlDeptBars
            // 
            this.pnlDeptBars.AutoScroll = true;
            this.pnlDeptBars.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDeptBars.Location = new System.Drawing.Point(16, 43);
            this.pnlDeptBars.Name = "pnlDeptBars";
            this.pnlDeptBars.Size = new System.Drawing.Size(702, 136);
            this.pnlDeptBars.TabIndex = 1;
            // 
            // lblDeptTitle
            // 
            this.lblDeptTitle.AutoSize = true;
            this.lblDeptTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDeptTitle.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold);
            this.lblDeptTitle.Location = new System.Drawing.Point(16, 16);
            this.lblDeptTitle.Name = "lblDeptTitle";
            this.lblDeptTitle.Size = new System.Drawing.Size(150, 27);
            this.lblDeptTitle.TabIndex = 0;
            this.lblDeptTitle.Text = "By department";
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.White;
            this.panelRight.Controls.Add(this.pnlHolidayFooter);
            this.panelRight.Controls.Add(this.pnlScans);
            this.panelRight.Controls.Add(this.lblScansTitle);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(770, 14);
            this.panelRight.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Padding = new System.Windows.Forms.Padding(16);
            this.panelRight.Size = new System.Drawing.Size(410, 460);
            this.panelRight.TabIndex = 1;
            // 
            // pnlHolidayFooter
            // 
            this.pnlHolidayFooter.Controls.Add(this.lblNextHoliday);
            this.pnlHolidayFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlHolidayFooter.Location = new System.Drawing.Point(16, 404);
            this.pnlHolidayFooter.Name = "pnlHolidayFooter";
            this.pnlHolidayFooter.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.pnlHolidayFooter.Size = new System.Drawing.Size(378, 40);
            this.pnlHolidayFooter.TabIndex = 2;
            // 
            // lblNextHoliday
            // 
            this.lblNextHoliday.AutoSize = true;
            this.lblNextHoliday.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNextHoliday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.lblNextHoliday.Location = new System.Drawing.Point(0, 10);
            this.lblNextHoliday.Name = "lblNextHoliday";
            this.lblNextHoliday.Size = new System.Drawing.Size(144, 24);
            this.lblNextHoliday.TabIndex = 0;
            this.lblNextHoliday.Text = "Next holiday: —";
            // 
            // pnlScans
            // 
            this.pnlScans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlScans.Location = new System.Drawing.Point(16, 43);
            this.pnlScans.Name = "pnlScans";
            this.pnlScans.Size = new System.Drawing.Size(378, 401);
            this.pnlScans.TabIndex = 1;
            // 
            // lblScansTitle
            // 
            this.lblScansTitle.AutoSize = true;
            this.lblScansTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblScansTitle.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold);
            this.lblScansTitle.Location = new System.Drawing.Point(16, 16);
            this.lblScansTitle.Name = "lblScansTitle";
            this.lblScansTitle.Size = new System.Drawing.Size(130, 27);
            this.lblScansTitle.TabIndex = 0;
            this.lblScansTitle.Text = "Recent scans";
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1200, 680);
            this.Controls.Add(this.tlpMain);
            this.Controls.Add(this.flpKpis);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDashboard";
            this.Text = "frmDashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.tlpMain.ResumeLayout(false);
            this.tlpLeft.ResumeLayout(false);
            this.panelTrend.ResumeLayout(false);
            this.panelTrend.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTrend)).EndInit();
            this.panelDept.ResumeLayout(false);
            this.panelDept.PerformLayout();
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            this.pnlHolidayFooter.ResumeLayout(false);
            this.pnlHolidayFooter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TableLayoutPanel flpKpis;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.TableLayoutPanel tlpLeft;
        private System.Windows.Forms.Panel panelDept;
        private System.Windows.Forms.Panel pnlDeptBars;
        private System.Windows.Forms.Label lblDeptTitle;
        private System.Windows.Forms.Panel panelTrend;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTrend;
        private System.Windows.Forms.FlowLayoutPanel pnlLegend;
        private System.Windows.Forms.Label lblTrendTitle;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Panel pnlScans;
        private System.Windows.Forms.Label lblScansTitle;
        private System.Windows.Forms.Panel pnlHolidayFooter;
        private System.Windows.Forms.Label lblNextHoliday;
    }
}