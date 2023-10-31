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
    public partial class FrmDefaultEmployee : Form
    {
        public Account account = null;
        public FrmDefaultEmployee()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.IsMdiContainer = true;
        }

        private void FrmDefaultEmployee_Load(object sender, EventArgs e)
        {
            //MessageBox.Show($"Welcome Back, {account.Employee.Name}", "Welcome !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in this.MdiChildren)
            {
                item.Close();
            }
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDetailAccount frm = new FrmDetailAccount();
            frm.MdiParent = this;
            frm.account = account;
            if (!frm.IsOpened)
            {
                frm.Show();
            }
        }

        private void sleepToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMaskSleep frmMaskSleep = new FrmMaskSleep();
            frmMaskSleep.account = account;
            frmMaskSleep.ShowDialog();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.account = null;
            this.Hide();

            frmLogin frm = new frmLogin();
            frm.Show();
        }

        private void startAttendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAttendance frm = new FrmAttendance();
            frm.employee = account.Employee;
            frm.dateAttendance = DateTime.Now;
            frm.ShowDialog();
        }

        private void FrmDefaultEmployee_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString();
        }
    }
}
