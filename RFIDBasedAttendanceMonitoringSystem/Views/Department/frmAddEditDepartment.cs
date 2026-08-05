using RFIDBasedAttendanceMonitoringSystem.Controllers;
using RFIDBasedAttendanceMonitoringSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RFIDBasedAttendanceMonitoringSystem.VIews.Department
{
    public partial class frmAddEditDepartment : Form
    {
        private readonly AppController _controller;
        private readonly frmDepartment _frmDepartment;
       
      
        public string isAction = string.Empty;
        private int _editId = 0;
  
        public frmAddEditDepartment(AppController controller, frmDepartment frmDepartment)
        {
            InitializeComponent();
            this._controller = controller;
            this._frmDepartment = frmDepartment;
        }

        private void frmAddEditDepartment_Load(object sender, EventArgs e)
        {
            bool isUpdate = isAction == "update";
           
            btnSave.Enabled = !isUpdate;
            btnUpdate.Enabled = isUpdate;
            lblTitle.Text = isUpdate ? "EDIT DEPARTMENT" : "DEPARTMENT DETAILS";
        }

        public void LoadDepartment(Models.Department department)
        {
            _editId = department.Id;
            txtDepartment.Text = department.DepartmentName;
        }

     
    
        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtDepartment.Text))
            {
                MessageBox.Show("Department name is required.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDepartment.Focus();
                return false;
            }
            return true;
        }

        public void Save()
        {
            if (!ValidateInput()) return;
            try
            {
                Models.Department department = new Models.Department()
                {
                    DepartmentName = txtDepartment.Text.Trim().ToUpper()
                };

                if (isAction == "save")
                {
                    department.CreatedAt = DateTime.UtcNow;

                    _controller.Department.Add(department);
                    MessageBox.Show("Department saved successfully.", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    _frmDepartment?.LoadRecords();
                }
                if (isAction == "update")
                {
                    if (department == null) return;

                    department.Id = _editId;
                  
                    _controller.Department.Update(department);

                    MessageBox.Show("Department updated successfully.", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    _frmDepartment?.LoadRecords();
                }

             
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to save department: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            isAction = "save"; 
            Save();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            isAction = "update";
            Save();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
