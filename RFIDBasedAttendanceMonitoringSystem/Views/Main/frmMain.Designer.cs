namespace RFIDBasedAttendanceMonitoringSystem.VIews.Main
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelMaintenanceSub = new System.Windows.Forms.Panel();
            this.btnShiftSchedule = new System.Windows.Forms.Button();
            this.btnHoliday = new System.Windows.Forms.Button();
            this.btnPosition = new System.Windows.Forms.Button();
            this.btnDepartment = new System.Windows.Forms.Button();
            this.btnMaintenance = new System.Windows.Forms.Button();
            this.lblSectionManagement = new System.Windows.Forms.Label();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnAttendances = new System.Windows.Forms.Button();
            this.lblSectionMonitoring = new System.Windows.Forms.Label();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelMaintenanceSub.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.label4.Location = new System.Drawing.Point(361, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(339, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "RFID-BASED ATTENDANCE MONITORING SYSTEM";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(210, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(723, 75);
            this.panel3.TabIndex = 4;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Location = new System.Drawing.Point(651, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 60);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(210, 100);
            this.panel2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(78, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 14);
            this.label3.TabIndex = 3;
            this.label3.Text = "role";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(78, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(77, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "RFIDBAMS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RFIDBasedAttendanceMonitoringSystem.Properties.Resources.administrator;
            this.pictureBox1.Location = new System.Drawing.Point(16, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.panelMaintenanceSub);
            this.panel1.Controls.Add(this.btnMaintenance);
            this.panel1.Controls.Add(this.lblSectionManagement);
            this.panel1.Controls.Add(this.btnReports);
            this.panel1.Controls.Add(this.btnAttendances);
            this.panel1.Controls.Add(this.lblSectionMonitoring);
            this.panel1.Controls.Add(this.btnEmployees);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 554);
            this.panel1.TabIndex = 3;
            // 
            // panelMaintenanceSub
            // 
            this.panelMaintenanceSub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(42)))), ((int)(((byte)(44)))));
            this.panelMaintenanceSub.Controls.Add(this.btnShiftSchedule);
            this.panelMaintenanceSub.Controls.Add(this.btnHoliday);
            this.panelMaintenanceSub.Controls.Add(this.btnPosition);
            this.panelMaintenanceSub.Controls.Add(this.btnDepartment);
            this.panelMaintenanceSub.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMaintenanceSub.Location = new System.Drawing.Point(0, 315);
            this.panelMaintenanceSub.Name = "panelMaintenanceSub";
            this.panelMaintenanceSub.Size = new System.Drawing.Size(210, 145);
            this.panelMaintenanceSub.TabIndex = 19;
            this.panelMaintenanceSub.Visible = false;
            // 
            // btnShiftSchedule
            // 
            this.btnShiftSchedule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShiftSchedule.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnShiftSchedule.FlatAppearance.BorderSize = 0;
            this.btnShiftSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShiftSchedule.Font = new System.Drawing.Font("Calibri", 8F);
            this.btnShiftSchedule.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShiftSchedule.Location = new System.Drawing.Point(0, 105);
            this.btnShiftSchedule.Name = "btnShiftSchedule";
            this.btnShiftSchedule.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnShiftSchedule.Size = new System.Drawing.Size(210, 35);
            this.btnShiftSchedule.TabIndex = 3;
            this.btnShiftSchedule.Text = "SHIFT SCHEDULE";
            this.btnShiftSchedule.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShiftSchedule.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnShiftSchedule.UseVisualStyleBackColor = true;
            this.btnShiftSchedule.Click += new System.EventHandler(this.btnShiftSchedule_Click);
            // 
            // btnHoliday
            // 
            this.btnHoliday.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHoliday.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHoliday.FlatAppearance.BorderSize = 0;
            this.btnHoliday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoliday.Font = new System.Drawing.Font("Calibri", 8F);
            this.btnHoliday.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHoliday.Location = new System.Drawing.Point(0, 70);
            this.btnHoliday.Name = "btnHoliday";
            this.btnHoliday.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnHoliday.Size = new System.Drawing.Size(210, 35);
            this.btnHoliday.TabIndex = 2;
            this.btnHoliday.Text = "HOLIDAYS";
            this.btnHoliday.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHoliday.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHoliday.UseVisualStyleBackColor = true;
            this.btnHoliday.Click += new System.EventHandler(this.btnHoliday_Click);
            // 
            // btnPosition
            // 
            this.btnPosition.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPosition.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPosition.FlatAppearance.BorderSize = 0;
            this.btnPosition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPosition.Font = new System.Drawing.Font("Calibri", 8F);
            this.btnPosition.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPosition.Location = new System.Drawing.Point(0, 35);
            this.btnPosition.Name = "btnPosition";
            this.btnPosition.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnPosition.Size = new System.Drawing.Size(210, 35);
            this.btnPosition.TabIndex = 1;
            this.btnPosition.Text = "POSITIONS";
            this.btnPosition.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPosition.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPosition.UseVisualStyleBackColor = true;
            this.btnPosition.Click += new System.EventHandler(this.btnPosition_Click);
            // 
            // btnDepartment
            // 
            this.btnDepartment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDepartment.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDepartment.FlatAppearance.BorderSize = 0;
            this.btnDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDepartment.Font = new System.Drawing.Font("Calibri", 8F);
            this.btnDepartment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDepartment.Location = new System.Drawing.Point(0, 0);
            this.btnDepartment.Name = "btnDepartment";
            this.btnDepartment.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnDepartment.Size = new System.Drawing.Size(210, 35);
            this.btnDepartment.TabIndex = 0;
            this.btnDepartment.Text = "DEPARTMENTS";
            this.btnDepartment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDepartment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDepartment.UseVisualStyleBackColor = true;
            this.btnDepartment.Click += new System.EventHandler(this.btnDepartment_Click);
            // 
            // btnMaintenance
            // 
            this.btnMaintenance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaintenance.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMaintenance.FlatAppearance.BorderSize = 0;
            this.btnMaintenance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaintenance.Font = new System.Drawing.Font("Calibri", 8F);
            this.btnMaintenance.Image = global::RFIDBasedAttendanceMonitoringSystem.Properties.Resources.settings_16;
            this.btnMaintenance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMaintenance.Location = new System.Drawing.Point(0, 280);
            this.btnMaintenance.Name = "btnMaintenance";
            this.btnMaintenance.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnMaintenance.Size = new System.Drawing.Size(210, 35);
            this.btnMaintenance.TabIndex = 18;
            this.btnMaintenance.Text = "MAINTENANCE  ▸";
            this.btnMaintenance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMaintenance.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMaintenance.UseVisualStyleBackColor = true;
            this.btnMaintenance.Click += new System.EventHandler(this.btnMaintenance_Click);
            // 
            // lblSectionManagement
            // 
            this.lblSectionManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSectionManagement.Font = new System.Drawing.Font("Calibri", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSectionManagement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.lblSectionManagement.Location = new System.Drawing.Point(0, 260);
            this.lblSectionManagement.Name = "lblSectionManagement";
            this.lblSectionManagement.Padding = new System.Windows.Forms.Padding(15, 6, 0, 2);
            this.lblSectionManagement.Size = new System.Drawing.Size(210, 20);
            this.lblSectionManagement.TabIndex = 17;
            this.lblSectionManagement.Text = "MANAGEMENT";
            // 
            // btnReports
            // 
            this.btnReports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReports.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Calibri", 8F);
            this.btnReports.Image = ((System.Drawing.Image)(resources.GetObject("btnReports.Image")));
            this.btnReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.Location = new System.Drawing.Point(0, 225);
            this.btnReports.Name = "btnReports";
            this.btnReports.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnReports.Size = new System.Drawing.Size(210, 35);
            this.btnReports.TabIndex = 16;
            this.btnReports.Text = "REPORTS";
            this.btnReports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnAttendances
            // 
            this.btnAttendances.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAttendances.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAttendances.FlatAppearance.BorderSize = 0;
            this.btnAttendances.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttendances.Font = new System.Drawing.Font("Calibri", 8F);
            this.btnAttendances.Image = global::RFIDBasedAttendanceMonitoringSystem.Properties.Resources.clock;
            this.btnAttendances.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAttendances.Location = new System.Drawing.Point(0, 190);
            this.btnAttendances.Name = "btnAttendances";
            this.btnAttendances.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnAttendances.Size = new System.Drawing.Size(210, 35);
            this.btnAttendances.TabIndex = 15;
            this.btnAttendances.Text = "ATTENDANCE";
            this.btnAttendances.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAttendances.UseVisualStyleBackColor = true;
            this.btnAttendances.Click += new System.EventHandler(this.btnAttendances_Click);
            // 
            // lblSectionMonitoring
            // 
            this.lblSectionMonitoring.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSectionMonitoring.Font = new System.Drawing.Font("Calibri", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSectionMonitoring.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.lblSectionMonitoring.Location = new System.Drawing.Point(0, 170);
            this.lblSectionMonitoring.Name = "lblSectionMonitoring";
            this.lblSectionMonitoring.Padding = new System.Windows.Forms.Padding(15, 6, 0, 2);
            this.lblSectionMonitoring.Size = new System.Drawing.Size(210, 20);
            this.lblSectionMonitoring.TabIndex = 14;
            this.lblSectionMonitoring.Text = "MONITORING";
            // 
            // btnEmployees
            // 
            this.btnEmployees.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmployees.FlatAppearance.BorderSize = 0;
            this.btnEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployees.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployees.Image = global::RFIDBasedAttendanceMonitoringSystem.Properties.Resources.employee;
            this.btnEmployees.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployees.Location = new System.Drawing.Point(0, 135);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnEmployees.Size = new System.Drawing.Size(210, 35);
            this.btnEmployees.TabIndex = 10;
            this.btnEmployees.Text = "EMPLOYEES";
            this.btnEmployees.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployees.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmployees.UseVisualStyleBackColor = true;
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Calibri", 8F);
            this.btnDashboard.Image = global::RFIDBasedAttendanceMonitoringSystem.Properties.Resources.dashboard;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(0, 100);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnDashboard.Size = new System.Drawing.Size(210, 35);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "DASHBOARD";
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Calibri", 8F);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = global::RFIDBasedAttendanceMonitoringSystem.Properties.Resources.logout;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 519);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(210, 35);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.Text = "LOGOUT";
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(210, 75);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Padding = new System.Windows.Forms.Padding(5);
            this.MainPanel.Size = new System.Drawing.Size(723, 479);
            this.MainPanel.TabIndex = 5;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 554);
            this.ControlBox = false;
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panelMaintenanceSub.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel panelMaintenanceSub;
        private System.Windows.Forms.Button btnPosition;
        private System.Windows.Forms.Button btnDepartment;
        private System.Windows.Forms.Button btnMaintenance;
        private System.Windows.Forms.Label lblSectionManagement;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnAttendances;
        private System.Windows.Forms.Label lblSectionMonitoring;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.Button btnHoliday;
        private System.Windows.Forms.Button btnShiftSchedule;
    }
}