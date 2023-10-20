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
    public partial class FrmMaskSleep : Form
    {
        public Account account = null;
        private bool isShowPassword = false;
        public FrmMaskSleep()
        {
            InitializeComponent();

            pbHideShowPassword.Image = Resources.view;


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text.Equals(account.Password))
            {
                this.Close();
            }
        }

        private void pbHideShowPassword_Click(object sender, EventArgs e)
        {
            isShowPassword = !isShowPassword;

            pbHideShowPassword.Image = isShowPassword ? Resources.hide : Resources.view;
            txtPassword.PasswordChar = isShowPassword ? '\0' : '*';
        }
    }
}
