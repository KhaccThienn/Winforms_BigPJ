using BigPJV2.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BigPJV2.Forms
{
    public partial class FrmLevels : Form
    {
        EmplManagementEntities empl = new EmplManagementEntities();
        public bool IsOpened { get; set; } = false;
        public FrmLevels()
        {
            InitializeComponent();

            dgvLevels.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void FrmLevels_Load(object sender, EventArgs e)
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

            var level = new Level();

            level.Name = txtName.Text;
            level.Description = txtDescription.Text;

            empl.Levels.Add(level);

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
            var lvl = empl.Levels.FirstOrDefault(x => x.Id.ToString() == txtId.Text);

            if (lvl != null)
            {
                lvl.Name = txtName.Text;
                lvl.Description = txtDescription.Text;

                empl.SaveChanges();

                MessageBox.Show("Update Data Success !", "System Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                FetchingAllData();
                ClearForms();

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvLevels.CurrentRow != null)
            {
                var dialogResult = MessageBox.Show("Do You Want To Delete This Item ?", "System Notify", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    var lvl = empl.Levels.FirstOrDefault(x => x.Id.ToString() == txtId.Text);

                    if (lvl != null)
                    {
                        if (lvl.Employees.Count > 0)
                        {
                            MessageBox.Show("Cannot Delete This Item !", "System Notify", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        else
                        {
                            empl.Levels.Remove(lvl);

                            empl.SaveChanges();

                            MessageBox.Show("Delete Success !", "System Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            FetchingAllData();
                            ClearForms();
                        }
                    }
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvLevels.DataSource = null;

            if (string.IsNullOrEmpty(txtSearch.Text))
            {
                MessageBox.Show("Search field is required", "System Notify", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSearch.Select();
                return;
            }

            var levels = from level in empl.Levels
                        where level.Name.Contains(txtSearch.Text)
                        select new
                        {
                            Id = level.Id,
                            Name = level.Name,
                            Description = level.Description
                        };
            dgvLevels.DataSource = levels.ToList();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearForms();
            FetchingAllData();

            btnAdd.Enabled = true;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
        }

        private void FetchingAllData()
        {
            var levels = from level in empl.Levels
                        select new
                        {
                            Id = level.Id,
                            Name = level.Name,
                            Description = level.Description
                        };
            dgvLevels.DataSource = levels.ToList();
        }

        private void ClearForms()
        {
            txtId.Text = txtName.Text = txtSearch.Text = txtDescription.Text = string.Empty;
        }

        private void dgvLevels_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvLevels.CurrentRow != null)
            {
                DataGridViewRow row = dgvLevels.CurrentRow;

                txtId.Text = row.Cells[0].Value.ToString();
                txtName.Text = row.Cells[1].Value.ToString();
                txtDescription.Text = row.Cells[2].Value.ToString();

                btnAdd.Enabled = false;
                btnDelete.Enabled = true;
                btnUpdate.Enabled = true;
            }
        }
    }
}
