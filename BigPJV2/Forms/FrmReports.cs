using BigPJV2.Models;
using BigPJV2.Reports;
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
    public partial class FrmReports : Form
    {
        EmplManagementEntities empl = new EmplManagementEntities();
        public Account account = null;
        public bool IsOpened { get; set; } = false;
        public FrmReports()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;
        }

        private void FrmReports_Load(object sender, EventArgs e)
        {
            LoadReport();
        }

        private void LoadReport()
        {
            var empRpt = new EmpReport();

            var empData = from emp in empl.Employees
                          select new EmployeeReport
                          {
                              Id = emp.Id,
                              Name = emp.Name,
                              Email = emp.Email,
                              Phone = emp.Phone,
                              Address = emp.Address,
                              Gender = emp.Gender == true ? "Male" : "Female",
                              BirthDay = emp.BirthDay,
                              Level = emp.Level.Name,
                              Department = emp.Department.Name
                          };
            if (empData != null)
            {
                empRpt.SetDataSource(empData.AsEnumerable());
            }

            empRpt.SetParameterValue("company_name", "TD x Nasa Music Team");
            empRpt.SetParameterValue("owner_sig", account.Employee.Name.ToString());
            empRpt.SetParameterValue("report_title", "List Employee In TD x Nasa Company");

            rptViewer.ReportSource = empRpt;

            rptViewer.Show();
        }
    }
}
