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
    public partial class FrmRoles : Form
    {
        EmplManagementEntities empl = new EmplManagementEntities();
        public bool IsOpened { get; set; } = false;
        public FrmRoles()
        {
            InitializeComponent();

            dgvRoles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            
        }
        private void FrmRoles_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;

            FetchingAllData();
            ClearForms();
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

            var role = new Role();

            role.Name = txtName.Text;

            empl.Roles.Add(role);

            empl.SaveChanges();

            MessageBox.Show("Add Data Success !", "System Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);

            FetchingAllData();
            ClearForms();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            FetchingAllData();
            ClearForms();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var emp = empl.Roles.FirstOrDefault(x => x.Id.ToString() == txtId.Text);

            if (emp != null)
            {
                emp.Name = txtName.Text;
                empl.SaveChanges();

                MessageBox.Show("Update Data Success !", "System Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);

                FetchingAllData();
                ClearForms();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvRoles.CurrentRow != null)
            {
                var dialogResult = MessageBox.Show("Do you wanna delete this item ?", "System Notify", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    var emp = empl.Roles.FirstOrDefault(x => x.Id.ToString() == txtId.Text);

                    if (emp != null)
                    {
                        if (emp.Accounts.Count > 0)
                        {
                            MessageBox.Show("Cannot delete this item !", "System Notify", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        } else
                        {
                            empl.Roles.Remove(emp);

                            empl.SaveChanges();

                            MessageBox.Show("Delete Data Success !", "System Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            FetchingAllData();
                            ClearForms();
                        }
                    }
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvRoles.DataSource = null;

            if (string.IsNullOrEmpty(txtSearch.Text))
            {
                MessageBox.Show("Search field is required", "System Notify", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSearch.Select();
                return;
            }

            var roles = from role in empl.Roles
                        where role.Name.Contains(txtSearch.Text)
                        select new
                        {
                            Id = role.Id,
                            Name = role.Name
                        };
            dgvRoles.DataSource = roles.ToList();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearForms();
            btnAdd.Enabled = true;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
        }

        private void FetchingAllData()
        {
            var roles = from role in empl.Roles
                        select new
                        {
                            Id = role.Id,
                            Name = role.Name
                        };
            dgvRoles.DataSource = roles.ToList();
        }

        private void ClearForms()
        {
            txtId.Text = txtName.Text = txtSearch.Text = string.Empty;
        }

        private void dgvRoles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvRoles.CurrentRow != null)
            {
                DataGridViewRow row = dgvRoles.CurrentRow;

                txtId.Text = row.Cells[0].Value.ToString();
                txtName.Text = row.Cells[1].Value.ToString();

                btnAdd.Enabled = false;
                btnDelete.Enabled = true;
                btnUpdate.Enabled = true;
            }
        }

        
    }
}
