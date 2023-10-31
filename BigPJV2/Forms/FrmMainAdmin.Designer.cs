namespace BigPJV2.Forms
{
    partial class FrmMainAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainAdmin));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDepartment = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLevels = new System.Windows.Forms.ToolStripMenuItem();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAccounts = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuRoles = new System.Windows.Forms.ToolStripMenuItem();
            this.côngCụToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTimeSheets = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuListTimeSheets = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuSleep = new System.Windows.Forms.ToolStripMenuItem();
            this.tàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChangePass = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblTimer = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerDateTimeNow = new System.Windows.Forms.Timer(this.components);
            this.mnuReport = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.mnuEmployee,
            this.danhMụcToolStripMenuItem,
            this.hệThốngToolStripMenuItem,
            this.côngCụToolStripMenuItem,
            this.tàiKhoảnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1209, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // mnuEmployee
            // 
            this.mnuEmployee.Name = "mnuEmployee";
            this.mnuEmployee.Size = new System.Drawing.Size(181, 24);
            this.mnuEmployee.Text = "Employee Management";
            this.mnuEmployee.Click += new System.EventHandler(this.mnuEmployee_Click);
            // 
            // danhMụcToolStripMenuItem
            // 
            this.danhMụcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDepartment,
            this.mnuLevels});
            this.danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
            this.danhMụcToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.danhMụcToolStripMenuItem.Text = "Categories";
            // 
            // mnuDepartment
            // 
            this.mnuDepartment.Name = "mnuDepartment";
            this.mnuDepartment.Size = new System.Drawing.Size(264, 26);
            this.mnuDepartment.Text = "Department Management";
            this.mnuDepartment.Click += new System.EventHandler(this.mnuDepartment_Click);
            // 
            // mnuLevels
            // 
            this.mnuLevels.Name = "mnuLevels";
            this.mnuLevels.Size = new System.Drawing.Size(264, 26);
            this.mnuLevels.Text = "Level Management";
            this.mnuLevels.Click += new System.EventHandler(this.mnuLevels_Click);
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAccounts,
            this.toolStripSeparator2,
            this.mnuRoles});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.hệThốngToolStripMenuItem.Text = "Systems";
            // 
            // mnuAccounts
            // 
            this.mnuAccounts.Name = "mnuAccounts";
            this.mnuAccounts.Size = new System.Drawing.Size(238, 26);
            this.mnuAccounts.Text = "Account Management";
            this.mnuAccounts.Click += new System.EventHandler(this.mnuAccounts_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(235, 6);
            // 
            // mnuRoles
            // 
            this.mnuRoles.Name = "mnuRoles";
            this.mnuRoles.Size = new System.Drawing.Size(238, 26);
            this.mnuRoles.Text = "Role Management";
            this.mnuRoles.Click += new System.EventHandler(this.mnuRoles_Click);
            // 
            // côngCụToolStripMenuItem
            // 
            this.côngCụToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTimeSheets,
            this.mnuListTimeSheets,
            this.toolStripSeparator4,
            this.mnuReport,
            this.toolStripSeparator3,
            this.mnuSleep});
            this.côngCụToolStripMenuItem.Name = "côngCụToolStripMenuItem";
            this.côngCụToolStripMenuItem.Size = new System.Drawing.Size(135, 24);
            this.côngCụToolStripMenuItem.Text = "Manager Control";
            // 
            // mnuTimeSheets
            // 
            this.mnuTimeSheets.Name = "mnuTimeSheets";
            this.mnuTimeSheets.Size = new System.Drawing.Size(254, 26);
            this.mnuTimeSheets.Text = "TimeSheet Management";
            this.mnuTimeSheets.Click += new System.EventHandler(this.mnuTimeSheets_Click);
            // 
            // mnuListTimeSheets
            // 
            this.mnuListTimeSheets.Name = "mnuListTimeSheets";
            this.mnuListTimeSheets.Size = new System.Drawing.Size(254, 26);
            this.mnuListTimeSheets.Text = "List TimeSheets";
            this.mnuListTimeSheets.Click += new System.EventHandler(this.mnuListTimeSheets_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(251, 6);
            // 
            // mnuSleep
            // 
            this.mnuSleep.Name = "mnuSleep";
            this.mnuSleep.Size = new System.Drawing.Size(254, 26);
            this.mnuSleep.Text = "Sleep";
            this.mnuSleep.Click += new System.EventHandler(this.mnuSleep_Click);
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            this.tàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuChangePass,
            this.toolStripSeparator1,
            this.mnuLogout});
            this.tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            this.tàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.tàiKhoảnToolStripMenuItem.Text = "Account";
            // 
            // mnuChangePass
            // 
            this.mnuChangePass.Name = "mnuChangePass";
            this.mnuChangePass.Size = new System.Drawing.Size(224, 26);
            this.mnuChangePass.Text = "Change Password";
            this.mnuChangePass.Click += new System.EventHandler(this.mnuChangePass_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(221, 6);
            // 
            // mnuLogout
            // 
            this.mnuLogout.Name = "mnuLogout";
            this.mnuLogout.Size = new System.Drawing.Size(224, 26);
            this.mnuLogout.Text = "Log Out";
            this.mnuLogout.Click += new System.EventHandler(this.mnuLogout_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblTimer});
            this.statusStrip1.Location = new System.Drawing.Point(0, 601);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1209, 26);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblTimer
            // 
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(151, 20);
            this.lblTimer.Text = "toolStripStatusLabel1";
            // 
            // timerDateTimeNow
            // 
            this.timerDateTimeNow.Enabled = true;
            this.timerDateTimeNow.Interval = 1;
            this.timerDateTimeNow.Tick += new System.EventHandler(this.timerDateTimeNow_Tick);
            // 
            // mnuReport
            // 
            this.mnuReport.Name = "mnuReport";
            this.mnuReport.Size = new System.Drawing.Size(254, 26);
            this.mnuReport.Text = "Reporting";
            this.mnuReport.Click += new System.EventHandler(this.mnuReport_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(251, 6);
            // 
            // FrmMainAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::BigPJV2.Properties.Resources._372838934_3672856576372585_1819941916978568845_n;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1209, 627);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMainAdmin";
            this.Text = "Admin Control Panel";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMainAdmin_FormClosed);
            this.Load += new System.EventHandler(this.FrmMainAdmin_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuEmployee;
        private System.Windows.Forms.ToolStripMenuItem danhMụcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuDepartment;
        private System.Windows.Forms.ToolStripMenuItem mnuLevels;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuChangePass;
        private System.Windows.Forms.ToolStripMenuItem mnuAccounts;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mnuRoles;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuLogout;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblTimer;
        private System.Windows.Forms.Timer timerDateTimeNow;
        private System.Windows.Forms.ToolStripMenuItem côngCụToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuSleep;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem mnuTimeSheets;
        private System.Windows.Forms.ToolStripMenuItem mnuListTimeSheets;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem mnuReport;
    }
}