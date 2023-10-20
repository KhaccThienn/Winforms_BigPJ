using BigPJV2.Helpers;
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
    public partial class FrmTimeSheets : Form
    {
        EmplManagementEntities empl = new EmplManagementEntities();
        public bool IsOpened { get; set; } = false;

        DataValidator dataValidate = new DataValidator();

        public Account SignedInAccount = null;

        public FrmTimeSheets()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            dgvEmployee.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        private void FrmTimeSheets_Load(object sender, EventArgs e)
        {
            FetchingAllData();
            FetchingDepsData();
            FetchingLevelsData();
        }
        private void FetchingDepsData()
        {
            var deps = from dep in empl.Departments
                       select new
                       {
                           DepId = dep.Id,
                           DepName = dep.Name,
                       };
            cboDepartments.DataSource = deps.ToList();

            cboDepartments.DisplayMember = "DepName";
            cboDepartments.ValueMember = "DepId";

        }
        private void FetchingLevelsData()
        {
            var levels = from level in empl.Levels
                         select new
                         {
                             Id = level.Id,
                             Name = level.Name,
                         };
            cboLevels.DataSource = levels.ToList();

            cboLevels.DisplayMember = "Name";
            cboLevels.ValueMember = "Id";
        }


        private void btnFetch_Click(object sender, EventArgs e)
        {
            dgvEmployee.DataSource = null;
            var depId = (int)cboDepartments.SelectedValue;
            var levelId = (int)cboLevels.SelectedValue;

            var employees = from emp in empl.Employees
                            where emp.DepartmentId == depId
                            && emp.LevelId == levelId
                            select new
                            {
                                Id = emp.Id,
                                Name = emp.Name,
                                Email = emp.Email,
                                Phone = emp.Phone,
                                Address = emp.Address,
                                Gender = emp.Gender == true ? "Male" : "Female",
                                Birthday = emp.BirthDay,
                                Depart = emp.Department.Name,
                                Level = emp.Level.Name
                            };
            dgvEmployee.DataSource = employees.ToList();
        }

        private void dgvEmployee_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvEmployee.CurrentRow != null)
            {
                DataGridViewRow row = dgvEmployee.CurrentRow;

                var result = MessageBox.Show("Are you sure you want to check attendance for this employee ?", "System Notify", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                
                if (result == DialogResult.Yes)
                {
                    var id = row.Cells[0].Value.ToString();

                    var employee = empl.Employees.FirstOrDefault(x => x.Id.ToString() == id);

                    var ts = employee.Timesheets.Where(
                        x => x.EmployeeId.ToString() == id
                        && DateTime.Now.ToShortDateString().ToString() == x.AttendanceDate.ToShortDateString().ToString()
                        && x.Value == 1
                    ).FirstOrDefault();

                    if (ts != null)
                    {
                        MessageBox.Show("This employee attended today !", "System Notify", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (employee != null)
                    {
                        FrmAttendance frm = new FrmAttendance();
                        frm.employee = employee;
                        frm.dateAttendance = txtAttendanceDate.Value;
                        frm.ShowDialog();
                    }
                }
            }
        }

        private void FetchingAllData ()
        {
            var employees = from emp in empl.Employees
                            select new
                            {
                                Id = emp.Id,
                                Name = emp.Name,
                                Email = emp.Email,
                                Phone = emp.Phone,
                                Address = emp.Address,
                                Gender = emp.Gender == true ? "Male" : "Female",
                                Birthday = emp.BirthDay,
                                Depart = emp.Department.Name,
                                Level = emp.Level.Name
                            };
            dgvEmployee.DataSource = employees.ToList();
        }

        private void btnFetchAll_Click(object sender, EventArgs e)
        {
            FetchingAllData();
            cboDepartments.SelectedItem = cboDepartments.Items[0];
            cboLevels.SelectedItem = cboLevels.Items[0];
        }
    }
}
