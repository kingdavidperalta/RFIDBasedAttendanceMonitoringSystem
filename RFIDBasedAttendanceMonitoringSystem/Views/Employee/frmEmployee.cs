using RFIDBasedAttendanceMonitoringSystem.Controllers;
using RFIDBasedAttendanceMonitoringSystem.Models;
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

namespace RFIDBasedAttendanceMonitoringSystem.VIews.Employee
{
    public partial class frmEmployee : PagedListForm
    {
        private readonly AppController _controller;
        public frmEmployee(AppController controller)
        {
            InitializeComponent();
            this._controller = controller;
        }

        public void LoadActiveRecords()
        {
            PagedResult<Models.Employee> result = _controller.Employee.GetAll(_currentPage, _pageSize, txtSearch.Text);
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

        private void LoadCurrentTab()
        {
            if (tabControl1.SelectedIndex == 0)
                LoadActiveRecords();
            if (tabControl1.SelectedIndex == 1)
                LoadArchivedRecords();
        }

        public void LoadArchivedRecords()
        {
            PagedResult<Models.Employee> result = _controller.Employee.GetArchived(_currentPage, _pageSize, txtSearch.Text);
            dgv2.DataSource = result.Items;

            dgv2.BeginInvoke((MethodInvoker)delegate
            {
                dgv2.ClearSelection();
                dgv2.CurrentCell = null;
            });

            int startRecord = result.TotalCount == 0 ? 0 : ((_currentPage - 1) * _pageSize) + 1;
            int endRecord = startRecord + result.Items.Count - 1;

            lblPageInfo2.Text = $"Page {result.PageNumber} of {result.TotalPages} (Showing {startRecord}–{endRecord} of {result.TotalCount} record(s))";

            btnPrevArchived.Enabled = _currentPage > 1;
            btnNextArchived.Enabled = _currentPage < result.TotalPages;
        }

        private void frmEmployee_Load(object sender, EventArgs e)
        {
            LoadActiveRecords();
            LoadArchivedRecords();
           
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadCurrentTab();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            _currentPage--;
            LoadCurrentTab();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            _currentPage++;
            LoadCurrentTab();
        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string colName = dgv1.Columns[e.ColumnIndex].Name;
            Models.Employee employee = (Models.Employee)dgv1.Rows[e.RowIndex].DataBoundItem;

            if (colName == "btnEdit")
            {
                frmAddEditEmployee frm = new frmAddEditEmployee(_controller, this);
                frm.isAction = "update";
                frm.btnUpdate.Enabled = true;
                frm.btnSave.Enabled = false;
                frm.LoadEmployee(employee);
                frm.ShowDialog();
            }

            if (colName == "btnDel")
            {

                if (MessageBox.Show("Are you sure you want to delete this row?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    _controller.Employee.Delete(employee.Id);
                    LoadCurrentTab();
                    _currentPage = 1;
                }
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            frmAddEditEmployee frm = new frmAddEditEmployee(_controller, this);
           
            frm.btnUpdate.Enabled = false;
            frm.btnSave.Enabled = true;
            frm.ShowDialog();
        }
    }
}
