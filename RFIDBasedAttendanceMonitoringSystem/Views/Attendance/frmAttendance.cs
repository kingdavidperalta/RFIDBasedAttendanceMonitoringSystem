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

namespace RFIDBasedAttendanceMonitoringSystem.VIews.Attendance
{
    public partial class frmAttendance : PagedListForm
    {
        private readonly AppController _controller;
        public frmAttendance(AppController controller)
        {
            InitializeComponent();
            this._controller = controller;
        }


        public void LoadAttendance()
        {
            PagedResult<Models.Attendance> result = _controller.Attendance.GetAll(_currentPage, _pageSize, dtpDate.Value, txtSearch.Text);
            dgv1.DataSource = result.Items;

            dgv1.BeginInvoke((MethodInvoker)delegate
            {
                dgv1.ClearSelection();
                dgv1.CurrentCell = null;
            });

            int startRecord = result.TotalCount == 0 ? 0 : ((_currentPage - 1) * _pageSize) + 1;
            int endRecord = startRecord + result.Items.Count - 1;

            lblPageInfo.Text = $"Page {result.PageNumber} of {result.TotalPages} (Showing {startRecord}–{endRecord} of {result.TotalCount} record(s))";

            btnPrev.Enabled = _currentPage > 1;
            btnNext.Enabled = _currentPage < result.TotalPages;
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            _currentPage--;
            LoadAttendance();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            _currentPage++;
            LoadAttendance();
        }

        private void frmAttendance_Load(object sender, EventArgs e)
        {
            LoadAttendance();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnRecordScan_Click(object sender, EventArgs e)
        {
            frmRecordScan frm = new frmRecordScan(_controller);
            frm.ShowDialog();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            LoadAttendance();
        }
    }
}
