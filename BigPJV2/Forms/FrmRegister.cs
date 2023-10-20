using BigPJV2.Data;
using BigPJV2.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BigPJV2
{
    public partial class frmRegister : Form
    {
        private bool isShowPassword = false;
        private bool isShowCfm = false;

        private SqlConnection conn;


        public frmRegister()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterParent;
            this.Icon = Resources.favicon;

            pbHideShowPassword.Image = Resources.view;

            pbHideShowConfrm.Image = Resources.view;

            btnRegister.Cursor = Cursors.Hand;
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {
            this.conn = DatabaseContext.Connection;
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

        

        private void btnRegister_Click(object sender, EventArgs e)
        {
            #region Validating Form
            if (string.IsNullOrEmpty(txtFullname.Text))
            {
                MessageBox.Show("Name is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUserName.Select();
                return;
            }
            if (txtFullname.Text.Length < 6)
            {
                MessageBox.Show("Name at least 6 characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUserName.Select();
                return;
            }


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
            #endregion


            #region Register Services


            #endregion
        }

        private void lkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();

            frmLogin frmLogin = new frmLogin();

            frmLogin.Show();
        }

        private void frmRegister_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }

        
    }
}
