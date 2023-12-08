namespace Meditechnology_System
{
    partial class PharmacyScreen
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
			this.LogoutBtn = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.Processbtn = new System.Windows.Forms.Button();
			this.MedicineListView = new System.Windows.Forms.ListBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label6 = new System.Windows.Forms.Label();
			this.NameLBL = new System.Windows.Forms.Label();
			this.AgeLBL = new System.Windows.Forms.Label();
			this.GENDERlbl = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.medCB = new System.Windows.Forms.ComboBox();
			this.label8 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.medicinelist = new System.Windows.Forms.DataGridView();
			this.addBtn = new System.Windows.Forms.Button();
			this.remarksTxtBox = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.remarksLB = new System.Windows.Forms.ListBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label10 = new System.Windows.Forms.Label();
			this.patientNameTXT = new System.Windows.Forms.Label();
			this.doctorNameTXT = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.totalLBL = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.refNumLB = new System.Windows.Forms.ListBox();
			this.refNumLBL = new System.Windows.Forms.Label();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.medicinelist)).BeginInit();
			this.SuspendLayout();
			// 
			// LogoutBtn
			// 
			this.LogoutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
			this.LogoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.LogoutBtn.ForeColor = System.Drawing.Color.White;
			this.LogoutBtn.Location = new System.Drawing.Point(961, 457);
			this.LogoutBtn.Name = "LogoutBtn";
			this.LogoutBtn.Size = new System.Drawing.Size(75, 23);
			this.LogoutBtn.TabIndex = 1;
			this.LogoutBtn.Text = "Logout";
			this.LogoutBtn.UseVisualStyleBackColor = false;
			this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.label1.Location = new System.Drawing.Point(25, 93);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Reference Number:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.label2.Location = new System.Drawing.Point(29, 214);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(83, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "Name of Patient";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.label3.Location = new System.Drawing.Point(256, 214);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(26, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "Age";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.label4.Location = new System.Drawing.Point(257, 238);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(25, 13);
			this.label4.TabIndex = 8;
			this.label4.Text = "Sex";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.label5.Location = new System.Drawing.Point(24, 285);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(84, 13);
			this.label5.TabIndex = 9;
			this.label5.Text = "List of Medicine:";
			// 
			// Processbtn
			// 
			this.Processbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
			this.Processbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.Processbtn.ForeColor = System.Drawing.Color.White;
			this.Processbtn.Location = new System.Drawing.Point(467, 410);
			this.Processbtn.Name = "Processbtn";
			this.Processbtn.Size = new System.Drawing.Size(211, 29);
			this.Processbtn.TabIndex = 10;
			this.Processbtn.Text = "Process";
			this.Processbtn.UseVisualStyleBackColor = false;
			this.Processbtn.Click += new System.EventHandler(this.Processbtn_Click);
			// 
			// MedicineListView
			// 
			this.MedicineListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.MedicineListView.FormattingEnabled = true;
			this.MedicineListView.Location = new System.Drawing.Point(28, 301);
			this.MedicineListView.Name = "MedicineListView";
			this.MedicineListView.Size = new System.Drawing.Size(312, 69);
			this.MedicineListView.TabIndex = 11;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
			this.panel2.Controls.Add(this.pictureBox1);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Location = new System.Drawing.Point(-114, -4);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1168, 65);
			this.panel2.TabIndex = 37;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.Image = global::Meditechnology_System.Properties.Resources.MEDITECH__1_;
			this.pictureBox1.Location = new System.Drawing.Point(142, 16);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(40, 32);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 26;
			this.pictureBox1.TabStop = false;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(188, 20);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(124, 25);
			this.label6.TabIndex = 27;
			this.label6.Text = "MEDITECH";
			// 
			// NameLBL
			// 
			this.NameLBL.AutoSize = true;
			this.NameLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.NameLBL.Location = new System.Drawing.Point(28, 244);
			this.NameLBL.Name = "NameLBL";
			this.NameLBL.Size = new System.Drawing.Size(70, 13);
			this.NameLBL.TabIndex = 38;
			this.NameLBL.Text = "Doctor Name";
			// 
			// AgeLBL
			// 
			this.AgeLBL.AutoSize = true;
			this.AgeLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.AgeLBL.Location = new System.Drawing.Point(294, 214);
			this.AgeLBL.Name = "AgeLBL";
			this.AgeLBL.Size = new System.Drawing.Size(46, 13);
			this.AgeLBL.TabIndex = 39;
			this.AgeLBL.Text = "- - - - - - -";
			// 
			// GENDERlbl
			// 
			this.GENDERlbl.AutoSize = true;
			this.GENDERlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.GENDERlbl.Location = new System.Drawing.Point(294, 238);
			this.GENDERlbl.Name = "GENDERlbl";
			this.GENDERlbl.Size = new System.Drawing.Size(46, 13);
			this.GENDERlbl.TabIndex = 40;
			this.GENDERlbl.Text = "- - - - - - -";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.label7.Location = new System.Drawing.Point(397, 93);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(93, 13);
			this.label7.TabIndex = 41;
			this.label7.Text = "MEDICINE NAME";
			// 
			// medCB
			// 
			this.medCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.medCB.FormattingEnabled = true;
			this.medCB.Location = new System.Drawing.Point(501, 90);
			this.medCB.Margin = new System.Windows.Forms.Padding(2);
			this.medCB.Name = "medCB";
			this.medCB.Size = new System.Drawing.Size(187, 21);
			this.medCB.TabIndex = 42;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.label8.Location = new System.Drawing.Point(397, 125);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(62, 13);
			this.label8.TabIndex = 43;
			this.label8.Text = "QUANTITY";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(501, 123);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(61, 20);
			this.textBox1.TabIndex = 44;
			// 
			// medicinelist
			// 
			this.medicinelist.AllowUserToAddRows = false;
			this.medicinelist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.medicinelist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.medicinelist.Location = new System.Drawing.Point(380, 173);
			this.medicinelist.Name = "medicinelist";
			this.medicinelist.RowHeadersWidth = 62;
			this.medicinelist.Size = new System.Drawing.Size(367, 198);
			this.medicinelist.TabIndex = 45;
			// 
			// addBtn
			// 
			this.addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
			this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.addBtn.ForeColor = System.Drawing.Color.White;
			this.addBtn.Location = new System.Drawing.Point(602, 119);
			this.addBtn.Name = "addBtn";
			this.addBtn.Size = new System.Drawing.Size(106, 29);
			this.addBtn.TabIndex = 46;
			this.addBtn.Text = "ADD ";
			this.addBtn.UseVisualStyleBackColor = false;
			this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
			// 
			// remarksTxtBox
			// 
			this.remarksTxtBox.Location = new System.Drawing.Point(782, 121);
			this.remarksTxtBox.Name = "remarksTxtBox";
			this.remarksTxtBox.Size = new System.Drawing.Size(242, 20);
			this.remarksTxtBox.TabIndex = 47;
			this.remarksTxtBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.remarksTxtBox_KeyDown);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.label9.Location = new System.Drawing.Point(766, 96);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(60, 13);
			this.label9.TabIndex = 48;
			this.label9.Text = "REMARKS";
			// 
			// remarksLB
			// 
			this.remarksLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.remarksLB.FormattingEnabled = true;
			this.remarksLB.Location = new System.Drawing.Point(782, 175);
			this.remarksLB.Name = "remarksLB";
			this.remarksLB.Size = new System.Drawing.Size(242, 186);
			this.remarksLB.TabIndex = 49;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Location = new System.Drawing.Point(961, 377);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(63, 23);
			this.button1.TabIndex = 50;
			this.button1.Text = "remove";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
			this.label10.ForeColor = System.Drawing.SystemColors.AppWorkspace;
			this.label10.Location = new System.Drawing.Point(780, 144);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(96, 9);
			this.label10.TabIndex = 51;
			this.label10.Text = "PRESS ENTER TO NEXT";
			// 
			// patientNameTXT
			// 
			this.patientNameTXT.AutoSize = true;
			this.patientNameTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.patientNameTXT.Location = new System.Drawing.Point(135, 214);
			this.patientNameTXT.Name = "patientNameTXT";
			this.patientNameTXT.Size = new System.Drawing.Size(97, 13);
			this.patientNameTXT.TabIndex = 52;
			this.patientNameTXT.Text = "- - - - - - - - - - - - - - - ";
			// 
			// doctorNameTXT
			// 
			this.doctorNameTXT.AutoSize = true;
			this.doctorNameTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.doctorNameTXT.Location = new System.Drawing.Point(135, 244);
			this.doctorNameTXT.Name = "doctorNameTXT";
			this.doctorNameTXT.Size = new System.Drawing.Size(46, 13);
			this.doctorNameTXT.TabIndex = 53;
			this.doctorNameTXT.Text = "- - - - - - -";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(637, 380);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(34, 13);
			this.label11.TabIndex = 54;
			this.label11.Text = "Total:";
			// 
			// totalLBL
			// 
			this.totalLBL.AutoSize = true;
			this.totalLBL.Location = new System.Drawing.Point(683, 380);
			this.totalLBL.Name = "totalLBL";
			this.totalLBL.Size = new System.Drawing.Size(34, 13);
			this.totalLBL.TabIndex = 55;
			this.totalLBL.Text = "- - - - -";
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// refNumLB
			// 
			this.refNumLB.FormattingEnabled = true;
			this.refNumLB.Location = new System.Drawing.Point(28, 109);
			this.refNumLB.MultiColumn = true;
			this.refNumLB.Name = "refNumLB";
			this.refNumLB.Size = new System.Drawing.Size(312, 95);
			this.refNumLB.TabIndex = 56;
			this.refNumLB.SelectedIndexChanged += new System.EventHandler(this.refNumLB_SelectedIndexChanged);
			// 
			// refNumLBL
			// 
			this.refNumLBL.AutoSize = true;
			this.refNumLBL.Location = new System.Drawing.Point(128, 93);
			this.refNumLBL.Name = "refNumLBL";
			this.refNumLBL.Size = new System.Drawing.Size(46, 13);
			this.refNumLBL.TabIndex = 57;
			this.refNumLBL.Text = "- - - - - - -";
			// 
			// PharmacyScreen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1048, 492);
			this.Controls.Add(this.refNumLBL);
			this.Controls.Add(this.refNumLB);
			this.Controls.Add(this.totalLBL);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.doctorNameTXT);
			this.Controls.Add(this.patientNameTXT);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.remarksLB);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.remarksTxtBox);
			this.Controls.Add(this.addBtn);
			this.Controls.Add(this.medicinelist);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.medCB);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.GENDERlbl);
			this.Controls.Add(this.AgeLBL);
			this.Controls.Add(this.NameLBL);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.MedicineListView);
			this.Controls.Add(this.Processbtn);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.LogoutBtn);
			this.Name = "PharmacyScreen";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "PharmacyScreen";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PharmacyScreen_FormClosed);
			this.Load += new System.EventHandler(this.PharmacyScreen_Load);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.medicinelist)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button LogoutBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Processbtn;
        private System.Windows.Forms.ListBox MedicineListView;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label NameLBL;
        private System.Windows.Forms.Label AgeLBL;
        private System.Windows.Forms.Label GENDERlbl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox medCB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView medicinelist;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.TextBox remarksTxtBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox remarksLB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label patientNameTXT;
        private System.Windows.Forms.Label doctorNameTXT;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label totalLBL;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.ListBox refNumLB;
		private System.Windows.Forms.Label refNumLBL;
	}
}