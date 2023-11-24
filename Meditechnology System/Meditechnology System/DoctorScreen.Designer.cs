namespace Meditechnology_System
{
    partial class DoctorScreen
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
            this.DGVSchedule = new System.Windows.Forms.DataGridView();
            this.DGVPatients = new System.Windows.Forms.DataGridView();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.AddPatientBtn = new System.Windows.Forms.Button();
            this.ViewBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVSchedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPatients)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVSchedule
            // 
            this.DGVSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVSchedule.Location = new System.Drawing.Point(35, 86);
            this.DGVSchedule.Name = "DGVSchedule";
            this.DGVSchedule.Size = new System.Drawing.Size(249, 243);
            this.DGVSchedule.TabIndex = 0;
            // 
            // DGVPatients
            // 
            this.DGVPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVPatients.Location = new System.Drawing.Point(341, 86);
            this.DGVPatients.Name = "DGVPatients";
            this.DGVPatients.Size = new System.Drawing.Size(415, 243);
            this.DGVPatients.TabIndex = 1;
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.Location = new System.Drawing.Point(681, 347);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(75, 23);
            this.LogoutBtn.TabIndex = 2;
            this.LogoutBtn.Text = "Logout";
            this.LogoutBtn.UseVisualStyleBackColor = true;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // AddPatientBtn
            // 
            this.AddPatientBtn.Location = new System.Drawing.Point(681, 57);
            this.AddPatientBtn.Name = "AddPatientBtn";
            this.AddPatientBtn.Size = new System.Drawing.Size(75, 23);
            this.AddPatientBtn.TabIndex = 3;
            this.AddPatientBtn.Text = "Add";
            this.AddPatientBtn.UseVisualStyleBackColor = true;
            this.AddPatientBtn.Click += new System.EventHandler(this.AddPatientBtn_Click);
            // 
            // ViewBtn
            // 
            this.ViewBtn.Location = new System.Drawing.Point(600, 57);
            this.ViewBtn.Name = "ViewBtn";
            this.ViewBtn.Size = new System.Drawing.Size(75, 23);
            this.ViewBtn.TabIndex = 4;
            this.ViewBtn.Text = "View";
            this.ViewBtn.UseVisualStyleBackColor = true;
            this.ViewBtn.Click += new System.EventHandler(this.ViewBtn_Click);
            // 
            // DoctorScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 399);
            this.Controls.Add(this.ViewBtn);
            this.Controls.Add(this.AddPatientBtn);
            this.Controls.Add(this.LogoutBtn);
            this.Controls.Add(this.DGVPatients);
            this.Controls.Add(this.DGVSchedule);
            this.Name = "DoctorScreen";
            this.Text = "DoctorScreen";
            ((System.ComponentModel.ISupportInitialize)(this.DGVSchedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPatients)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVSchedule;
        private System.Windows.Forms.DataGridView DGVPatients;
        private System.Windows.Forms.Button LogoutBtn;
        private System.Windows.Forms.Button AddPatientBtn;
        private System.Windows.Forms.Button ViewBtn;
    }
}