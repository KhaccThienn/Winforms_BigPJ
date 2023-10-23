using BigPJV2.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BigPJV2.Forms
{
    public partial class FrmEmployee : Form
    {
        EmplManagementEntities empl = new EmplManagementEntities();

        DataValidator dataValidator = new DataValidator();

        public Account sign_account = null;


        public bool IsOpened { get; set; } = false;
        public FrmEmployee()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;

            dgvEmployees.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void FrmEmployee_Load(object sender, EventArgs e)
        {
            FetchingDepsData();
            FetchingLevelsData();
            FetchingEmpData();

            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            btnGenerate.Enabled = false;


        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            FetchingDepsData();
            FetchingLevelsData();
            FetchingEmpData();

            ClearForms();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (dataValidator.IsEmpty(txtName.Text))
            {
                MessageBox.Show("Name field is required", "System Notify", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Select();
                return;
            }

            if (dataValidator.IsEmpty(txtEmail.Text))
            {
                MessageBox.Show("Email field is required", "System Notify", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Select();
                return;
            }

            if (!dataValidator.IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Invalid Email Address", "System Notify", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Select();
                return;
            }

            if (dataValidator.IsEmpty(txtPhone.Text))
            {
                MessageBox.Show("Phone field is required", "System Notify", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Select();
                return;
            }

            if (dataValidator.IsEmpty(txtAddress.Text))
            {
                MessageBox.Show("Address field is required", "System Notify", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Select();
                return;
            }

            var emp = new Employee();

            emp.Name = txtName.Text;
            emp.Email = txtEmail.Text;
            emp.Phone = txtPhone.Text;
            emp.Address = txtAddress.Text;
            emp.Gender = chkMale.Checked;
            emp.BirthDay = txtBirthday.Value;
            emp.LevelId = (int)cboLevels.SelectedValue;
            emp.DepartmentId = (int)cboLevels.SelectedValue;

            empl.Employees.Add(emp);
            empl.SaveChanges();

            MessageBox.Show("Add Data Success !", "System Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);

            FetchingEmpData();

            ClearForms();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var emp = empl.Employees.FirstOrDefault(x => x.Id.ToString() == txtId.Text);
            if (emp != null)
            {
                if (dataValidator.IsEmpty(txtName.Text))
                {
                    MessageBox.Show("Name field is required", "System Notify", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtName.Select();
                    return;
                }

                if (dataValidator.IsEmpty(txtEmail.Text))
                {
                    MessageBox.Show("Email field is required", "System Notify", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtName.Select();
                    return;
                }

                if (!dataValidator.IsValidEmail(txtEmail.Text))
                {
                    MessageBox.Show("Invalid Email Address", "System Notify", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtName.Select();
                    return;
                }

                if (dataValidator.IsEmpty(txtPhone.Text))
                {
                    MessageBox.Show("Phone field is required", "System Notify", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtName.Select();
                    return;
                }

                if (dataValidator.IsEmpty(txtAddress.Text))
                {
                    MessageBox.Show("Address field is required", "System Notify", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtName.Select();
                    return;
                }


                emp.Name = txtName.Text;
                emp.Email = txtEmail.Text;
                emp.Phone = txtPhone.Text;
                emp.Address = txtAddress.Text;
                emp.Gender = chkMale.Checked;
                emp.BirthDay = txtBirthday.Value;
                emp.LevelId = (int)cboLevels.SelectedValue;
                emp.DepartmentId = (int)cboLevels.SelectedValue;

                MessageBox.Show("Update Data Success !", "System Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);


                empl.SaveChanges();

                FetchingEmpData();
                ClearForms();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var dialogResult = MessageBox.Show("Do you wanna delete this item ?", "System Notify", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                var employee = empl.Employees.FirstOrDefault(x => x.Id.ToString() == txtId.Text);
                if (employee != null)
                {

                    if (employee.Timesheets.Count > 0)
                    {
                        foreach (var timesheet in employee.Timesheets)
                        {
                            empl.Timesheets.Remove(timesheet);
                        }
                    }

                    empl.Employees.Remove(employee);

                    empl.SaveChanges();

                    MessageBox.Show("Delete Data Success !", "System Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    FetchingEmpData();
                    ClearForms();
                }
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearForms();
            btnAdd.Enabled = true;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            if (dataValidator.IsEmpty(txtSearch.Text))
            {
                MessageBox.Show("Search field is required", "System Notify", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSearch.Select();
                return;
            }
            else
            {
                dgvEmployees.DataSource = null;
                var employess = from emp in empl.Employees
                                where emp.Name.Contains(txtSearch.Text)
                                select new
                                {
                                    Id = emp.Id,
                                    Name = emp.Name,
                                    Email = emp.Email,
                                    Phone = emp.Phone,
                                    Address = emp.Address,
                                    Gender = emp.Gender == true ? "Male" : "Female",
                                    Birthday = emp.BirthDay,
                                    Level = emp.Level.Name,
                                    Department = emp.Department.Name
                                };
                dgvEmployees.DataSource = employess.ToList();
            }


        }

        private void dgvEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvEmployees.CurrentRow != null)
            {
                DataGridViewRow row = dgvEmployees.CurrentRow;

                var id = row.Cells[0].Value.ToString();

                var employee = empl.Employees.FirstOrDefault(x => x.Id.ToString() == id);

                if (employee != null)
                {
                    txtId.Text = row.Cells[0].Value.ToString();
                    txtName.Text = row.Cells[1].Value.ToString();
                    txtEmail.Text = row.Cells[2].Value.ToString();
                    txtPhone.Text = row.Cells[3].Value.ToString();
                    txtAddress.Text = row.Cells[4].Value.ToString();
                    chkMale.Checked = row.Cells[5].Value.ToString() == "Male" ? true : false;
                    txtBirthday.Value = (DateTime)row.Cells[6].Value;
                    cboLevels.SelectedValue = employee.LevelId;
                    cboDepartments.SelectedValue = employee.DepartmentId;
                }

                btnAdd.Enabled = false;
                btnDelete.Enabled = true;
                btnUpdate.Enabled = true;
                btnGenerate.Enabled = true;

            }
        }

        private void FetchingEmpData()
        {
            var employess = from emp in empl.Employees
                            select new
                            {
                                Id = emp.Id,
                                Name = emp.Name,
                                Email = emp.Email,
                                Phone = emp.Phone,
                                Address = emp.Address,
                                Gender = emp.Gender == true ? "Male" : "Female",
                                Birthday = emp.BirthDay,
                                Level = emp.Level.Name,
                                Department = emp.Department.Name
                            };
            dgvEmployees.DataSource = employess.ToList();
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

        private void ClearForms()
        {
            txtId.Text = txtName.Text = txtEmail.Text = txtPhone.Text = txtAddress.Text = txtSearch.Text = string.Empty;
            chkMale.Checked = false;
            txtBirthday.Value = DateTime.Now;

            cboLevels.SelectedItem = cboLevels.Items[0];
            cboDepartments.SelectedItem = cboDepartments.Items[0];
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (dgvEmployees.CurrentRow != null)
            {
                DataGridViewRow row = dgvEmployees.CurrentRow;

                var id = row.Cells[0].Value.ToString();

                var employee = empl.Employees.FirstOrDefault(x => x.Id.ToString() == id);

                if (employee != null)
                {
                    FrmGenerateQR frm = new FrmGenerateQR();
                    frm.emp = employee;
                    if (!frm.IsOpened)
                    {
                        frm.Show();
                    }
                }
            }
        }
    }
}
