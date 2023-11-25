namespace Meditechnology_System
{
    partial class ViewPrescription
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
			this.label1N = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.Reference = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.ReferenceLBL = new System.Windows.Forms.Label();
			this.DoctorNameLBL = new System.Windows.Forms.Label();
			this.DoctorContactNumberLBL = new System.Windows.Forms.Label();
			this.DateLBL = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.PatientNameLBL = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.AgeLBL = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.SexLBL = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.SendSaveBtn = new System.Windows.Forms.Button();
			this.backBtn = new System.Windows.Forms.Button();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// label1N
			// 
			this.label1N.AutoSize = true;
			this.label1N.Location = new System.Drawing.Point(86, 135);
			this.label1N.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1N.Name = "label1N";
			this.label1N.Size = new System.Drawing.Size(125, 20);
			this.label1N.TabIndex = 0;
			this.label1N.Text = "Name of Doctor:";
			this.label1N.Click += new System.EventHandler(this.label1N_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(86, 155);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(129, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "Contact Number:";
			// 
			// Reference
			// 
			this.Reference.AutoSize = true;
			this.Reference.Location = new System.Drawing.Point(86, 115);
			this.Reference.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Reference.Name = "Reference";
			this.Reference.Size = new System.Drawing.Size(88, 20);
			this.Reference.TabIndex = 6;
			this.Reference.Text = "Reference:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(470, 38);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(222, 33);
			this.label1.TabIndex = 7;
			this.label1.Text = "PRESCIPTION";
			// 
			// ReferenceLBL
			// 
			this.ReferenceLBL.AutoSize = true;
			this.ReferenceLBL.Location = new System.Drawing.Point(254, 115);
			this.ReferenceLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.ReferenceLBL.Name = "ReferenceLBL";
			this.ReferenceLBL.Size = new System.Drawing.Size(108, 20);
			this.ReferenceLBL.TabIndex = 8;
			this.ReferenceLBL.Text = "00000000000";
			// 
			// DoctorNameLBL
			// 
			this.DoctorNameLBL.AutoSize = true;
			this.DoctorNameLBL.Location = new System.Drawing.Point(254, 135);
			this.DoctorNameLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.DoctorNameLBL.Name = "DoctorNameLBL";
			this.DoctorNameLBL.Size = new System.Drawing.Size(51, 20);
			this.DoctorNameLBL.TabIndex = 9;
			this.DoctorNameLBL.Text = "Name";
			this.DoctorNameLBL.Click += new System.EventHandler(this.label5_Click);
			// 
			// DoctorContactNumberLBL
			// 
			this.DoctorContactNumberLBL.AutoSize = true;
			this.DoctorContactNumberLBL.Location = new System.Drawing.Point(254, 155);
			this.DoctorContactNumberLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.DoctorContactNumberLBL.Name = "DoctorContactNumberLBL";
			this.DoctorContactNumberLBL.Size = new System.Drawing.Size(108, 20);
			this.DoctorContactNumberLBL.TabIndex = 10;
			this.DoctorContactNumberLBL.Text = "09000000000";
			// 
			// DateLBL
			// 
			this.DateLBL.AutoSize = true;
			this.DateLBL.Location = new System.Drawing.Point(922, 115);
			this.DateLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.DateLBL.Name = "DateLBL";
			this.DateLBL.Size = new System.Drawing.Size(91, 20);
			this.DateLBL.TabIndex = 12;
			this.DateLBL.Text = "00-00-0000";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(864, 115);
			this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(48, 20);
			this.label8.TabIndex = 11;
			this.label8.Text = "Date:";
			// 
			// PatientNameLBL
			// 
			this.PatientNameLBL.AutoSize = true;
			this.PatientNameLBL.Location = new System.Drawing.Point(258, 218);
			this.PatientNameLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.PatientNameLBL.Name = "PatientNameLBL";
			this.PatientNameLBL.Size = new System.Drawing.Size(255, 20);
			this.PatientNameLBL.TabIndex = 14;
			this.PatientNameLBL.Text = "LastName, FirstName MiddleName";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(90, 218);
			this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(127, 20);
			this.label10.TabIndex = 13;
			this.label10.Text = "Name of Patient:";
			// 
			// AgeLBL
			// 
			this.AgeLBL.AutoSize = true;
			this.AgeLBL.Location = new System.Drawing.Point(948, 218);
			this.AgeLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.AgeLBL.Name = "AgeLBL";
			this.AgeLBL.Size = new System.Drawing.Size(27, 20);
			this.AgeLBL.TabIndex = 16;
			this.AgeLBL.Text = "00";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(862, 218);
			this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(42, 20);
			this.label12.TabIndex = 15;
			this.label12.Text = "Age:";
			this.label12.Click += new System.EventHandler(this.label12_Click);
			// 
			// SexLBL
			// 
			this.SexLBL.AutoSize = true;
			this.SexLBL.Location = new System.Drawing.Point(950, 238);
			this.SexLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.SexLBL.Name = "SexLBL";
			this.SexLBL.Size = new System.Drawing.Size(43, 20);
			this.SexLBL.TabIndex = 18;
			this.SexLBL.Text = "Male";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(864, 238);
			this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(40, 20);
			this.label14.TabIndex = 17;
			this.label14.Text = "Sex:";
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(304, 297);
			this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(123, 20);
			this.label17.TabIndex = 21;
			this.label17.Text = "List of Medicine:";
			// 
			// SendSaveBtn
			// 
			this.SendSaveBtn.Location = new System.Drawing.Point(466, 504);
			this.SendSaveBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.SendSaveBtn.Name = "SendSaveBtn";
			this.SendSaveBtn.Size = new System.Drawing.Size(261, 35);
			this.SendSaveBtn.TabIndex = 30;
			this.SendSaveBtn.Text = "Send and Save as PDF";
			this.SendSaveBtn.UseVisualStyleBackColor = true;
			this.SendSaveBtn.Click += new System.EventHandler(this.SendSaveBtn_Click);
			// 
			// backBtn
			// 
			this.backBtn.Location = new System.Drawing.Point(495, 548);
			this.backBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.backBtn.Name = "backBtn";
			this.backBtn.Size = new System.Drawing.Size(212, 35);
			this.backBtn.TabIndex = 31;
			this.backBtn.Text = "Back";
			this.backBtn.UseVisualStyleBackColor = true;
			this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 20;
			this.listBox1.Location = new System.Drawing.Point(308, 329);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(546, 144);
			this.listBox1.TabIndex = 32;
			// 
			// ViewPrescription
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1160, 632);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.backBtn);
			this.Controls.Add(this.SendSaveBtn);
			this.Controls.Add(this.label17);
			this.Controls.Add(this.SexLBL);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.AgeLBL);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.PatientNameLBL);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.DateLBL);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.DoctorContactNumberLBL);
			this.Controls.Add(this.DoctorNameLBL);
			this.Controls.Add(this.ReferenceLBL);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Reference);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1N);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "ViewPrescription";
			this.Text = "ViewPrescription";
			this.Load += new System.EventHandler(this.ViewPrescription_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1N;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Reference;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ReferenceLBL;
        private System.Windows.Forms.Label DoctorNameLBL;
        private System.Windows.Forms.Label DoctorContactNumberLBL;
        private System.Windows.Forms.Label DateLBL;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label PatientNameLBL;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label AgeLBL;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label SexLBL;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button SendSaveBtn;
        private System.Windows.Forms.Button backBtn;
		private System.Windows.Forms.ListBox listBox1;
	}
}