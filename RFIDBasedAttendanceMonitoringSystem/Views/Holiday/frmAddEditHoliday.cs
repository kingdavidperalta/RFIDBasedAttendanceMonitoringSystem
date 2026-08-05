using RFIDBasedAttendanceMonitoringSystem.Controllers;
using RFIDBasedAttendanceMonitoringSystem.Models;
using System;
using System.Windows.Forms;

namespace RFIDBasedAttendanceMonitoringSystem.Views.Holiday
{
    public partial class frmAddEditHoliday : Form
    {
        private readonly AppController _controller;
        private readonly frmHoliday _frmHoliday;

        public string isAction = string.Empty;
        private int _editId = 0;

        public frmAddEditHoliday(AppController controller, frmHoliday frmHoliday)
        {
            InitializeComponent();
            this._controller = controller;
            this._frmHoliday = frmHoliday;
        }

        private void frmAddEditHoliday_Load(object sender, EventArgs e)
        {
            bool isUpdate = isAction == "update";

            btnSave.Enabled = !isUpdate;
            btnUpdate.Enabled = isUpdate;
            lblTitle.Text = isUpdate ? "EDIT HOLIDAY" : "HOLIDAY DETAILS";

            if (!isUpdate)
            {
                dtpHolidayDate.Value = DateTime.Today;
            }
        }

        public void LoadHoliday(Models.Holiday holiday)
        {
            _editId = holiday.Id;
            dtpHolidayDate.Value = holiday.HolidayDate;
            txtDescription.Text = holiday.Description;
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                MessageBox.Show("Description is required.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDescription.Focus();
                return false;
            }
            return true;
        }

        public void Save()
        {
            if (!ValidateInput()) return;
            try
            {
                Models.Holiday holiday = new Models.Holiday()
                {
                    HolidayDate = dtpHolidayDate.Value.Date,
                    Description = txtDescription.Text.Trim().ToUpper()
                };

                if (isAction == "save")
                {
                    holiday.CreatedAt = DateTime.UtcNow;

                    _controller.Holiday.Add(holiday);
                    MessageBox.Show("Holiday saved successfully.", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    _frmHoliday?.LoadRecords();
                }
                if (isAction == "update")
                {
                    if (holiday == null) return;

                    holiday.Id = _editId;

                    _controller.Holiday.Update(holiday);

                    MessageBox.Show("Holiday updated successfully.", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    _frmHoliday?.LoadRecords();
                }

                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to save holiday: " + ex.Message, "Error",
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