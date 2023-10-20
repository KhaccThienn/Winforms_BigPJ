namespace BigPJV2.Forms
{
    partial class FrmDetailAccount
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
            this.pbHideShowConfrm = new System.Windows.Forms.PictureBox();
            this.pbHideShowPassword = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.pbHideShowOldPass = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOldPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbHideShowConfrm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHideShowPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHideShowOldPass)).BeginInit();
            this.SuspendLayout();
            // 
            // pbHideShowConfrm
            // 
            this.pbHideShowConfrm.Image = global::BigPJV2.Properties.Resources.view;
            this.pbHideShowConfrm.Location = new System.Drawing.Point(421, 258);
            this.pbHideShowConfrm.Name = "pbHideShowConfrm";
            this.pbHideShowConfrm.Size = new System.Drawing.Size(30, 30);
            this.pbHideShowConfrm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHideShowConfrm.TabIndex = 19;
            this.pbHideShowConfrm.TabStop = false;
            this.pbHideShowConfrm.Click += new System.EventHandler(this.pbHideShowConfrm_Click);
            // 
            // pbHideShowPassword
            // 
            this.pbHideShowPassword.Image = global::BigPJV2.Properties.Resources.view;
            this.pbHideShowPassword.Location = new System.Drawing.Point(421, 177);
            this.pbHideShowPassword.Name = "pbHideShowPassword";
            this.pbHideShowPassword.Size = new System.Drawing.Size(30, 30);
            this.pbHideShowPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHideShowPassword.TabIndex = 18;
            this.pbHideShowPassword.TabStop = false;
            this.pbHideShowPassword.Click += new System.EventHandler(this.pbHideShowPassword_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(65, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(68, 174);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(347, 33);
            this.txtPassword.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(68, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Confirm Password";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(68, 255);
            this.txtConfirmPassword.Multiline = true;
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(347, 33);
            this.txtConfirmPassword.TabIndex = 14;
            // 
            // pbHideShowOldPass
            // 
            this.pbHideShowOldPass.Image = global::BigPJV2.Properties.Resources.view;
            this.pbHideShowOldPass.Location = new System.Drawing.Point(421, 107);
            this.pbHideShowOldPass.Name = "pbHideShowOldPass";
            this.pbHideShowOldPass.Size = new System.Drawing.Size(30, 30);
            this.pbHideShowOldPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHideShowOldPass.TabIndex = 22;
            this.pbHideShowOldPass.TabStop = false;
            this.pbHideShowOldPass.Click += new System.EventHandler(this.pbHideShowOldPass_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(65, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Old Password";
            // 
            // txtOldPassword
            // 
            this.txtOldPassword.Location = new System.Drawing.Point(68, 104);
            this.txtOldPassword.Multiline = true;
            this.txtOldPassword.Name = "txtOldPassword";
            this.txtOldPassword.Size = new System.Drawing.Size(347, 33);
            this.txtOldPassword.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(148, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 30);
            this.label2.TabIndex = 23;
            this.label2.Text = "Change Password";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(71, 333);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(380, 40);
            this.btnSubmit.TabIndex = 24;
            this.btnSubmit.Text = "Confirm";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // FrmDetailAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 428);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbHideShowOldPass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOldPassword);
            this.Controls.Add(this.pbHideShowConfrm);
            this.Controls.Add(this.pbHideShowPassword);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtConfirmPassword);
            this.Name = "FrmDetailAccount";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Password Control Panel";
            this.Load += new System.EventHandler(this.FrmDetailAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbHideShowConfrm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHideShowPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHideShowOldPass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbHideShowConfrm;
        private System.Windows.Forms.PictureBox pbHideShowPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.PictureBox pbHideShowOldPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOldPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSubmit;
    }
}