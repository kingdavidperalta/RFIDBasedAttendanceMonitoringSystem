using System;

namespace RFIDBasedAttendanceMonitoringSystem.VIews.Employee
{
    partial class frmAddEditEmployee
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
            this.pnlAccent = new System.Windows.Forms.Panel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.lblPersonalInfoHeader = new System.Windows.Forms.Label();
            this.pnlDividerPersonal = new System.Windows.Forms.Panel();
            this.lblTagCaption = new System.Windows.Forms.Label();
            this.txtEmployeeTag = new System.Windows.Forms.TextBox();
            this.lblLastNameCaption = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblFirstNameCaption = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblMiddleNameCaption = new System.Windows.Forms.Label();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.lblSuffixCaption = new System.Windows.Forms.Label();
            this.txtSuffix = new System.Windows.Forms.TextBox();
            this.lblEmploymentHeader = new System.Windows.Forms.Label();
            this.pnlDividerEmployment = new System.Windows.Forms.Panel();
            this.lblDepartmentCaption = new System.Windows.Forms.Label();
            this.cboDepartment = new System.Windows.Forms.ComboBox();
            this.btnAddDepartment = new System.Windows.Forms.Button();
            this.lblPositionCaption = new System.Windows.Forms.Label();
            this.cboPosition = new System.Windows.Forms.ComboBox();
            this.btnPosition = new System.Windows.Forms.Button();
            this.lblStatusCaption = new System.Windows.Forms.Label();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.lblPhotoCaption = new System.Windows.Forms.Label();
            this.pnlDividerPhoto = new System.Windows.Forms.Panel();
            this.picEmployee = new System.Windows.Forms.PictureBox();
            this.btnChoosePicture = new System.Windows.Forms.Button();
            this.lblPhotoHint = new System.Windows.Forms.Label();
            this.lblHint = new System.Windows.Forms.Label();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.pnlBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEmployee)).BeginInit();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAccent
            // 
            this.pnlAccent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.pnlAccent.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAccent.Location = new System.Drawing.Point(0, 0);
            this.pnlAccent.Name = "pnlAccent";
            this.pnlAccent.Size = new System.Drawing.Size(654, 4);
            this.pnlAccent.TabIndex = 0;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.ForeColor = System.Drawing.Color.White;
            this.pnlHeader.Location = new System.Drawing.Point(0, 4);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Padding = new System.Windows.Forms.Padding(24, 16, 24, 16);
            this.pnlHeader.Size = new System.Drawing.Size(654, 64);
            this.pnlHeader.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(24, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(148, 23);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Employee Details";
            // 
            // pnlBody
            // 
            this.pnlBody.Controls.Add(this.lblPersonalInfoHeader);
            this.pnlBody.Controls.Add(this.pnlDividerPersonal);
            this.pnlBody.Controls.Add(this.lblTagCaption);
            this.pnlBody.Controls.Add(this.txtEmployeeTag);
            this.pnlBody.Controls.Add(this.lblLastNameCaption);
            this.pnlBody.Controls.Add(this.txtLastName);
            this.pnlBody.Controls.Add(this.lblFirstNameCaption);
            this.pnlBody.Controls.Add(this.txtFirstName);
            this.pnlBody.Controls.Add(this.lblMiddleNameCaption);
            this.pnlBody.Controls.Add(this.txtMiddleName);
            this.pnlBody.Controls.Add(this.lblSuffixCaption);
            this.pnlBody.Controls.Add(this.txtSuffix);
            this.pnlBody.Controls.Add(this.lblEmploymentHeader);
            this.pnlBody.Controls.Add(this.pnlDividerEmployment);
            this.pnlBody.Controls.Add(this.lblDepartmentCaption);
            this.pnlBody.Controls.Add(this.cboDepartment);
            this.pnlBody.Controls.Add(this.btnAddDepartment);
            this.pnlBody.Controls.Add(this.lblPositionCaption);
            this.pnlBody.Controls.Add(this.cboPosition);
            this.pnlBody.Controls.Add(this.btnPosition);
            this.pnlBody.Controls.Add(this.lblStatusCaption);
            this.pnlBody.Controls.Add(this.cboStatus);
            this.pnlBody.Controls.Add(this.lblPhotoCaption);
            this.pnlBody.Controls.Add(this.pnlDividerPhoto);
            this.pnlBody.Controls.Add(this.picEmployee);
            this.pnlBody.Controls.Add(this.btnChoosePicture);
            this.pnlBody.Controls.Add(this.lblPhotoHint);
            this.pnlBody.Controls.Add(this.lblHint);
            this.pnlBody.Controls.Add(this.pnlFooter);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 68);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Padding = new System.Windows.Forms.Padding(24, 20, 24, 12);
            this.pnlBody.Size = new System.Drawing.Size(654, 569);
            this.pnlBody.TabIndex = 2;
            // 
            // lblPersonalInfoHeader
            // 
            this.lblPersonalInfoHeader.AutoSize = true;
            this.lblPersonalInfoHeader.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblPersonalInfoHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.lblPersonalInfoHeader.Location = new System.Drawing.Point(24, 16);
            this.lblPersonalInfoHeader.Name = "lblPersonalInfoHeader";
            this.lblPersonalInfoHeader.Size = new System.Drawing.Size(156, 17);
            this.lblPersonalInfoHeader.TabIndex = 100;
            this.lblPersonalInfoHeader.Text = "PERSONAL INFORMATION";
            // 
            // pnlDividerPersonal
            // 
            this.pnlDividerPersonal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(227)))), ((int)(((byte)(230)))));
            this.pnlDividerPersonal.Location = new System.Drawing.Point(24, 38);
            this.pnlDividerPersonal.Name = "pnlDividerPersonal";
            this.pnlDividerPersonal.Size = new System.Drawing.Size(372, 1);
            this.pnlDividerPersonal.TabIndex = 101;
            // 
            // lblTagCaption
            // 
            this.lblTagCaption.AutoSize = true;
            this.lblTagCaption.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.lblTagCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTagCaption.Location = new System.Drawing.Point(24, 52);
            this.lblTagCaption.Name = "lblTagCaption";
            this.lblTagCaption.Size = new System.Drawing.Size(83, 14);
            this.lblTagCaption.TabIndex = 0;
            this.lblTagCaption.Text = "EMPLOYEE TAG";
            // 
            // txtEmployeeTag
            // 
            this.txtEmployeeTag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmployeeTag.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.txtEmployeeTag.Location = new System.Drawing.Point(24, 71);
            this.txtEmployeeTag.MaxLength = 10;
            this.txtEmployeeTag.Name = "txtEmployeeTag";
            this.txtEmployeeTag.Size = new System.Drawing.Size(372, 25);
            this.txtEmployeeTag.TabIndex = 1;
            this.txtEmployeeTag.Leave += new System.EventHandler(this.txtEmployeeTag_Leave);
            // 
            // lblLastNameCaption
            // 
            this.lblLastNameCaption.AutoSize = true;
            this.lblLastNameCaption.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.lblLastNameCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblLastNameCaption.Location = new System.Drawing.Point(24, 111);
            this.lblLastNameCaption.Name = "lblLastNameCaption";
            this.lblLastNameCaption.Size = new System.Drawing.Size(65, 14);
            this.lblLastNameCaption.TabIndex = 2;
            this.lblLastNameCaption.Text = "LAST NAME";
            // 
            // txtLastName
            // 
            this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLastName.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.txtLastName.Location = new System.Drawing.Point(24, 130);
            this.txtLastName.MaxLength = 50;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(372, 25);
            this.txtLastName.TabIndex = 3;
            // 
            // lblFirstNameCaption
            // 
            this.lblFirstNameCaption.AutoSize = true;
            this.lblFirstNameCaption.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.lblFirstNameCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblFirstNameCaption.Location = new System.Drawing.Point(24, 170);
            this.lblFirstNameCaption.Name = "lblFirstNameCaption";
            this.lblFirstNameCaption.Size = new System.Drawing.Size(69, 14);
            this.lblFirstNameCaption.TabIndex = 4;
            this.lblFirstNameCaption.Text = "FIRST NAME";
            // 
            // txtFirstName
            // 
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFirstName.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.txtFirstName.Location = new System.Drawing.Point(24, 189);
            this.txtFirstName.MaxLength = 50;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(372, 25);
            this.txtFirstName.TabIndex = 5;
            // 
            // lblMiddleNameCaption
            // 
            this.lblMiddleNameCaption.AutoSize = true;
            this.lblMiddleNameCaption.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.lblMiddleNameCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblMiddleNameCaption.Location = new System.Drawing.Point(24, 229);
            this.lblMiddleNameCaption.Name = "lblMiddleNameCaption";
            this.lblMiddleNameCaption.Size = new System.Drawing.Size(81, 14);
            this.lblMiddleNameCaption.TabIndex = 6;
            this.lblMiddleNameCaption.Text = "MIDDLE NAME";
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMiddleName.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.txtMiddleName.Location = new System.Drawing.Point(24, 248);
            this.txtMiddleName.MaxLength = 50;
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(372, 25);
            this.txtMiddleName.TabIndex = 7;
            // 
            // lblSuffixCaption
            // 
            this.lblSuffixCaption.AutoSize = true;
            this.lblSuffixCaption.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.lblSuffixCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSuffixCaption.Location = new System.Drawing.Point(24, 288);
            this.lblSuffixCaption.Name = "lblSuffixCaption";
            this.lblSuffixCaption.Size = new System.Drawing.Size(43, 14);
            this.lblSuffixCaption.TabIndex = 8;
            this.lblSuffixCaption.Text = "SUFFIX";
            // 
            // txtSuffix
            // 
            this.txtSuffix.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSuffix.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.txtSuffix.Location = new System.Drawing.Point(24, 307);
            this.txtSuffix.MaxLength = 3;
            this.txtSuffix.Name = "txtSuffix";
            this.txtSuffix.Size = new System.Drawing.Size(120, 25);
            this.txtSuffix.TabIndex = 9;
            // 
            // lblEmploymentHeader
            // 
            this.lblEmploymentHeader.AutoSize = true;
            this.lblEmploymentHeader.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblEmploymentHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.lblEmploymentHeader.Location = new System.Drawing.Point(24, 356);
            this.lblEmploymentHeader.Name = "lblEmploymentHeader";
            this.lblEmploymentHeader.Size = new System.Drawing.Size(141, 17);
            this.lblEmploymentHeader.TabIndex = 102;
            this.lblEmploymentHeader.Text = "EMPLOYMENT DETAILS";
            // 
            // pnlDividerEmployment
            // 
            this.pnlDividerEmployment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(227)))), ((int)(((byte)(230)))));
            this.pnlDividerEmployment.Location = new System.Drawing.Point(24, 378);
            this.pnlDividerEmployment.Name = "pnlDividerEmployment";
            this.pnlDividerEmployment.Size = new System.Drawing.Size(372, 1);
            this.pnlDividerEmployment.TabIndex = 103;
            // 
            // lblDepartmentCaption
            // 
            this.lblDepartmentCaption.AutoSize = true;
            this.lblDepartmentCaption.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.lblDepartmentCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDepartmentCaption.Location = new System.Drawing.Point(24, 392);
            this.lblDepartmentCaption.Name = "lblDepartmentCaption";
            this.lblDepartmentCaption.Size = new System.Drawing.Size(76, 14);
            this.lblDepartmentCaption.TabIndex = 10;
            this.lblDepartmentCaption.Text = "DEPARTMENT";
            // 
            // cboDepartment
            // 
            this.cboDepartment.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.cboDepartment.FormattingEnabled = true;
            this.cboDepartment.Location = new System.Drawing.Point(24, 411);
            this.cboDepartment.Name = "cboDepartment";
            this.cboDepartment.Size = new System.Drawing.Size(267, 25);
            this.cboDepartment.TabIndex = 11;
            this.cboDepartment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboDepartment_KeyPress);
            // 
            // btnAddDepartment
            // 
            this.btnAddDepartment.Location = new System.Drawing.Point(293, 410);
            this.btnAddDepartment.Name = "btnAddDepartment";
            this.btnAddDepartment.Size = new System.Drawing.Size(25, 27);
            this.btnAddDepartment.TabIndex = 12;
            this.btnAddDepartment.Text = "+";
            this.btnAddDepartment.UseVisualStyleBackColor = true;
            this.btnAddDepartment.Click += new System.EventHandler(this.btnAddDepartment_Click);
            // 
            // lblPositionCaption
            // 
            this.lblPositionCaption.AutoSize = true;
            this.lblPositionCaption.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.lblPositionCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPositionCaption.Location = new System.Drawing.Point(333, 393);
            this.lblPositionCaption.Name = "lblPositionCaption";
            this.lblPositionCaption.Size = new System.Drawing.Size(55, 14);
            this.lblPositionCaption.TabIndex = 13;
            this.lblPositionCaption.Text = "POSITION";
            // 
            // cboPosition
            // 
            this.cboPosition.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.cboPosition.FormattingEnabled = true;
            this.cboPosition.Location = new System.Drawing.Point(336, 410);
            this.cboPosition.Name = "cboPosition";
            this.cboPosition.Size = new System.Drawing.Size(267, 25);
            this.cboPosition.TabIndex = 14;
            this.cboPosition.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboDepartment_KeyPress);
            // 
            // btnPosition
            // 
            this.btnPosition.Location = new System.Drawing.Point(605, 409);
            this.btnPosition.Name = "btnPosition";
            this.btnPosition.Size = new System.Drawing.Size(25, 27);
            this.btnPosition.TabIndex = 15;
            this.btnPosition.Text = "+";
            this.btnPosition.UseVisualStyleBackColor = true;
            this.btnPosition.Click += new System.EventHandler(this.btnPosition_Click);
            // 
            // lblStatusCaption
            // 
            this.lblStatusCaption.AutoSize = true;
            this.lblStatusCaption.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.lblStatusCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblStatusCaption.Location = new System.Drawing.Point(24, 444);
            this.lblStatusCaption.Name = "lblStatusCaption";
            this.lblStatusCaption.Size = new System.Drawing.Size(44, 14);
            this.lblStatusCaption.TabIndex = 16;
            this.lblStatusCaption.Text = "STATUS";
            // 
            // cboStatus
            // 
            this.cboStatus.Font = new System.Drawing.Font("Calibri", 10.5F);
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Location = new System.Drawing.Point(24, 463);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(606, 25);
            this.cboStatus.TabIndex = 17;
            this.cboStatus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboDepartment_KeyPress);
            // 
            // lblPhotoCaption
            // 
            this.lblPhotoCaption.AutoSize = true;
            this.lblPhotoCaption.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblPhotoCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.lblPhotoCaption.Location = new System.Drawing.Point(420, 16);
            this.lblPhotoCaption.Name = "lblPhotoCaption";
            this.lblPhotoCaption.Size = new System.Drawing.Size(49, 17);
            this.lblPhotoCaption.TabIndex = 104;
            this.lblPhotoCaption.Text = "PHOTO";
            // 
            // pnlDividerPhoto
            // 
            this.pnlDividerPhoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(227)))), ((int)(((byte)(230)))));
            this.pnlDividerPhoto.Location = new System.Drawing.Point(420, 38);
            this.pnlDividerPhoto.Name = "pnlDividerPhoto";
            this.pnlDividerPhoto.Size = new System.Drawing.Size(210, 1);
            this.pnlDividerPhoto.TabIndex = 105;
            // 
            // picEmployee
            // 
            this.picEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.picEmployee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picEmployee.Location = new System.Drawing.Point(420, 52);
            this.picEmployee.Name = "picEmployee";
            this.picEmployee.Size = new System.Drawing.Size(210, 230);
            this.picEmployee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picEmployee.TabIndex = 18;
            this.picEmployee.TabStop = false;
            // 
            // btnChoosePicture
            // 
            this.btnChoosePicture.BackColor = System.Drawing.Color.White;
            this.btnChoosePicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChoosePicture.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.btnChoosePicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChoosePicture.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnChoosePicture.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.btnChoosePicture.Location = new System.Drawing.Point(420, 290);
            this.btnChoosePicture.Name = "btnChoosePicture";
            this.btnChoosePicture.Size = new System.Drawing.Size(210, 32);
            this.btnChoosePicture.TabIndex = 19;
            this.btnChoosePicture.Text = "CHOOSE PHOTO";
            this.btnChoosePicture.UseVisualStyleBackColor = false;
            this.btnChoosePicture.Click += new System.EventHandler(this.btnChoosePicture_Click);
            // 
            // lblPhotoHint
            // 
            this.lblPhotoHint.AutoSize = true;
            this.lblPhotoHint.Font = new System.Drawing.Font("Calibri", 8.25F);
            this.lblPhotoHint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.lblPhotoHint.Location = new System.Drawing.Point(420, 328);
            this.lblPhotoHint.Name = "lblPhotoHint";
            this.lblPhotoHint.Size = new System.Drawing.Size(92, 13);
            this.lblPhotoHint.TabIndex = 106;
            this.lblPhotoHint.Text = "JPG or PNG format";
            // 
            // lblHint
            // 
            this.lblHint.AutoSize = true;
            this.lblHint.Font = new System.Drawing.Font("Calibri", 8.25F);
            this.lblHint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.lblHint.Location = new System.Drawing.Point(24, 556);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(0, 13);
            this.lblHint.TabIndex = 20;
            this.lblHint.Visible = false;
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.pnlFooter.Controls.Add(this.btnUpdate);
            this.pnlFooter.Controls.Add(this.btnSave);
            this.pnlFooter.Controls.Add(this.btnCancel);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(24, 497);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Padding = new System.Windows.Forms.Padding(24, 14, 24, 14);
            this.pnlFooter.Size = new System.Drawing.Size(606, 60);
            this.pnlFooter.TabIndex = 21;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(412, 17);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(90, 32);
            this.btnUpdate.TabIndex = 23;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(313, 17);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 32);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(212)))), ((int)(((byte)(216)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancel.Location = new System.Drawing.Point(509, 17);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 32);
            this.btnCancel.TabIndex = 24;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // frmAddEditEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(654, 637);
            this.ControlBox = false;
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlAccent);
            this.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmAddEditEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAddEditEmployee_FormClosed);
            this.Load += new System.EventHandler(this.frmAddEditEmployee_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlBody.ResumeLayout(false);
            this.pnlBody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEmployee)).EndInit();
            this.pnlFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAccent;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlBody;

        private System.Windows.Forms.Label lblPersonalInfoHeader;
        private System.Windows.Forms.Panel pnlDividerPersonal;
        private System.Windows.Forms.Label lblTagCaption;
        private System.Windows.Forms.TextBox txtEmployeeTag;
        private System.Windows.Forms.Label lblLastNameCaption;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblFirstNameCaption;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblMiddleNameCaption;
        private System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.Label lblSuffixCaption;
        private System.Windows.Forms.TextBox txtSuffix;

        private System.Windows.Forms.Label lblEmploymentHeader;
        private System.Windows.Forms.Panel pnlDividerEmployment;
        private System.Windows.Forms.Label lblDepartmentCaption;
        private System.Windows.Forms.ComboBox cboDepartment;
        private System.Windows.Forms.Button btnAddDepartment;
        private System.Windows.Forms.Label lblPositionCaption;
        private System.Windows.Forms.ComboBox cboPosition;
        private System.Windows.Forms.Button btnPosition;
        private System.Windows.Forms.Label lblStatusCaption;
        private System.Windows.Forms.ComboBox cboStatus;

        private System.Windows.Forms.Label lblPhotoCaption;
        private System.Windows.Forms.Panel pnlDividerPhoto;
        private System.Windows.Forms.PictureBox picEmployee;
        private System.Windows.Forms.Button btnChoosePicture;
        private System.Windows.Forms.Label lblPhotoHint;

        private System.Windows.Forms.Label lblHint;

        private System.Windows.Forms.Panel pnlFooter;
        public System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.Button btnCancel;
    }
}