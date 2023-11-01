namespace BigPJV2.Forms
{
    partial class FrmTimeSheetsMgmt
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
            this.dgvTimeSheets = new System.Windows.Forms.DataGridView();
            this.txtEnd = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStart = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFetch = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimeSheets)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTimeSheets
            // 
            this.dgvTimeSheets.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTimeSheets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimeSheets.Location = new System.Drawing.Point(12, 131);
            this.dgvTimeSheets.Name = "dgvTimeSheets";
            this.dgvTimeSheets.RowHeadersWidth = 51;
            this.dgvTimeSheets.RowTemplate.Height = 24;
            this.dgvTimeSheets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTimeSheets.Size = new System.Drawing.Size(912, 389);
            this.dgvTimeSheets.TabIndex = 0;
            // 
            // txtEnd
            // 
            this.txtEnd.Location = new System.Drawing.Point(418, 42);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(300, 22);
            this.txtEnd.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(415, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "End Date";
            // 
            // txtStart
            // 
            this.txtStart.Location = new System.Drawing.Point(15, 42);
            this.txtStart.Name = "txtStart";
            this.txtStart.Size = new System.Drawing.Size(300, 22);
            this.txtStart.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Start Date";
            // 
            // btnFetch
            // 
            this.btnFetch.Location = new System.Drawing.Point(15, 79);
            this.btnFetch.Name = "btnFetch";
            this.btnFetch.Size = new System.Drawing.Size(141, 37);
            this.btnFetch.TabIndex = 3;
            this.btnFetch.Text = "Search...";
            this.btnFetch.UseVisualStyleBackColor = true;
            this.btnFetch.Click += new System.EventHandler(this.btnFetch_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(174, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 37);
            this.button1.TabIndex = 4;
            this.button1.Text = "Reporting...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmTimeSheetsMgmt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 531);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnFetch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtStart);
            this.Controls.Add(this.txtEnd);
            this.Controls.Add(this.dgvTimeSheets);
            this.Name = "FrmTimeSheetsMgmt";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List Timesheets Management Control Panel";
            this.Load += new System.EventHandler(this.FrmTimeSheetsMgmt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimeSheets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTimeSheets;
        private System.Windows.Forms.DateTimePicker txtEnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker txtStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFetch;
        private System.Windows.Forms.Button button1;
    }
}