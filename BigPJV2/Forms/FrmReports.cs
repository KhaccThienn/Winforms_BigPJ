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

        public string ReportName { get; set; }
        public Department dep = null;
        public Level lvl = null;

        public DateTime txtStart = DateTime.Now;
        public DateTime txtEnd = DateTime.Now;


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

            if (ReportName.Equals("allEmps"))
            {
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

            }
            if (ReportName.Equals("byDeps"))
            {
                
                var empData = from emp in empl.Employees
                              where emp.Department.Id == dep.Id
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
                empRpt.SetParameterValue("report_title", $"List Employee In TD x Nasa Company - Department {dep.Name.ToString()}");
                rptViewer.ReportSource = empRpt;
            }
            if (ReportName.Equals("byLvls"))
            {
                var empData = from emp in empl.Employees
                              where emp.Level.Id == lvl.Id
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
                empRpt.SetParameterValue("report_title", $"List Employee In TD x Nasa Company - Level {lvl.Name.ToString()}");
                rptViewer.ReportSource = empRpt;
            }
            if (ReportName.Equals("byDateTime"))
            {
                var empData = from ts in empl.Timesheets
                              where ts.AttendanceDate >= txtStart
                              && ts.AttendanceDate <= txtEnd
                              select new EmployeeReport
                              {
                                  Id = ts.Employee.Id,
                                  Name = ts.Employee.Name,
                                  Email = ts.Employee.Email,
                                  Phone = ts.Employee.Phone,
                                  Address = ts.Employee.Address,
                                  Gender = ts.Employee.Gender == true ? "Male" : "Female",
                                  BirthDay = ts.Employee.BirthDay,
                                  Level = ts.Employee.Level.Name,
                                  Department = ts.Employee.Department.Name
                              };
                if (empData != null)
                {
                    empRpt.SetDataSource(empData.AsEnumerable());
                }

                empRpt.SetParameterValue("company_name", "TD x Nasa Music Team");
                empRpt.SetParameterValue("owner_sig", account.Employee.Name.ToString());
                empRpt.SetParameterValue("report_title", $"List Employee In TD x Nasa Company - Attended From {txtStart} To {txtEnd}");
                rptViewer.ReportSource = empRpt;
            }


            
            rptViewer.Show();
        }
    }
}
