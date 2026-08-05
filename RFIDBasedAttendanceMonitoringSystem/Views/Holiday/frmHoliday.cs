using RFIDBasedAttendanceMonitoringSystem.Controllers;
using RFIDBasedAttendanceMonitoringSystem.Models;
using RFIDBasedAttendanceMonitoringSystem.Shared;
using System;
using System.Windows.Forms;

namespace RFIDBasedAttendanceMonitoringSystem.Views.Holiday
{
    public partial class frmHoliday : PagedListForm
    {
        private readonly AppController _controller;
        public frmHoliday(AppController controller)
        {
            InitializeComponent();
            this._controller = controller;
        }
        public void LoadRecords()
        {
            PagedResult<Models.Holiday> result = _controller.Holiday.GetAll(_currentPage, _pageSize, txtSearch.Text);
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

 
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            _currentPage = 1;
            LoadRecords();
        }  
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            frmAddEditHoliday frm = new frmAddEditHoliday(_controller, this);

            frm.ShowDialog();
        }

        private void dgv1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string colName = dgv1.Columns[e.ColumnIndex].Name;
            Models.Holiday holiday = (Models.Holiday)dgv1.Rows[e.RowIndex].DataBoundItem;

            if (colName == "btnEdit")
            {
                frmAddEditHoliday frm = new frmAddEditHoliday(_controller, this);
                frm.isAction = "update";
                frm.LoadHoliday(holiday);
                frm.Show();
            }
            if (colName == "btnDel")
            {
                if (MessageBox.Show("Are you sure you want to delete this row?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    _controller.Holiday.Delete(holiday.Id);
                    LoadRecords();
                    _currentPage = 1;
                }
            }
        }

        private void btnPrev_Click_1(object sender, EventArgs e)
        {

            _currentPage--;
            LoadRecords();
        }

        private void btnNext_Click_1(object sender, EventArgs e)
        {
            _currentPage++;
            LoadRecords();
        }

        private void frmHoliday_Load_1(object sender, EventArgs e)
        {
            LoadRecords();
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            LoadRecords();
        }
    }
}