using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BigPJV2.Forms
{
    public partial class FrmDepartment : Form
    {
        EmplManagementEntities empl = new EmplManagementEntities();
        public bool IsOpened { get; set; } = false; 
        public Account account = null;
        public FrmDepartment()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            dgvDeps.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void FrmDepartment_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            button1.Enabled = false;

            FetchingAllData();
            ClearForms();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvDeps.DataSource = null;

            if (string.IsNullOrEmpty(txtSearch.Text))
            {
                MessageBox.Show("Search field is required", "System Notify", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSearch.Select();
                return;
            }

            var deps = from dep in empl.Departments
                       where dep.Name.Contains(txtSearch.Text)
                       select new
                       {
                           Id = dep.Id,
                           Name = dep.Name,
                           NumbersOfEmployee = dep.Employees.Count
                       };
            dgvDeps.DataSource = deps.ToList();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            FetchingAllData();
            ClearForms();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearForms();
            btnAdd.Enabled = true;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            button1.Enabled = false;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvDeps.CurrentRow != null)
            {
                var dialogResult = MessageBox.Show("Do you wanna delete this item ?", "System Notify", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    var deps = empl.Departments.FirstOrDefault(x => x.Id.ToString() == txtId.Text);

                    if (deps != null)
                    {
                        if (deps.Employees.Count > 0)
                        {
                            MessageBox.Show("Cannot delete this item !", "System Notify", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else
                        {
                            empl.Departments.Remove(deps);

                            empl.SaveChanges();

                            MessageBox.Show("Delete Data Success !", "System Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            FetchingAllData();
                            ClearForms();
                        }
                    }
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var deps = empl.Departments.FirstOrDefault(x => x.Id.ToString() == txtId.Text);

            if (deps != null)
            {
                deps.Name = txtName.Text;

                empl.SaveChanges();

                FetchingAllData();
                ClearForms();

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Name field is required", "System Notify", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Select();
                return;
            }

            if (txtName.Text.Length < 3)
            {
                MessageBox.Show("Name field at least 3 characters", "System Notify", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Select();
                return;
            }

            var dep = new Department();

            dep.Name = txtName.Text;

            empl.Departments.Add(dep);

            empl.SaveChanges();

            MessageBox.Show("Add Data Success !", "System Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);

            FetchingAllData();
            ClearForms();

        }

        private void dgvDeps_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDeps.CurrentRow != null)
            {
                DataGridViewRow row = dgvDeps.CurrentRow;

                txtId.Text = row.Cells[0].Value.ToString();
                txtName.Text = row.Cells[1].Value.ToString();

                btnAdd.Enabled = false;
                btnDelete.Enabled = true;
                btnUpdate.Enabled = true;
                button1.Enabled = true;
            }
        }


        private void FetchingAllData()
        {
            var deps = from dep in empl.Departments
                        select new
                        {
                            Id = dep.Id,
                            Name = dep.Name,
                            NumbersOfEmployee = dep.Employees.Count
                        };
            dgvDeps.DataSource = deps.ToList();
        }

        private void ClearForms()
        {
            txtId.Text = txtName.Text = txtSearch.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var deps = empl.Departments.FirstOrDefault(x => x.Id.ToString() == txtId.Text);

            if (deps != null)
            {
                FrmReports frm = new FrmReports();
                frm.dep = deps;
                frm.account = account;
                frm.ReportName = "byDeps";
                if (!frm.IsOpened)
                {
                    frm.Show();
                }

            }
        }
    }
}
