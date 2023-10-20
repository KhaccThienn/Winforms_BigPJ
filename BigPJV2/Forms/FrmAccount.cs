using BigPJV2.Helpers;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BigPJV2.Forms
{
    public partial class FrmAccount : Form
    {
        EmplManagementEntities empl = new EmplManagementEntities();
        public bool IsOpened { get; set; } = false;

        DataValidator dataValidate = new DataValidator();

        public Account SignedInAccount = null;
        public FrmAccount()
        {
            InitializeComponent();

            dgvAccounts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void FrmAccount_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;

            FetchingAllData();
            FetchingEmployees();
            FetchingRoles();
            ClearForms();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var selecting_emp = cboEmployees.SelectedValue.ToString();
            var emp = empl.Employees.Where(x => x.Id.ToString() == selecting_emp).FirstOrDefault();
            if (emp != null)
            {
                if (emp.Accounts.Count > 0)
                {
                    MessageBox.Show("Each employee has only 1 account !", "System Notify", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    if (dataValidate.IsEmpty(txtUsername.Text))
                    {
                        MessageBox.Show("Username is required", "System Notify", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtUsername.Select();
                        return;
                    }
                    if (txtUsername.Text.Length < 6)
                    {
                        MessageBox.Show("Username at least 6 characters", "System Notify", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtUsername.Select();
                        return;
                    }

                    if (dataValidate.IsEmpty(txtPassword.Text))
                    {
                        MessageBox.Show("Password is required", "System Notify", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtPassword.Select();
                        return;
                    }
                    if (txtPassword.Text.Length < 8)
                    {
                        MessageBox.Show("Password at least 8 characters", "System Notify", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtPassword.Select();
                        return;
                    }

                    var acc = new Account();

                    acc.Username = txtUsername.Text;
                    acc.Password = txtPassword.Text;
                    acc.EmpId = (int)cboEmployees.SelectedValue;
                    acc.RoleId = (int)cboRoles.SelectedValue;

                    var result = MessageBox.Show($"Are you sure wanna give employee {emp.Name} an account? ", "System Notify", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        empl.Accounts.Add(acc);

                        empl.SaveChanges();

                        MessageBox.Show("Add Data Success !", "System Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        FetchingAllData();
                    }
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            FetchingAllData();
            FetchingEmployees();
            FetchingRoles();

            ClearForms();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var acc = empl.Accounts.Where(x => x.Id.ToString() == txtId.Text).FirstOrDefault();

            if (acc != null)
            {
                if (dataValidate.IsEmpty(txtUsername.Text))
                {
                    MessageBox.Show("Username is required", "System Notify", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUsername.Select();
                    return;
                }
                if (txtUsername.Text.Length < 6)
                {
                    MessageBox.Show("Username at least 6 characters", "System Notify", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUsername.Select();
                    return;
                }

                if (dataValidate.IsEmpty(txtPassword.Text))
                {
                    MessageBox.Show("Password is required", "System Notify", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPassword.Select();
                    return;
                }
                if (txtPassword.Text.Length < 8)
                {
                    MessageBox.Show("Password at least 8 characters", "System Notify", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPassword.Select();
                    return;
                }

                acc.Username = txtUsername.Text;
                acc.Password = txtPassword.Text;
                acc.EmpId = (int)cboEmployees.SelectedValue;
                acc.RoleId = (int)cboRoles.SelectedValue;

                empl.SaveChanges();
                MessageBox.Show("Update Data Success !", "System Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);

                FetchingAllData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Do You Wanna Delete This Account ?", "System Notify", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    var acc = empl.Accounts.Where(x => x.Id.ToString() == txtId.Text).FirstOrDefault();
                    if (acc != null)
                    {
                        //if (SignedInAccount.Equals(acc))
                        //{
                        //    MessageBox.Show("Cannot Delete Current Account !", "System Notify", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        //    return;
                        //}
                        empl.Accounts.Remove(acc);

                        empl.SaveChanges();

                        MessageBox.Show("Delete Success !", "System Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        FetchingAllData();

                        ClearForms();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "System Error");
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
            if (dataValidate.IsEmpty(txtSearch.Text))
            {
                MessageBox.Show("Search field is required", "System Notify", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSearch.Select();
                return;
            }
            else
            {
                dgvAccounts.DataSource = null;
                dgvAccounts.DataSource = null;
                var accs = from acc in empl.Accounts
                           where acc.Username.Contains(txtSearch.Text)
                           select new
                           {
                               Id = acc.Id,
                               Username = acc.Username,
                               Password = acc.Password,
                               Employee = acc.Employee.Name,
                               Role = acc.Role.Name
                           };
                dgvAccounts.DataSource = accs.ToList();
            }
        }

        private void FetchingAllData()
        {
            var accs = from acc in empl.Accounts
                       select new
                       {
                           Id = acc.Id,
                           Username = acc.Username,
                           Password = acc.Password,
                           Employee = acc.Employee.Name,
                           Role = acc.Role.Name
                       };
            dgvAccounts.DataSource = accs.ToList();
        }

        private void FetchingEmployees()
        {
            var employess = from emp in empl.Employees
                            select new
                            {
                                EmpId = emp.Id,
                                EmpName = emp.Name,
                            };
            cboEmployees.DataSource = employess.ToList();
            cboEmployees.DisplayMember = "EmpName";
            cboEmployees.ValueMember = "EmpId";
        }

        private void FetchingRoles()
        {
            var roles = from role in empl.Roles
                        select new
                        {
                            RoleId = role.Id,
                            RoleName = role.Name,
                        };
            cboRoles.DataSource = roles.ToList();
            cboRoles.DisplayMember = "RoleName";
            cboRoles.ValueMember = "RoleId";
        }

        private void ClearForms()
        {
            txtId.Text = txtUsername.Text = txtSearch.Text = txtPassword.Text = string.Empty;
            cboEmployees.SelectedItem = cboEmployees.Items[0];
            cboRoles.SelectedItem = cboRoles.Items[0];

            btnAdd.Enabled = true;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
        }

        private void dgvAccounts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAccounts.CurrentRow != null)
            {
                DataGridViewRow row = dgvAccounts.CurrentRow;

                var id = row.Cells[0].Value.ToString();

                var acc = empl.Accounts.Where(x => x.Id.ToString() == id).FirstOrDefault();
                if (acc != null)
                {
                    txtId.Text = acc.Id.ToString();
                    txtUsername.Text = acc.Username.ToString();
                    txtPassword.Text = acc.Password.ToString();

                    cboEmployees.SelectedValue = acc.EmpId;
                    cboRoles.SelectedValue = acc.RoleId;

                    btnAdd.Enabled = false;
                    btnDelete.Enabled = true;
                    btnUpdate.Enabled = true;
                }
            }
        }
    }
}
