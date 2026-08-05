using RFIDBasedAttendanceMonitoringSystem.Controllers;
using RFIDBasedAttendanceMonitoringSystem.Shared;
using RFIDBasedAttendanceMonitoringSystem.VIews.Department;
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
    public partial class frmPosition : PagedListForm
    {
        private readonly AppController _controller;
        public frmPosition(AppController controller)
        {
            InitializeComponent();
            this._controller = controller;
        }

        public void LoadRecords()
        {
            PagedResult<Models.Position> result = _controller.Position.GetAll(_currentPage, _pageSize, txtSearch.Text);
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

        private void frmPosition_Load(object sender, EventArgs e)
        {
            LoadRecords();
        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string colName = dgv1.Columns[e.ColumnIndex].Name;
            Models.Position position = (Models.Position)dgv1.Rows[e.RowIndex].DataBoundItem;

            if (colName == "btnEdit")
            {
                frmAddEditPosition frm = new frmAddEditPosition(_controller, this);
               
                frm.LoadPosition(position);
                frm.Show();
            }
            if (colName == "btnDel")
            {
                if (MessageBox.Show("Are you sure you want to delete this row?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    _controller.Position.Delete(position.Id);
                    LoadRecords();
                    _currentPage = 1;
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddEditPosition frm = new frmAddEditPosition(_controller, this);
            
            frm.Show();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
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
    }
}
