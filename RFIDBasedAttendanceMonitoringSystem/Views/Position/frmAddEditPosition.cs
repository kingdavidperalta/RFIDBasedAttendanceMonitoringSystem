using RFIDBasedAttendanceMonitoringSystem.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RFIDBasedAttendanceMonitoringSystem.VIews.Position
{
    public partial class frmAddEditPosition : Form
    {
        private readonly AppController _controller;
        private readonly frmPosition _frmPosition;

        public string isAction = string.Empty;
        private int _editId = 0;

        public frmAddEditPosition(AppController controller, frmPosition frmPosition)
        {
            InitializeComponent();
            this._controller = controller;
            this._frmPosition = frmPosition;
        }

        private void frmAddEditPosition_Load(object sender, EventArgs e)
        {
            bool isUpdate = isAction == "update";

            btnSave.Enabled = !isUpdate;
            btnUpdate.Enabled = isUpdate;
            lblTitle.Text = isUpdate ? "EDIT POSITION" : "POSITION DETAILS";
        }

        public void LoadPosition(Models.Position position)
        {
            _editId = position.Id;
            txtPosition.Text = position.PositionName;
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtPosition.Text))
            {
                MessageBox.Show("Position name is required.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPosition.Focus();
                return false;
            }
            return true;
        }

        public void Save()
        {
            if (!ValidateInput()) return;
            try
            {
                Models.Position position = new Models.Position()
                {
                    PositionName = txtPosition.Text.Trim().ToUpper()
                };

                if (isAction == "save")
                {
                    position.CreatedAt = DateTime.UtcNow;

                    _controller.Position.Add(position);
                    MessageBox.Show("Position saved successfully.", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    _frmPosition?.LoadRecords();
                }
                if (isAction == "update")
                {
                    if (position == null) return;

                    position.Id = _editId;

                    _controller.Position.Update(position);

                    MessageBox.Show("Department updated successfully.", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    _frmPosition?.LoadRecords();
                }


                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to save position: " + ex.Message, "Error",
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
