using System;
using System.Windows.Forms;

namespace BigPJV2.Forms
{
    public partial class FrmMainAdmin : Form
    {
        public Account account = null;
        public FrmMainAdmin()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.IsMdiContainer = true;
        }

        private void FrmMainAdmin_Load(object sender, EventArgs e)
        {
            MessageBox.Show($"Welcome Back, {account.Employee.Name}", "Welcome !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }


        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in this.MdiChildren)
            {
                item.Close();
            }
        }

        private void mnuEmployee_Click(object sender, EventArgs e)
        {
            FrmEmployee frmEmployee = new FrmEmployee();
            frmEmployee.MdiParent = this;

            frmEmployee.sign_account = account;

            if (!frmEmployee.IsOpened)
            {
                frmEmployee.Show();
            }
        }

        private void mnuDepartment_Click(object sender, EventArgs e)
        {
            FrmDepartment frm = new FrmDepartment();
            frm.MdiParent = this;

            if (!frm.IsOpened)
            {
                frm.Show();
            }
        }

        private void mnuLevels_Click(object sender, EventArgs e)
        {
            FrmLevels frm = new FrmLevels();
            frm.MdiParent = this;

            if (!frm.IsOpened)
            {
                frm.Show();
            }
        }

        private void mnuAccounts_Click(object sender, EventArgs e)
        {
            FrmAccount frm = new FrmAccount();
            frm.MdiParent = this;

            if (!frm.IsOpened)
            {
                frm.Show();
            }
        }

        private void mnuRoles_Click(object sender, EventArgs e)
        {
            FrmRoles frm = new FrmRoles();
            frm.MdiParent = this;

            if (!frm.IsOpened)
            {
                frm.Show();
            }
        }

        private void mnuTimeSheets_Click(object sender, EventArgs e)
        {
            FrmTimeSheets frm = new FrmTimeSheets();
            frm.MdiParent = this;

            if (!frm.IsOpened)
            {
                frm.Show();
            }
        }

        private void mnuListTimeSheets_Click(object sender, EventArgs e)
        {

            FrmTimeSheetsMgmt frm = new FrmTimeSheetsMgmt();
            frm.MdiParent = this;

            if (!frm.IsOpened)
            {
                frm.Show();
            }
            
        }

        private void mnuChangePass_Click(object sender, EventArgs e)
        {
            FrmDetailAccount frm = new FrmDetailAccount();
            frm.MdiParent = this;
            frm.account = account;
            if (!frm.IsOpened)
            {
                frm.Show();
            }
        }


        private void mnuLogout_Click(object sender, EventArgs e)
        {
            this.account = null;
            this.Hide();

            frmLogin frm = new frmLogin();
            frm.Show();
        }

        private void mnuSleep_Click(object sender, EventArgs e)
        {
            FrmMaskSleep frmMaskSleep = new FrmMaskSleep();
            frmMaskSleep.account = account;
            frmMaskSleep.ShowDialog();
        }

        private void timerDateTimeNow_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = DateTime.Now.ToString("dd / MM / yyyy -- HH : mm : ss tt");
        }

        private void FrmMainAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void mnuReport_Click(object sender, EventArgs e)
        {
            FrmReports frm = new FrmReports();
            frm.MdiParent = this;
            frm.account = account;
            if (!frm.IsOpened)
            {
                frm.Show();
            }
        }
    }
}
