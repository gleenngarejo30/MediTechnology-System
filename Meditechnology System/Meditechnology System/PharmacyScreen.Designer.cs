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
			this.refNumCB = new System.Windows.Forms.ComboBox();
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.addBtn = new System.Windows.Forms.Button();
			this.remarksTxtBox = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label10 = new System.Windows.Forms.Label();
			this.patientNameTXT = new System.Windows.Forms.Label();
			this.doctorNameTXT = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.totalLBL = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// LogoutBtn
			// 
			this.LogoutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
			this.LogoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.LogoutBtn.ForeColor = System.Drawing.Color.White;
			this.LogoutBtn.Location = new System.Drawing.Point(1442, 703);
			this.LogoutBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.LogoutBtn.Name = "LogoutBtn";
			this.LogoutBtn.Size = new System.Drawing.Size(112, 35);
			this.LogoutBtn.TabIndex = 1;
			this.LogoutBtn.Text = "Logout";
			this.LogoutBtn.UseVisualStyleBackColor = false;
			this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.label1.Location = new System.Drawing.Point(38, 143);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(150, 20);
			this.label1.TabIndex = 2;
			this.label1.Text = "Reference Number";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.label2.Location = new System.Drawing.Point(60, 208);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(129, 20);
			this.label2.TabIndex = 6;
			this.label2.Text = "Name of Patient";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.label3.Location = new System.Drawing.Point(406, 208);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(38, 20);
			this.label3.TabIndex = 7;
			this.label3.Text = "Age";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.label4.Location = new System.Drawing.Point(408, 245);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(37, 20);
			this.label4.TabIndex = 8;
			this.label4.Text = "Sex";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.label5.Location = new System.Drawing.Point(57, 331);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(133, 20);
			this.label5.TabIndex = 9;
			this.label5.Text = "List of Medicine:";
			// 
			// Processbtn
			// 
			this.Processbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
			this.Processbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.Processbtn.ForeColor = System.Drawing.Color.White;
			this.Processbtn.Location = new System.Drawing.Point(700, 631);
			this.Processbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Processbtn.Name = "Processbtn";
			this.Processbtn.Size = new System.Drawing.Size(316, 45);
			this.Processbtn.TabIndex = 10;
			this.Processbtn.Text = "Process";
			this.Processbtn.UseVisualStyleBackColor = false;
			this.Processbtn.Click += new System.EventHandler(this.Processbtn_Click);
			// 
			// MedicineListView
			// 
			this.MedicineListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.MedicineListView.FormattingEnabled = true;
			this.MedicineListView.ItemHeight = 20;
			this.MedicineListView.Location = new System.Drawing.Point(64, 385);
			this.MedicineListView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MedicineListView.Name = "MedicineListView";
			this.MedicineListView.Size = new System.Drawing.Size(422, 164);
			this.MedicineListView.TabIndex = 11;
			// 
			// refNumCB
			// 
			this.refNumCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.refNumCB.FormattingEnabled = true;
			this.refNumCB.Location = new System.Drawing.Point(230, 138);
			this.refNumCB.Name = "refNumCB";
			this.refNumCB.Size = new System.Drawing.Size(278, 28);
			this.refNumCB.TabIndex = 12;
			this.refNumCB.SelectedIndexChanged += new System.EventHandler(this.refNumCB_SelectedIndexChanged);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
			this.panel2.Controls.Add(this.pictureBox1);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Location = new System.Drawing.Point(-171, -6);
			this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1752, 100);
			this.panel2.TabIndex = 37;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.Image = global::Meditechnology_System.Properties.Resources.MEDITECH__1_;
			this.pictureBox1.Location = new System.Drawing.Point(213, 25);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(60, 49);
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
			this.label6.Location = new System.Drawing.Point(282, 31);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(177, 36);
			this.label6.TabIndex = 27;
			this.label6.Text = "MEDITECH";
			// 
			// NameLBL
			// 
			this.NameLBL.AutoSize = true;
			this.NameLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.NameLBL.Location = new System.Drawing.Point(80, 265);
			this.NameLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.NameLBL.Name = "NameLBL";
			this.NameLBL.Size = new System.Drawing.Size(109, 20);
			this.NameLBL.TabIndex = 38;
			this.NameLBL.Text = "Doctor Name";
			// 
			// AgeLBL
			// 
			this.AgeLBL.AutoSize = true;
			this.AgeLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.AgeLBL.Location = new System.Drawing.Point(464, 208);
			this.AgeLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.AgeLBL.Name = "AgeLBL";
			this.AgeLBL.Size = new System.Drawing.Size(81, 20);
			this.AgeLBL.TabIndex = 39;
			this.AgeLBL.Text = "- - - - - - -";
			// 
			// GENDERlbl
			// 
			this.GENDERlbl.AutoSize = true;
			this.GENDERlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.GENDERlbl.Location = new System.Drawing.Point(464, 245);
			this.GENDERlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.GENDERlbl.Name = "GENDERlbl";
			this.GENDERlbl.Size = new System.Drawing.Size(81, 20);
			this.GENDERlbl.TabIndex = 40;
			this.GENDERlbl.Text = "- - - - - - -";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.label7.Location = new System.Drawing.Point(596, 143);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(143, 20);
			this.label7.TabIndex = 41;
			this.label7.Text = "MEDICINE NAME";
			// 
			// medCB
			// 
			this.medCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.medCB.FormattingEnabled = true;
			this.medCB.Location = new System.Drawing.Point(752, 138);
			this.medCB.Name = "medCB";
			this.medCB.Size = new System.Drawing.Size(278, 28);
			this.medCB.TabIndex = 42;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.label8.Location = new System.Drawing.Point(596, 192);
			this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(91, 20);
			this.label8.TabIndex = 43;
			this.label8.Text = "QUANTITY";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(752, 189);
			this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(90, 26);
			this.textBox1.TabIndex = 44;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(570, 266);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 62;
			this.dataGridView1.Size = new System.Drawing.Size(550, 305);
			this.dataGridView1.TabIndex = 45;
			// 
			// addBtn
			// 
			this.addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
			this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.addBtn.ForeColor = System.Drawing.Color.White;
			this.addBtn.Location = new System.Drawing.Point(903, 183);
			this.addBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.addBtn.Name = "addBtn";
			this.addBtn.Size = new System.Drawing.Size(159, 45);
			this.addBtn.TabIndex = 46;
			this.addBtn.Text = "ADD ";
			this.addBtn.UseVisualStyleBackColor = false;
			// 
			// remarksTxtBox
			// 
			this.remarksTxtBox.Location = new System.Drawing.Point(1173, 186);
			this.remarksTxtBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.remarksTxtBox.Name = "remarksTxtBox";
			this.remarksTxtBox.Size = new System.Drawing.Size(361, 26);
			this.remarksTxtBox.TabIndex = 47;
			this.remarksTxtBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.remarksTxtBox_KeyDown);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.label9.Location = new System.Drawing.Point(1149, 148);
			this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(91, 20);
			this.label9.TabIndex = 48;
			this.label9.Text = "REMARKS";
			// 
			// listBox1
			// 
			this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 20;
			this.listBox1.Location = new System.Drawing.Point(1173, 269);
			this.listBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(361, 284);
			this.listBox1.TabIndex = 49;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Location = new System.Drawing.Point(1442, 580);
			this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(94, 35);
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
			this.label10.Location = new System.Drawing.Point(1170, 222);
			this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(146, 15);
			this.label10.TabIndex = 51;
			this.label10.Text = "PRESS ENTER TO NEXT";
			// 
			// patientNameTXT
			// 
			this.patientNameTXT.AutoSize = true;
			this.patientNameTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.patientNameTXT.Location = new System.Drawing.Point(225, 208);
			this.patientNameTXT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.patientNameTXT.Name = "patientNameTXT";
			this.patientNameTXT.Size = new System.Drawing.Size(174, 20);
			this.patientNameTXT.TabIndex = 52;
			this.patientNameTXT.Text = "- - - - - - - - - - - - - - - ";
			// 
			// doctorNameTXT
			// 
			this.doctorNameTXT.AutoSize = true;
			this.doctorNameTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.doctorNameTXT.Location = new System.Drawing.Point(225, 265);
			this.doctorNameTXT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.doctorNameTXT.Name = "doctorNameTXT";
			this.doctorNameTXT.Size = new System.Drawing.Size(88, 20);
			this.doctorNameTXT.TabIndex = 53;
			this.doctorNameTXT.Text = "Jose Rizal";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(956, 585);
			this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(48, 20);
			this.label11.TabIndex = 54;
			this.label11.Text = "Total:";
			// 
			// totalLBL
			// 
			this.totalLBL.AutoSize = true;
			this.totalLBL.Location = new System.Drawing.Point(1024, 585);
			this.totalLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.totalLBL.Name = "totalLBL";
			this.totalLBL.Size = new System.Drawing.Size(50, 20);
			this.totalLBL.TabIndex = 55;
			this.totalLBL.Text = "- - - - -";
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// PharmacyScreen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1572, 757);
			this.Controls.Add(this.totalLBL);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.doctorNameTXT);
			this.Controls.Add(this.patientNameTXT);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.remarksTxtBox);
			this.Controls.Add(this.addBtn);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.medCB);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.GENDERlbl);
			this.Controls.Add(this.AgeLBL);
			this.Controls.Add(this.NameLBL);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.refNumCB);
			this.Controls.Add(this.MedicineListView);
			this.Controls.Add(this.Processbtn);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.LogoutBtn);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "PharmacyScreen";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "PharmacyScreen";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PharmacyScreen_FormClosed);
			this.Load += new System.EventHandler(this.PharmacyScreen_Load);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
		private System.Windows.Forms.ComboBox refNumCB;
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.TextBox remarksTxtBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label patientNameTXT;
        private System.Windows.Forms.Label doctorNameTXT;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label totalLBL;
		private System.Windows.Forms.Timer timer1;
	}
}