namespace RFIDBasedAttendanceMonitoringSystem.VIews.Attendance
{
    partial class frmRecordScan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.txtScanInput = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.pnlUserCard = new System.Windows.Forms.Panel();
            this.pnlTimeOut = new System.Windows.Forms.Panel();
            this.lblTimeOutValue = new System.Windows.Forms.Label();
            this.lblTimeOutCaption = new System.Windows.Forms.Label();
            this.pnlTimeIn = new System.Windows.Forms.Panel();
            this.lblTimeInValue = new System.Windows.Forms.Label();
            this.lblTimeInCaption = new System.Windows.Forms.Label();
            this.pnlDivider = new System.Windows.Forms.Panel();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblPositionCaption = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblDepartmentCaption = new System.Windows.Forms.Label();
            this.lblUserTag = new System.Windows.Forms.Label();
            this.lblUserTagCaption = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.picUserPhoto = new System.Windows.Forms.PictureBox();
            this.pnlScan = new System.Windows.Forms.Panel();
            this.pnlStatusBadge = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblScanSubtext = new System.Windows.Forms.Label();
            this.lblScanInstruction = new System.Windows.Forms.Label();
            this.picRfidIcon = new System.Windows.Forms.PictureBox();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.lblFooter = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlBody.SuspendLayout();
            this.pnlUserCard.SuspendLayout();
            this.pnlTimeOut.SuspendLayout();
            this.pnlTimeIn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUserPhoto)).BeginInit();
            this.pnlScan.SuspendLayout();
            this.pnlStatusBadge.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRfidIcon)).BeginInit();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(71)))));
            this.pnlHeader.Controls.Add(this.txtScanInput);
            this.pnlHeader.Controls.Add(this.btnClose);
            this.pnlHeader.Controls.Add(this.lblDateTime);
            this.pnlHeader.Controls.Add(this.lblSubTitle);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.picLogo);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(933, 80);
            this.pnlHeader.TabIndex = 0;
            // 
            // txtScanInput
            // 
            this.txtScanInput.Location = new System.Drawing.Point(-444, 16);
            this.txtScanInput.Name = "txtScanInput";
            this.txtScanInput.Size = new System.Drawing.Size(100, 23);
            this.txtScanInput.TabIndex = 5;
            this.txtScanInput.Text = "2468ACE135";
            this.txtScanInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtScanInput_KeyDown);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(889, 16);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(36, 36);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "✕";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblDateTime
            // 
            this.lblDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDateTime.BackColor = System.Drawing.Color.Transparent;
            this.lblDateTime.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            this.lblDateTime.ForeColor = System.Drawing.Color.White;
            this.lblDateTime.Location = new System.Drawing.Point(613, 20);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(260, 26);
            this.lblDateTime.TabIndex = 3;
            this.lblDateTime.Text = "Wednesday, July 22, 2023   10:45:12 AM";
            this.lblDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblSubTitle.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.lblSubTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(230)))), ((int)(((byte)(215)))));
            this.lblSubTitle.Location = new System.Drawing.Point(86, 44);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(91, 15);
            this.lblSubTitle.TabIndex = 2;
            this.lblSubTitle.Text = "Scan Station 01";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(84, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(271, 27);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "RFID Attendance Monitoring";
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.Image = global::RFIDBasedAttendanceMonitoringSystem.Properties.Resources.rfid_tags;
            this.picLogo.Location = new System.Drawing.Point(24, 16);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(48, 48);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // pnlBody
            // 
            this.pnlBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.pnlBody.Controls.Add(this.pnlUserCard);
            this.pnlBody.Controls.Add(this.pnlScan);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 80);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Padding = new System.Windows.Forms.Padding(24);
            this.pnlBody.Size = new System.Drawing.Size(933, 399);
            this.pnlBody.TabIndex = 1;
            // 
            // pnlUserCard
            // 
            this.pnlUserCard.BackColor = System.Drawing.Color.White;
            this.pnlUserCard.Controls.Add(this.pnlTimeOut);
            this.pnlUserCard.Controls.Add(this.pnlTimeIn);
            this.pnlUserCard.Controls.Add(this.pnlDivider);
            this.pnlUserCard.Controls.Add(this.lblPosition);
            this.pnlUserCard.Controls.Add(this.lblPositionCaption);
            this.pnlUserCard.Controls.Add(this.lblDepartment);
            this.pnlUserCard.Controls.Add(this.lblDepartmentCaption);
            this.pnlUserCard.Controls.Add(this.lblUserTag);
            this.pnlUserCard.Controls.Add(this.lblUserTagCaption);
            this.pnlUserCard.Controls.Add(this.lblUserName);
            this.pnlUserCard.Controls.Add(this.picUserPhoto);
            this.pnlUserCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUserCard.Location = new System.Drawing.Point(444, 24);
            this.pnlUserCard.Margin = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.pnlUserCard.Name = "pnlUserCard";
            this.pnlUserCard.Size = new System.Drawing.Size(465, 351);
            this.pnlUserCard.TabIndex = 1;
            // 
            // pnlTimeOut
            // 
            this.pnlTimeOut.Controls.Add(this.lblTimeOutValue);
            this.pnlTimeOut.Controls.Add(this.lblTimeOutCaption);
            this.pnlTimeOut.Location = new System.Drawing.Point(240, 274);
            this.pnlTimeOut.Name = "pnlTimeOut";
            this.pnlTimeOut.Size = new System.Drawing.Size(190, 60);
            this.pnlTimeOut.TabIndex = 10;
            // 
            // lblTimeOutValue
            // 
            this.lblTimeOutValue.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.lblTimeOutValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(90)))), ((int)(((byte)(60)))));
            this.lblTimeOutValue.Location = new System.Drawing.Point(0, 20);
            this.lblTimeOutValue.Name = "lblTimeOutValue";
            this.lblTimeOutValue.Size = new System.Drawing.Size(180, 30);
            this.lblTimeOutValue.TabIndex = 1;
            this.lblTimeOutValue.Text = "--:-- --";
            // 
            // lblTimeOutCaption
            // 
            this.lblTimeOutCaption.Font = new System.Drawing.Font("Calibri", 9F);
            this.lblTimeOutCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(155)))), ((int)(((byte)(165)))));
            this.lblTimeOutCaption.Location = new System.Drawing.Point(0, 0);
            this.lblTimeOutCaption.Name = "lblTimeOutCaption";
            this.lblTimeOutCaption.Size = new System.Drawing.Size(180, 18);
            this.lblTimeOutCaption.TabIndex = 0;
            this.lblTimeOutCaption.Text = "TIME OUT";
            // 
            // pnlTimeIn
            // 
            this.pnlTimeIn.Controls.Add(this.lblTimeInValue);
            this.pnlTimeIn.Controls.Add(this.lblTimeInCaption);
            this.pnlTimeIn.Location = new System.Drawing.Point(30, 274);
            this.pnlTimeIn.Name = "pnlTimeIn";
            this.pnlTimeIn.Size = new System.Drawing.Size(190, 60);
            this.pnlTimeIn.TabIndex = 9;
            // 
            // lblTimeInValue
            // 
            this.lblTimeInValue.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.lblTimeInValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(150)))), ((int)(((byte)(90)))));
            this.lblTimeInValue.Location = new System.Drawing.Point(0, 20);
            this.lblTimeInValue.Name = "lblTimeInValue";
            this.lblTimeInValue.Size = new System.Drawing.Size(180, 30);
            this.lblTimeInValue.TabIndex = 1;
            this.lblTimeInValue.Text = "--:-- --";
            // 
            // lblTimeInCaption
            // 
            this.lblTimeInCaption.Font = new System.Drawing.Font("Calibri", 9F);
            this.lblTimeInCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(155)))), ((int)(((byte)(165)))));
            this.lblTimeInCaption.Location = new System.Drawing.Point(0, 0);
            this.lblTimeInCaption.Name = "lblTimeInCaption";
            this.lblTimeInCaption.Size = new System.Drawing.Size(180, 18);
            this.lblTimeInCaption.TabIndex = 0;
            this.lblTimeInCaption.Text = "TIME IN";
            // 
            // pnlDivider
            // 
            this.pnlDivider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(237)))), ((int)(((byte)(242)))));
            this.pnlDivider.Location = new System.Drawing.Point(30, 254);
            this.pnlDivider.Name = "pnlDivider";
            this.pnlDivider.Size = new System.Drawing.Size(400, 1);
            this.pnlDivider.TabIndex = 8;
            // 
            // lblPosition
            // 
            this.lblPosition.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold);
            this.lblPosition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(65)))), ((int)(((byte)(78)))));
            this.lblPosition.Location = new System.Drawing.Point(30, 216);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(400, 20);
            this.lblPosition.TabIndex = 7;
            this.lblPosition.Text = "Associate Software Engineer";
            // 
            // lblPositionCaption
            // 
            this.lblPositionCaption.Font = new System.Drawing.Font("Calibri", 9F);
            this.lblPositionCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(155)))), ((int)(((byte)(165)))));
            this.lblPositionCaption.Location = new System.Drawing.Point(30, 198);
            this.lblPositionCaption.Name = "lblPositionCaption";
            this.lblPositionCaption.Size = new System.Drawing.Size(180, 18);
            this.lblPositionCaption.TabIndex = 6;
            this.lblPositionCaption.Text = "Position";
            // 
            // lblDepartment
            // 
            this.lblDepartment.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold);
            this.lblDepartment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(65)))), ((int)(((byte)(78)))));
            this.lblDepartment.Location = new System.Drawing.Point(30, 168);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(400, 20);
            this.lblDepartment.TabIndex = 5;
            this.lblDepartment.Text = "Information Technology";
            // 
            // lblDepartmentCaption
            // 
            this.lblDepartmentCaption.Font = new System.Drawing.Font("Calibri", 9F);
            this.lblDepartmentCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(155)))), ((int)(((byte)(165)))));
            this.lblDepartmentCaption.Location = new System.Drawing.Point(30, 150);
            this.lblDepartmentCaption.Name = "lblDepartmentCaption";
            this.lblDepartmentCaption.Size = new System.Drawing.Size(180, 18);
            this.lblDepartmentCaption.TabIndex = 4;
            this.lblDepartmentCaption.Text = "Department - Position";
            // 
            // lblUserTag
            // 
            this.lblUserTag.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold);
            this.lblUserTag.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(65)))), ((int)(((byte)(78)))));
            this.lblUserTag.Location = new System.Drawing.Point(150, 86);
            this.lblUserTag.Name = "lblUserTag";
            this.lblUserTag.Size = new System.Drawing.Size(200, 20);
            this.lblUserTag.TabIndex = 3;
            this.lblUserTag.Text = "2023-00123";
            // 
            // lblUserTagCaption
            // 
            this.lblUserTagCaption.Font = new System.Drawing.Font("Calibri", 9F);
            this.lblUserTagCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(155)))), ((int)(((byte)(165)))));
            this.lblUserTagCaption.Location = new System.Drawing.Point(150, 68);
            this.lblUserTagCaption.Name = "lblUserTagCaption";
            this.lblUserTagCaption.Size = new System.Drawing.Size(120, 18);
            this.lblUserTagCaption.TabIndex = 2;
            this.lblUserTagCaption.Text = "ID Tag";
            // 
            // lblUserName
            // 
            this.lblUserName.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold);
            this.lblUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.lblUserName.Location = new System.Drawing.Point(150, 35);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(280, 30);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "KING DAVID PERALTA";
            // 
            // picUserPhoto
            // 
            this.picUserPhoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(240)))));
            this.picUserPhoto.Location = new System.Drawing.Point(30, 30);
            this.picUserPhoto.Name = "picUserPhoto";
            this.picUserPhoto.Size = new System.Drawing.Size(100, 100);
            this.picUserPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUserPhoto.TabIndex = 0;
            this.picUserPhoto.TabStop = false;
            // 
            // pnlScan
            // 
            this.pnlScan.BackColor = System.Drawing.Color.White;
            this.pnlScan.Controls.Add(this.pnlStatusBadge);
            this.pnlScan.Controls.Add(this.lblScanSubtext);
            this.pnlScan.Controls.Add(this.lblScanInstruction);
            this.pnlScan.Controls.Add(this.picRfidIcon);
            this.pnlScan.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlScan.Location = new System.Drawing.Point(24, 24);
            this.pnlScan.Name = "pnlScan";
            this.pnlScan.Size = new System.Drawing.Size(420, 351);
            this.pnlScan.TabIndex = 0;
            // 
            // pnlStatusBadge
            // 
            this.pnlStatusBadge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(246)))), ((int)(((byte)(232)))));
            this.pnlStatusBadge.Controls.Add(this.lblStatus);
            this.pnlStatusBadge.Location = new System.Drawing.Point(110, 290);
            this.pnlStatusBadge.Name = "pnlStatusBadge";
            this.pnlStatusBadge.Size = new System.Drawing.Size(200, 40);
            this.pnlStatusBadge.TabIndex = 3;
            // 
            // lblStatus
            // 
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStatus.Font = new System.Drawing.Font("Calibri", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(150)))), ((int)(((byte)(90)))));
            this.lblStatus.Location = new System.Drawing.Point(0, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(200, 40);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Ready to Scan";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblScanSubtext
            // 
            this.lblScanSubtext.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.lblScanSubtext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(130)))), ((int)(((byte)(145)))));
            this.lblScanSubtext.Location = new System.Drawing.Point(30, 240);
            this.lblScanSubtext.Name = "lblScanSubtext";
            this.lblScanSubtext.Size = new System.Drawing.Size(360, 40);
            this.lblScanSubtext.TabIndex = 2;
            this.lblScanSubtext.Text = "Hold your RFID card near the scanner to record your attendance.";
            this.lblScanSubtext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblScanInstruction
            // 
            this.lblScanInstruction.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.lblScanInstruction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(71)))));
            this.lblScanInstruction.Location = new System.Drawing.Point(30, 200);
            this.lblScanInstruction.Name = "lblScanInstruction";
            this.lblScanInstruction.Size = new System.Drawing.Size(360, 40);
            this.lblScanInstruction.TabIndex = 1;
            this.lblScanInstruction.Text = "Tap your ID Card";
            this.lblScanInstruction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picRfidIcon
            // 
            this.picRfidIcon.BackColor = System.Drawing.Color.Transparent;
            this.picRfidIcon.Location = new System.Drawing.Point(150, 60);
            this.picRfidIcon.Name = "picRfidIcon";
            this.picRfidIcon.Size = new System.Drawing.Size(120, 120);
            this.picRfidIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRfidIcon.TabIndex = 0;
            this.picRfidIcon.TabStop = false;
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(71)))));
            this.pnlFooter.Controls.Add(this.lblFooter);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 479);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(933, 40);
            this.pnlFooter.TabIndex = 2;
            // 
            // lblFooter
            // 
            this.lblFooter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFooter.Font = new System.Drawing.Font("Calibri", 8.5F);
            this.lblFooter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(220)))), ((int)(((byte)(205)))));
            this.lblFooter.Location = new System.Drawing.Point(0, 0);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Size = new System.Drawing.Size(933, 40);
            this.lblFooter.TabIndex = 0;
            this.lblFooter.Text = "RFID Based Attendance Monitoring System  •  v1.0";
            this.lblFooter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // frmRecordScan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmRecordScan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmRecordScan_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnlBody.ResumeLayout(false);
            this.pnlUserCard.ResumeLayout(false);
            this.pnlTimeOut.ResumeLayout(false);
            this.pnlTimeIn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picUserPhoto)).EndInit();
            this.pnlScan.ResumeLayout(false);
            this.pnlStatusBadge.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picRfidIcon)).EndInit();
            this.pnlFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Button btnClose;

        private System.Windows.Forms.Panel pnlBody;

        private System.Windows.Forms.Panel pnlScan;
        private System.Windows.Forms.PictureBox picRfidIcon;
        private System.Windows.Forms.Label lblScanInstruction;
        private System.Windows.Forms.Label lblScanSubtext;
        private System.Windows.Forms.Panel pnlStatusBadge;
        private System.Windows.Forms.Label lblStatus;

        private System.Windows.Forms.Panel pnlUserCard;
        private System.Windows.Forms.PictureBox picUserPhoto;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblUserTagCaption;
        private System.Windows.Forms.Label lblUserTag;
        private System.Windows.Forms.Label lblDepartmentCaption;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblPositionCaption;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Panel pnlDivider;
        private System.Windows.Forms.Panel pnlTimeIn;
        private System.Windows.Forms.Label lblTimeInCaption;
        private System.Windows.Forms.Label lblTimeInValue;
        private System.Windows.Forms.Panel pnlTimeOut;
        private System.Windows.Forms.Label lblTimeOutCaption;
        private System.Windows.Forms.Label lblTimeOutValue;

        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Label lblFooter;
        private System.Windows.Forms.TextBox txtScanInput;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}