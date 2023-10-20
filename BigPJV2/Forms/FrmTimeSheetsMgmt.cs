using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BigPJV2.Forms
{
    public partial class FrmTimeSheetsMgmt : Form
    {
        EmplManagementEntities empl = new EmplManagementEntities();
        public bool IsOpened { get; set; } = false;
        public FrmTimeSheetsMgmt()
        {
            InitializeComponent();
        }

        private void FrmTimeSheetsMgmt_Load(object sender, EventArgs e)
        {
            FetchingAllData();
        }

        private void FetchingAllData()
        {
            var timesheets = from ts in empl.Timesheets
                             select new
                             {
                                 Id = ts.Id,
                                 Employee = ts.Employee.Name,
                                 Department = ts.Employee.Department.Name,
                                 Level = ts.Employee.Level.Name,
                                 AttendanceDate = ts.AttendanceDate,
                                 Status = ts.Value == 0 ? "Working" : "Completed"
                             };
            dgvTimeSheets.DataSource = timesheets.ToList();
        }

        private void btnFetch_Click(object sender, EventArgs e)
        {

            if (txtStart.Value > txtEnd.Value || txtStart.Value.ToShortDateString() == txtEnd.Value.ToShortDateString())
            {
                MessageBox.Show("Invalid Date Range !", "System Notify", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                dgvTimeSheets.DataSource = null;
                var timesheets = from ts in empl.Timesheets
                                 where ts.AttendanceDate >= txtStart.Value
                                 && ts.AttendanceDate <= txtEnd.Value
                                 select new
                                 {
                                     Id = ts.Id,
                                     Employee = ts.Employee.Name,
                                     Department = ts.Employee.Department.Name,
                                     Level = ts.Employee.Level.Name,
                                     AttendanceDate = ts.AttendanceDate,
                                     Status = ts.Value == 0 ? "Working" : "Completed"
                                 };
                dgvTimeSheets.DataSource = timesheets.ToList();
            }


        }
    }
}
