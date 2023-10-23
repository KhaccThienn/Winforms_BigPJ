namespace BigPJV2.Forms
{
    partial class FrmMainEmployee
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
            this.pb_Scanner = new System.Windows.Forms.PictureBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.cboCameras = new System.Windows.Forms.ComboBox();
            this.ReadedData = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Scanner)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_Scanner
            // 
            this.pb_Scanner.Location = new System.Drawing.Point(12, 66);
            this.pb_Scanner.Name = "pb_Scanner";
            this.pb_Scanner.Size = new System.Drawing.Size(431, 326);
            this.pb_Scanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Scanner.TabIndex = 0;
            this.pb_Scanner.TabStop = false;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(449, 66);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(123, 43);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "Open Camera";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // cboCameras
            // 
            this.cboCameras.FormattingEnabled = true;
            this.cboCameras.Location = new System.Drawing.Point(12, 12);
            this.cboCameras.Name = "cboCameras";
            this.cboCameras.Size = new System.Drawing.Size(431, 24);
            this.cboCameras.TabIndex = 2;
            // 
            // ReadedData
            // 
            this.ReadedData.Location = new System.Drawing.Point(449, 115);
            this.ReadedData.Multiline = true;
            this.ReadedData.Name = "ReadedData";
            this.ReadedData.Size = new System.Drawing.Size(313, 69);
            this.ReadedData.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmMainEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 404);
            this.Controls.Add(this.ReadedData);
            this.Controls.Add(this.cboCameras);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.pb_Scanner);
            this.Name = "FrmMainEmployee";
            this.Text = "Employee Control Panel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMainEmployee_FormClosing);
            this.Load += new System.EventHandler(this.FrmMainEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Scanner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_Scanner;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.ComboBox cboCameras;
        private System.Windows.Forms.TextBox ReadedData;
        private System.Windows.Forms.Timer timer1;
    }
}