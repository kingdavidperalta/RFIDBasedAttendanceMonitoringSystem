using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RFIDBasedAttendanceMonitoringSystem.Shared
{
    public class PagedListForm : Form
    {
        protected int _currentPage = 1;
        protected int _pageSize = 15;

        protected int CalculatePageSize(DataGridView dgv)
        {
            int headerHeight = dgv.ColumnHeadersVisible ? dgv.ColumnHeadersHeight : 0;
            int availableHeight = dgv.ClientSize.Height - headerHeight;
            int rowHeight = dgv.RowTemplate.Height > 0 ? dgv.RowTemplate.Height : 35;

            int calculated = availableHeight / rowHeight;

            return calculated < 1 ? 1 : calculated;
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // PagedListForm
            // 
            this.ClientSize = new System.Drawing.Size(242, 88);
            this.Name = "PagedListForm";
            this.ResumeLayout(false);

        }
    }
}
