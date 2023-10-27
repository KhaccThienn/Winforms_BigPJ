using BigPJV2.Data;
using BigPJV2.Forms;
using BigPJV2.Models;
using BigPJV2.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BigPJV2
{
    public partial class frmLogin : Form
    {
        private bool isShowPassword = false;
        EmplManagementEntities empl = new EmplManagementEntities();
        public frmLogin()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Icon = Resources.favicon;

            pbHideShowPassword.Image = Resources.view;

            btnLogin.Cursor = Cursors.Hand;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
        }

        private void lkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRegister frmRegister = new frmRegister();

            frmRegister.ShowDialog();
        }

        private void pbHideShowPassword_Click(object sender, EventArgs e)
        {
            isShowPassword = !isShowPassword;

            pbHideShowPassword.Image = isShowPassword ? Resources.hide : Resources.view;
            txtPassword.PasswordChar = isShowPassword ? '\0' : '*';
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            #region Validating Form
            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                MessageBox.Show("Username is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUserName.Select();
                return;
            }
            if (txtUserName.Text.Length < 6)
            {
                MessageBox.Show("Username at least 6 characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUserName.Select();
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

            #endregion


            var account = empl.Accounts.Where(x => x.Username == txtUserName.Text && x.Password == txtPassword.Text).FirstOrDefault();

            if (account != null)
            {
                if (account.Role.Name.ToString().Equals("Admin"))
                {
                    this.Hide();

                    FrmMainAdmin frmMainAdmin = new FrmMainAdmin();
                    frmMainAdmin.account = account;
                    frmMainAdmin.Show();

                }
                if (account.Role.Name.ToString().Equals("Employee"))
                {
                    this.Hide();

                    FrmDefaultEmployee frmMainEmployee = new FrmDefaultEmployee();
                    frmMainEmployee.account = account;
                    frmMainEmployee.Show();
                }

            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            var result = MessageBox.Show("Do You Want To Close This App ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
