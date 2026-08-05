using RFIDBasedAttendanceMonitoringSystem.Controllers;
using RFIDBasedAttendanceMonitoringSystem.Models;
using System;
using System.Windows.Forms;

namespace RFIDBasedAttendanceMonitoringSystem.Views.ShiftSchedule
{
    public partial class frmShiftSchedule : Form
    {
        private readonly AppController _controller;

        private int _editId = 0;
        public string isAction = string.Empty;

        public frmShiftSchedule(AppController controller)
        {
            InitializeComponent();
            this._controller = controller;
        }

     

        private void LoadCurrentSchedule()
        {
            Models.ShiftSchedule current = _controller.ShiftSchedule.GetCurrent();

            if (current != null)
            {
                isAction = "update";
                _editId = current.Id;

                dtpTimeIn.Value = DateTime.Today.Add(current.TimeInStart);
                dtpTimeOut.Value = DateTime.Today.Add(current.TimeOutEnd);
                numGracePeriod.Value = current.GracePeriodMinutes;

                btnSave.Enabled = false;
                btnUpdate.Enabled = true;
            }
            else
            {
                isAction = "save";
                _editId = 0;

                dtpTimeIn.Value = DateTime.Today.Add(new TimeSpan(8, 0, 0));
                dtpTimeOut.Value = DateTime.Today.Add(new TimeSpan(17, 0, 0));
                numGracePeriod.Value = 0;

                btnSave.Enabled = true;
                btnUpdate.Enabled = false;
            }
        }

        public void Save()
        {
            try
            {
                Models.ShiftSchedule shiftSchedule = new Models.ShiftSchedule
                {
                    Id = _editId,
                    TimeInStart = dtpTimeIn.Value.TimeOfDay,
                    TimeOutEnd = dtpTimeOut.Value.TimeOfDay,
                    GracePeriodMinutes = (int)numGracePeriod.Value
                };

                if (isAction == "save")
                {
                    shiftSchedule.CreatedAt = DateTime.UtcNow;
                    _editId = _controller.ShiftSchedule.Add(shiftSchedule);
                }
                else if (isAction == "update")
                {
                    shiftSchedule.Id = _editId;
                    _controller.ShiftSchedule.Update(shiftSchedule);
                }

                LoadCurrentSchedule();

                MessageBox.Show("Shift schedule saved.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmShiftSchedule_Load(object sender, EventArgs e)
        {
            LoadCurrentSchedule();
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
    }
}