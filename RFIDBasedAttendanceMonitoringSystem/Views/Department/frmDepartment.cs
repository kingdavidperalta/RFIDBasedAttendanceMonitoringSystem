using RFIDBasedAttendanceMonitoringSystem.Controllers;
using RFIDBasedAttendanceMonitoringSystem.Models;
using RFIDBasedAttendanceMonitoringSystem.Shared;
using RFIDBasedAttendanceMonitoringSystem.VIews.Department;
using System;
using System.Windows.Forms;

namespace RFIDBasedAttendanceMonitoringSystem.VIews
{
    public partial class frmDepartment : PagedListForm
    {
        private readonly AppController _controller;
        public frmDepartment(AppController controller)
        {
            InitializeComponent();
            this._controller = controller;
        }
        public void LoadRecords()
        {
            PagedResult<Models.Department> result = _controller.Department.GetAll(_currentPage, _pageSize, txtSearch.Text);
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

        private void frmDepartment_Load(object sender, System.EventArgs e)
        {
            LoadRecords();
        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string colName = dgv1.Columns[e.ColumnIndex].Name;
            Models.Department department = (Models.Department)dgv1.Rows[e.RowIndex].DataBoundItem;

            if (colName == "btnEdit")
            {
                frmAddEditDepartment frm = new frmAddEditDepartment(_controller, this);
                
                frm.LoadDepartment(department);
                frm.Show();
            }
            if (colName == "btnDel")
            {
                if (MessageBox.Show("Are you sure you want to delete this row?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    _controller.Department.Delete(department.Id);
                    LoadRecords();
                    _currentPage = 1;
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            _currentPage = 1;
            LoadRecords();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {

            _currentPage--;
            LoadRecords();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            _currentPage++;
            LoadRecords();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddEditDepartment frm = new frmAddEditDepartment(_controller, this);
           
            frm.ShowDialog();
        }
    }
}
