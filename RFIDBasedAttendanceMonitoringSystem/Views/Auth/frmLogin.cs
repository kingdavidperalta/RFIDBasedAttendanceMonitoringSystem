using RFIDBasedAttendanceMonitoringSystem.Controllers;
using RFIDBasedAttendanceMonitoringSystem.Models;
using RFIDBasedAttendanceMonitoringSystem.VIews.Attendance;
using RFIDBasedAttendanceMonitoringSystem.VIews.Main;
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
    public partial class frmLogin : Form
    {
        private readonly AppController _controller;
        public frmLogin(AppController controller)
        {
            InitializeComponent();
            this._controller = controller;
        }

        public void ClearFields()
        {
            txtUsername.Clear();
            txtPassword.Clear();
            lblError.Text = "";
            txtUsername.Focus();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            lblError.Text = "";

            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                lblError.Text = "Please enter both username and password.";
                return;
            }

            try
            {
                User user = _controller.User.Authenticate(username, password);

                if (user == null)
                {
                    lblError.Text = "Invalid username or password.";
                    return;
                }

                CurrentSession.SignIn(user);
                this.Hide();

                if (user.Role.ToLower() == "system administrator")
                {
                    frmMain frm = new frmMain(_controller, this);
                    frm.Show();
                    ClearFields();
                }
               
                else
                {
                    lblError.Text = "Your account role is not recognized. Contact an administrator.";
                    this.Show();
                }

            }
            catch (Exception ex)
            {
                lblError.Text = "Login failed: " + ex.Message;
            }
        }

        private void lnkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (frmRegister frm = new frmRegister(_controller))
            {
                frm.ShowDialog();
            }
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnLogin_Click(sender, e);
        }

        private void lnkRfid_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _controller.Attendance.SeedForToday();
            frmRecordScan frm = new frmRecordScan(_controller);
            frm.ShowDialog();
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
