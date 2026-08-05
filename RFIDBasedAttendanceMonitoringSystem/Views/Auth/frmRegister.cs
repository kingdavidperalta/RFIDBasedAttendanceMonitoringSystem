using RFIDBasedAttendanceMonitoringSystem.Controllers;
using RFIDBasedAttendanceMonitoringSystem.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RFIDBasedAttendanceMonitoringSystem.Views.Auth
{
    public partial class frmRegister : Form
    {
        private readonly AppController _controller;

        public frmRegister(AppController controller)
        {
            InitializeComponent();
            _controller = controller;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            lblError.Text = "";

            string fullName = txtFullName.Text.Trim();
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;
            string role = cboRole.Text.Trim();

            if (string.IsNullOrWhiteSpace(fullName) || string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password))
            {
                lblError.Text = "All fields are required.";
                return;
            }

            if (password.Length < 6)
            {
                lblError.Text = "Password must be at least 6 characters.";
                return;
            }

            if (password != confirmPassword)
            {
                lblError.Text = "Passwords do not match.";
                return;
            }

            try
            {
                if (_controller.User.UsernameExists(username))
                {
                    lblError.Text = "That username is already taken.";
                    return;
                }

                Models.User user = new Models.User()
                {
                    Username = username
                    ,
                    FullName = fullName
                    ,
                    PasswordHash = PasswordHelper.Hash(password)
                    ,
                    Role = role
                    ,
                    CreatedAt = DateTime.UtcNow
                };

                _controller.User.Register(user);

                MessageBox.Show("Account created. You can now log in.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                lblError.Text = "Registration failed: " + ex.Message;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cboRole_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
