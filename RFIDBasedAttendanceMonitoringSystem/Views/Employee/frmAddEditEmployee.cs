using RFIDBasedAttendanceMonitoringSystem.Controllers;
using RFIDBasedAttendanceMonitoringSystem.VIews.Department;
using RFIDBasedAttendanceMonitoringSystem.VIews.Position;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace RFIDBasedAttendanceMonitoringSystem.VIews.Employee
{
    public partial class frmAddEditEmployee : Form
    {
        private readonly AppController _controller;
        private readonly frmEmployee _frm;

        private int _editId = 0;
        public string isAction = string.Empty;

        private Models.EmployeeStatus _pendingStatus;
        private string _pendingDepartmentName;
        private string _pendingPositionName;

        private string _pendingPhotoPath;
        private string _selectedPhotoFullPath;

        public frmAddEditEmployee(AppController controller, frmEmployee frm)
        {
            InitializeComponent();
            this._controller = controller;
            this._frm = frm;
        }

        public void LoadDepartment()
        {
            cboDepartment.DataSource = _controller.Employee.GetDepartments();
            cboDepartment.DisplayMember = "DepartmentName";
            cboDepartment.ValueMember = "Id";

            if (isAction == "update")
            {
                cboDepartment.Text = _pendingDepartmentName;
            }
            else
            {
                cboDepartment.SelectedIndex = -1;
            }
        }

        public void LoadPosition()
        {
            cboPosition.DataSource = _controller.Employee.GetPositions();
            cboPosition.DisplayMember = "PositionName";
            cboPosition.ValueMember = "Id";

            if (isAction == "update")
            {
                cboPosition.Text = _pendingPositionName;
            }
            else
            {
                cboPosition.SelectedIndex = -1;
            }
        }

        public void LoadStatus()
        {
            cboStatus.DataSource = Enum.GetValues(typeof(Models.EmployeeStatus));
        }

        public void LoadEmployee(Models.Employee employee)
        {
            _editId = employee.Id;
            txtEmployeeTag.Text = employee.EmployeeTag;
            txtLastName.Text = employee.LastName;
            txtFirstName.Text = employee.FirstName;
            txtMiddleName.Text = employee.MiddleName;
            txtSuffix.Text = employee.Suffix;
            _pendingDepartmentName = employee.DepartmentName;
            _pendingPositionName = employee.PositionName;
            _pendingStatus = employee.Status;
            _pendingPhotoPath = employee.PhotoPath;
        }

        public void Save()
        {
            if (string.IsNullOrWhiteSpace(txtEmployeeTag.Text) ||
                string.IsNullOrWhiteSpace(txtLastName.Text) ||
                string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                string.IsNullOrWhiteSpace(cboDepartment.Text) ||
                string.IsNullOrWhiteSpace(cboPosition.Text))
            {
                MessageBox.Show("Please fill in the empty fields.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            string trimmedTag = txtEmployeeTag.Text.Trim().ToUpper();
            int? excludeId = isAction == "update" ? _editId : (int?)null;

            if (_controller.Employee.Exists(trimmedTag, excludeId))
            {
                MessageBox.Show("A category with this name already exists.", "Duplicate Entry",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmployeeTag.Focus();
                return;
            }

            try
            {
                string photoPath = _pendingPhotoPath;

                if (!string.IsNullOrEmpty(_selectedPhotoFullPath))
                {
                    string photosDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Photos");
                    Directory.CreateDirectory(photosDir);

                    string fileName = $"{txtEmployeeTag.Text.Trim()}{Path.GetExtension(_selectedPhotoFullPath)}";
                    string destPath = Path.Combine(photosDir, fileName);

                    File.Copy(_selectedPhotoFullPath, destPath, overwrite: true);
                    photoPath = Path.Combine("Photos", fileName);
                }

                Models.Employee employee = new Models.Employee
                {
                    Id = _editId,
                    EmployeeTag = txtEmployeeTag.Text.Trim(),
                    LastName = txtLastName.Text.Trim().ToUpper(),
                    FirstName = txtFirstName.Text.Trim().ToUpper(),
                    MiddleName = txtMiddleName.Text.Trim().ToUpper(),
                    Suffix = txtSuffix.Text.Trim(),
                    DepartmentId = Convert.ToInt32(cboDepartment.SelectedValue),
                    PositionId = Convert.ToInt32(cboPosition.SelectedValue),
                    Status = (Models.EmployeeStatus)cboStatus.SelectedItem,
                    PhotoPath = photoPath
                };

                if (isAction == "save")
                {
                    employee.CreatedAt = DateTime.UtcNow;
                    _controller.Employee.Add(employee);
                }
                else if (isAction == "update")
                {
                    employee.Id = _editId;
                    _controller.Employee.Update(employee);
                }

                _frm.LoadActiveRecords();
                _frm.LoadArchivedRecords();
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            isAction = "update";
            Save();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            isAction = "save";
            Save();
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cboDepartment_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnAddDepartment_Click(object sender, EventArgs e)
        {
            frmAddEditDepartment frm = new frmAddEditDepartment(_controller, null);
            frm.btnUpdate.Enabled = false;
            frm.btnSave.Enabled = true;

            frm.ShowDialog();

            LoadDepartment();
        }

        private void btnPosition_Click(object sender, EventArgs e)
        {
            frmAddEditPosition frm = new frmAddEditPosition(_controller, null);
            frm.btnUpdate.Enabled = false;
            frm.btnSave.Enabled = true;

            frm.ShowDialog();

            LoadPosition();
        }

        private void frmAddEditEmployee_Load(object sender, EventArgs e)
        {
            LoadDepartment();
            LoadPosition();
            LoadStatus();

            if (isAction == "update")
            {
                cboStatus.SelectedItem = _pendingStatus;

                if (!string.IsNullOrEmpty(_pendingPhotoPath))
                {
                    string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, _pendingPhotoPath);
                    if (File.Exists(fullPath))
                    {
                      
                        byte[] imageBytes = File.ReadAllBytes(fullPath);
                        using (var ms = new MemoryStream(imageBytes))
                        using (var loadedImage = Image.FromStream(ms))
                        {
                            picEmployee.Image = new Bitmap(loadedImage);
                        }
                    }
                }
            }
        }

        private void btnChoosePicture_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Filter = "Image Files|*.jpg;*.jpeg;*.png";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    _selectedPhotoFullPath = dlg.FileName;

                   
                    byte[] imageBytes = File.ReadAllBytes(dlg.FileName);
                    using (var ms = new MemoryStream(imageBytes))
                    using (var loadedImage = Image.FromStream(ms))
                    {
                        picEmployee.Image?.Dispose();
                        picEmployee.Image = new Bitmap(loadedImage);
                    }
                }
            }
        }

        private void frmAddEditEmployee_FormClosed(object sender, FormClosedEventArgs e)
        {
          
            picEmployee.Image?.Dispose();
        }

        private void txtEmployeeTag_Leave(object sender, EventArgs e)
        {

            string trimmedTag = txtEmployeeTag.Text.Trim().ToUpper();
            int? excludeId = isAction == "update" ? _editId : (int?)null;

            if (_controller.Employee.Exists(trimmedTag, excludeId))
            {
                MessageBox.Show("A employee with this tag already exists.", "Duplicate Entry",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmployeeTag.Focus();
                txtEmployeeTag.Clear();
                return;
            }
        }
    }
}