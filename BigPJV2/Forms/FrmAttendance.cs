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
    public partial class FrmAttendance : Form
    {
        EmplManagementEntities empl = new EmplManagementEntities();
        public Employee employee;
        public DateTime dateAttendance;
        public Timesheet ts;

        public bool IsOpened { get; set; } = false;
        public FrmAttendance()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void FrmAttendance_Load(object sender, EventArgs e)
        {
            FetchData();
        }

        private void FetchData()
        {

            this.ts = empl.Timesheets.Where(x => x.EmployeeId == employee.Id).OrderByDescending(x => x.Id).FirstOrDefault();

            if (ts != null)
            {
                MessageBox.Show(ts.Employee.Name);
                MessageBox.Show(DateTime.Now.ToShortDateString().ToString());
                MessageBox.Show(dateAttendance.ToShortDateString().ToString());

                MessageBox.Show((DateTime.Now.ToShortDateString().ToString() == dateAttendance.ToShortDateString().ToString()).ToString());

                if (DateTime.Now.ToShortDateString().ToString() == dateAttendance.ToShortDateString().ToString() && ts.Value == 0)
                {
                    btnStart.Enabled = false;
                    lblEmp.Text = ts.Employee.Name.ToString();
                    lblStatus.Text = ts.Value == 0 ? "Working" : "Completed";
                }
                else
                {
                    lblStatus.Text = "Uncheked";
                    btnEnd.Enabled = false;
                }

            }
            else
            {
                lblStatus.Text = "Uncheked";
                btnEnd.Enabled = false;
            }

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.ts = new Timesheet();

            ts.AttendanceDate = DateTime.Now;
            ts.EmployeeId = employee.Id;
            ts.Value = 0;

            empl.Timesheets.Add(ts);
            empl.SaveChangesAsync();

            MessageBox.Show("Attendanced Success !", "System Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Hide();
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {

            ts.AttendanceDate = DateTime.Now;
            ts.EmployeeId = employee.Id;
            ts.Value = 1;

            empl.SaveChangesAsync();

            MessageBox.Show("Attendanced Success !", "System Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblEmp.Text = employee.Name.ToString();
            lblAttendanceDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss tt");
        }
    }
}
