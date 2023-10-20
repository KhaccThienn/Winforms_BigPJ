namespace BigPJV2
{
    partial class frmRegister
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFullname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pbHideShowPassword = new System.Windows.Forms.PictureBox();
            this.pbHideShowConfrm = new System.Windows.Forms.PictureBox();
            this.lkLogin = new System.Windows.Forms.LinkLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHideShowPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHideShowConfrm)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lkLogin);
            this.panel1.Controls.Add(this.pbHideShowConfrm);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.pbHideShowPassword);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtUserName);
            this.panel1.Controls.Add(this.btnRegister);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtConfirmPassword);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txtFullname);
            this.panel1.Location = new System.Drawing.Point(164, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(474, 471);
            this.panel1.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(64, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(67, 248);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(347, 33);
            this.txtPassword.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(64, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Username";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(67, 170);
            this.txtUserName.Multiline = true;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(347, 33);
            this.txtUserName.TabIndex = 8;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.Lime;
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRegister.Location = new System.Drawing.Point(67, 391);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(347, 35);
            this.btnRegister.TabIndex = 7;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(67, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Confirm Password";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(67, 329);
            this.txtConfirmPassword.Multiline = true;
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(347, 33);
            this.txtConfirmPassword.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(64, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Display Name";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.label1);
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(474, 43);
            this.panel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Register New Account";
            // 
            // txtFullname
            // 
            this.txtFullname.Location = new System.Drawing.Point(67, 88);
            this.txtFullname.Multiline = true;
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.Size = new System.Drawing.Size(347, 33);
            this.txtFullname.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 4.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(12, 514);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 9);
            this.label4.TabIndex = 10;
            this.label4.Text = "v0.0.1";
            // 
            // pbHideShowPassword
            // 
            this.pbHideShowPassword.Image = global::BigPJV2.Properties.Resources.view;
            this.pbHideShowPassword.Location = new System.Drawing.Point(420, 251);
            this.pbHideShowPassword.Name = "pbHideShowPassword";
            this.pbHideShowPassword.Size = new System.Drawing.Size(30, 30);
            this.pbHideShowPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHideShowPassword.TabIndex = 12;
            this.pbHideShowPassword.TabStop = false;
            this.pbHideShowPassword.Click += new System.EventHandler(this.pbHideShowPassword_Click);
            // 
            // pbHideShowConfrm
            // 
            this.pbHideShowConfrm.Image = global::BigPJV2.Properties.Resources.view;
            this.pbHideShowConfrm.Location = new System.Drawing.Point(420, 332);
            this.pbHideShowConfrm.Name = "pbHideShowConfrm";
            this.pbHideShowConfrm.Size = new System.Drawing.Size(30, 30);
            this.pbHideShowConfrm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHideShowConfrm.TabIndex = 13;
            this.pbHideShowConfrm.TabStop = false;
            this.pbHideShowConfrm.Click += new System.EventHandler(this.pbHideShowConfrm_Click);
            // 
            // lkLogin
            // 
            this.lkLogin.AutoSize = true;
            this.lkLogin.Location = new System.Drawing.Point(432, 443);
            this.lkLogin.Name = "lkLogin";
            this.lkLogin.Size = new System.Drawing.Size(40, 16);
            this.lkLogin.TabIndex = 22;
            this.lkLogin.TabStop = true;
            this.lkLogin.Text = "Login";
            this.lkLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkLogin_LinkClicked);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(284, 443);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 16);
            this.label7.TabIndex = 21;
            this.label7.Text = "Having An Account ?";
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 532);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Name = "frmRegister";
            this.ShowIcon = false;
            this.Text = "Register Control Panel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRegister_FormClosing);
            this.Load += new System.EventHandler(this.frmRegister_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHideShowPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHideShowConfrm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFullname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.PictureBox pbHideShowConfrm;
        private System.Windows.Forms.PictureBox pbHideShowPassword;
        private System.Windows.Forms.LinkLabel lkLogin;
        private System.Windows.Forms.Label label7;
    }
}