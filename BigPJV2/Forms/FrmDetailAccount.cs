using BigPJV2.Properties;
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
    public partial class FrmDetailAccount : Form
    {
        private bool isShowOldPassword = false;
        private bool isShowPassword = false;
        private bool isShowCfm = false;

        public Account account;

        EmplManagementEntities empl = new EmplManagementEntities();
        public bool IsOpened { get; set; } = false;

        public FrmDetailAccount()
        {
            InitializeComponent();

            pbHideShowOldPass.Image = Resources.view;
            txtOldPassword.PasswordChar = '*';

            pbHideShowPassword.Image = Resources.view;
            txtPassword.PasswordChar = '*';

            pbHideShowConfrm.Image = Resources.view;
            txtConfirmPassword.PasswordChar = '*';

        }

        private void FrmDetailAccount_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtOldPassword.Text))
            {
                MessageBox.Show("Old Password is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtOldPassword.Select();
                return;
            }
            if (string.Compare(txtOldPassword.Text, account.Password) != 0)
            {
                MessageBox.Show("Invalid Password Account", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtOldPassword.Select();
                return;
            }

            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Password is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Select();
                return;
            }
            if (txtPassword.Text.Length < 8)
            {
                MessageBox.Show("Password at least 8 characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Select();
                return;
            }

            if (string.IsNullOrEmpty(txtConfirmPassword.Text))
            {
                MessageBox.Show("Confirm Password is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConfirmPassword.Select();
                return;
            }
            if (string.Compare(txtPassword.Text, txtConfirmPassword.Text) != 0)
            {
                MessageBox.Show("Passwords does not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConfirmPassword.Select();
                return;
            }

            var result = MessageBox.Show("Do you wanna change password ?", "System Notify", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                var acc_found = empl.Accounts.Where(x => x.Id == account.Id).FirstOrDefault();
                if (acc_found != null)
                {
                    acc_found.Password = txtPassword.Text;

                    empl.SaveChangesAsync();

                    MessageBox.Show("Change Pass Success !", "System Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
            }
        }

        private void pbHideShowOldPass_Click(object sender, EventArgs e)
        {
            isShowOldPassword = !isShowOldPassword;

            pbHideShowOldPass.Image = isShowOldPassword ? Resources.hide : Resources.view;
            txtOldPassword.PasswordChar = isShowOldPassword ? '\0' : '*';
        }

        private void pbHideShowPassword_Click(object sender, EventArgs e)
        {
            isShowPassword = !isShowPassword;

            pbHideShowPassword.Image = isShowPassword ? Resources.hide : Resources.view;
            txtPassword.PasswordChar = isShowPassword ? '\0' : '*';
        }

        private void pbHideShowConfrm_Click(object sender, EventArgs e)
        {

            isShowCfm = !isShowCfm;

            pbHideShowConfrm.Image = isShowCfm ? Resources.hide : Resources.view;
            txtConfirmPassword.PasswordChar = isShowCfm ? '\0' : '*';
        }
    }
}
